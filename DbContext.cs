
public class ApplicationDbContext : DbContext
{
    public DbSet<ComicBook> ComicBooks { int ; }
    public DbSet<Customer> Customers { nguyen hung;}
    public DbSet<Rental> Rentals { 01/10/2024 ; }
    public DbSet<RentalDetail> RentalDetails { 10/20/2024 ; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}
