using Project.BLL.DesignPatterns.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class ProductRepository : BaseRepository<Product>
    {
        /// <summary>
        /// Bu metot varolan bir Kategori id'sini ekleyeceginiz Product'a CategoryId olarak verir..Dikkat edin eger ilgili kategori yoksa ekleme yapılmaz
        /// </summary>
        /// <param name="p"></param>
        /// <param name="id"></param>
        /// <param name="message"></param>
        public void SpecialAdd(Product p, int id,out string message)
        {
            CategoryRepository cr = new CategoryRepository();
            if (cr.GetById(id) == null)
            {
                message = "Bildirmek istediginiz kategori bulunamadi";
                return;
            }
            
            p.CategoryId = id;
            Add(p);
            message = "Kategorisi eklenerek urun olusturuldu.";
        }

        /// <summary>
        /// Bu metot Product'i yaratırken Category'i de onunla birlikte yaratır
        /// </summary>
        /// <param name="p"></param>
        /// <param name="item"></param>
        public void SpecialAddProductAndCategory(Product p, Category item)
        {
            p.Category = item;
            Add(p);
        }
    }
}
