using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConcpets
{
    interface IRespository<T>
    {
        List<T> GetAll();

        T getById(int id);

        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
