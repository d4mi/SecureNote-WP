using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using SecureNote.Service;
using SecureNote.Service.Implementations;
using SecureNote.Service.Interfaces;
using SecureNote.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Common
{
    public class ViewModelLocator
    {
        
        static ViewModelLocator()
        {


        }

        public static MainViewModel MainViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }

        public static DocumentsViewModel DocumentsViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DocumentsViewModel>();
            }
        }

        public static NotesViewModel NotesViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<NotesViewModel>();
            }
        }

        public static LoginViewModel LoginViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<LoginViewModel>();
            }
        }
    }
}
