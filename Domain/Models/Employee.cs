namespace Domain.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public string? FullName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public int DerpatmentId { get; set; }
    public int BranchId { get; set; }
}