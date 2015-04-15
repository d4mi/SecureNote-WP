using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using SecureNote.DAL;
using SecureNote.Desktop.ViewModel;
using SecureNote.Service.Implementation;
using SecureNote.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Desktop.Utils
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainWindowViewModel>();
            SimpleIoc.Default.Register<NoteEditViewModel>();
            SimpleIoc.Default.Register<NotesCatalogViewModel>();
            SimpleIoc.Default.Register<PagePasswordsViewModel>();
            SimpleIoc.Default.Register<AddWebPageViewModel>();
            SimpleIoc.Default.Register<SettingsViewModel>();
            SimpleIoc.Default.Register<AddDocumentViewModel>();
            SimpleIoc.Default.Register<CreditCardInfoViewModel>();
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<SignUpViewModel>();

            SimpleIoc.Default.Register<IFileBrowserDialog, FileBrowserDialog>();
            SimpleIoc.Default.Register<IUnitOfWork, SQLiteDatabaseAccessor>();
            SimpleIoc.Default.Register<DatabaseUnitOfWork>();
        }

        #region ViewModels

        public MainWindowViewModel MainWindowViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainWindowViewModel>();
            }
        }

        public NoteEditViewModel NoteEditViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NoteEditViewModel>();
            }
        }

        public NotesCatalogViewModel NotesCatalogViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NotesCatalogViewModel>();
            }
        }

        public PagePasswordsViewModel PagePasswordsViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<PagePasswordsViewModel>();
            }
        }

        public AddWebPageViewModel AddWebPageViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddWebPageViewModel>();
            }
        }

        public SettingsViewModel SettingsViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SettingsViewModel>();
            }
        }

        public AddDocumentViewModel AddDocumentViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<AddDocumentViewModel>();
            }
        }

        public CreditCardInfoViewModel CreditCardInfoViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CreditCardInfoViewModel>();
            }
        }

        public LoginViewModel LoginViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginViewModel>();
            }
        }

        public MainViewModel MainViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public SignUpViewModel SignUpViewModel
        {
            get 
            {
                return ServiceLocator.Current.GetInstance<SignUpViewModel>();
            }
        }

        #endregion // ViewModels


        #region Services 

        #endregion

        #region DAL

        public IUnitOfWork IUnitOfWork
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IUnitOfWork>();
            }
        }

        public DatabaseUnitOfWork DatabaseUnitOfWork
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DatabaseUnitOfWork>();
            }
        }


        #endregion

        public static void Cleanup()
        {


        }
    }
}
