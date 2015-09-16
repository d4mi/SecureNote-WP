using SecureNote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.DAL
{
       public class DatabaseUnitOfWork : IDisposable
    {
        #region Fields

        IUnitOfWork _unitOfWork;

        #endregion

        #region Ctor

        public DatabaseUnitOfWork(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
           
        }

        private void SetConnectionString()
        {
            _unitOfWork.SetConnectionString("db.txt");
        }



        #endregion

        #region Properties

        public IRepository<Note> Notes
        {
            get
            {
                return _unitOfWork.GetRepository<Note>();
            }
        }

        public IRepository<User> Users
        {
            get
            {
                return _unitOfWork.GetRepository<User>();
            }
        }
           
        #endregion

        #region Methods

        public void SubmitChanges()
        {
            _unitOfWork.SubmitChanges();
        }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        #endregion
    }
}
