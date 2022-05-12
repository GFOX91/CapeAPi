namespace CapeApi.Shared
{
    public class CustomerDto
    {
        public CustomerDto()
        {
        }

        public CustomerDto(Customer customer)
        {
            Name = customer.FIRSTNAME;
            LastName = customer.LASTNAME;
        }
        public string Name { get; set; }

        public string LastName { get; set; }
    }
}
