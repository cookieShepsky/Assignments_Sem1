using System.Text.Json.Serialization;

namespace Gardener;

internal class Garden
{
    public string Name { get; set; }
    public List<Plant> Plants { get; private set; } = [];

    public Garden(string name) { this.Name = name; }

    [JsonConstructor]
    public Garden(string name, List<Plant> plants)
    {
        this.Name = name;
        this.Plants = plants;
    }

    /// <summary>
    /// If plant is valid, adds it to Plants
    /// </summary>
    /// <returns> List of faults, will contain Plant.Fault.None if valid. </returns>
    public List<Plant.Fault> AddPlant(Plant plant)
    {
        if (plant.Validate()[0] == Plant.Fault.None)
        { this.Plants.Add(plant); }

        return plant.Validate();
    }

    /// <summary>
    /// If passed plant is in Plants, removes first occurrence
    /// </summary>
    /// <returns>True if successful;<br/>
    /// Otherwise false.</returns>
    public bool RemovePlant(Plant plant) { return this.Plants.Remove(plant); }

    /// <summary>
    /// Returns a list of enums indicating what's wrong with the object.
    /// </summary>
    public List<Fault> Validate()
    {
        List<Fault> faults = [];

        if (string.IsNullOrEmpty(this.Name)) faults.Add(Fault.NameEmpty);

        if (faults.Count == 0)
            faults.Add(Fault.None);
        return faults;
    }

    public enum Fault
    {
        None,
        NameEmpty
    }
}