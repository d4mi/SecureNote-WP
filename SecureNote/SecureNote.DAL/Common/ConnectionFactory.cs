using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.DAL.Common
{
    public class ConnectionFactory
    {
        public static IUnitOfWork GetConnection()
        {
            return _unitOfWork;
        }

        public static bool SetConnection(string connectionString)
        {
            _unitOfWork = new DatabaseUnitOfWork();
            _unitOfWork.SetConnectionString(connectionString);

        }

        private static IUnitOfWork _unitOfWork;

    }
}
