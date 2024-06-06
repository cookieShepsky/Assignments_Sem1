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