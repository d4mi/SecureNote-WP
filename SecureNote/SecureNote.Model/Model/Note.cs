using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Model
{
    public class Note
    {
        #region Fields

        private string _text;
        private string _title;
        private DateTime? _dateCreated;

        #endregion

        #region Properties

        public string Text
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
            }
        }
        
        public string Title
        {
            get 
            { 
                return _title;
            }

            set 
            { 
                _title = value;
            }
        }
        
        public DateTime? DateCreated
        {
            get
            {
                return _dateCreated;
            }

            set
            {
                _dateCreated = value;
            }
        }

        #endregion


        #region Ctor

        public Note()
        {
            Title = String.Empty;
            Text = String.Empty;

        }
        
        #endregion
    }
}
