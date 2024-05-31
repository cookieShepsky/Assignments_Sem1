namespace Bakery;

public class Ingredient(string name, double price)
{
    public string Name { get; } = name;
    public double Price { get; } = price;

    public bool IsValid()
    {
        return !string.IsNullOrEmpty(this.Name);
    }

    public override string ToString()
    {
        return $"{this.Name} | \u20ac {this.Price}";
    }
}