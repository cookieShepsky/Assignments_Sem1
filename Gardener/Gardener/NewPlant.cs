namespace Gardener;

public partial class NewPlant : Form
{
    private Plant _plant;
    private Garden _garden;
    public NewPlant(Plant incompletePlant, Garden owner)
    {
        InitializeComponent();
        _plant = incompletePlant;
        _garden = owner;
        this.Text = $"Creating new plant:{incompletePlant.Name}";
        lblName.Text = $"Name: {incompletePlant.Name}";
        lblColor.Text = $"Color: {incompletePlant.Color}";
        lblType.Text = $"Type: {incompletePlant.Type}";
        lblEvergreen.Text = $"Evergreen: {incompletePlant.Evergreen}";

        // Populate Comboboxes
        foreach (Month m in Enum.GetValues(typeof(Month)))
        {
            cbxBloomStart.Items.Add(m);
            cbxBloomEnd.Items.Add(m);
            cbxPruneStart.Items.Add(m);
            cbxPruneEnd.Items.Add(m);
        }

        RefreshListBoxes();
    }

    private void btnBloomAdd_Click(object sender, EventArgs e)
    {
        //todo: Check for duplicate periods
        // Check for empty input
        if (cbxBloomStart.SelectedIndex == -1 || cbxBloomEnd.SelectedIndex == -1)
        {
            MessageBox.Show("Please provide all the required information.");
            return;
        }
        _plant.AddBlossomPeriod(((Month)cbxBloomStart.SelectedItem!, (Month)cbxBloomEnd.SelectedItem!));
        RefreshListBoxes();
    }

    private void btnPruneAdd_Click(object sender, EventArgs e)
    {
        // Check for empty input
        if (cbxPruneStart.SelectedIndex == -1 || cbxPruneEnd.SelectedIndex == -1)
        {
            MessageBox.Show("Please provide all the required information.");
            return;
        }
        _plant.AddPrunePeriod(((Month)cbxPruneStart.SelectedItem!, (Month)cbxPruneEnd.SelectedItem!));
        RefreshListBoxes();
    }

    private void RefreshListBoxes()
    {
        lbxBloom.Items.Clear();
        lbxPrune.Items.Clear();

        foreach ((Month, Month) period in _plant.BlossomPeriods)
        {
            Month start = period.Item1;
            Month end = period.Item2;

            lbxBloom.Items.Add($"From {start} to {end}");
        }

        foreach ((Month, Month) period in _plant.PrunePeriods)
        {
            Month start = period.Item1;
            Month end = period.Item2;

            lbxPrune.Items.Add($"From {start} to {end}");
        }
    }

    private void btnFinish_Click(object sender, EventArgs e)
    {
        // if plant is valid, add it to the garden.
        if (_plant.Validate()[0] == Plant.Fault.None)
        {
            _garden.AddPlant(_plant);
            MessageBox.Show($"Added the following plant to {_garden}:\n\n{_plant.ShowInfo()}");
            this.Close();
        }
        else
        {
            string msg = $"Error(s) while finalizing Plant:\n";
            foreach (Plant.Fault f in _plant.Validate())
                msg += $"{f}\n";
            MessageBox.Show(msg);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Adding of this plant was cancelled!");
        this.Close();
    }
}