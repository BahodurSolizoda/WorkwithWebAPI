namespace Domain.Models;

public class Branch
{
    public int BranchId { get; set; }
    public string? BranchName { get; set; }
    public int CompanyId { get; set; }
    public string? BranchAddress { get; set; }
}