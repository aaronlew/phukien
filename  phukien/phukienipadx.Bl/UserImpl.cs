using System;
using phukienipadx.Core.Utilities;
using phukienipadx.Dal;
using phukienipadx.Dal.Repository;

namespace phukienipadx.Bl
{
    public class UserImpl
    {
        /// <summary>
        /// Authenticate
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Authenticate(string username, string password)
        {
            admin admin = null;
            var repository = new adminRepository();

            bool bflag = false;

            try
            {
                password = Security.Encrypt(password);
                admin = repository.GetSingleadmin(x => x.admin_name == username &&
                    x.admin_pass == password);
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
