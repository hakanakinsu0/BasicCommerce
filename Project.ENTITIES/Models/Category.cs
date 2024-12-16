using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    //Category entity'si BaseEntity classinin ozelliklerini ve davranislarini miras alir ve kendine has ozellik ve davranis tanimlamalari yapilmistir.
    public class Category : BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties

        //1 urun 1 kategoride, 1 kategoride birden fazla urun bulunur.
        public virtual List<Product> Products { get; set; }

        public override string ToString()
        {
            return $"{CategoryName} - Veri durumu {Status}...E.Tarih{CreatedDate} ,G.Tarih : {ModifiedDate} , P.Tarih {DeletedDate}";
        }
    }
}
