//by Rody Jansen
using System.Diagnostics;

namespace Assignments;

public partial class Form1 : Form
{
    SnackBar macSnack;
    List<string> cart;
    List<(Snack, int)> cartSnacks;
    double cartPrice;
    List<Snack> snacks;

    public Form1()
    {
        InitializeComponent();
        macSnack = new SnackBar("MacSnack");
        macSnack.AddDefaultSnacks();
        snacks = macSnack.GetSnacks();
        cart = new List<string>();
        cartSnacks = new List<(Snack, int)>();
        UpdateComboBox();
    }

    private void UpdateComboBox()
    {
        // Updates the combobox with the current snacks in stock
        combxSnacks.Items.Clear();
        combxSnacks.Text = "";

        foreach (Snack snack in snacks)
        {
            combxSnacks.Items.Add(snack.ToString());
        }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        // Amounts in cart are subtracted from stock, but added back if the order is cancelled.

        // Check if an item has been selected
        if (combxSnacks.SelectedIndex < 0 || numAmount.Value < 1)
        {
            MessageBox.Show("Please select an item.");
            return;
        }

        Snack selection = snacks[combxSnacks.SelectedIndex];
        int amount = (int)numAmount.Value;

        // Check if amount is in stock
        if (amount > selection.GetStock())
        {
            MessageBox.Show("Not enough in stock.\nTry adding a smaller amount.");
            return;
        }

        cart.Add($"{selection.GetName()} : {amount}");
        cartSnacks.Add((selection, amount));
        cartPrice += selection.GetPrice() * amount;
        selection.DecrementStock(amount);

        UpdateComboBox();
        ShowCart();
    }

    private void ShowCart()
    {
        lbxCart.Items.Clear();
        foreach (string i in cart)
        {
            lbxCart.Items.Add(i);
        }
        lbxCart.Items.Add($"Total: \u20AC {Math.Round(cartPrice, 2)}");
    }

    private void btnCheckout_Click(object sender, EventArgs e)
    {
        // empties cart and adds cartPrice to Revenue
        macSnack.UpdateRevenue(cartPrice);
        Reset();
        lbxCart.Items.Clear();
        lbxCart.Items.Add("Enjoy your meal!");
    }

    private void Reset()
    {
        // clears cart without adding back to stock -> "sells" the selected items
        cart.Clear();
        cartPrice = 0;
        cartSnacks.Clear();
        UpdateComboBox();
        ShowCart();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        // adds selected items back to stock and empties cart
        {
            foreach ((Snack, int) i in cartSnacks.ToList())      /// Lists of tuples are very cool :D       "in cartSnacks" would throw InvalidOperationException. Fixed by forcing cartSnacks to a list. using .ToList()
            {
                Snack snack = i.Item1;
                int amount = i.Item2;

                snack.IncrementStock(amount);

                Reset();
            }
        }
    }

    private void btnRevenue_Click(object sender, EventArgs e)
    {
        lbxCart.Items.Clear();
        lbxCart.Items.Add($"Current total revenue: \u20AC {macSnack.GetRevenue()}");
    }


    private void btnAddStock_Click(object sender, EventArgs e)
    {
        if (tbName.Text == "" || tbStock.Text == "")
        {
            MessageBox.Show("Please fill the name and stock fields.");
            return;
        }

        try
        {
            if (!cbNew.Checked)
            {
                foreach (Snack snack in snacks)
                {
                    if (snack.GetName().ToLower() == tbName.Text.ToLower())
                    {
                        snack.IncrementStock(Convert.ToInt32(tbStock.Text));
                        if (tbPrice.Text != "")
                        {
                            snack.SetPrice(Convert.ToDouble(tbPrice.Text));
                        }
                        MessageBox.Show("Stock Updated.");
                        tbName.Text = tbPrice.Text = tbStock.Text = "";
                        UpdateComboBox();
                        return;

                    }
                }
            }
            if (tbPrice.Text != "")
            {
                macSnack.AddSnack(tbName.Text, Convert.ToInt32(tbStock.Text), Convert.ToDouble(tbPrice.Text));
                MessageBox.Show("Product added.");
                tbName.Text = tbPrice.Text = tbStock.Text = "";
            }
            else
            {
                MessageBox.Show("Please specify a price.");
            }
        }
        catch (FormatException)
        {
            MessageBox.Show("Something went wrong.\nPlease make sure you put numeric values in the stock and price fields.");
        }
        UpdateComboBox();
    }

    private void combxSnacks_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (combxSnacks.SelectedIndex >= 0)
        {
            numAmount.Maximum = snacks[combxSnacks.SelectedIndex].GetStock();
        }
    }
}
