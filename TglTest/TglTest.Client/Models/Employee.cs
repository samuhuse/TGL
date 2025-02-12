using FluentValidation;

namespace TglTest.Client.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public DateTime? HireDate { get; set; }
    public int DepartmentId { get; set; }
}

public class EmployeeValidator : AbstractValidator<Employee>
{
    public EmployeeValidator()
    {


        RuleFor(e => e.Name)
            .NotEmpty().WithMessage("Name is required.");

        RuleFor(e => e.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Email must be a valid email address.");

        RuleFor(e => e.Phone)
            .NotEmpty().WithMessage("Phone is required.")
            .Matches(@"^\+?[1-9]\d{1,14}$").WithMessage("Phone must be a valid phone number.");
            
        RuleFor(e => e.Address)
            .NotEmpty().WithMessage("Address is required.");

        RuleFor(e => e.Position)
            .NotEmpty().WithMessage("Position is required.");

        RuleFor(e => e.Salary)
            .NotEmpty().WithMessage("Salary is required.")
            .GreaterThan(0).WithMessage("Salary must be greater than zero.");

        RuleFor(e => e.HireDate)
            .NotEmpty().WithMessage("HireDate is required.");


    }
}
