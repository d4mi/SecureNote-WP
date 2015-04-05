using SecureNote.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Desktop.Utils
{
    [Serializable]
    public class NoteTypeToString : Dictionary<NoteType, string>
    {
        #region Ctor

        public NoteTypeToString()
        {
            CreateMapping();
        }

        #endregion

        #region Methods

        private void CreateMapping()
        {
            base.Add(NoteType.CONFIDENTIAL, "Confidential");
            base.Add(NoteType.OFFICIAL, "Official");
            base.Add(NoteType.RESTRICTED, "Restricted");
            base.Add(NoteType.SECRET, "Secret");
            base.Add(NoteType.TOP_SECRET, "Top secret");
        }

        #endregion

    }
}
