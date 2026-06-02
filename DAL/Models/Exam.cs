using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Exam
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateTime? Date { get; set; }

    public string? Subject { get; set; }

    public string? TotalMarks { get; set; }

    public string? PassingMarks { get; set; }

    public virtual ICollection<ExamResult> ExamResults { get; set; } = new List<ExamResult>();
}
