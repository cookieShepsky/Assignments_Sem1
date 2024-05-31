using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Bakery
{
    public partial class MainForm : Form
    {
        private Bakery bakkerBart;

        public MainForm()
        {
            InitializeComponent();

            bakkerBart = new("Bakker Bart");
            bakkerBart.DebugTestSandwiches();

            // Init GUI
            lblSandwichInfo.Text = "";
            this.Text = bakkerBart.Name;

            // Populate filter combobox
            foreach (BreadType b in Enum.GetValues(typeof(BreadType)))
                cbbBreadFilter.Items.Add(b);

            // Populate Menu
            RefreshMenu();
        }

        private void btnShowOfferedSandwiches_Click(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        private void btnAddSandwich_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(bakkerBart);
            addForm.Show();
            addForm.Closing += AddFormClosing;
        }

        private void AddFormClosing(object sender, CancelEventArgs e)
        {
            RefreshMenu();
        }

        private void RefreshMenu()
        {
            lbxMenu.Items.Clear();
            // Populate menu with available sandwiches
            if (cbbBreadFilter.SelectedIndex == -1)
            {
                foreach (Sandwich s in bakkerBart.GetAvailableSandwiches())
                    lbxMenu.Items.Add(s);
            }
            else
                foreach (Sandwich s in bakkerBart.GetAvailableSandwiches((BreadType)cbbBreadFilter.SelectedItem))
                    lbxMenu.Items.Add(s);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (bakkerBart.JsonSave())
                    MessageBox.Show("Data successfully saved!");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                Bakery loadData = bakkerBart.JsonLoad();
                if (loadData == null)
                {
                    MessageBox.Show("No saved data found.");
                    return;
                }
                bakkerBart = loadData;
                RefreshMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxMenu.SelectedIndex == -1) return;
            Sandwich selected = (Sandwich)lbxMenu.SelectedItem;
            lblSandwichInfo.Text = $"{selected} : \u20ac {selected.GetPrice():0.00}";
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (lbxMenu.SelectedIndex == -1) return;

            Sandwich selected = (Sandwich)lbxMenu.SelectedItem;
            double? sellPrice = bakkerBart.SellSandwich(selected);

            MessageBox.Show($"{selected.Name} sold for {sellPrice:0.00} (including VAT).");
            lbxMenu.SelectedIndex = -1;
            lblSandwichInfo.Text = "";
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Sandwiches sold: {bakkerBart.SoldSandwiches.Count} pcs\n" +
                            $"Total revenue (ex. VAT): \u20ac {bakkerBart.CalculateRevenue():0.00}\n" +
                            $"Total revenue (incl. VAT) \u20ac {bakkerBart.CalculateRevenue(true):0.00}");
        }
    }
}
