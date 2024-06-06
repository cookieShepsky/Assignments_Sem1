using System.Text.Json.Serialization;

namespace Gardener;

public class Garden
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
    /// Returns a list of plants that are prune-able during the given month
    /// </summary>
    public List<Plant> GetPrunablePlants(Month month)
    {
        List<Plant> prunablePlants = [];
        bool spansNewYear = false;
        foreach (Plant p in this.Plants)
        {
            foreach ((Month, Month) period in p.PrunePeriods)
            {
                Month start = period.Item1;
                Month end = period.Item2;

                if (start > end) spansNewYear = true;

                // Check if passed month is in between any of the prune periods in p
                if (!spansNewYear)
                {
                    if (month >= start && month <= end)
                    {
                        prunablePlants.Add(p);
                        break;
                    }
                }
                else
                {
                    if ((month >= start && month >= end) || (month <= start && month <= end))
                    {
                        prunablePlants.Add(p);
                        break;
                    }
                }
            }
        }
        return prunablePlants;
    }

    /// <summary>
    /// Return the first month in which this garden is in peak blossom.
    /// </summary>
    public Month GetPeakBlossom()
    {
        int[] monthValues = new int[12];
        bool spansNewYear = false;

        // for every plant in the garden
        foreach (Plant p in this.Plants)
        {
            // for every blossom period for that plant
            foreach ((Month, Month) period in p.BlossomPeriods)
            {
                // get the start and end months
                Month start = period.Item1;
                Month end = period.Item2;

                if (start > end) spansNewYear = true;

                // for every month in the year
                foreach (Month m in Enum.GetValues(typeof(Month)))
                {
                    //check if it falls within the blossom period
                    if (!spansNewYear)
                    {
                        if (m >= start && m <= end)
                            monthValues[(int)m] += 1;
                    }
                    else
                    {
                        if ((m >= start && m >= end) || (m <= start && m <= end))
                            monthValues[(int)m] += 1;
                    }
                }
            }
        }

        // get the value of the month with the most blossom
        int maxMonth = monthValues.Max();
        // find what month corresponds with that value
        Month peakMonth = (Month)Array.IndexOf(monthValues, maxMonth);
        return peakMonth;
    }

    public override string ToString() { return this.Name; }

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
        NameEmpty,
        NameTaken
    }
}