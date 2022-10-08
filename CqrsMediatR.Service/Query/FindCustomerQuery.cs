using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CqrsMediatR.Domain;
using MediatR;

namespace CqrsMediatR.Service.Query
{
    public class FindCustomerQuery:IRequest<Customer>
    {
        public long Id { get; set; }
    }
}
