using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapeApi.Shared
{
    public class Product
    {
        public int PRODUCTID { get; set; }

        public string PRODUCTNAME { get; set; }

        public decimal? PACKHEIGHT { get; set; }

        public decimal? PACKWIDTH { get; set; }

        public decimal? PACKWEIGHT { get; set; }

        public string COLOUR { get; set; }

        public string SIZE { get; set; }

    }
}
