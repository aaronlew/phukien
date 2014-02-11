using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace ResizeImage
{
    class Program
    {
        static void Main(string[] args)
        {
            //ResizeAllImage();
            UnmarkName();
        }

        private static void UnmarkName()
        {
            string connString = "data source=123.30.185.47;initial catalog=phukienipadx_com;UID=phukienipadx;Password=admin1!;";
            using (var conn = new SqlConnection(connString))
            {
                // Open Connection
                conn.Open();
                var transaction = conn.BeginTransaction();

                try
                {
                    using (var comm = conn.CreateCommand())
                    {
                        comm.Transaction = transaction;

                        var query = "SELECT * FROM products_description";
                        comm.CommandText = query;

                        DataTable table = new DataTable();
                        var adapter = new SqlDataAdapter(comm);
                        adapter.Fill(table);

                        foreach (DataRow item in table.Rows)
                        {
                            query = String.Format("UPDATE products_description SET products_url = '{0}' WHERE products_id = {1} AND language_id = 0", StringUtils.GetGoodUrl(item["products_name"].ToString()), item["products_id"]);
                            comm.CommandText = query;
                            comm.ExecuteNonQuery();
                        }

                        query = "SELECT * FROM categories_description WHERE categories_id > 0";
                        comm.CommandText = query;

                        table = new DataTable();
                        adapter = new SqlDataAdapter(comm);
                        adapter.Fill(table);

                        foreach (DataRow item in table.Rows)
                        {
                            query = String.Format("UPDATE categories_description SET categories_url = '{0}' WHERE categories_id = {1} AND language_id = 0", StringUtils.GetGoodUrl(item["categories_name"].ToString()), item["categories_id"]);
                            comm.CommandText = query;
                            comm.ExecuteNonQuery();
                        }

                        query = "SELECT * FROM ezpages";
                        comm.CommandText = query;

                        table = new DataTable();
                        adapter = new SqlDataAdapter(comm);
                        adapter.Fill(table);

                        foreach (DataRow item in table.Rows)
                        {
                            query = String.Format("UPDATE ezpages SET alt_url = '{0}' WHERE pages_id = {1} AND languages_id = 0", StringUtils.GetGoodUrl(item["pages_title"].ToString()), item["pages_id"]);
                            comm.CommandText = query;
                            comm.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                }

                conn.Close();
            }
        }

        private static void ResizeAllImage()
        {
            const string path = @"F:\Workspace\phukienipadx solution\GiaPhuc\Upload";
            const string thumbnailsPath = @"F:\Workspace\phukienipadx solution\GiaPhuc\Upload\Thumbs\";

            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (var fileInfo in dir.GetFiles())
            {
                try
                {
                    Bitmap srcImage = new Bitmap(fileInfo.FullName);
                    Bitmap newImage = ScaleImage(srcImage, 210, 140);
                    newImage.Save(Path.Combine(thumbnailsPath, fileInfo.Name));
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        static Bitmap ScaleImage(Bitmap srcImage, int newWidth, int newHeight)
        {
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(srcImage, new Rectangle(0, 0, newWidth, newHeight));
            }

            return newImage;
        }
    }
}
