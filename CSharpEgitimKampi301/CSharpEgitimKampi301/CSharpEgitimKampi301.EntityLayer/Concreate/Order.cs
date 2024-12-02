using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concreate
{
   public class Order
    {

        public string OrderId{ get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Decimal UnitPrice { get; set; }
     

        public Decimal TotalPrice { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }




    }
}
