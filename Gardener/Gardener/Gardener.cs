using System.Text.Json.Serialization;

namespace Gardener;

public class Gardener
{
    public List<Garden> Gardens { get; set; } = [];

    public Gardener() {}    // need an empty constructor so we can create the object without passing a list (like the json would need to do)

    [JsonConstructor]
    public Gardener(List<Garden> gardens) { this.Gardens = gardens; }


    /// <summary>
    /// If garden is valid, adds it to Gardens
    /// </summary>
    /// <returns> List of faults, will contain Garden.Fault.None if valid. </returns>
    public List<Garden.Fault> AddGarden(Garden garden)
    {
        if (garden.Validate()[0] == Garden.Fault.None)
            Gardens.Add(garden);

        return garden.Validate();
    }

    /// <summary>
    /// If passed garden is in Gardens, removes first occurrence
    /// </summary>
    /// <returns>True if successful;<br/>
    /// Otherwise false.</returns>
    public bool RemoveGarden(Garden garden) { return Gardens.Remove(garden); }

    /// <summary>
    /// Returns a list of plants that are prune-able during the given month
    /// </summary>
    public List<Plant> GetPrunablePlants(Garden garden, Month month)
    {
        List<Plant> prunablePlants = [];

        foreach (Plant p in garden.Plants)
        {
            foreach ((Month, Month) period in p.PrunePeriods)
            {
                Month start = period.Item1;
                Month end = period.Item2;

                // Check if passed month is in between any of the prune periods in p
                if (month >= start && month <= end)
                    prunablePlants.Add(p);
            }
        }
        return prunablePlants;
    }

}