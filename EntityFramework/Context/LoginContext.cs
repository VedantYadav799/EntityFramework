using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
namespace EntityFramework.Context;
public class LoginContext : DbContext{

    public DbSet<Employee> employees { get; set; }
    public DbSet<Role> Roles { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString="server=localhost; database=inventorymanagement; user=root; password='1234512345'";
        optionsBuilder.UseMySQL(conString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId);
            entity.HasKey(e => e.EmployeeFirstName);
            entity.HasKey(e => e.EmployeeLastName);
            entity.HasKey(e => e.Email);
            entity.HasKey(e => e.ContactNumber);
            entity.HasKey(e => e.Password);
            entity.HasKey(e => e.BirthDate);
            entity.HasKey(e => e.HireDate);
            entity.HasKey(e => e.ImgUrl);
            entity.HasKey(e => e.RoleId);
            entity.HasKey(e => e.GenderId);
            entity.HasKey(e => e.DepatmentId);
             modelBuilder.Entity<Employee>().ToTable("employees");
        });

         modelBuilder.Entity<Role>(entity =>
       {
           entity.HasKey(e => e.RoleId);
           entity.Property(e => e.RoleName);
           modelBuilder.Entity<Role>().ToTable("roles");
       });

    }
}