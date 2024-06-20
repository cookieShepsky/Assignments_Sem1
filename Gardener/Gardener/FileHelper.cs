using System.Diagnostics;
using System.Text.Json;

namespace Gardener;

public static class FileHelper
{
    private static string _fileName = "";
    private static readonly JsonSerializerOptions SerializerOptions = new() { IncludeFields = true };

    /// <summary>
    /// Saves all garden data to a (new) user defined json file.
    /// </summary>
    public static bool JsonSaveAs(Gardener gardener)
    {
        SaveFileDialog browser = new();
        browser.DefaultExt = "json";

        browser.ShowDialog();

        _fileName = browser.FileName;

        // If no path was selected
        if (_fileName == "") return false;

        string json = JsonSerializer.Serialize(gardener, SerializerOptions);
        File.WriteAllText(_fileName, json);
        return true;
    }

    /// <summary>
    /// Saves all garden data to an existing, previously defined json file.
    /// </summary>
    public static bool JsonSave(Gardener gardener)
    {
        if (!File.Exists(_fileName)) return false;

        string json = JsonSerializer.Serialize(gardener, SerializerOptions);
        File.WriteAllText(_fileName, json);
        return true;
    }

    /// <summary>
    /// Loads data from a json file
    /// </summary>
    /// <returns> Gardener object;<br/>
    /// Null if file not found.</returns>
    public static Gardener? JsonLoad()
    {
        OpenFileDialog browser = new();

        // If a file has been previously saved, use previously used _saveFile as default dir
        if (File.Exists(_fileName))
            browser.InitialDirectory = _fileName;

        browser.ShowDialog();

        if (browser.FileName == "") return null;
        _fileName = browser.FileName;
        Debug.WriteLine($"[GARDENER] File Loaded: {_fileName}");

        string json = File.ReadAllText(_fileName);
        Gardener data = JsonSerializer.Deserialize<Gardener>(json, SerializerOptions)!;
        return data;
    }
}
