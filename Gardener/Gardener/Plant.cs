using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardener;

public class Plant()
{
    public string Name { get; private set; }
    public string Color { get; private set; }
    public bool Evergreen { get; private set; }
    public PlantType Type { get; private set; }
    public List<TimeSpan> BlossomPeriods { get; private set; } = [];    //.count should be >0
    public List<TimeSpan> PrunePeriods { get; private set; } = [];      //.count should be >0
}