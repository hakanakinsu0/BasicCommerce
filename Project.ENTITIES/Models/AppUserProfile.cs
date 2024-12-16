using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    //AppUserProfile entity'si BaseEntity classinin ozelliklerini ve davranislarini miras alir ve kendine has ozellik ve davranis tanimlamalari yapilmistir.

    public class AppUserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relational Properties

        //1 kullanicinin 1 profili ve 1 profil de 1 kullaniciya aittir.
        public virtual AppUser AppUser { get; set; }
    }
}
