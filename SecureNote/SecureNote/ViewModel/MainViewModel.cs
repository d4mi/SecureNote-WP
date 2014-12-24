using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
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

        public MainViewModel()
        {
            Title = IsInDesignMode ? "Hello" : "World";
        }

        #endregion
    }
}
