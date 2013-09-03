using GiaPhuc.Utility;

namespace GiaPhuc.Data
{
    public partial class EZPages
    {
        public string PageType
        {
            get { return Define.PageTypes[ToCChapter]; }
        }
    }
}