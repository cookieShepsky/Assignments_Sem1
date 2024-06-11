using System.Numerics;
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
    /// <returns>True if successful;<br/>
    /// False if unsuccessful.</returns>
    public bool AddBlossomPeriod((Month, Month) period)
    {
        // Check for identical periods
        foreach ((Month, Month) existingPeriod in this.BlossomPeriods)
            if (period == existingPeriod)
                return false;

        BlossomPeriods.Add(period);
        return true;
    }

    /// <summary>
    /// Adds a period to this plant's PrunePeriods
    /// </summary>
    public bool AddPrunePeriod((Month, Month) period)
    {
        foreach ((Month, Month) existingPeriod in this.PrunePeriods)
            if (period == existingPeriod)
                return false;

        PrunePeriods.Add(period);
        return true;
    }

    public override string ToString() { return this.Name; }

    public string ShowInfo()
    {
        // todo: Should be a localizable string, generated in frontend. Only pass properties to display.
        string msg = $"Plant name: {this.Name}\n" +
                     $"Plant color: {this.Color}\n" +
                     $"Evergreen: {this.Evergreen}\n" +
                     $"Plant type: {this.Type}\n\n" +
                     $"Blossom Period(s):\n";

        foreach ((Month, Month) period in this.BlossomPeriods)
        {
            Month start = period.Item1;
            Month end = period.Item2;
            
            msg += $"\tFrom {start} to {end}.\n";
        }

        msg += $"\nPruning Period(s):\n";
        foreach ((Month, Month) period in this.PrunePeriods)
        {
            Month start = period.Item1;
            Month end = period.Item2;

            msg += $"\tFrom {start} to {end}.\n";
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

