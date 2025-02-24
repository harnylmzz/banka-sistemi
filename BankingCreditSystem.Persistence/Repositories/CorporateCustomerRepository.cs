using Microsoft.EntityFrameworkCore;
using BankingCreditSystem.Domain.Entities;
namespace BankingCreditSystem.Persistence.Repositories
{
    public class CorporateCustomerRepository : CustomerRepository<CorporateCustomer>, ICorporateCustomerRepository
    {
        public CorporateCustomerRepository(BaseDbContext context) : base(context)
        {
        }
    }

    internal interface ICorporateCustomerRepository
    {
    }
} 