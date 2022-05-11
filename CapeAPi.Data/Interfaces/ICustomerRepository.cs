using CapeApi.Shared;
using System.Threading.Tasks;

namespace CapeAPi.Data
{
    public interface ICustomerRepository
    {
        Task<Customer> FindAsync(string email, string customerId);
    }
}