using CapeApi.Shared;
using System.Threading.Tasks;

namespace CapeAPi.Data
{
    public interface IOrderRepository
    {
        Task<Order> GetLatestAsync(string customerId);
    }
}