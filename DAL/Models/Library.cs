using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Library
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public string? Isbn { get; set; }

    public string? Status { get; set; }

    public string? Borrower { get; set; }
}
