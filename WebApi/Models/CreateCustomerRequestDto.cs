namespace WebApi.Models
{
    public class CreateCustomerRequestDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<AddressModel> AddressModel { get; set; }
    }
}
