using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gardener;

public class Plant
{
    public string Name { get; private set; }                                   // should != ""
    public string Color { get; private set; }
    public bool Evergreen { get; private set; }
    public PlantType Type { get; private set; }
    public List<(Month, Month)> BlossomPeriods { get; private set; } = [];    //.count should be >0
    public List<(Month, Month)> PrunePeriods { get; private set; } = [];      //.count should be >0

    public Plant(string name, string color, bool evergreen, PlantType type)
    {
        this.Name = name;
        this.Color = color;
        this.Evergreen = evergreen;
        this.Type = type;
    }
}