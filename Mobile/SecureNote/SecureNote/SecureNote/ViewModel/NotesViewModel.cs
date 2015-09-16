using GalaSoft.MvvmLight;
using SecureNote.Model;
using SecureNote.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.ViewModel
{
    public class NotesViewModel : ViewModelBase
    {
        #region Fields

        private ObservableCollection<Note> _notes;
        private INotesProvider _notesProvider;
        private INavigationService _navigationService;

        #endregion

        #region Properties

        public ObservableCollection<Note> Notes
        {
            get
            {
                return _notes;
            }
            set
            {
                if( value != _notes )
                {
                    _notes = value;
                    base.RaisePropertyChanged(() => Notes);
                }
            }
        }

        #endregion

        #region Ctor

        public NotesViewModel(INotesProvider notesProvider,
                              INavigationService navigationService)
        {
            if (notesProvider == null)
                throw new ArgumentNullException("notesProvider is null");
            if (navigationService == null)
                throw new ArgumentNullException("navigationService is null");

            _notesProvider = notesProvider;
            _navigationService = navigationService;

            Notes = new ObservableCollection<Note>(notesProvider.GetNotes());
        }

        #endregion
    }
}
