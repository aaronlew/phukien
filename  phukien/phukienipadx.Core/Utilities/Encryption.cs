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
        /// <param name="PlainText">Text to be encrypted</param>
        /// <param name="Password">Password to encrypt with</param>
        /// <param name="Salt">Salt to encrypt with</param>
        /// <param name="HashAlgorithm">Can be either SHA1 or MD5</param>
        /// <param name="PasswordIterations">Number of iterations to do</param>
        /// <param name="InitialVector">Needs to be 16 ASCII characters long</param>
        /// <param name="KeySize">Can be 128, 192, or 256</param>
        /// <returns>An encrypted string</returns>
        public static string Encrypt(string PlainText, string Password,
                                     string Salt, string HashAlgorithm,
                                     int PasswordIterations, string InitialVector,
                                     int KeySize)
        {
            try
            {
                if (string.IsNullOrEmpty(PlainText))
                    return String.Empty;
                byte[] InitialVectorBytes = Encoding.ASCII.GetBytes(InitialVector);
                byte[] SaltValueBytes = Encoding.ASCII.GetBytes(Salt);
                byte[] PlainTextBytes = Encoding.UTF8.GetBytes(PlainText);
                var DerivedPassword = new PasswordDeriveBytes(Password, SaltValueBytes, HashAlgorithm,
                                                              PasswordIterations);
                byte[] KeyBytes = DerivedPassword.GetBytes(KeySize/8);
                byte[] CipherTextBytes = null;

                var SymmetricKey = new RijndaelManaged();
                SymmetricKey.Mode = CipherMode.CBC;
                using (ICryptoTransform Encryptor = SymmetricKey.CreateEncryptor(KeyBytes, InitialVectorBytes))
                {
                    MemoryStream memoryStream = null;
                    try
                    {
                        memoryStream = new MemoryStream();
                        using (var CryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write))
                        {
                            CryptoStream.Write(PlainTextBytes, 0, PlainTextBytes.Length);
                            CryptoStream.FlushFinalBlock();
                            CipherTextBytes = memoryStream.ToArray();
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
                SymmetricKey.Clear();
                return Convert.ToBase64String(CipherTextBytes);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Decrypts a string
        /// </summary>
        /// <param name="CipherText">Text to be decrypted</param>
        /// <param name="Password">Password to decrypt with</param>
        /// <param name="Salt">Salt to decrypt with</param>
        /// <param name="HashAlgorithm">Can be either SHA1 or MD5</param>
        /// <param name="PasswordIterations">Number of iterations to do</param>
        /// <param name="InitialVector">Needs to be 16 ASCII characters long</param>
        /// <param name="KeySize">Can be 128, 192, or 256</param>
        /// <returns>A decrypted string</returns>
        public static string Decrypt(string CipherText, string Password,
                                     string Salt, string HashAlgorithm,
                                     int PasswordIterations, string InitialVector,
                                     int KeySize)
        {
            try
            {
                if (string.IsNullOrEmpty(CipherText))
                    return "";
                byte[] InitialVectorBytes = Encoding.ASCII.GetBytes(InitialVector);
                byte[] SaltValueBytes = Encoding.ASCII.GetBytes(Salt);
                byte[] CipherTextBytes = Convert.FromBase64String(CipherText);
                var DerivedPassword = new PasswordDeriveBytes(Password, SaltValueBytes, HashAlgorithm,
                                                              PasswordIterations);
                byte[] KeyBytes = DerivedPassword.GetBytes(KeySize/8);
                var SymmetricKey = new RijndaelManaged();
                SymmetricKey.Mode = CipherMode.CBC;
                var PlainTextBytes = new byte[CipherTextBytes.Length];
                int ByteCount = 0;
                using (ICryptoTransform Decryptor = SymmetricKey.CreateDecryptor(KeyBytes, InitialVectorBytes))
                {
                    using (var memoryStream = new MemoryStream(CipherTextBytes))
                    {
                        using (var CryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read))
                        {
                            ByteCount = CryptoStream.Read(PlainTextBytes, 0, PlainTextBytes.Length);
                        }
                        memoryStream.Close();
                    }
                }
                SymmetricKey.Clear();
                return Encoding.UTF8.GetString(PlainTextBytes, 0, ByteCount);
            }
            catch
            {
                throw;
            }
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