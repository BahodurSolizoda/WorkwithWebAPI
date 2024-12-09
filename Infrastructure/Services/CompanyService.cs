using Domain.Models;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class CompanyService:ICompany
{
    private readonly List<Company?> _companies;

    public CompanyService()
    {
        _companies = new List<Company?>();
    }
    
    public bool InsertCompany(int companyId)
    {
        if (_companies.Any(c => c.CompanyId == companyId)) return false;
        _companies.Add(new Company({ CompanyId = companyId, CompanyName = $"Company {companyId}" });
        return true;
    }

    public List<Company?> GetCompanies()
    {
        return _companies;
    }

    public Company? GetCompanyById(int companyId)
    {
        return _companies.FirstOrDefault(c => c.CompanyId == companyId);
    }

    public bool UpdateCompany(Company company)
    {
        var existingCompany = GetCompanyById(company.CompanyId);
        if (existingCompany == null) return false;
        existingCompany.CompanyName = company.CompanyName;
        return true;
    }

    public bool DeleteCompany(int companyId)
    {
        var companyToDelete = GetCompanyById(companyId);
        if (companyToDelete == null) return false;
        _companies.Remove(companyToDelete);
        return true;
    }
}