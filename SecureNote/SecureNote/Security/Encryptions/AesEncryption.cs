using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Security.Encryptions
{
    public class AesEncryption
    {
        #region Fields
        public BinaryData Key { get; set; }

        public BinaryData IV { get; set; }

        public BinaryData Data { get; set; }

        #endregion

        #region Ctor

        public AesEncryption()
        {

        }

        #endregion
    }
}
