using System;
using GiaPhuc.Data;
using GiaPhuc.Helper;

namespace GiaPhuc
{
    public class CMSContext : IDisposable
    {

        #region Constructors
        public CMSContext()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        #endregion

        #region Authorization
        public bool AuthenticateUser(string username, string password)
        {
            return UserHelper.AuthenticateUser(username, password);
        }
        #endregion

        #region MetaTags

        public MetaTags LoadMetaTag()
        {
            return MetaTagHelper.GetMetaTag();
        }

        public bool SaveMetaTag(string title, string metaKeywords, string metaDescription)
        {
            return MetaTagHelper.SaveMetaTag(title, metaKeywords, metaDescription);
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if (null != this)
                GC.SuppressFinalize(this);
        }

        #endregion

    }
}