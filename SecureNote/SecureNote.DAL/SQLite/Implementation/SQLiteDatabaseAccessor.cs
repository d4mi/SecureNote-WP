using SecureNote.DAL.SQLite.Implementation;
using SecureNote.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.DAL
{
    public class SQLiteDatabaseAccessor : IUnitOfWork
    {

        #region Fields

        private SQLiteConnection _database;


        #endregion

        #region Ctor

        public SQLiteDatabaseAccessor()
        {
            _database = new SQLiteConnection("data.db");
            _database.CreateTable<Note>();
        }

        #endregion


        #region IUnitOfWork

        public Repository<T> GetRepository<T>() where T : class, new()
        {
            IEnumerable<T> table = _database.Query<T>("select * from Note");

            return new SQLiteRepository<T>(table);
        }

        public void SubmitChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
