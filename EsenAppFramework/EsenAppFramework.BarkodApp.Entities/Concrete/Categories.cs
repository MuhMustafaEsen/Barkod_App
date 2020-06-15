using EsenAppFramework.Core.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsenAppFramework.BarkodApp.Entities.Concrete
{
    public class Categories:IEntity
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
