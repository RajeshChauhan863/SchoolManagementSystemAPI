using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Age { get; set; }

    public string? Grade { get; set; }

    public virtual ICollection<ExamResult> ExamResults { get; set; } = new List<ExamResult>();

    public virtual ICollection<Fee> Fees { get; set; } = new List<Fee>();
}
