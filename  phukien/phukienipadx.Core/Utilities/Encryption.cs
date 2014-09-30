using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace phukienipadx.Core.Utilities
{
    /// <summary>
    /// Utility class that handles encryption
    /// </summary>
    public class Encryption
    {
        #region Static Functions

        /// <summary>
        /// Encrypts a string
        /// </summary>
        /// <param name="plainText">Text to be encrypted</param>
        /// <param name="password">Password to encrypt with</param>
        /// <param name="salt">Salt to encrypt with</param>
        /// <param name="passwordIterations">Number of iterations to do</param>
        /// <param name="initialVector">Needs to be 16 ASCII characters long</param>
        /// <param name="keySize">Can be 128, 192, or 256</param>
        /// <returns>An encrypted string</returns>
        public static string Encrypt(string plainText, string password,
                                     string salt, int passwordIterations,
                                    string initialVector, int keySize)
        {
            if (string.IsNullOrEmpty(plainText))
                return String.Empty;
            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            var derivedPassword = new Rfc2898DeriveBytes(password, saltValueBytes, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);
            byte[] cipherTextBytes = null;

            var symmetricKey = new RijndaelManaged { Mode = CipherMode.CBC };
            using (ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initialVectorBytes))
            {
                MemoryStream memoryStream = null;
                try
                {
                    memoryStream = new MemoryStream();
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memoryStream.ToArray();
                        memoryStream = null;
                    }
                }
                catch (ObjectDisposedException)
                {
                }
                finally
                {
                    if (null != memoryStream)
                    {
                        memoryStream.Dispose();
                    }
                }
            }
            symmetricKey.Clear();
            if (cipherTextBytes != null) return Convert.ToBase64String(cipherTextBytes);
            return null;
        }

        /// <summary>
        /// Decrypts a string
        /// </summary>
        /// <param name="cipherText">Text to be decrypted</param>
        /// <param name="password">Password to decrypt with</param>
        /// <param name="salt">Salt to decrypt with</param>
        /// <param name="passwordIterations">Number of iterations to do</param>
        /// <param name="initialVector">Needs to be 16 ASCII characters long</param>
        /// <param name="keySize">Can be 128, 192, or 256</param>
        /// <returns>A decrypted string</returns>
        public static string Decrypt(string cipherText, string password,
                                     string salt, int passwordIterations,
                                     string initialVector, int keySize)
        {
            if (string.IsNullOrEmpty(cipherText))
                return string.Empty;
            byte[] initialVectorBytes = Encoding.ASCII.GetBytes(initialVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(salt);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            var derivedPassword = new Rfc2898DeriveBytes(password, saltValueBytes, passwordIterations);
            byte[] keyBytes = derivedPassword.GetBytes(keySize / 8);
            var symmetricKey = new RijndaelManaged { Mode = CipherMode.CBC };
            var plainTextBytes = new byte[cipherTextBytes.Length];
            int byteCount;
            using (ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initialVectorBytes))
            {
                using (var memoryStream = new MemoryStream(cipherTextBytes))
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        byteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                    }
                    memoryStream.Close();
                }
            }
            symmetricKey.Clear();
            return Encoding.UTF8.GetString(plainTextBytes, 0, byteCount);
        }

        #endregion

        /* Example: 
             * string FinalValue = AESEncryption.Encrypt(
             * "My Text","My Password",
             * "Salt or Password2",
             * "SHA1",2,
             * "16CHARSLONG12345",256);
             */
    }
}