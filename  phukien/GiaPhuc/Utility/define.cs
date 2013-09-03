using System.Configuration;

namespace GiaPhuc.Utility
{
    public class Define
    {
        public const int PageSize = 11;
        public const string Email = "phukienipadx@gmail.com";
        public const string Password = "38587323";
        public const int Port = 587;
        public const string Host = "smtp.gmail.com";
        public const string CompanyName = "Nice store";
        public const string OwnerEmail = "phukienipadx@gmail.com";
        public const string HiddenEmail = "huutai.alz@gmail.com,lieumanhdat@gmail.com";
        public static readonly string UploadFolder = ConfigurationManager.AppSettings["imgUrl"];
        public static readonly string ThumbFolder = ConfigurationManager.AppSettings["thumbUrl"];

        static public readonly string[] PageTypes = new string[] {
                                                                     "Chọn nhóm tin", "Bài viết", "Hướng dẫn"
                                                                 };
    }

    public enum PageType
    {
        None = 0,
        Topic = 1,
        Guide = 2
    }
}