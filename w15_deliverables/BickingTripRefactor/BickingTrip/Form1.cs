using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BickingTrip;

public partial class Form1 : Form
{
    TripManager tripManager;
    List<Trip> filtered;
    bool isFiltered;
    public Form1()
    {
        InitializeComponent();
        tripManager = new();
        isFiltered = false;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        string destination = tbxTo.Text;
        double distance = Convert.ToDouble(nudDistance.Value);
        double rating = Convert.ToDouble(nudRating.Value);


        if (tripManager.AddTrip(destination, distance, rating))
        {
            UpdateForm();
        }

        else { MessageBox.Show("Please define a destination, distance, and rating"); }
    }

        private void btnDelete_Click(object sender, EventArgs e)
    {
        if (isFiltered)     // Accounts for deleting from the filtered listBox, even if there is duplicate objects!!
        {
            int occurrence = lbxMyTrips.SelectedIndex + 1;

            tripManager.RemoveTrip(filtered[lbxMyTrips.SelectedIndex].Destination, occurrence);
        }
        else tripManager.RemoveTripAt(lbxMyTrips.SelectedIndex);
        UpdateForm();
    }

    private void btnInfo_Click(object sender, EventArgs e)
    {
        if (lbxMyTrips.SelectedIndex > -1)
        {
            MessageBox.Show(tripManager.Trips[lbxMyTrips.SelectedIndex].ToString());
        }
    }

    private void btnShowAll_Click(object sender, EventArgs e)
    {
        UpdateForm();   // Could also += this to the eventhandler in Form1.Designer.
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        lbxMyTrips.Items.Clear();

        string query = tbxSearch.Text;
        filtered = tripManager.FilterByDestination(query);
        foreach (Trip trip in filtered)
            lbxMyTrips.Items.Add(trip.Destination);
        tbxSearch.Text = "";
        isFiltered = true;
    }

    private void UpdateForm()
    {
        lbxMyTrips.Items.Clear();
        foreach (Trip trip in tripManager.Trips)
            lbxMyTrips.Items.Add(trip.Destination);
        tbxTo.Clear();
        nudDistance.Value = 0m;
        nudRating.Value = 0m;
        isFiltered = false;
    }
}
