namespace _1._2_Extending_Student_Group;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        
        // Populate controls
        RefreshGroups();
        btnShow_Click("", EventArgs.Empty);
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        Member newMember;
        string name = tbName.Text;

        //check if selected student number is a number
        if (int.TryParse(tbNumber.Text, out int studentNumber))
            newMember = new(name, studentNumber);
        else
        {
            newMember = new(name);
            MessageBox.Show("No valid student number provided. Proceeding without a student number");
            tbNumber.Text = "";
        }

        if (string.IsNullOrEmpty(cbxGroup.Text))
        {
            MessageBox.Show("Please choose an existing group, or provide a new group.");
            return;
        }
        string group = cbxGroup.Text;

        // verify validity
        if (!newMember.IsValid())
        {
            MessageBox.Show("Please specify a name");
            return;
        }


        try
        {
            // add to db
            if (DBMediator.AddMember(newMember, group))
                MessageBox.Show($"New member {newMember} added!");
            else MessageBox.Show("That student number is already in use.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return;
        }
        RefreshGroups();
    }

    private void btnShow_Click(object sender, EventArgs e)
    {
        // show all members in selected group
        lb.Items.Clear();

        try
        {
            if (cbxShowGroup.SelectedItem == null)
            {
                foreach (Member m in DBMediator.GetMembers())
                    lb.Items.Add(m);
            }
            else
            {
                string selectedGroup = (string)cbxShowGroup.SelectedItem;
                foreach (Member m in DBMediator.GetMembers(selectedGroup))
                    lb.Items.Add(m);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return;
        }

        cbxShowGroup.SelectedIndex = -1;
    }

    private void RefreshGroups()
    {
        // populate combo boxes
        cbxShowGroup.Items.Clear();
        cbxGroup.Items.Clear();

        foreach (string i in DBMediator.GetGroups())
        {
            cbxShowGroup.Items.Add(i);
            cbxGroup.Items.Add(i);
        }
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        if (lb.SelectedIndex == -1)
        {
            MessageBox.Show("Please select a student.");
            return;
        }

        Member selectedMember = (Member)lb.Items[lb.SelectedIndex]; // why did lb.SelectedValue not work?
        try
        {
            if (DBMediator.RemoveMember(selectedMember))
            {
                MessageBox.Show($"Removed {selectedMember}");
                lb.Items.RemoveAt(lb.SelectedIndex);
                return;
            }
        }
        catch (Exception ex)
        { MessageBox.Show(ex.Message); }

        MessageBox.Show("Something went wrong...");
    }

    private void btnChangeGroupName_Click(object sender, EventArgs e)
    {
        if (cbxShowGroup.SelectedIndex == -1) return;

        string currentName = (string)cbxShowGroup.SelectedItem!;

        ChangeGroupNameForm f = new ChangeGroupNameForm(currentName);
        f.Show();
        f.Closed += ChangeGroupNameForm_Closed;
    }

    private void ChangeGroupNameForm_Closed(object? sender, EventArgs e)
    {
        RefreshGroups();
    }
}