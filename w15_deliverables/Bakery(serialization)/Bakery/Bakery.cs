using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Bakery;

public class Bakery
{
    public string Name { get; set; }

    private const double VAT_MULTIPLIER = 1.09;
    private string SaveFile;
    public List<Ingredient> AvailableIngredients { get; private set; } = [];
    public List<Sandwich> AvailableSandwiches { get; private set;  } = [];
    public List<Sandwich> SoldSandwiches { get; private set; } = [];

    public Bakery(string name)
    {
        this.Name = name;
        SaveFile = @$"..\..\..\..\{Name}.Json";
        this.AvailableIngredients.AddRange(new List<Ingredient>
            {
                new("Cucumber", 0.05),
                new("Tomato", 0.15),
                new("Cheddar", 0.2),
                new("Ham", 0.15),
                new("Chorizo", 0.25),
                new("Apple", 0.1),
                new("Tuna", 0.2),
                new("Smoked Salmon", 0.4),
                new("Cream cheese", 0.15),
                new("Gouda cheese", 0.1)
            }
        );
    }

    [JsonConstructor]
    public Bakery(string name, List<Ingredient> availableIngredients, List<Sandwich> availableSandwiches, List<Sandwich> soldSandwiches)
    {
        this.Name = name;
        this.AvailableIngredients = availableIngredients;
        this.AvailableSandwiches = availableSandwiches;
        this.SoldSandwiches = soldSandwiches;
    }

    public bool AddSandwich(Sandwich sandwich)
    {
        if (!sandwich.IsValid()) return false;
        this.AvailableSandwiches.Add(sandwich);
        return true;
    }

    public List<Sandwich> GetAvailableSandwiches()
    {
        return this.AvailableSandwiches;
    }

    public List<Sandwich> GetAvailableSandwiches(BreadType bread)
    {
        List<Sandwich> result = [];
        
        foreach (Sandwich s in this.AvailableSandwiches)
            if (s.Bread == bread)
                result.Add(s);
        return result;
    }

    /// <summary>
    /// Adds a sandwich to SoldSandwiches for later calculation of total revenue.
    /// </summary>
    /// <returns>Price of sold sandwich including VAT;<br/>
    /// null if the passed sandwich isn't on this bakery's menu.</returns>
    public double? SellSandwich(Sandwich sandwich)
    {
        if (!AvailableSandwiches.Contains(sandwich)) return null;

        SoldSandwiches.Add(sandwich);

        double sellPrice = sandwich.GetPrice() * VAT_MULTIPLIER;
        return sellPrice;
    }

    /// <returns>Total revenue.</returns>
    /// <param name="vat">Whether VAT should be included in the calculation.</param>
    public double CalculateRevenue(bool vat = false)
    {
        double revenue = SoldSandwiches.Sum(s => s.GetPrice());

        if (vat) revenue *= VAT_MULTIPLIER;
        return revenue;
    }

    /// <summary>
    /// Saves the current Bakery object to a local json file
    /// </summary>
    /// <returns>True if successful;<br/>Exception if unsuccessful</returns>
    public bool JsonSave()
    {
        try
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            browser.ShowDialog();
            SaveFile = browser.SelectedPath;
            if (SaveFile == "") return false;
            SaveFile += $@"\{this.Name}.json";

            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(SaveFile, json);
            return true;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Returns the previously saved Bakery object, if it exists. Else returns null.
    /// </summary>
    public Bakery JsonLoad()
    {
        OpenFileDialog browser = new();
        browser.ShowDialog();
        if (browser.FileName == "") return null;

        SaveFile = browser.FileName;
        if(File.Exists(SaveFile))
            return JsonSerializer.Deserialize<Bakery>(File.ReadAllText(SaveFile));
        
        return null;
    }

    /// <summary>
    /// Adds 5 various sandwiches to AvailableSandwiches
    /// </summary>
    public void DebugTestSandwiches()
    {
        this.AvailableSandwiches.AddRange(new List<Sandwich>
            {
                new("Broodje Gezond", 1, BreadType.WHOLE_WHEAT),
                new("BLT", 1, BreadType.SOUR_DOUGH),
                new("Carpaccio", 1.2, BreadType.FOCACCIA),
                new("Broodje Hamburger", 1.35, BreadType.CIABATTA),
                new("Broodje Kip", 1.15, BreadType.SOUR_DOUGH)
            }
        );
    }
}