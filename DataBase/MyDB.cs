using AdmiPanel_HealthApp.Data;
using Microsoft.EntityFrameworkCore;

namespace AdmiPanel_HealthApp.DataBase;

public class MyDB : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<BadHabits> BadHabits { get; set; }
    public DbSet<HealthState> HealthStates { get; set; }
    public DbSet<HeredityState> HeredityStates { get; set; }
    public DbSet<DocumentInfo> DocumentInfos { get; set; }
    public DbSet<InsurancePackage> InsurancePackages { get; set; }
    public DbSet<NonTypicalHealthProblem> NonTypicalHealthProblems { get; set; }
    public DbSet<UserData> UserDatas { get; set; }
    public DbSet<UserPolicies> UserPolicie { get; set; }
    public DbSet<UserApplications> UserApplication { get; set; }

    public MyDB()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    
    
}