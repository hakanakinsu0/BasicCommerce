using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class AppUserConfiguration : BaseConfiguration<AppUser>
    {
        public AppUserConfiguration()
        {
            ToTable("Kullanicilar");

            Property(x => x.UserName).HasColumnName("Kullanici Adi");
            Property(x => x.Password).HasColumnName("Sifre");

            HasOptional(x => x.Profile).WithRequired(x => x.AppUser);
        }
    }
}
