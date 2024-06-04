using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gardener;

public class Gardener
{
    private string _saveFile = "";
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
        // TODO: Prevent duplicate garden names
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

    /// <summary>
    /// Return the first month in which this garden is in peak blossom.
    /// </summary>
    public Month GetPeakBlossom(Garden garden)
    {
        int[] monthValues = new int[12];

        // for every plant in the garden
        foreach (Plant p in garden.Plants)
        {
            // for every blossom period for that plant
            foreach ((Month, Month) period in p.BlossomPeriods)
            {
                // get the start and end months
                Month start = period.Item1;
                Month end = period.Item2;

                // for every month in the year
                foreach (Month m in Enum.GetValues(typeof(Month)))
                {
                    //check if it falls within the blossom period
                    if (m >= start && m <= end)
                        monthValues[(int)m] += 1;
                }
            }
        }

        // get the value of the month with the most blossom
        int maxMonth = monthValues.Max();
        // find what month corresponds with that value
        Month peakMonth = (Month)Array.IndexOf(monthValues, maxMonth);
        return peakMonth;
    }

    /// <summary>
    /// Saves all garden data to a json file.
    /// </summary>
    public bool JsonSave()
    {
        FolderBrowserDialog browser = new();
        string saveName = @"GardenData.json";

        // If a file has been previously saved, use previously used _saveFile as default dir
        if (_saveFile != "")
            browser.InitialDirectory = _saveFile;
        
        browser.ShowDialog();

        _saveFile = browser.SelectedPath;

        // If no path was selected
        if (_saveFile == "") return false;
        _saveFile += saveName;

        string json = JsonSerializer.Serialize(this);
        File.WriteAllText(_saveFile,json);
        return true;
    }

    /// <summary>
    /// Loads data from a json file
    /// </summary>
    /// <returns> Gardener object;<br/>
    /// Null if file not found.</returns>
    public Gardener? JsonLoad()
    {
        OpenFileDialog browser = new();

        // If a file has been previously saved, use previously used _saveFile as default dir
        if (_saveFile != "")
            browser.InitialDirectory = _saveFile;

        browser.ShowDialog();

        if (browser.FileName == "") return null;
        _saveFile = browser.FileName;

        string json = File.ReadAllText(_saveFile);
        Gardener data = JsonSerializer.Deserialize<Gardener>(json)!;
        return data;
    }

    /// <summary>
    /// Add 3 generic gardens with one unique plant each to this Gardener
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