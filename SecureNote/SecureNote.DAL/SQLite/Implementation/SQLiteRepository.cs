using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.DAL.SQLite.Implementation
{
    public class SQLiteRepository<T> : Repository<T> 
        where T : class, new()
    {
        #region Fields

        private readonly IEnumerable<T> _table;

        #endregion

        #region Repository

        public SQLiteRepository(IEnumerable<T> table)
            : base(table.AsQueryable<T>())
        {
            _table = table;
        }

        #endregion

    }
}
