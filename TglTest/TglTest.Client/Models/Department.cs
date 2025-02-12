using System.ComponentModel.DataAnnotations;
using FluentValidation;

namespace TglTest.Client.Models;
public class Department
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string? Description { get; set; }

    public List<Employee> Employees { get; set; } = [];
}

public class ValidateAttribute : Attribute
{
    public ValidateAttribute(Type type)
    {
        throw new NotImplementedException();
    }
}

public class DepartmentValidator : AbstractValidator<Department>
{
    public DepartmentValidator()
    {
        RuleFor(d => d.Name)
            .NotEmpty()
            .WithMessage("Department name is required."); 
        
        RuleFor(d => d.Employees)
            .NotEmpty()
            .WithMessage("Department must have at least one employee.")
            .ForEach(emp => emp.SetValidator(new EmployeeValidator()));


    }
}