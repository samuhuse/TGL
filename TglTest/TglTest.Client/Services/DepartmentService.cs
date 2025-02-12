using TglTest.Client.Models;

namespace TglTest.Client.Services;

public class DepartmentService
{
    private readonly List<Department> _departments = [];

    public DepartmentService()
    {
        FillWithMockData();
    }

    public void FillWithMockData()
    {
        var random = new Random();

        string[] departmentNames = { "HR", "IT", "Finance", "Marketing", "Sales", "Logistics" };
        string[] positions = { "Manager", "Assistant", "Analyst", "Clerk", "Coordinator", "Specialist" };

        for (int i = 0; i < 6; i++)
        {
            var department = new Department
            {
                Id = i + 1,
                Name = departmentNames[i],
                Description = $"Description for {departmentNames[i]}",
                Employees = []
            };

            for (int j = 0; j < 10; j++)
            {
                var employee = new Employee
                {
                    Id = i * 10 + j + 1,
                    Name = $"Employee {i * 10 + j + 1}",
                    Email = $"employee{i * 10 + j + 1}@Tgl.{department.Name}.com",
                    Phone = $"460-0100{j + i * 10}",
                    Address = $"100{j + 1} Main St, City{i}, State{i}",
                    Position = positions[random.Next(positions.Length)],
                    Salary = random.Next(50000, 100000),
                    HireDate = DateTime.Now.AddDays(random.Next(-365, 0)),
                    DepartmentId = department.Id
                };

                department.Employees.Add(employee);
            }

            _departments.Add(department);
        }
    }

    public List<Department> GetDepartments()
    {
        return _departments;
    }

    public bool AddDepartment(Department department)
    {
        department.Id = _departments.Count + 1;

        foreach (var employee in department.Employees)
        {
            employee.Id = _departments.Sum(d => d.Employees.Count) + 1;
            employee.DepartmentId = department.Id;
        }

        _departments.Add(department);

        return true;
    }

    public Department? GetDepartment(int id)
    {
        return _departments.FirstOrDefault(d => d.Id == id);
    }

    public List<Employee> GetEmployees(int departmentId)
    {
        return _departments.FirstOrDefault(d => d.Id == departmentId)?.Employees ?? [];
    }


}
