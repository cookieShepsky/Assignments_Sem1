namespace _1._2_Extending_Student_Group;

public partial class ChangeGroupNameForm : Form
{
    private string currentName;
    public ChangeGroupNameForm(string currentGroupName)
    {
        InitializeComponent();
        currentName = this.Text = currentGroupName;
    }

    private void btnAccept_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(tbNewName.Text))
        {
            MessageBox.Show("Name cannot be empty.");
            return;
        }
        string newName = tbNewName.Text;
            
        int affectedRows = DBMediator.ChangeGroupName(currentName, newName);
        if (affectedRows == 0) MessageBox.Show("The group name you're trying to change doesn't exist...");
        else MessageBox.Show($"{currentName} was changed to {newName}!\n{affectedRows} rows were changed in the Database.");
        this.Close();
    }
}