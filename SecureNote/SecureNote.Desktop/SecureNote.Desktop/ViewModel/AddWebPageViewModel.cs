using GalaSoft.MvvmLight;
using SecureNote.Model.Model;
using SecureNote.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Desktop.ViewModel
{
    public class AddWebPageViewModel : ViewModelBase
    {
        #region Fields

        private Page _page = new Page();

        #endregion

        #region Ctor

        public AddWebPageViewModel()
        {
            WebsiteScreenshot w = new WebsiteScreenshot();
            w.GetPage("");
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



        #endregion

    }
}
