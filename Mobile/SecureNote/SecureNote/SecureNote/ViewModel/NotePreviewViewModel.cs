using GalaSoft.MvvmLight;
using SecureNote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.ViewModel
{
    public class NotePreviewViewModel : ViewModelBase
    {
        #region Fields

        private Note _note;

        #endregion

        #region Properties

        public Note Note
        {
            get
            {
                return _note;
            }
            set
            {
                if( value != _note )
                {
                    _note = value;
                    base.RaisePropertyChanged(() => Note);
                }
            }
        }

        #endregion

        #region Ctor

        public NotePreviewViewModel(Note note)
        {
            _note = note;
        }

        #endregion

    }
}
