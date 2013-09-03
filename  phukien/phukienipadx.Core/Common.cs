using System.Configuration;

namespace phukienipadx.Core
{
    public class Define
    {
        public const int PageSize = 11;
        public const string Email = "phukienipadx@gmail.com";
        public const string Password = "38587323";
        public const int Port = 587;
        public const string Host = "smtp.gmail.com";
        public const string CompanyName = "Nice store";
        public const string OwnerEmail = "lieumanhdat@gmail.com";
        public const string HiddenEmail = "lieumanhdat@gmail.com,huutai.alz@gmail.com,phukienipadx@gmail.com";
        public static readonly string UploadFolder = ConfigurationManager.AppSettings["imgUrl"];
        public static readonly string ThumbsFolder = ConfigurationManager.AppSettings["thumbUrl"];

        static public readonly string[] PageTypes = new [] {
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
