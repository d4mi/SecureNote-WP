using SecureNote.Service.Interfaces;
using SecureNote.View;
using SecureNote.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SecureNote.Service.Implementations
{
    public class NavigationService : INavigationService
    {
        #region Fields

        private Dictionary<string, Type> _registeredViews =
            new Dictionary<string, Type>();

        private INavigation _navigation;

        #endregion

        #region Ctor

        public NavigationService()
        {
        }

        void Init()
        {
            _navigation = App.Current.MainPage.Navigation;
        }
         
        #endregion

        #region INavigationService implementations

        public async Task NavigateTo(string pageName)
        {
            Init();

            if (_registeredViews.ContainsKey(pageName))
            {
                ContentPage view = (ContentPage)Activator.CreateInstance(_registeredViews[pageName]);
                await _navigation.PushAsync(view);
            }
            else
            {
                throw new Exception("View: " + pageName + " is not registered.");
            }                  
        }

        public async Task NavigateTo(string pageName, object bindingContext)
        {
            Init();

            if (_registeredViews.ContainsKey(pageName))
            {
                ContentPage view = (ContentPage)Activator.CreateInstance(_registeredViews[pageName]);
                view.BindingContext = bindingContext;
                await _navigation.PushAsync(view);
            }
            else
            {
                throw new Exception("View: " + pageName + " is not registered.");
            }     
        }

        public async Task GoBack()
        {
            await _navigation.PopAsync();
        }

        public void RegisterPage(string pageName, Type type)
        {
            _registeredViews.Add(pageName, type);
        }

        #endregion
    }
}
