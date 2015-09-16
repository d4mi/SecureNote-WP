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
    public class SignUpViewModel : ViewModelBase
    {

        #region Fields

        private string _errorMessage = String.Empty;
        private string _login = String.Empty;

        #endregion

        #region Ctor

        public SignUpViewModel()
        {
                
        }

        #endregion

        #region Properties

        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                if( _errorMessage != value )
                {
                    _errorMessage = value;
                    base.RaisePropertyChanged(() => ErrorMessage);
                }
            }
        }

        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                if( _login != value )
                {
                    _login = value;
                    base.RaisePropertyChanged(() => Login);
                }
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
                        _signInCommand = new RelayCommand<object>(
                            (passwords) =>
                            {
                                SignUp(passwords);
                            }
                        )
                    );
            }
        }
        
        #endregion

        #region Methods

        private void PublishErrorMessage(string message)
        {
            ErrorMessage = message;
        }

        private void SignUp(object passwords)
        {
            var passwordBoxes = passwords as object[];
            if (passwordBoxes != null && passwordBoxes.Length >= 2)
            {
                PasswordBox passwordBoxFirst = (PasswordBox)passwordBoxes[0];
                PasswordBox passwordBoxSecond = (PasswordBox)passwordBoxes[1];

                if (passwordBoxFirst.Password != passwordBoxSecond.Password)
                {
                    PublishErrorMessage("Passwords must match.");
                }

                if( Login == String.Empty )
                {
                    PublishErrorMessage("Login cannot be empty.");
                }
            }
        }

        #endregion

    }
}
