using System.Diagnostics;
using System.Text.Json;
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
            foreach (Garden g in this.Gardens)
            {
                if (garden.Name == g.Name)
                    return [Garden.Fault.NameTaken];    // <-- Cool way to create collections!
            }

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
    /// Add 3 generic gardens with one unique plant each to this Gardener for debugging
    /// </summary>
    public void AddDebugGardens()
    {
        List<Garden> newGardens = [];
        newGardens.AddRange(new List<Garden>()
        {
            new Garden("g1"),
            new Garden("g2"),
            new Garden("g3")
        });

        Plant p1 = new Plant("p1", "red", true, PlantType.Flower);
        Plant p2 = new Plant("p2", "green", false, PlantType.Fungus);
        Plant p3 = new Plant("p3", "blue", false, PlantType.Hedge);

        p1.AddBlossomPeriod((Month.April, Month.August));
        p1.AddPrunePeriod((Month.December, Month.January));
        p2.AddBlossomPeriod((Month.April, Month.August));
        p2.AddPrunePeriod((Month.December, Month.January));
        p3.AddBlossomPeriod((Month.April, Month.August));
        p3.AddPrunePeriod((Month.December, Month.January));

        newGardens[0].AddPlant(p1);
        newGardens[1].AddPlant(p2);
        newGardens[2].AddPlant(p3);

        foreach (Garden g in newGardens) this.AddGarden(g);
    }
}