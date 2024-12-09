using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IEmployee
{
    bool InsertEmployee(int employeeId);
    List<Employee> GetEmployees();
    Employee GetEmployeeById(int employeeId);
    bool UpdateEmploee(Employee employee);
    bool DeleteEmployee(int employeeId);
}