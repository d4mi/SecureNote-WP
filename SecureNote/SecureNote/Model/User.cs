using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Model
{
    public class User
    {
        #region Properties

        public string Name { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return String.Format("{0} {1}", Name, LastName);
            }
        }

        #endregion

        #region Ctor
        public User()
        {
            Name = String.Empty;
            LastName = String.Empty;
        }
        #endregion
    }
}
