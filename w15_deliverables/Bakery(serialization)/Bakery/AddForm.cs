using System;
using System.Windows.Forms;

namespace Bakery;

public partial class AddForm : Form
{
    public AddForm(Bakery bakery)
    {
        InitializeComponent();

        // Populate combobox
        foreach (BreadType b in Enum.GetValues(typeof(BreadType)))
            cbbBreadFilter.Items.Add(b);
        
        // Pass bakery object
        this.BakkerBart = bakery;

        // Populate ingredients
        foreach (Ingredient i in BakkerBart.AvailableIngredients)
            checkedListBox1.Items.Add(i);
    }

    public Bakery BakkerBart { get; set; }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        // Check for invalid values
        if (string.IsNullOrEmpty(tbxName.Text))
        {
            MessageBox.Show("Please provide a name.");
            return;
        }

        if (cbbBreadFilter.SelectedIndex == -1)
        {
            MessageBox.Show("Please provide a bread type.");
            return;
        }
        
        string name = tbxName.Text;
        BreadType bread = (BreadType)cbbBreadFilter.SelectedItem;
        double basePrice = (double)nudBasePrice.Value;

        Sandwich newSandwich = new(name, basePrice, bread);
        
        // Max 5 ingredients
        if (checkedListBox1.CheckedItems.Count > 5)
        {
            MessageBox.Show("You may only select up to 5 ingredients.");
            return;
        }

        // Add ingredients to sandwich
        foreach (Ingredient i in checkedListBox1.CheckedItems)
            newSandwich.AddIngredient(i);

        if (!newSandwich.IsValid()) MessageBox.Show("Something went wrong...");
        else
        {
            // Add sandwich to bakery
            BakkerBart.AddSandwich(newSandwich);

            // Reset controls
            int i = 0;
            while (i < checkedListBox1.Items.Count)
            {
                checkedListBox1.SetItemChecked(i, false);
                i++;
            }

            tbxName.Text = "";
            cbbBreadFilter.SelectedIndex = -1;
            nudBasePrice.Value = 0;
        }

    }
}