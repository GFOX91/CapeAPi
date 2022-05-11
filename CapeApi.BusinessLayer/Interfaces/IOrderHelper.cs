using CapeApi.Shared;
using CapeAPi.Data;
using System.Threading.Tasks;

namespace CapeApi.BusinessLayer.Helpers
{
    public interface IOrderHelper
    {
        ICustomerRepository CustomerRepository { get; }

        Task<LatestOrderReturnModel> GetLatestOrder(string email, string customerId);
    }
}