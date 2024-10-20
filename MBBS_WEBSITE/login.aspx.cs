using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MBBS_WEBSITE
{
    public partial class login : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

         
        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(strcon))
                {
                    string query = "SELECT * FROM UserRegister where LoginId = '" + txtuserid.Text.Trim() + "' and UserPassword='" + txtPassword.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    
                    if(dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            // Response.Write("<script> alert('login successfulllllll') </script>");
                            Session["UserName"] = dr.GetValue(0).ToString();
                            Session["DateOfBirth"] = dr.GetValue(4).ToString();
                            Session["HSCRollNumber"] = dr.GetValue(6).ToString();
                            Session["YearOfPassing"] = dr.GetValue(9).ToString();
                            Session["NEETRollNumber"] = dr.GetValue(7).ToString();
                            Session["Gender"] = dr.GetValue(2).ToString();
                            Session["LoginId"] = dr.GetValue(11).ToString();
                        }
                        Response.Redirect("pinfo.aspx");
                        

                    }
                    else
                    {
                        Response.Write("<script> alert('login id or password is wrong ....!') </script>");
                    }
                }
                
                }
            catch(Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "') </script>");
            }
        }



    }
}