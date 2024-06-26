﻿namespace Gardener;

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

        RefreshListBoxes();
    }

    private void btnBloomAdd_Click(object sender, EventArgs e)
    {
        // Check for empty input
        if (cbxBloomStart.SelectedIndex == -1 || cbxBloomEnd.SelectedIndex == -1)
        {
            MessageBox.Show("Please provide all the required information.");
            return;
        }

        (Month, Month) newPeriod = ((Month)cbxBloomStart.SelectedIndex+1!, (Month)cbxBloomEnd.SelectedIndex+1!);

        if (!_plant.AddBlossomPeriod(newPeriod))
            MessageBox.Show("That period has already been added!");
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

        (Month, Month) newPeriod = ((Month)cbxPruneStart.SelectedIndex+1!, (Month)cbxPruneEnd.SelectedIndex+1!);

        if (!_plant.AddPrunePeriod(newPeriod))
            MessageBox.Show("That period has already been added!");
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