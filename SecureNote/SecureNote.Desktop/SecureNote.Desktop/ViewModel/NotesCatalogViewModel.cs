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

               _notes = new ObservableCollection<Note>();
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
