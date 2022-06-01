using Microsoft.EntityFrameworkCore;
using testProgram004.Data.Entities;
namespace testProgram004.Data
{
    public class DatabaseContext : DbContext 
    {
		protected readonly IConfiguration Configuration;

		public DatabaseContext(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
    	{
        	options.UseSqlServer(Configuration.GetConnectionString("myDb1"));
    	}	

		

        public DbSet<Customer> Customer { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Customer>()
			.HasData(new Customer()
			{
				Id = 1,
				Title = "Mr",
				Firstname = "Test",
				Middlename = "T",
				Lastname = "Testington",
				Email = "tttestington@emailprovider.com"
			});
		} 
    }
}