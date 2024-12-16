using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    //Product entity'si BaseEntity classinin ozelliklerini ve davranislarini miras alir ve kendine has ozellik ve davranis tanimlamalari yapilmistir.

    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }

        //Relational Properties

        //1 urun 1 kategoride, 1 kategoride birden fazla urun bulunur.
        public virtual Category Category { get; set; }

        //1 sipariste birden fazla urun, 1 urun birden fazla sipariste bulunur.
        public virtual List<OrderDetail> OrderDetails { get; set; }

    }
}
