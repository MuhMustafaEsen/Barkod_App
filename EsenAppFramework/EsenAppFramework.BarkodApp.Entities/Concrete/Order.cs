using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsenAppFramework.BarkodApp.Entities.Concrete
{
   public class Order
    {
        public string OrderId { get; set; }
        public string Name { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
