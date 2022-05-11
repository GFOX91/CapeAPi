using System;

namespace CapeApi.Shared
{
    public class Order
    {
        public int ORDERID { get; set; }
        public string CUSTOMERID { get; set; }

        public DateTime? ORDERDATE { get; set; }

        public DateTime? DELIVERYEXPECTED { get; set; }
        public bool CONTAINSGIFT { get; set; }
        public string SHIPPINGMODE { get; set; }
        public string ORDERSOURCE { get; set; }
    }
}
