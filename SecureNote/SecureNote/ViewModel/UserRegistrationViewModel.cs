using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.ViewModel
{
    public class UserRegistrationViewModel : ViewModelBase
    {
        #region Properties

        private string _login = String.Empty;
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                base.Set(() => Login, ref _login, value);
            }
        }

        private string _password = String.Empty;

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                base.Set(() => Password, ref _password, value);
            }
        }

        #endregion

    }
}
