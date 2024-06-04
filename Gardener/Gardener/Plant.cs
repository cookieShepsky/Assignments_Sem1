using System.Text.Json.Serialization;

namespace Gardener;

public class Plant
{
    public string Name { get; private set; }
    public string Color { get; private set; }
    public bool Evergreen { get; private set; }
    public PlantType Type { get; private set; }
    public List<(Month, Month)> BlossomPeriods { get; private set; } = [];
    public List<(Month, Month)> PrunePeriods { get; private set; } = [];

    public Plant(string name, string color, bool evergreen, PlantType type)
    {
        this.Name = name;
        this.Color = color;
        this.Evergreen = evergreen;
        this.Type = type;
    }

    [JsonConstructor]
    public Plant(string name, string color, bool evergreen, PlantType type,List<(Month, Month)> blossomPeriods, List<(Month, Month)> prunePeriods)
    {
        this.Name = name;
        this.Color = color;
        this.Evergreen = evergreen;
        this.Type = type;
        this.BlossomPeriods = blossomPeriods;
        this.PrunePeriods = prunePeriods;
    }

    /// <summary>
    /// Adds a period to this plant's BlossomPeriods
    /// </summary>
    public void AddBlossomPeriod((Month, Month) period) { BlossomPeriods.Add(period); }

    /// <summary>
    /// Adds a period to this plant's PrunePeriods
    /// </summary>
    public void AddPrunePeriod((Month, Month) period) { PrunePeriods.Add(period); }

    public override string ToString() { return this.Name; }

    public string ShowInfo()
    {
        string msg = $"Plant name: {this.Name}\n" +
                     $"Plant color: {this.Color}\n" +
                     $"Evergreen: {this.Evergreen}" +
                     $"Plant type: {this.Type}\n" +
                     $"Blossom Period(s):\n";

        foreach ((Month, Month) period in BlossomPeriods)
        {
            Month start = period.Item1;
            Month end = period.Item2;
            
            msg += $"\tFrom {start} to {end}.\n";
        }

        msg += $"Pruning Period(s):\n";
        foreach ((Month, Month) period in PrunePeriods)
        {
            Month start = period.Item1;
            Month end = period.Item2;

            msg += $"\tFrom {start} to {end}";
        }

        return msg;
    }

    /// <summary>
    /// Returns a list of enums indicating what's wrong with the object.
    /// </summary>
    public List<Fault> Validate()
    {
        List<Fault> faults = [];

        if (string.IsNullOrEmpty(this.Name)) faults.Add(Fault.NameEmpty);
        if (string.IsNullOrEmpty(this.Color)) faults.Add(Fault.ColorEmpty);
        if (this.BlossomPeriods.Count == 0) faults.Add(Fault.LowBlossomPeriodsCount);
        if (this.PrunePeriods.Count == 0) faults.Add(Fault.LowPrunePeriodsCount);

        if (faults.Count == 0) faults.Add(Fault.None);
        return faults;
    }

    public enum Fault
    {
        None,
        NameEmpty,
        ColorEmpty,
        LowBlossomPeriodsCount,
        LowPrunePeriodsCount
    }
}

