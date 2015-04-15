using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SecureNote.Desktop.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SecureNote.Desktop.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region Fields

        private ViewModelBase _currentViewModel;

        private readonly MainViewModel _mainViewModel;
        private readonly LoginViewModel _loginViewModel;
        private readonly SignUpViewModel _signUpViewModel;

        #endregion

        #region Ctor
        public MainWindowViewModel()
        {
            ViewModelLocator viewModelLocator = new ViewModelLocator();
            _loginViewModel = viewModelLocator.LoginViewModel;
            _mainViewModel = viewModelLocator.MainViewModel;
            _signUpViewModel = viewModelLocator.SignUpViewModel;

            _loginViewModel.UserSignedInEvent += OnUserSignedIn;
            _loginViewModel.UserSignUpClickedEvent += OnUserSignUpClicked;

            CurrentViewModel = _loginViewModel;

        }

        #endregion

        #region Methods

        private void OnUserSignedIn(object sender, EventArgs args)
        {
            CurrentViewModel = _mainViewModel;
        }

        private void OnUserSignUpClicked(object sender, EventArgs args)
        {
            CurrentViewModel = _signUpViewModel;
        }


        #endregion

        #region Properties


        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                if( _currentViewModel != value )
                {
                    _currentViewModel = value;
                    base.RaisePropertyChanged(() => CurrentViewModel);
                }
            }
        }

        #endregion


    }
}