using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    //Tum entitylerimiz icin gecerli olacak propertyler tanimlanmistir. Bu classin gorevi sadece entitylere miras vermektir.
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            //Bu classa basvuruldugunda olusturulma tarihi ve verinin durumunu eklendi olarak tanimlanmistir.
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }

        //Tum entityler icin gecerli olan propertylerin tanimlanmasi yapilmistir.
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
