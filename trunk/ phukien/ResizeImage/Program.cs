using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.IO;

namespace ResizeImage
{
    class Program
    {
        static void Main(string[] args)
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
                catch(Exception)
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
