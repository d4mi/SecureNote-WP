using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using SecureNote.Service;
using SecureNote.Service.Implementations;
using SecureNote.Service.Interfaces;
using SecureNote.View;
using SecureNote.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SecureNote
{
    public class Bootstrap
    {
        #region Fields

       // private INavigation _navigation;

        #endregion

        #region Ctor

        public Bootstrap()
        {
            InitializeServiceLocator();

            InitializeServices();

            RegisterViews();

            InitializeViewModels();
        }

        #endregion

        #region Methods

        private void InitializeServiceLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
        }

        private void InitializeServices()
        {
            SimpleIoc.Default.Register<IDocumentsProvider, DocumentsProviderStub>();
            SimpleIoc.Default.Register<INotesProvider, NotesProviderStub>();
            SimpleIoc.Default.Register<IAuthenticationService, AuthenticationServiceStub>();
            SimpleIoc.Default.Register<INavigationService>(() => new NavigationService());
        }

        private void InitializeViewModels()
        {
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<DocumentsViewModel>();
            SimpleIoc.Default.Register<DocumentPreviewViewModel>();
            SimpleIoc.Default.Register<NotesViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<AddUserViewModel>();
        }

        private void RegisterViews()
        {
            var navigationService = ServiceLocator.Current.GetInstance<INavigationService>();
            navigationService.RegisterPage("", typeof(DocumentsView));
            navigationService.RegisterPage("DocumentPreview", typeof(DocumentPreviewView));
            navigationService.RegisterPage("SignIn", typeof(AddUserView));
        }

        #endregion
    }
}
