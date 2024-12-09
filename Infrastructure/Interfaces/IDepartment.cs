using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IDepartment
{
    bool InsertCompany(int departmentId, string companyName);
    List<Departments> GetDepartments();
    Departments GetDepartmentsById(int id);
    bool UpdateDepartment(Departments department);
    bool DeleteDepartment(int departmentId);
}