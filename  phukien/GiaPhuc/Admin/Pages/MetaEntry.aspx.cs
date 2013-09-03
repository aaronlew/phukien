using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GiaPhuc;

public partial class Pages_MetaEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            using (CMSContext cms = new CMSContext())
            {
                var metaTag = cms.LoadMetaTag();

                if (null != metaTag)
                {
                    this.txtTitle.Text = metaTag.MetaTagsTitle;
                    this.txtKeywords.Text = metaTag.MetaTagsKeywords;
                    this.txtDescription.Text = metaTag.MetaTagsDescription;
                }
            }
        }
    }

    protected void lnkSave_Click(object sender, EventArgs e)
    {
        using (CMSContext cms = new CMSContext())
        {
            string title = this.txtTitle.Text;
            string metaKeywords = this.txtKeywords.Text;
            string metaDescription = this.txtDescription.Text;

            bool flag = cms.SaveMetaTag(title, metaKeywords, metaDescription);

            if (flag)
            {
                this.FailureText.Text = "Save the meta tags successful.";
            }
            else
            {
                this.FailureText.Text = "Save the meta tags failure.";
            }
        }
    }
}