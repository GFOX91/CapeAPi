using CapeApi.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CapeAPi.Data
{
    public interface IOrderItemRepository
    {
        Task<IEnumerable<OrderItem>> ListAsync(int orderId);
    }
}