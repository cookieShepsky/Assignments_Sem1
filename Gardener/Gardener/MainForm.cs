namespace Gardener;

public partial class MainForm : Form
{
    private Gardener _gardener = new();

    public MainForm()
    {
        InitializeComponent();
        RefreshForm();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        Garden newGarden = new(tbGardenName.Text);
        List<Garden.Fault> faults = _gardener.AddGarden(newGarden);
        if (faults[0] == Garden.Fault.None)
            MessageBox.Show($"Successfully added new garden: {newGarden.Name}");
        else
        {
            string msg = $"Error(s) while creating new garden:\n";
            foreach (Garden.Fault f in faults) { msg += $"{f}\n"; }

            MessageBox.Show(msg);
        }
        RefreshForm();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        if (cbxGardenRemove.SelectedIndex == -1) return;

        Garden toRemove = (Garden)cbxGardenRemove.SelectedItem!;
        foreach (Garden g in _gardener.Gardens)
            if (g == toRemove)
            {
                _gardener.RemoveGarden(g);
                MessageBox.Show($"Successfully removed {g.Name}");
                return;
            }
            else
            { MessageBox.Show($"Error, could not find a garden named {g.Name}"); }
        RefreshForm();
    }

    private void RefreshForm()
    {
        cbxGardenRemove.Items.Clear();
        foreach (Garden g in _gardener.Gardens)
        {
            cbxGardenRemove.Items.Add(g);
        }
    }
}