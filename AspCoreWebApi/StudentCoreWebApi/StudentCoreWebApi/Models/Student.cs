using System;
using System.Collections.Generic;

namespace StudentCoreWebApi.Models;

public partial class Student
{
    public int Id { get; set; }

    public string StudentName { get; set; } = null!;

    public string? Gender { get; set; }

    public string? Standard { get; set; }

    public string? FatherName { get; set; }
}
