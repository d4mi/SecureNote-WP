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
    public class DocumentPreviewViewModel : ViewModelBase
    {
        #region Fields

        private Document _document = new Document();
        private INavigationService _navigationService;

        #endregion

        #region Ctor

        public DocumentPreviewViewModel(INavigationService navigationService)
        {
            if (navigationService == null)
                throw new ArgumentNullException("navigationService is null");

            _navigationService = navigationService;
        }

        #endregion

        #region Properties

        public Document Document
        {
            get
            {
                return _document;
            }
            set
            {
                if( _document != value )
                {
                    _document = value;
                    base.RaisePropertyChanged(() => Document);
                }
            }
        }

        #endregion

        #region Commands

        private ICommand _showCommand;
        public ICommand ShowCommand
        {
            get
            {
                return _showCommand ??
                    (_showCommand = new RelayCommand(() =>
                        {
                            ShowDocument();
                        }));
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
                    }));
            }
        }

        #endregion

        #region Methods

        private void ShowDocument()
        {
            
        }

        #endregion

    }
}
