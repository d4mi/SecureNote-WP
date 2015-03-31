using GalaSoft.MvvmLight;
using SecureNote.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Desktop.ViewModel
{
    public class NoteEditViewModel : ViewModelBase
    {
        #region Fields

        private Note _note = new Note();

        #endregion

        #region Properties

        public string Title
        {
            get
            {
                return _note.Title;
            }
            set
            {
                if( value != _note.Title )
                {
                    _note.Title = value;
                    base.RaisePropertyChanged(() => Title);
                }
            }
        }

        public string Text
        {
            get
            {
                return _note.Text;
            }
            set
            {
                if( value != _note.Text )
                {
                    _note.Text = value;
                    RaisePropertyChanged(() => Text);
                }
            }
        }

        #endregion

    }
}
