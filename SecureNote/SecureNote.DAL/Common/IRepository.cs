using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.DAL
{
    public interface IRepository<T> 
        where T : class, new()
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        bool Remove(T entity);
        bool Update(T entity);
    }
}
