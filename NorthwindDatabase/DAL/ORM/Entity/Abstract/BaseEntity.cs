using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDatabase.DAL.ORM.Entity.Abstract
{
    public abstract  class BaseEntity
    {
        [
            Key,
            DatabaseGenerated(DatabaseGeneratedOption.Identity),
            Column(Order =1)
        ]

        public int ID { get; set; }

        private DateTime _addDate = DateTime.Now; 
        public DateTime AddDate { get { return _addDate; } set { _addDate = value; } }

        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

    }
}
