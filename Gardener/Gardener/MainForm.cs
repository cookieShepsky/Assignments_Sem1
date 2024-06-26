using System.ComponentModel;

namespace Gardener;

public partial class MainForm : Form
{
    private Gardener _gardener = new();
    private Garden? _selectedGarden;

    public MainForm()
    {
        InitializeComponent();
        RefreshAll();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        Garden newGarden = new(tbGardenName.Text);
        List<Garden.Fault> faults = _gardener.AddGarden(newGarden);
        if (faults[0] == Garden.Fault.None)
        {
            MessageBox.Show($"Successfully added new garden: {newGarden.Name}");
            Save();
        }
        else
        {
            string msg = $"Error(s) while creating new garden:\n";
            foreach (Garden.Fault f in faults) { msg += $"{f}\n"; }

            MessageBox.Show(msg);
        }
        RefreshForm();
        RefreshCbxGardenRemove();
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
                _selectedGarden = null;
                RefreshAll();
                return;
            }
        MessageBox.Show($"Error, could not find a garden named {toRemove.Name}");
    }

    private void cbxGardenRemove_IndexChange(object sender, EventArgs e)
    {
        if (cbxGardenRemove.SelectedIndex == -1) return;

        _selectedGarden = (Garden)cbxGardenRemove.SelectedItem!;
        RefreshForm();
        RefreshGarden();
    }

    private void RefreshAll()
    {
        RefreshGarden();
        RefreshCbxGardenRemove();
        RefreshForm();
    }

    private void RefreshForm()
    {
        // Set form text
        this.Text = "GardenManager";
        if (_selectedGarden != null) this.Text += $" | Current garden: {_selectedGarden}";  // "if statement always true" ?? no it's not???

        // Set lblSelectedGarden
        if (_selectedGarden != null) lblSelectedGarden.Text = _selectedGarden.ToString();
        else lblSelectedGarden.Text = "No garden selected.";

        // Populate PlantType combobox
        cbxPlantType.Items.Clear();
        foreach (PlantType m in Enum.GetValues(typeof(PlantType)))
            cbxPlantType.Items.Add(m);

        // Clear new plant tb's
        tbPlantName.Text = tbPlantColor.Text = "";

        // Reset selected month
        cbxSelectMonth.SelectedIndex = -1;
    }

    private void RefreshCbxGardenRemove()
    {
        // Populate garden combobox
        cbxGardenRemove.Items.Clear();
        foreach (Garden g in _gardener.Gardens)
            cbxGardenRemove.Items.Add(g);
    }

    private void RefreshGarden()
    {
        // Populate listbox
        lbxPlants.Items.Clear();
        if (_selectedGarden != null)
            foreach (Plant p in _selectedGarden.Plants)
                lbxPlants.Items.Add(p);

        // Show peak bloom period
        if (_selectedGarden == null || _selectedGarden.Plants.Count == 0) lblPeakBloom.Text = "Peak bloom: n/a";
        else lblPeakBloom.Text = $"Peak bloom: {_selectedGarden.GetPeakBlossom()}";
    }

    private void btnPlantsRemove_Click(object sender, EventArgs e)
    {
        // remove the selected plant from the garden.
        if (lbxPlants.SelectedIndex == -1) return;
        MessageBox.Show(!_selectedGarden!.RemovePlant((Plant)lbxPlants.SelectedItem!)
            ? "Something went wrong while removing this plant..."
            : $"{lbxPlants.SelectedItem} successfully removed!");
        RefreshGarden();
    }

    private void btnPlantsInfo_Click(object sender, EventArgs e)
    {
        if (lbxPlants.SelectedIndex == -1) return;
        Plant selectedPlant = (Plant)lbxPlants.SelectedItem!;
        MessageBox.Show(selectedPlant.ShowInfo());
    }

    private void btnPlantAdd_Click(object sender, EventArgs e)
    {
        // NOTE: by using a new form I do not allow editing the prune/blossom periods.
        // I do it this way because prune/blossom periods will never change.

        // Check if a garden is selected
        if (_selectedGarden == null)
        {
            MessageBox.Show("Please select a garden first.");
            return;
        }
        // Check for empty input
        if (tbPlantName.Text == "" || tbPlantColor.Text == "" || cbxPlantType.SelectedIndex == -1)
        {
            MessageBox.Show("Please provide all the required information for this plant.");
            return;
        }

        string newName = tbPlantName.Text;
        string newColor = tbPlantColor.Text;
        PlantType newType = (PlantType)cbxPlantType.SelectedItem!;
        bool newEvergreen = cbPlantEvergreen.Checked;

        Plant newPlant = new(newName, newColor, newEvergreen, newType);
        NewPlant formNew = new NewPlant(newPlant, _selectedGarden);
        formNew.Closing += AddFormClosing;
        formNew.Show();
    }

    private void AddFormClosing(object? sender, CancelEventArgs e)
    {
        RefreshGarden();
        Save();
    }

    private void btnSelectPrunable_Click(object sender, EventArgs e)
    {
        if (_selectedGarden == null)
        {
            MessageBox.Show("Please select a garden first.");
            return;
        }
        if (cbxSelectMonth.SelectedIndex == -1)
        {
            MessageBox.Show("Please select a month first.");
            return;
        }
        lbxPlants.Items.Clear();
        foreach (Plant p in _selectedGarden.GetPrunablePlants((Month)cbxSelectMonth.SelectedIndex+1!))
            lbxPlants.Items.Add(p);
    }

    private void btnShowAll_Click(object sender, EventArgs e)
    {
        RefreshGarden();
        cbxSelectMonth.SelectedIndex = -1;
    }

    /// <summary>
    /// "Quick" save functionality; If a save file is currently available (achieved through SaveAs, or Load), will save all data to that file.
    /// </summary>
    private void Save() { if (!FileHelper.JsonSave(_gardener)) MessageBox.Show("Save Unavailable. No save file selected."); }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) { MessageBox.Show(FileHelper.JsonSaveAs(_gardener) ? "File successfully saved!" : "No path specified."); }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Gardener? loadData = FileHelper.JsonLoad();
        if (loadData != null)
        {
            _gardener = loadData;
            RefreshAll();
        }
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e) { Save(); }
}