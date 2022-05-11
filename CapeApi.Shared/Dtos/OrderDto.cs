using System.Collections.Generic;

namespace CapeApi.Shared
{
    public class OrderDto
    {
        public int OrderNumber { get; set; }

        public string OrderDate { get; set; }

        public string DeliveryAddress { get; set; }

        public IEnumerable<OrderItemDto> OrderItems { get; set; }

        public string DeliveryExpected { get; set; }
    }
}
