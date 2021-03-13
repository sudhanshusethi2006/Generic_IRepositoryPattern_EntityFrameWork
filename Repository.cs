using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConcpets
{
    class Repository<T> : IRespository<T> where T : class
    {
        EmployeeSystemEntities dbcontext;

        DbSet<T> dbSet;// Dbset is the collection of all entities 
        public Repository(EmployeeSystemEntities context)
        {
            dbcontext = context;
            dbSet = context.Set<T>();
        }
        public void Create(T entity)
        {
            dbSet.Add(entity);
        }
        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }
        public List<T> GetAll()
        {
            return dbSet.ToList();
        }
        public T getById(int id)
        {
            return dbSet.Find(id);
        }
        public void Update(T entity)
        {
            dbcontext.Entry<T>(entity).State = EntityState.Modified;
        }
    }
}
