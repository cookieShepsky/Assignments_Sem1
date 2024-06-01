using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text.Json.Serialization;

namespace Bakery;

public class Sandwich
{
    public string Name { get; set; }
    public double BasePrice { get; set; }
    public BreadType Bread { get; set; }
    public List<Ingredient> Ingredients { get; } = [];

    public Sandwich(string name, double basePrice, BreadType bread)
    {
        this.Name = name;
        this.BasePrice = basePrice;
        this.Bread = bread;
    }

    [JsonConstructor]
    public Sandwich(string name, double basePrice, BreadType bread, List<Ingredient> ingredients)
    {
        this.Name = name;
        this.BasePrice = basePrice;
        this.Bread = bread;
        this.Ingredients = ingredients;
        if (Ingredients.Count > 5)
            throw new HighIngredientException(ingredients.Count);
    }

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
        if (string.IsNullOrEmpty(this.Name)) return false;
        if (Ingredients.Count >= 5) return false;
        return true;
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