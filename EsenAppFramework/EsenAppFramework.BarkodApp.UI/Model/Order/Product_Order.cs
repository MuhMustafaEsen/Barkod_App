using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsenAppFramework.BarkodApp.UI.Model.Order
{
    public class Product_Order
    {
        public string ProductID { get; set; }
        public decimal Price { get; set; }
        public string ProductName { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Piece { get; set; }
        public string Barcod { get; set; }
    }
}
