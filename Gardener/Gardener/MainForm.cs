using System.ComponentModel;
using Microsoft.VisualBasic;

namespace Gardener;

public partial class MainForm : Form
{
    // TODO: Implement save/load
    private Gardener _gardener = new();
    private Garden? _selectedGarden;

    public MainForm()
    {
        //DEBUG//
        _gardener.AddDebugGardens();
        /////////

        InitializeComponent();
        RefreshForm();
        RefreshCbxGardenRemove();
        RefreshGarden();

        // Populate Month Select combobox
        cbxSelectMonth.Items.Clear();
        foreach (Month m in Enum.GetValues(typeof(Month)))
            cbxSelectMonth.Items.Add(m);
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
                RefreshForm();
                RefreshCbxGardenRemove();
                RefreshGarden();
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
        if (!_selectedGarden.RemovePlant((Plant)lbxPlants.SelectedItem!))
            MessageBox.Show("Something went wrong while removing this plant...");
        else MessageBox.Show($"{lbxPlants.SelectedItem} successfully removed!");
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
        foreach (Plant p in _selectedGarden.GetPrunablePlants((Month)cbxSelectMonth.SelectedItem!))
            lbxPlants.Items.Add(p);
    }

    private void btnShowAll_Click(object sender, EventArgs e)
    {
        RefreshGarden();
        cbxSelectMonth.SelectedIndex = -1;
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show(_gardener.JsonSave()? "File successfully saved!" : "No existing save file.");
    }

    private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show(_gardener.JsonSaveAs() ? "File successfully saved!" : "No path specified.");
    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // TODO: Load file from location
        Gardener? loadData = _gardener.JsonLoad();
        if (loadData != null)
        {
             _gardener = loadData;
            RefreshAll();
        }
    }
}