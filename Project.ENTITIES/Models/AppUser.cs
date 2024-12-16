using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    //AppUser entity'si BaseEntity classinin ozelliklerini ve davranislarini miras alir ve kendine has ozellik ve davranis tanimlamalari yapilmistir.

    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        //Relational Properties
        //1 kullanicinin 1 profili ve 1 profil de 1 kullaniciya aittir.
        public virtual AppUserProfile Profile { get; set; }

        //1 kullanicinin birden fazla siparisi, 1 siparis 1 kullaniciya aittir.
        public virtual List<Order> Orders { get; set; }
    }
}
