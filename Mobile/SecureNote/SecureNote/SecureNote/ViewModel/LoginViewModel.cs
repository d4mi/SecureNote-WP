using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SecureNote.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SecureNote.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        #region Fields

        private string _userName = String.Empty;
        private string _password = String.Empty;

        private IAuthenticationService _authenticationService;
        private INavigationService _navigationService;

        #endregion

        #region Properties

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if( _userName != value )
                {
                    _userName = value;
                    base.RaisePropertyChanged(()=>UserName);
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if( _password != value )
                {
                    _password = value;
                    base.RaisePropertyChanged(() => Password);
                }
            }
        }

        #endregion

        #region Ctor

        public LoginViewModel(IAuthenticationService authenticationService,
                              INavigationService navigationService)
        {
            if (authenticationService == null)
                throw new ArgumentNullException("authenticationService");

            if (navigationService == null)
                throw new ArgumentNullException("navigationService");

            _authenticationService = authenticationService;
            _navigationService = navigationService;
        }

        #endregion

        #region Commands

        private ICommand _loginClickedCommand;
        public ICommand LoginClickedCommand
        {
            get
            {
                return _loginClickedCommand ??
                    (_loginClickedCommand = new RelayCommand(
                    () =>
                    {
                        Authenicate();
                    }
                ));
            }
        }

        private ICommand _signInCommand;
        public ICommand SignInCommand
        {
            get
            {
                return _signInCommand ??
                    (_signInCommand = new RelayCommand(
                    () =>
                    {
                        _navigationService.NavigateTo("SignIn");
                    }
                ));
            }

        }




        #endregion

        #region Methods

        private void Authenicate()
        {
            if( _authenticationService.Authenticate(UserName, Password) )
            {
                _navigationService.NavigateTo("");
            }
        }

        #endregion
    }
}
