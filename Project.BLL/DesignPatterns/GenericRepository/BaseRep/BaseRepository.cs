using Project.BLL.DesignPatterns.GenericRepository.IntRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext _db;

        public BaseRepository()
        {
            _db = DbTool.DbInstace;
        }
        public void Add(T entity)
        {
            _db.Set<T>().Add(entity);
            Save();
        }

        private void Save()
        {
            _db.SaveChanges();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public void Delete(T entity)
        {
            entity.DeletedDate = DateTime.Now;
            entity.Status = ENTITIES.Enums.DataStatus.Deleted;
            Save();
        }

        public string Destroy(T entity)
        {
            if (entity.Status != ENTITIES.Enums.DataStatus.Deleted) return "Once silmek istediginiz veriyi pasife getiriniz";
            else
            {
                _db.Set<T>().Remove(entity);
                Save();
                return "Veri silinmistir";
            }
        }

        public List<T> GetActives()
        {
            return Where(x=>x.Status != ENTITIES.Enums.DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public List<T> GetModifieds()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Updated);

        }

        public List<T> GetPassives()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted);

        }

        public void Update(T entity)
        {
            T orijinalEntity = GetById(entity.Id);
            entity.ModifiedDate = DateTime.Now; 
            entity.Status = ENTITIES.Enums.DataStatus.Updated;

            _db.Entry(orijinalEntity).CurrentValues.SetValues(entity);
            Save();
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }
    }
}
