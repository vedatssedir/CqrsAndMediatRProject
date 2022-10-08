namespace WebApi.Models
{
    public class GetAllCustomerResponseDto
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public List<AddressModel> AddressList { get; init; } = new List<AddressModel>();
    }
}
