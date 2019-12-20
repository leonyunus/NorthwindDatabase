using NorthwindDatabase.DAL.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDatabase.DAL.ORM.Entity.Concrete
{
    public class Orders:BaseEntity
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public string ShipVia { get; set; }
        public int Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public int ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }


        public virtual List<OrderDetails> OrderDetails { get; set; }

        public virtual List<Employees> Employees { get; set; }
        public virtual Shippers Shippers { get; set; }
        public virtual Customers Customers { get; set; }


    }
}
