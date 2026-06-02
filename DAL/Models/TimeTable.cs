using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class TimeTable
{
    public int Id { get; set; }

    public string? Day { get; set; }

    public TimeOnly? Start { get; set; }

    public TimeOnly? End { get; set; }

    public string? Subject { get; set; }

    public int? TeacherId { get; set; }

    public string? RoomNo { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
