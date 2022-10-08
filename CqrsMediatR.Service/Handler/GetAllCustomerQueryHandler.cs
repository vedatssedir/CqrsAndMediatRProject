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
    public class GetAllCustomerQueryHandler:IRequestHandler<GetAllCustomerQuery,List<Customer>>
    {
        private readonly ICustomerRepository _customerRepository;

        public GetAllCustomerQueryHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;
        public async  Task<List<Customer>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            return  _customerRepository.GetAll().ToList();
        }
    }
}
