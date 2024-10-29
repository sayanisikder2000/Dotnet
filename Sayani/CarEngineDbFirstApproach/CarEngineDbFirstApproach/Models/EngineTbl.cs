using System;
using System.Collections.Generic;

namespace CarEngineDbFirstApproach.Models;

public partial class EngineTbl
{
    public int EngineId { get; set; }

    public string EngineBrand { get; set; } = null!;

    public string EngineModel { get; set; } = null!;

    public virtual ICollection<CarTbl> CarTbls { get; set; } = new List<CarTbl>();
}
