using Domain.Models;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class BranchService:IBranch
{
    private readonly List<Branch> IBranches = new List<Branch>();

    public BranchService()
    {
        IBranches=new List<Branch>();
    }
    
    public bool InsertBranch(int branchId)
    {
        if (IBranches.Any(b => b.BranchId == branchId))
        {
            return false;
        }
        
        IBranches.Add( new Branch { BranchId = branchId });
        return true;
    }

    public List<Branch> GetBranches()
    {
        return IBranches;
    }

    public Branch GetBranchById(int branchId)
    {
        return IBranches.FirstOrDefault(b => b.BranchId == branchId);
    }

    public bool UpdateBranch(Branch branch)
    {
        var existingBranch = IBranches.FirstOrDefault(b => b.BranchId == branch.BranchId);
        if(existingBranch!=null) return false;
        existingBranch.BranchName = branch.BranchName;
        return true;
    }

    public bool DeleteBranch(int branchId)
    {
        var branchesToDelete = IBranches.FirstOrDefault(b => b.BranchId == branchId);
        if(branchesToDelete!=null) return false;
        IBranches.Remove(branchesToDelete);
        return true;
    }
}