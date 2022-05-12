using CapeApi.Shared;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace CapeAPi.Data
{
    public class OrderRepository : RepositoryBase, IOrderRepository
    {
        public OrderRepository(IConfiguration configuration)
            : base(configuration)
        {
        }

        public async Task<Order> GetLatestAsync(string customerId)
        {
            using (var con = GetConnection())
            {
                return await con.QuerySingleOrDefaultAsync<Order>("select top 1 * from [Orders] where [customerId] = @customerId order by [orderDate]", new { customerId });
            }
        }
    }
}
