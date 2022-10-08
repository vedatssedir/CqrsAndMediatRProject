using CqrsMediatR.Data.ORM.EntityFramework;
using CqrsMediatR.Domain;

namespace CqrsMediatR.Data.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
