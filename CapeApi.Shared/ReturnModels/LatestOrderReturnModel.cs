namespace CapeApi.Shared
{
    public class LatestOrderReturnModel
    {
        public LatestOrderReturnModel()
        {
        }

        public LatestOrderReturnModel(CustomerDto customerDto, OrderDto orderDto)
        {
            Customer = customerDto;
            Order = orderDto;
        }
        public CustomerDto Customer { get; set; }
        public OrderDto Order { get; set; }
    }
}
