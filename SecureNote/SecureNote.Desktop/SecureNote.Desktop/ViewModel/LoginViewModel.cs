using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace SecureNote.Desktop.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        #region Fields

        private string _username = String.Empty;
        private string _password = String.Empty;

        #endregion


        #region Ctor

        public LoginViewModel()
        {

        }

        #endregion

        #region Properties

        public event EventHandler UserSignedInEvent;
        public event EventHandler UserSignUpClickedEvent;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                base.Set(Username, ref _username, value);
            }
        }

        #endregion

        #region Commands

        private ICommand _signInCommand;
        public ICommand SignInCommand
        {
            get
            {
                return _signInCommand ??
                    (
                        new RelayCommand<PasswordBox>(
                            (passwordBox) =>
                            {
                                System.Windows.MessageBox.Show(passwordBox.Password);
                                if( UserSignedInEvent != null )
                                {
                                    UserSignedInEvent(this, null);
                                }
                            }
                        )
                    );
            }
        }

        private ICommand _signUpCommand;
        public ICommand SignUpCommand
        {
            get
            {
                return _signUpCommand ??
                    (
                        new RelayCommand(
                            () =>
                            {
                                if (UserSignUpClickedEvent != null)
                                {
                                    UserSignUpClickedEvent(this, null);
                                }
                            }
                        )
                    );
            }
        }
        #endregion

    }
}
