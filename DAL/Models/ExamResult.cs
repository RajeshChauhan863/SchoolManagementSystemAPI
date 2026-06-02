using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ExamResult
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? ExamId { get; set; }

    public int? Score { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public virtual Exam? Exam { get; set; }

    public virtual Student? Student { get; set; }
}
