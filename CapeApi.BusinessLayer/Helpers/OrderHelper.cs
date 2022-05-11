using CapeApi.Shared;
using CapeAPi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapeApi.BusinessLayer.Helpers
{
    public class OrderHelper : IOrderHelper
    {
        public OrderHelper(ICustomerRepository customerRepository)
        {
            CustomerRepository = customerRepository;
        }

        public ICustomerRepository CustomerRepository { get; }

        public async Task<LatestOrderReturnModel> GetLatestOrder(string email, string customerId)
        {
            try
            {
                var customer = await CustomerRepository.FindAsync(email, customerId);

                if(customer == null)
                    return null;

                var customerDto = new CustomerDto() { Name = customer.FIRSTNAME, LastName = customer.LASTNAME };

                var latestOrder = new LatestOrderReturnModel() { Customer = customerDto };

                return latestOrder;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
