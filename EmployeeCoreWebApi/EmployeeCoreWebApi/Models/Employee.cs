namespace EmployeeCoreWebApi.Models;

public partial class Employee
{
    public int Eid { get; set; }

    public string EmployeeName { get; set; } = null!;

    public string? Gender { get; set; }

    public string? Post { get; set; }

    public string? FatherName { get; set; }
}
