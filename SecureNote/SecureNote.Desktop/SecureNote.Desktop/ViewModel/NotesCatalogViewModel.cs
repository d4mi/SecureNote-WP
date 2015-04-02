using GalaSoft.MvvmLight;
using SecureNote.DAL;
using SecureNote.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Desktop.ViewModel
{
    public class NotesCatalogViewModel : ViewModelBase
    {
        #region Fields

        private ObservableCollection<Note> _notes = new ObservableCollection<Note>();

        #endregion


        #region Ctor
        public NotesCatalogViewModel()
        {
               NotesRepository repository = new NotesRepository();
               repository.Add(new Note() { Text = "Hello world", Title = "First note" });
               repository.Add(new Note() { Text = "Hello world", Title = "Second note" });
               repository.Add(new Note() { Text = "Hello world", Title = "Third note" });

               _notes = new ObservableCollection<Note>(repository.GetAll());
        }

        #endregion

        #region Properties

        public ObservableCollection<Note> Notes
        {
            get
            {
                return _notes;
            }
        }

        #endregion
    }
}
