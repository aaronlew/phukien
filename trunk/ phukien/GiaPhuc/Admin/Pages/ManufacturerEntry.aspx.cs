using GiaPhuc.Data;
using GiaPhuc.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GiaPhuc.Admin.Pages
{
    public partial class ManufacturerEntry : System.Web.UI.Page
    {
        private int ManufacturerID
        {
            get
            {
                if (null != Request["ID"])
                {
                    return int.Parse(Request["ID"]);
                }
                return 0;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Manufacturers manufacturer = ManufacturerHelper.GetManufacturer(ManufacturerID);
                if (null != manufacturer)
                {
                    this.txtManufacturerName.Text = manufacturer.ManufacturersName;
                }
            }
        }

        protected void lnkSave_Click(object sender, EventArgs e)
        {
            try
            {
                Manufacturers manufacturer = new Manufacturers
                {
                    ManufacturersID = ManufacturerID,
                    ManufacturersName = this.txtManufacturerName.Text
                };

                ManufacturerHelper.SaveManufacturer(manufacturer);

                if (ManufacturerID == 0)
                {
                    Response.Redirect("/Admin/Pages/ManufacturerEntry.aspx");
                }
                else
                {
                    Response.Redirect("/Admin/Pages/ManufacturerManager.aspx");
                }
            }
            catch
            {
                throw;
            }
        }
    }
}