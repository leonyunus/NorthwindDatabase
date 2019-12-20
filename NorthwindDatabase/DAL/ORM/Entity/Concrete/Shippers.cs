using NorthwindDatabase.DAL.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDatabase.DAL.ORM.Entity.Concrete
{
   public class Shippers:BaseEntity
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public int Phone { get; set; }

        public virtual List<Orders> Orders { get; set; }
    }
}
