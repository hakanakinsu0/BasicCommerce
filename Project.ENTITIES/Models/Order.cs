using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    //Order entity'si BaseEntity classinin ozelliklerini ve davranislarini miras alir ve kendine has ozellik ve davranis tanimlamalari yapilmistir.

    public class Order : BaseEntity
    {
        public string ShippingAddress { get; set; }
        public int AppUserId { get; set; }

        //Relational Properties
        //1 kullanicinin birden fazla siparisi, 1 siparis 1 kullaniciya aittir.
        public virtual AppUser AppUser { get; set; }

        //1 sipariste birden fazla urun, 1 urun birden fazla sipariste bulunur.
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
