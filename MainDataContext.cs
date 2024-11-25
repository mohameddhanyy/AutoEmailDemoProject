using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoEmailDemoProject.Models;
namespace AutoEmailDemoProject;

public class MainDataContext : DbContext
{
    public static string ConnStrMain = "Data Source=localhost;Initial Catalog=AutoEmailDemoProject;Integrated Security=True;Persist Security Info=True ; TrustServerCertificate=True";
    public MainDataContext() : base() //string FileName = "appsettings"
    {
        //Database.SetCommandTimeout(int.MaxValue);
        //ChangeTracker.AutoDetectChangesEnabled = false;
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.EnableSensitiveDataLogging(false);
        //optionsBuilder.EnableDetailedErrors();
        //optionsBuilder.LogTo(Console.WriteLine);
        //optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        optionsBuilder.UseSqlServer(ConnStrMain);
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(t => t.GetProperties()).Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
        {
            property.SetColumnType("decimal (18, 4)");
        }
    }

    public DbSet<Account_Master> Account_Master { get; set; }

    public DbSet<AcOf_Master> AcOf_Master { get; set; }

    public DbSet<Bill_Master> Bill_Master { get; set; }

    public DbSet<Bill_Trans> Bill_Trans { get; set; }

    public DbSet<Book_Master> Book_Master { get; set; }

    public DbSet<Branch_Master> Branch_Master { get; set; }

    public DbSet<Company_Master> Company_Master { get; set; }

    public DbSet<Insu_Master> Insu_Master { get; set; }

    public DbSet<Item_Master> Item_Master { get; set; }
    public DbSet<Selvage_Master> Selvage_Master { get; set; }
    public DbSet<Trans_Master> Trans_Master { get; set; }
}


