using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users => Set<User>();
    public ApplicationContext() : base()
    {
        /*Database.EnsureDeleted();
        Database.EnsureCreated();
        this.SaveChanges();*/
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("Server=localhost; Database=Users;"
        //    + "User Id=sa;Password=23011986;"
        //+"Integrated Security = true;"
        //+"Trusted_Connection=True;
        //+"MultipleActiveResultSets=true;"
        //);

        optionsBuilder.UseSqlServer("data source=localhost;initial catalog=Users;user=sa;password=23011986;App=EntityFramework;TrustServerCertificate=True");

    } 
}