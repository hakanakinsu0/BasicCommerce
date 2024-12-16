using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    //OrderDetail entity'si BaseEntity classinin ozelliklerini ve davranislarini miras alir ve bu classin gorevi Order ve Product arasindaki ara tablo (junction table) tanimlamasidir.

    public class OrderDetail : BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        //Relational Properties

        public virtual Order Orders{ get; set; }

        public virtual Product Product { get; set; }
    }
}
