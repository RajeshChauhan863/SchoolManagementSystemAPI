using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Fee
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? DueDate { get; set; }

    public string? Status { get; set; }

    public virtual Student? Student { get; set; }
}
