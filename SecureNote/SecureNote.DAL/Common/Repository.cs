using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.DAL
{
    public abstract class Repository<T> : IQueryable<T>
        where T : class, new()
    {
        private IQueryable<T> _query;

        protected Repository(IQueryable<T> query)
        {
            _query = query;
        }

        public Type ElementType
        {
            get
            {
                return _query.ElementType;
            }
        }

        public Expression Expression
        {
            get
            {
                return _query.Expression;
            }
        }

        public virtual IQueryProvider Provider
        {
            get
            {
                return _query.Provider;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _query.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _query.GetEnumerator();
        }
 
    }
}
