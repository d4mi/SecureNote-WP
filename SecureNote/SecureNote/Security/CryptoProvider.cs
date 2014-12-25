using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureNote.Security
{
    public class CryptoProvider
    {
        #region Ctor

        public CryptoProvider()
        {

        }

        #endregion

        #region Methods

        public BinaryData EncryptWithAes256(string text, BinaryData key, BinaryData iv)
        {
            BinaryData encryptedData = new BinaryData();

            return encryptedData;
        }

        #endregion
    }
}
