using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SecureNote.Model;
using SecureNote.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SecureNote.ViewModel
{
    public class AddUserViewModel : ViewModelBase
    {
        #region Properties

        private User _user;
        private INavigationService _navigationService;

        #endregion

        #region Ctor

        public AddUserViewModel(INavigationService navigationService)
        {
            if (navigationService == null)
                throw new ArgumentNullException("navigationService is null");
            
            _user = new User();
            _navigationService = navigationService;
        }

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return _user.Name;
            }
            set
            {
                if(_user.Name != value)
                {
                    _user.Name = value;
                    base.RaisePropertyChanged(() => Name);
                }
            }
        }

        public string Password
        {
            get
            {
                return _user.Password;
            }
            set
            {
                if(_user.Password != value)
                {
                    _user.Password = value;
                    base.RaisePropertyChanged(() => Password);
                }
            }
        }

        public string Email
        {
            get
            {
                return _user.Email;
            }
            set
            {
                if(_user.Email!= value)
                {
                    _user.Email = value;
                    base.RaisePropertyChanged(() => Email);
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
                    (_signInCommand = new RelayCommand(() =>
                        {
                            
                        }
                     ));
            }
        }

        private ICommand _cancelCommand;
        public ICommand CancelCommand
        {
            get
            {
                return _cancelCommand ??
                    (_cancelCommand = new RelayCommand(() =>
                        {
                            _navigationService.GoBack();
                        }
                    ));
            }
        }

        #endregion

    }
}
