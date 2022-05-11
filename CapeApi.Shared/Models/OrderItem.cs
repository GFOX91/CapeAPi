namespace CapeApi.Shared
{
    public class OrderItem
    {
        public int ORDERITEMID { get; set; }
        public int? ORDERID { get; set; }
        public int? PRODUCTID { get; set; }

        public int QUANTITY { get; set; }

        public decimal PRICE { get; set; }
        public bool RETURNABLE { get; set; }

        public Product PRODUCT { get; set; }
    }
}
