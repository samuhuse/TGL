using FluentValidation;

namespace TglTest.Client.Models;
public class Department
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public List<Employee> Employees { get; set; } = [];
}
public class DepartmentValidator : AbstractValidator<Department>
{
    public DepartmentValidator()
    {
        // Set rules here.
        // Docs here: https://docs.fluentvalidation.net/en/latest/
    }
}