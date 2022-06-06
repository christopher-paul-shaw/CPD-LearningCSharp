using System.Text.Json;
using testProgram004.Data.Entities;
namespace testProgram004.Data
{
    public class CustomerSeeder
    {
        private readonly DatabaseContext _context;
        private readonly IWebHostEnvironment _env;

        public CustomerSeeder(DatabaseContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public void Seed ()
        {
            _context.Database.EnsureCreated();

            if(!_context.Customer.Any())
            {
                var filePath = Path.Combine(_env.ContentRootPath, "Data/Customers.json");
                var json = File.ReadAllText(filePath);
                var customers = JsonSerializer.Deserialize<IEnumerable<Customer>>(json);
                _context.Customer.AddRange(customers);
                _context.SaveChanges();
            }

        }
    }
}