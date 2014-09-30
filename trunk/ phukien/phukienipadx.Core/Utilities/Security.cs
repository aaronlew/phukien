using System;

namespace phukienipadx.Core.Utilities
{
    public class Security
    {
        public static string Password1 = String.Empty;
        public static string Password2 = String.Empty;
        public static string Charlong = "16CHARSLONG12345";
        public static int KeySize = 128;

        public static string Encrypt(string value)
        {
            string password2 = String.IsNullOrEmpty(Password2) ? "Salt" : Password2;
            return Encryption.Encrypt(
                value, Password1,
                password2, 2,
                Charlong, KeySize);
        }

        public static string Decrypt(string value)
        {
            string password2 = String.IsNullOrEmpty(Password2) ? "Salt" : Password2;
            return Encryption.Decrypt(
                value, Password1,
                password2, 2,
                Charlong, KeySize);
        }
    }
}