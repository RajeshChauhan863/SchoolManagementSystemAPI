using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Attandance
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Present { get; set; }

    public DateTime? Date { get; set; }
}
