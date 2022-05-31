namespace testProgram004API.Repositories
{
    public class CustomerRepository
    {
        public static List<Customer> Customers = new ()
        {
            new() { Title = "Mr", Forename = "Test", Surname = "Case" },
        };
    }
}