using CqrsMediatR.Data.Repository;
using CqrsMediatR.Domain;
using CqrsMediatR.Service.Command;
using MediatR;

namespace CqrsMediatR.Service.Handler
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Customer>
    {
        private readonly ICustomerRepository _customerRepository;
        public CreateCustomerCommandHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;
        public async Task<Customer> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _customerRepository.AddAsync(request.Customer);
        }
    }
}
