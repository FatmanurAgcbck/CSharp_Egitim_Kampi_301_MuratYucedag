using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        CampContext context = new CampContext();
       private readonly DbSet<T> _object;


        public GenericRepository()
        {
            _object=context.Set<T>();
        }

        void IGenericDal<T>.Delete(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        List<T> IGenericDal<T>.GetAll()
        {
            return _object.ToList();
        }

        T IGenericDal<T>.GetById(int id)
        {
            return _object.Find(id);
        }

        void IGenericDal<T>.Insert(T entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        void IGenericDal<T>.Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
