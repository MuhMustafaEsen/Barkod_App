using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsenAppFramework.BarkodApp.Entities.Concrete
{
    public class OrderDetails
    {
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Peice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
