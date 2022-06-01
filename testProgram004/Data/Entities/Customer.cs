namespace testProgram004.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public ICollection<CustomerAddress> Addresses  { get; set; }

    }
}