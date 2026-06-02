using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Transport
{
    public int Id { get; set; }

    public string? Vehicle { get; set; }

    public string? Route { get; set; }

    public string? Driver { get; set; }

    public string? Capacity { get; set; }

    public string? Status { get; set; }
}
