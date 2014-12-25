using GalaSoft.MvvmLight;
using SecureNote.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Fields

        private INavigationService _navigationService;

        #endregion

        #region Properties

        private string _title = String.Empty;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                Set(() => Title, ref _title, value);
            }
        }

        #endregion

        #region Ctor

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            Title = IsInDesignMode ? "Hello" : "World";
        }

        #endregion
    }
}
