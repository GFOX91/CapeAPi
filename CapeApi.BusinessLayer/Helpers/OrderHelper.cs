using CapeApi.Shared;
using CapeAPi.Data;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CapeApi.BusinessLayer.Helpers
{
    public class OrderHelper : IOrderHelper
    {
        public OrderHelper(ICustomerRepository customerRepository, IOrderRepository orderRepository, IOrderItemRepository orderItemRepository)
        {
            CustomerRepository = customerRepository;
            OrderRepository = orderRepository;
            OrderItemRepository = orderItemRepository;
        }

        public ICustomerRepository CustomerRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public IOrderItemRepository OrderItemRepository { get; }

        public async Task<LatestOrderReturnModel> GetLatestOrder(string email, string customerId)
        {
            try
            {
                // 1. Find customer
                var customer = await CustomerRepository.FindAsync(email, customerId);

                if (customer == null)
                    return null;

                var customerDto = new CustomerDto(customer);

                // 2. Find latest order
                var order = await OrderRepository.GetLatestAsync(customerId);

                if (order == null)
                    return new LatestOrderReturnModel() { Customer = customerDto };

                var orderDto = new OrderDto(order, customer.ADDRESS);

                // 3. Find latest orders items including associated products
                var orderItems = await OrderItemRepository.ListAsync(order.ORDERID);

                if (orderItems.Any())
                    orderDto.OrderItems = orderItems.Select(orderItem => new OrderItemDto(orderItem, order.CONTAINSGIFT));

                return new LatestOrderReturnModel() { Customer = customerDto, Order = orderDto };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
