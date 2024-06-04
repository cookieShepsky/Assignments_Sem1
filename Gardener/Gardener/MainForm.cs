namespace Gardener;

public partial class MainForm : Form
{
    private readonly Gardener _gardener = new();
    private Garden _selectedGarden;

    public MainForm()
    {
        //DEBUG//
        _gardener.AddDebugGardens();
        /////////

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
                break;
            }
            else
            { MessageBox.Show($"Error, could not find a garden named {g.Name}"); }
        RefreshForm();
    }

    private void btnGardenSelect_Click(object sender, EventArgs e)
    {
        if (cbxGardenRemove.SelectedIndex == -1) return;

        _selectedGarden = (Garden)cbxGardenRemove.SelectedItem!;
        RefreshForm();
        RefreshGarden();
    }

    private void RefreshForm()
    {
        // Populate combobox
        cbxGardenRemove.Items.Clear();
        foreach (Garden g in _gardener.Gardens)
        {
            cbxGardenRemove.Items.Add(g);
        }

        // Set form text
        this.Text = "GardenManager";
        if (_selectedGarden != null) this.Text += $" | Current garden: {_selectedGarden}";  // "if statement always true" ?? no it's not???

        // Set lblSelectedGarden
        if (_selectedGarden != null) lblSelectedGarden.Text = _selectedGarden.ToString();
        else lblSelectedGarden.Text = "No garden selected.";
    }

    private void RefreshGarden()
    {
        // Populate listbox
        lbxPlants.Items.Clear();
        if (_selectedGarden != null)
            foreach (Plant p in _selectedGarden.Plants)
                lbxPlants.Items.Add(p);
    }
}