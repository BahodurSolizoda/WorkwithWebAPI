using Domain.Models;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class DepartmentService:IDepartment
{
    private readonly List<Departments> _departments;

    public DepartmentService()
    {
        _departments = new List<Departments>();
    }


    public bool InsertCompany(int departmentId)
    {
        if (_departments.Any(c =>c.DepartmentId ==departmentId )) return false;
        _departments.Add(new Departments({ CompanyId = departmentId, DepartmentName = $"Company {_departments.Count}" });
        return true;
    }

    public List<Departments> GetDepartments()
    {
        return _departments;
    }

    public Departments GetDepartmentsById(int id)
    {
        return _departments.FirstOrDefault(c=>c.DepartmentId == id);
    }

    public bool UpdateDepartment(Departments department)
    {
        var existingDepartment = _departments.FirstOrDefault(c=>c.DepartmentId == department.DepartmentId);
        if (existingDepartment == null) return false;
        existingDepartment.DepartmentName = department.DepartmentName;
        return true;
    }

    public bool DeleteDepartment(int departmentId)
    {
        var departmentToDelete = _departments.FirstOrDefault(c=>c.DepartmentId == departmentId);
        if (departmentToDelete == null) return false;
        _departments.Remove(departmentToDelete);
        return true;
    }
}