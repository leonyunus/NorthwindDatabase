using NorthwindDatabase.DAL.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDatabase.DAL.ORM.Entity.Concrete
{
  public  class OrderDetails:BaseEntity
    {
               
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }


        public int OrderID { get; set; }
        public virtual Orders Orders { get; set; }

    }
}
