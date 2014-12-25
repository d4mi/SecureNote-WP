using SecureNote.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SecureNote.Service.Implementation
{
    public class NavigationService : INavigationService
    {

        #region Ctor

        public NavigationService()
        {

        }

        #endregion

        #region INavigationService
        public void Navigate(Type sourceTypePage)
        {
            ((Frame)Window.Current.Content).Navigate(sourceTypePage);
        }

        #endregion
    }
}
