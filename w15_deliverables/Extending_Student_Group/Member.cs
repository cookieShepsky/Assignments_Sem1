namespace _1._2_Extending_Student_Group;

internal class Member
{
    public int? StudentNumber { get; set; }
    public string Name { get; set; }

    public Member(string name)
    {
        this.Name = name;
        this.StudentNumber = null;
    }

    public Member(string name, int studentNumber)
    {
        this.Name = name;
        this.StudentNumber = studentNumber;
    }

    public bool IsValid()
    {
        if (string.IsNullOrEmpty(this.Name)) return false;
        return true;
    }

    public override string ToString()
    {
        if (this.StudentNumber == null)
            return $"{this.Name}";
        return $"{this.Name} (StudentNr. {this.StudentNumber})";
    }
}
