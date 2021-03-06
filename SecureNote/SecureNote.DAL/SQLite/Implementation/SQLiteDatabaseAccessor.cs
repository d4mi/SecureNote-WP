﻿using SecureNote.DAL.SQLite.Implementation;
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
 
        }

        #endregion

        #region Methods

        void CreateTables()
        {
            _database.CreateTable<Note>();
        }

        #endregion


        #region IUnitOfWork

        public void SetConnectionString(string connectionString)
        {
            _database = new SQLiteConnection(connectionString);
            CreateTables();
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new SQLiteRepository<T>(_database);
        }

        public int Insert<T>(T obj) where T : class, new()
        {
            return _database.Insert(obj);
        }

        public void SubmitChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _database.Dispose();
        }

        #endregion
    }
}
