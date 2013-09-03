using GiaPhuc.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

namespace GiaPhuc.Helper
{
    public class ManufacturerHelper : DataHelper
    {
        /// <summary>
        /// Get a manufacturer
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <param name="totalRecords"></param>
        /// <returns></returns>
        public static Manufacturers GetManufacturer(int manufacturerID)
        {
            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (ResellEraDMInPhUkIeNipAdX context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var manufacturer = from x in context.Manufacturers
                                       where x.ManufacturersID == manufacturerID
                                       select x;
                    if (manufacturer != null)
                        return manufacturer.SingleOrDefault();
                }
            }

            return null;
        }

        public static IList<Manufacturers> GetManufacturers()
        {
            IEnumerable<Manufacturers> manufacturers = null;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (var context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    manufacturers = from x in context.Manufacturers
                                    select x;
                }
            }

            return manufacturers.ToList();
        }

        public static bool SaveManufacturer(Manufacturers manufacturer)
        {
            bool flag = false;

            try
            {
                using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
                {
                    using (ResellEraDMInPhUkIeNipAdX context = new ResellEraDMInPhUkIeNipAdX(connection))
                    {
                        if (manufacturer.ManufacturersID == 0)
                        {
                            context.Manufacturers.InsertOnSubmit(manufacturer);
                            context.SubmitChanges();
                        }
                        else
                        {
                            var entry = context.Manufacturers.SingleOrDefault(x => x.ManufacturersID == manufacturer.ManufacturersID);
                            entry.ManufacturersName = manufacturer.ManufacturersName;

                            context.SubmitChanges();
                        }

                    }
                }

                flag = true;
            }
            catch
            {
                throw;
            }

            return flag;
        }

        public static bool DeleteManufacturer(int id)
        {
            bool bflag = false;

            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString))
            {
                using (ResellEraDMInPhUkIeNipAdX context = new ResellEraDMInPhUkIeNipAdX(connection))
                {
                    var manufacturer = context.Manufacturers.SingleOrDefault(x => x.ManufacturersID == id);

                    if (null != manufacturer)
                    {
                        context.Manufacturers.DeleteOnSubmit(manufacturer);
                        context.SubmitChanges();

                        bflag = true;
                    }
                }
            }

            return bflag;
        }
    }
}