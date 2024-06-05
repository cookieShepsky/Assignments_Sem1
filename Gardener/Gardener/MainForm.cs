using System.ComponentModel;
using Microsoft.VisualBasic;

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

    private void cbxGardenRemove_IndexChange(object sender, EventArgs e)
    {
        if (cbxGardenRemove.SelectedIndex == -1) return;

        _selectedGarden = (Garden)cbxGardenRemove.SelectedItem!;
        RefreshForm();
        RefreshGarden();
    }

    private void RefreshForm()
    {
        // Populate garden combobox
        cbxGardenRemove.Items.Clear();
        foreach (Garden g in _gardener.Gardens)
            cbxGardenRemove.Items.Add(g);

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
    }

    private void RefreshGarden()
    {
        // Populate listbox
        lbxPlants.Items.Clear();
        if (_selectedGarden != null)
            foreach (Plant p in _selectedGarden.Plants)
                lbxPlants.Items.Add(p);
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
        // Check for empty input
        if (tbPlantName.Text == "" || tbPlantColor.Text == "" || cbxPlantType.SelectedIndex == -1)
        {
            MessageBox.Show("Please provide all the required information for this plant.");
            return;
        }
        // Check if a garden is selected
        if (_selectedGarden == null)
        {
            MessageBox.Show("Please select a garden first.");
        }

        string newName = tbPlantName.Text;
        string newColor = tbPlantColor.Text;
        PlantType newType = (PlantType)cbxPlantType.SelectedItem!;
        bool newEvergreen = cbPlantEvergreen.Checked;

        Plant newPlant = new(newName, newColor, newEvergreen, newType);
        //todo: newform for adding periods
        NewPlant formNew = new NewPlant(newPlant, _selectedGarden);
        formNew.Show();
    }
}