using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Communication
{
    public int Id { get; set; }

    public string? Recipient { get; set; }

    public string? Subject { get; set; }

    public DateTime? SentAt { get; set; }
}
