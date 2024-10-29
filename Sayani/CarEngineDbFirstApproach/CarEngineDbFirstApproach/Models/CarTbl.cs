using System;
using System.Collections.Generic;

namespace CarEngineDbFirstApproach.Models;

public partial class CarTbl
{
    public int CarId { get; set; }

    public string CarBrand { get; set; } = null!;

    public string CarModel { get; set; } = null!;

    public string CarColor { get; set; } = null!;

    public int EngineId { get; set; }

    public virtual EngineTbl Engine { get; set; } = null!;
}
