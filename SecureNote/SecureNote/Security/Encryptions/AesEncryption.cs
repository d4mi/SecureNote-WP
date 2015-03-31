using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace SecureNote.Security.Encryptions
{
    public class AesEncryption
    {
        #region Fields
        public string Key { get; set; }

        public string IV { get; set; }

        public string Data { get; set; }

        public BinaryStringEncoding BinaryStringEncoding { get; set; }

        #endregion

        #region Ctor

        public AesEncryption()
            : this(String.Empty, String.Empty, String.Empty)
        {            
        }

        public AesEncryption(string data, string key, string iv)
        {
            BinaryStringEncoding = BinaryStringEncoding.Utf8;

            Key = key;
            IV = iv;
            Data = data;
        }

        #endregion

        #region Methods

        public IBuffer Encrypt(string data, string key, string iv)
        {
            Key = key;
            IV = iv;
            Data = data;

            return Encrypt();
        }

        public IBuffer Encrypt()
        {
            IBuffer dataBuffer = CryptographicBuffer.ConvertStringToBinary(Data, BinaryStringEncoding);
            IBuffer keyBuffer = CryptographicBuffer.ConvertStringToBinary(Key, BinaryStringEncoding);
            IBuffer ivBuffer = CryptographicBuffer.ConvertStringToBinary(IV, BinaryStringEncoding);

            return Encrypt(dataBuffer, keyBuffer, ivBuffer);
        }

        public IBuffer Encrypt(IBuffer dataBuffer, IBuffer keyBuffer, IBuffer ivBuffer)
        {
            SymmetricKeyAlgorithmProvider aes = SymmetricKeyAlgorithmProvider.OpenAlgorithm(
                SymmetricAlgorithmNames.AesCbcPkcs7);

            CryptographicKey cryptographicKey = aes.CreateSymmetricKey(keyBuffer);

            return CryptographicEngine.Encrypt(cryptographicKey, dataBuffer, ivBuffer);
        }

        #endregion
    }
}
