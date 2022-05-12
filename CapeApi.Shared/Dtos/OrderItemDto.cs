namespace CapeApi.Shared
{
    public class OrderItemDto
    {
        public OrderItemDto()
        {
        }

        public OrderItemDto(OrderItem orderItem, bool ContainsGift)
        {
            Product = ContainsGift ? "gift" : orderItem.PRODUCT.PRODUCTNAME.ToString();
            Qauntity = orderItem.QUANTITY;
            PriceEach = orderItem.PRICE / orderItem.QUANTITY;
        }
        public string Product { get; set; }

        public int Qauntity { get; set; }

        public decimal PriceEach { get; set; }
    }
}
