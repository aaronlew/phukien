using GiaPhuc.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

namespace GiaPhuc.Helper
{
    public class UserHelper : DataHelper
    {
        /// <summary>
        /// Authenticate
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool AuthenticateUser(string username, string password)
        {
            AdMIn admin = null;

            bool bflag = false;

            try
            {
                using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
                {
                    using (ResellEraDMInPhUkIeNipAdX context = new ResellEraDMInPhUkIeNipAdX(connection))
                    {
                        password = Security.Encrypt(password);
                        admin = context.AdMIn.SingleOrDefault(x => x.AdMInName == username &&
                            x.AdMInPass == password);
                    }
                }
            }
            catch (Exception)
            {
                admin = null;
            }

            if (null != admin)
            {
                bflag = true;
            }
            return bflag;
        }

    }
}