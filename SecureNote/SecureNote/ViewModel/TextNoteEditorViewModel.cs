using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.ViewModel
{
    public class TextNoteEditorViewModel : ViewModelBase
    {
        #region Properties

        private string _titile = String.Empty;
        public string Titile
        {
            get
            {
                return _titile;
            }
            set
            {
                base.Set(() => Titile, ref _titile, value);
            }
        }


        private string _text = String.Empty;
        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                base.Set(() => Text, ref _text, value);
            }
        }


        #endregion

        #region Ctor

        public TextNoteEditorViewModel()
        {

        }

        #endregion
    }
}
