using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MBBS_WEBSITE
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LoginId"] != null)
                {
                    headname.InnerHtml= Session["UserName"].ToString();
                }
            }
           
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Redirect to home.aspx
            Response.Redirect("home.aspx");
        }

        protected void lbPersonalInfo_Click(object sender, EventArgs e)
        {
            Response.Redirect("pinfo.aspx");
        }

        protected void lbSpecialReservation_Click(object sender, EventArgs e)
        {
            Response.Redirect("splres.aspx");
        }

        protected void lbAcademicSchooling_Click(object sender, EventArgs e)
        {
            Response.Redirect("sos.aspx");
        }

        protected void lbAdditionalInfo_Click(object sender, EventArgs e)
        {
            Response.Redirect("addinfo.aspx");
        }

        protected void lbDocumentsUpload_Click(object sender, EventArgs e)
        {
            Response.Redirect("upload.aspx");
        }

        protected void lbApplicationPreview_Click(object sender, EventArgs e)
        {
            Response.Redirect("apppreview.aspx");
        }
    }
}