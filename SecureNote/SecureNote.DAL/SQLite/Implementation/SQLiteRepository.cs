using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.DAL.SQLite.Implementation
{
    public class SQLiteRepository<T> : IRepository<T> 
        where T : class, new()
    {
        #region Fields

        private readonly SQLiteConnection _database;

        #endregion

        #region Repository

        public SQLiteRepository(SQLiteConnection database)
        {
            _database = database;
        }

        #endregion

        #region IRepository

        public IEnumerable<T> GetAll()
        {
            return _database.Query<T>("select * from Note");
        }

        public void Add(T entity)
        {
            _database.Insert(entity);
        }

        public bool Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
