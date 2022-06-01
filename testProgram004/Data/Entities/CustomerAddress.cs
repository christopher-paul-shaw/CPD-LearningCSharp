namespace testProgram004.Data.Entities
{
    public class CustomerAddress
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Postcode { get; set; }
        public Customer Customer { get; set; }
    }
}