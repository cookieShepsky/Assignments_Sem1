using System.Data.SqlClient;

namespace _1._2_Extending_Student_Group;

internal class DBMediator
{
    //TODO: try/catch for sql errors

    private const string ConnectionString =
        "Server=mssqlstud.fhict.local;Database=dbi514216_rjfirst;User Id=dbi514216_rjfirst;Password=ThisIsADB";

    public static List<Member> GetMembers()
    {
        using (SqlConnection conn = new(ConnectionString))
        {
            string sql = "SELECT * " +
                         "FROM [member];";
            SqlCommand cmd = new(sql, conn);
            List<Member> members = [];

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Member member;
                if (dr[1].GetType() != typeof(DBNull))
                    member = new((string)dr["name"], (int)dr["studentNumber"]);
                else
                    member = new((string)dr["name"]);
                members.Add(member);
            }

            return members;
        }
    }

    public static List<Member> GetMembers(string projectGroup)
    {
        try
        {
            using (SqlConnection conn = new(ConnectionString))
            {
                string sql =
                    "SELECT member.*, projectGroup.groupName " +
                    "FROM [member] " +
                    "JOIN [projectGroup] ON member.name = projectGroup.student " +
                    "WHERE projectGroup.groupName = @groupName " +
                    "ORDER BY member.studentNumber ASC;";

                SqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@groupName", projectGroup);
                List<Member> members = [];

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Member member;
                    if (dr[1].GetType() != typeof(DBNull))
                        member = new((string)dr["name"], (int)dr["studentNumber"]);
                    else
                        member = new((string)dr["name"]);
                    members.Add(member);
                }

                return members;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static List<string> GetGroups()
    {
        try
        {
            using (SqlConnection conn = new(ConnectionString))
            {
                List<string> groups = [];

                string sql =
                    "SELECT DISTINCT projectGroup.groupName " +
                    "FROM projectGroup";

                SqlCommand cmd = new(sql, conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                    groups.Add((string)dr["groupName"]);

                return groups;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static bool AddMember(Member newMember, string group)
    {
        // check for duplicate student numbers
        if (newMember.StudentNumber != null)
            foreach (Member m in GetMembers())
                if (m.StudentNumber == newMember.StudentNumber) return false;

        // add member to db (optional student number)
        try
        {
            using (SqlConnection conn = new(ConnectionString))
            {
                string sql = "INSERT INTO [member] (member.name, member.studentNumber) " +
                             "VALUES (@name, @studentNumber); " +
                             "INSERT INTO [projectGroup] " +
                             "VALUES (@name, @groupName);";     // DON'T USE GO!!!

                SqlCommand cmd = new(sql, conn);
                cmd.Parameters.AddWithValue("@name", newMember.Name);
                if (newMember.StudentNumber != null)
                    cmd.Parameters.AddWithValue("@studentNumber", newMember.StudentNumber);
                else
                    cmd.Parameters.AddWithValue("@studentNumber", DBNull.Value);
                cmd.Parameters.AddWithValue("groupName",  group);

                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Remove a member from the database.
    /// </summary>
    /// <returns>
    /// True if successful;<br/>
    /// False if unsuccessful;<br/>
    /// Exception if there are DB connection issues.
    /// </returns>
    public static bool RemoveMember(Member memberToRemove)
    {
        List<Member> dbMembers = GetMembers();
        int targetNum = -1;
        string targetName = "";
        string sql = "";
        bool byNum = false;

        // remove by number if possible, else remove by name.
        if (memberToRemove.StudentNumber != null)
        {
            // select all members with matching number (student numbers are unique)
            foreach (Member m in dbMembers)
                if (m.StudentNumber == memberToRemove.StudentNumber)
                {
                    byNum = true;
                    targetNum = (int)memberToRemove.StudentNumber;
                    sql = "delete [member] " +
                          "where studentNumber = @targetNum;";
                }
        }
        else
        {
            // select first member with matching name
            foreach (Member m in dbMembers)
                if (m.Name == memberToRemove.Name)
                {
                    targetName = memberToRemove.Name;
                    sql = $"DELETE TOP(1) " +
                          $"FROM [member] " +
                          $"WHERE [name] = @name AND studentNumber is null;";
                }
        }

        // return false if no match was found
        if (targetName == "" && targetNum == -1) return false;

        try
        {
            // delete record from db
            using (SqlConnection conn = new(ConnectionString))
            {
                SqlCommand cmd = new(sql, conn);
                if (byNum)
                    cmd.Parameters.AddWithValue("@targetNum", targetNum);
                else
                {
                    cmd.Parameters.AddWithValue("@name", targetName);
                }

                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }

    /// <summary>
    /// Changes the name of a group.
    /// </summary>
    /// <returns>
    /// Affected rows.
    /// </returns>
    public static int ChangeGroupName(string currentName, string newName)
    {
        if (!GetGroups().Contains(currentName)) return 0;

        string sql = "UPDATE projectGroup " +
                     "SET groupName = @newName " +
                     "WHERE groupName = @currentName;";
        
        using (SqlConnection conn = new(ConnectionString))
        {
            SqlCommand cmd = new(sql, conn);
            cmd.Parameters.AddWithValue("@newName", newName);
            cmd.Parameters.AddWithValue("@currentName", currentName);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}
