using Domain.Models;

namespace Infrastructure.Interfaces;

public interface ICompany
{
    bool InsertCompany(int companyId);
    List<Company?> GetCompanies();
    Company? GetCompanyById(int companyId);
    bool UpdateCompany(Company company);
    bool DeleteCompany(int companyId);
}