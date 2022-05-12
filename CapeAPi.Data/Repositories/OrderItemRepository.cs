using CapeApi.Shared;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CapeAPi.Data
{
    public class OrderItemRepository : RepositoryBase, IOrderItemRepository
    {
        public OrderItemRepository(IConfiguration configuration)
            : base(configuration)
        {
        }

        public async Task<IEnumerable<OrderItem>> ListAsync(int orderId)
        {
            using (var con = GetConnection())
            {
                var sql = @"select o.*, p.*  from [OrderItems] o " +
                "inner join [Products] p on p.[ProductId] = o.[ProductId] " +
                "where o.[OrderId] = @orderId";

                return await con.QueryAsync<OrderItem, Product, OrderItem>(
                    sql,
                    (o, p) =>
                    {
                        o.PRODUCT = p;
                        return o;
                    }, new { orderId }, splitOn: "ProductId");
            }
        }
    }
}
