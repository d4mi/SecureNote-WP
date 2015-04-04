using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using SecureNote.Desktop.ViewModel;
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
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<NoteEditViewModel>();
            SimpleIoc.Default.Register<NotesCatalogViewModel>();
            SimpleIoc.Default.Register<PagePasswordsViewModel>();
            SimpleIoc.Default.Register<AddWebPageViewModel>();
            SimpleIoc.Default.Register<SettingsViewModel>();
            SimpleIoc.Default.Register<AddDocumentViewModel>();
            SimpleIoc.Default.Register<CreditCardInfoViewModel>();
        }

        public MainViewModel MainViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
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

        public static void Cleanup()
        {


        }
    }
}
