using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IBranch
{
    bool InsertBranch(int branchId);
    List<Branch> GetBranches();
    Branch GetBranchById(int branchId);
    bool UpdateBranch(Branch branch);
    bool DeleteBranch(int branchId);
}