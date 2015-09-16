using GalaSoft.MvvmLight;
using SecureNote.DAL;
using SecureNote.Model.Model;
using SecureNote.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SecureNote.Desktop.ViewModel
{
    public class AddWebPageViewModel : ViewModelBase
    {
        #region Fields

        private SecureNote.Model.Model.Page _page = new SecureNote.Model.Model.Page();
        //private readonly DatabaseUnitOfWork _database;

        #endregion

        #region Ctor

        public AddWebPageViewModel()
        {


           // _database = db;
        }
       
        #endregion

        #region Properties

        public string PageName
        {
            get
            {
                return _page.Name;
            }
            set
            {
                if( value != _page.Name )
                {
                    _page.Name = value;
                    base.RaisePropertyChanged(() => PageName);
                }
            }
        }

        public string Url
        {
            get
            {
                return _page.Url;
            }
            set
            {
                if( value != _page.Url)
                {
                    _page.Url = value;
                    base.RaisePropertyChanged(() => Url);
                }
            }
        }

        public Image Thumb
        {
            get
            {
                return _page.Thumb;
            }
            set
            {
                if( _page.Thumb != value )
                {
                    _page.Thumb = value;
                    base.RaisePropertyChanged(() => Thumb);
                }
            }
        }

        #endregion

    }
}
