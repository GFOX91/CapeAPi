using System.Collections.Generic;

namespace CapeApi.Shared
{
    public class OrderDto
    {
        public OrderDto()
        {
        }

        public OrderDto(Order order, string deliveryAddress)
        {
            OrderNumber = order.ORDERID;
            OrderDate = order.ORDERDATE.Value.ToString("dd'-'MMM'-'yyyy");
            DeliveryAddress = deliveryAddress;
            DeliveryExpected = order.DELIVERYEXPECTED.Value.ToString("dd'-'MMM'-'yyyy");
        }
        public int OrderNumber { get; set; }

        public string OrderDate { get; set; }

        public string DeliveryAddress { get; set; }

        public IEnumerable<OrderItemDto> OrderItems { get; set; }

        public string DeliveryExpected { get; set; }
    }
}
