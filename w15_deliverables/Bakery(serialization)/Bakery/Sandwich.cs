using System.Collections.Generic;
using System.Linq;

namespace Bakery;

public class Sandwich(string name, double basePrice, BreadType bread)
{
    public string Name { get; set; } = name;
    public double BasePrice { get; set; } = basePrice;
    public BreadType Bread { get; set; } = bread;

    public List<Ingredient> Ingredients { get; } = [];

    public bool AddIngredient(Ingredient ingredient)
    {
        if (Ingredients.Count == 5) return false;
        Ingredients.Add(ingredient);
        return true;
    }

    public double GetPrice()
    {
        return this.BasePrice + Ingredients.Sum(i => i.Price);
    }

    public bool IsValid()
    {
        return !string.IsNullOrEmpty(this.Name);
    }

    public override string ToString()
    {
        List<string> ingredientNames = [];
        foreach (Ingredient i in this.Ingredients)
            ingredientNames.Add(i.Name);

        string join = string.Join(", ", ingredientNames);
        if (string.IsNullOrEmpty(join))
            return $"{this.Name} ({this.Bread})";
        return $"{this.Name} ({this.Bread} with {join})";
    }
}