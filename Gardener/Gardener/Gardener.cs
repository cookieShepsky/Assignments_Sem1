using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gardener;

public class Gardener
{
    private static string _saveFile;
    private static JsonSerializerOptions _serializerOptions = new() { IncludeFields = true };   // NOTE: I don't fully understand why this is required on (de)serialization.
    public List<Garden> Gardens { get; set; } = [];

    public Gardener() { _saveFile = ""; }    // need an empty constructor so we can create the object without passing a list (like the json would need to do)

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
    /// Saves all garden data to a (new) user defined json file.
    /// </summary>
    public bool JsonSaveAs()
    {
        SaveFileDialog browser = new();
        browser.DefaultExt = "json";

        browser.ShowDialog();

        _saveFile = browser.FileName;

        // If no path was selected
        if (_saveFile == "") return false;

        string json = JsonSerializer.Serialize(this, _serializerOptions);
        File.WriteAllText(_saveFile,json);
        return true;
    }

    /// <summary>
    /// Saves all garden data to an existing, previously defined json file.
    /// </summary>
    public bool JsonSave()
    {
        if(!File.Exists(_saveFile)) return false;

        string json = JsonSerializer.Serialize(this, _serializerOptions);
        File.WriteAllText(_saveFile, json);
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
        if (File.Exists(_saveFile))
            browser.InitialDirectory = _saveFile;

        browser.ShowDialog();

        if (browser.FileName == "") return null;
        _saveFile = browser.FileName;
        Debug.WriteLine($"[GARDENER] File Loaded: {_saveFile}");

        string json = File.ReadAllText(_saveFile);
        Gardener data = JsonSerializer.Deserialize<Gardener>(json, _serializerOptions)!;
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