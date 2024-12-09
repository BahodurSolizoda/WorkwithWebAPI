using Domain.Models;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class EmployeeService:IEmployee
{
    private readonly List<Employee> _employees;

    public EmployeeService()
    {
        _employees = new List<Employee>();
    }
    
    
    public bool InsertEmployee(int employeeId)
    {
        if (_employees.Any(e => e.EmployeeId == employeeId)) return false;
        _employees.Add(new Employee { EmployeeId = employeeId });
        return true;
    }

    public List<Employee> GetEmployees()
    {
        return _employees;
    }

    public Employee GetEmployeeById(int employeeId)
    {
        return _employees.FirstOrDefault(e => e.EmployeeId == employeeId);
    }

    public bool UpdateEmploee(Employee employee)
    {
        var existingEmployee= _employees.FirstOrDefault(e => e.EmployeeId == employee.EmployeeId);
        if (existingEmployee == null) return false;
        _employees.Add(employee);
        return true;
    }

    public bool DeleteEmployee(int employeeId)
    {
        var employeeToDelete = _employees.FirstOrDefault(e => e.EmployeeId == employeeId);
        if (employeeToDelete == null) return false;
        _employees.Remove(employeeToDelete);
        return true;
    }
}