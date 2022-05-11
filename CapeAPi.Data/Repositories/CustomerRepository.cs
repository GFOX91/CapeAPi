using CapeApi.Shared;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace CapeAPi.Data
{
    public class CustomerRepository : RepositoryBase, ICustomerRepository
    {
        public CustomerRepository(IConfiguration configuration)
            : base(configuration)
        {
        }

        public async Task<Customer> FindAsync(string email, string customerId)
        {
            using (var con = GetConnection())
            {
                return await con.QuerySingleOrDefaultAsync<Customer>("select * from [Customer] where [CUSTOMERID] = @customerId and [EMAIL] = @email", new { email, customerId });
            }
        }
    }
}
