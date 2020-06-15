using EsenAppFramework.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsenAppFramework.BarkodApp.Entities.Concrete
{
    public class Product:IEntity
    {
        public string ProductId { get; set; }
        public string BarkodNo { get; set; }  
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }       
        public DateTime AdditionDate { get; set; }

    }
}
