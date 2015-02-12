using System.IO;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Anovsys.Encryption.Encrypt
{
    public class AE_Encrypt
    {
        private string _userKey;

        public AE_Encrypt(string UserKey)
        {
            this._userKey = UserKey;
        }

        private byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
        {
            if (this._userKey != "bengkel1q2w3e")
            {
                return new byte[0];
            }
            MemoryStream memoryStream = new MemoryStream();
            Rijndael _rijndael = Rijndael.Create();
            _rijndael.Key = Key;
            _rijndael.IV = IV;
            CryptoStream cryptoStream = new CryptoStream(memoryStream, _rijndael.CreateDecryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(cipherData, 0, cipherData.Length);
            cryptoStream.Close();
            return memoryStream.ToArray();
        }

        public string Decrypt(string Data, string Password, int Bits)
        {
            byte[] byteArray2;
            byte[] byteArray3;
            if (this._userKey != "bengkel1q2w3e")
            {
                return "Hubungi Admin.";
            }
            byte[] byteArray1 = Convert.FromBase64String(Data);
            PasswordDeriveBytes passwordDeriveBytes1 = new PasswordDeriveBytes(Password, new byte[] { byte.MinValue, 1, 2, 28, 29, 30, 3, 4, 5, 15, 32, 33, 173, 175, 164 });
            if (Bits == 128)
            {
                byteArray2 = this.Decrypt(byteArray1, passwordDeriveBytes1.GetBytes(16), passwordDeriveBytes1.GetBytes(16));
                return Encoding.Unicode.GetString(byteArray2);
            }
            if (Bits == 192)
            {
                byteArray3 = this.Decrypt(byteArray1, passwordDeriveBytes1.GetBytes(24), passwordDeriveBytes1.GetBytes(16));
                return Encoding.Unicode.GetString(byteArray3);
            }
            if (Bits != 256)
            {
                return string.Concat(Bits);
            }
            byte[] byteArray4 = this.Decrypt(byteArray1, passwordDeriveBytes1.GetBytes(32), passwordDeriveBytes1.GetBytes(16));
            return Encoding.Unicode.GetString(byteArray4);
        }

        private byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
        {
            if (this._userKey != "bengkel1q2w3e")
            {
                return new byte[0];
            }
            MemoryStream memoryStream = new MemoryStream();
            Rijndael _rijndael = Rijndael.Create();
            _rijndael.Key = Key;
            _rijndael.IV = IV;
            CryptoStream cryptoStream = new CryptoStream(memoryStream, _rijndael.CreateEncryptor(), CryptoStreamMode.Write);
            cryptoStream.Write(clearData, 0, clearData.Length);
            cryptoStream.Close();
            return memoryStream.ToArray();
        }

        public string Encrypt(string Data, string Password, int Bits)
        {
            byte[] byteArray2;
            byte[] byteArray3;
            if (this._userKey != "bengkel1q2w3e")
            {
                return "Hubungi Admin";
            }
            byte[] byteArray1 = Encoding.Unicode.GetBytes(Data);
            PasswordDeriveBytes passwordDeriveBytes1 = new PasswordDeriveBytes(Password, new byte[] { byte.MinValue, 1, 2, 28, 29, 30, 3, 4, 5, 15, 32, 33, 173, 175, 164 });
            if (Bits == 128)
            {
                byteArray2 = this.Encrypt(byteArray1, passwordDeriveBytes1.GetBytes(16), passwordDeriveBytes1.GetBytes(16));
                return Convert.ToBase64String(byteArray2);
            }
            if (Bits == 192)
            {
                byteArray3 = this.Encrypt(byteArray1, passwordDeriveBytes1.GetBytes(24), passwordDeriveBytes1.GetBytes(16));
                return Convert.ToBase64String(byteArray3);
            }
            if (Bits != 256)
            {
                return string.Concat(Bits);
            }
            byte[] byteArray4 = this.Encrypt(byteArray1, passwordDeriveBytes1.GetBytes(32), passwordDeriveBytes1.GetBytes(16));
            return Convert.ToBase64String(byteArray4);
        }
    }
}
