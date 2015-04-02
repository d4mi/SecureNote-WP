using GalaSoft.MvvmLight;
using SecureNote.Model.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Desktop.ViewModel
{
    public class PagePasswordsViewModel : ViewModelBase
    {
        #region Fields

        private ObservableCollection<Page> _pages = new ObservableCollection<Page>();

        #endregion

        #region Ctor

        public PagePasswordsViewModel()
        {

        }

        #endregion

        #region Properties

        public ObservableCollection<Page> Pages
        {
            get
            {
                return _pages;
            }
        }

        #endregion


    }
}
