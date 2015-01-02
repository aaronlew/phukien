using System;
using System.IO;

namespace GiaPhuc.Helper
{
    public class ImageHelper
    {
        public static string GetDataURL(string imgFile)
        {
            var extension = Path.GetExtension(imgFile);
            if (extension != null)
                return "data:image/"
                       + extension.Replace(".", "")
                       + ";base64,"
                       + Convert.ToBase64String(File.ReadAllBytes(imgFile));
            return string.Empty;
        }
    }
}