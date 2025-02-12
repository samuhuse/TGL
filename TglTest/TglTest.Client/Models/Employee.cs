using FluentValidation;

namespace TglTest.Client.Models;

public class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? Position { get; set; }
    public decimal Salary { get; set; }
    public DateTime? HireDate { get; set; }
    public int DepartmentId { get; set; }
}

public class EmployeeValidator : AbstractValidator<Employee>
{
    public EmployeeValidator()
    {
        // Set rules here.
        // Docs here: https://docs.fluentvalidation.net/en/latest/
    }
}
