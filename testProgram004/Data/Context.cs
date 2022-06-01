using Microsoft.EntityFrameworkCore;

namespace testProgram004.Data
{
    public class Context : DbContext 
    {
		protected readonly IConfiguration Configuration;

		public Context(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
    	{
        	options.UseSqlServer(Configuration.GetConnectionString("myDb1"));
    	}	

        public DbSet<testProgram004.Data.Entities.Customer> Customer { get; set; }
    }
}