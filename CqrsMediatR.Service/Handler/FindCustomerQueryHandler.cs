using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CqrsMediatR.Data.Repository;
using CqrsMediatR.Domain;
using CqrsMediatR.Service.Query;
using MediatR;

namespace CqrsMediatR.Service.Handler
{
    public class FindCustomerQueryHandler:IRequestHandler<FindCustomerQuery,Customer>
    {
        private readonly ICustomerRepository _customerRepository;
        public FindCustomerQueryHandler(ICustomerRepository customerRepository) => _customerRepository =customerRepository;
        public async Task<Customer?> Handle(FindCustomerQuery request, CancellationToken cancellationToken)
        {
            return await _customerRepository.GetByIdAsync(request.Id);
        }






    }
}
