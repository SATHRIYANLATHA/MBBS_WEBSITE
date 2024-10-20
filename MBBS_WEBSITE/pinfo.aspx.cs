using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MBBS_WEBSITE
{
    public partial class pinfo : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!IsPostBack)
            {
                BindCommunityDropDown(); // dropdown for community
                BindNationalityDropDown(); // dropdown for nationality ...
                BindMotherTongueDropDown(); // dropdown for mother tongue ...
                BindReligionDropDown(); // dropdown for religion ...
                BindNativityDropDown(); // dropdown for nativity ...
                BindDistrictDropDown(); // dropdown for district ...

                string loginId = Session["LoginId"] as string;

                if (Session["LoginId"] != null)
                {
                    username.InnerHtml = Session["UserName"].ToString();
                    hscrollno.InnerHtml = Session["HSCRollNumber"].ToString();
                    neetrollno.InnerHtml = Session["NEETRollNumber"].ToString();
                    dateofbirth.InnerHtml = Session["DateOfBirth"].ToString();
                    yearofpassing.InnerHtml = Session["YearOfPassing"].ToString();
                    gender.InnerHtml = Session["Gender"].ToString();

                }

                loaduserdetails(loginId);
            }

            
        }

        protected void btnSaveContinue_Click(object sender, EventArgs e)
        {
            try
            {
                String LoginId = Session["LoginId"] as string;

                using (SqlConnection con = new SqlConnection(strcon))
                {
                    String checkQuery = "SELECT COUNT(*) FROM PersonalInformation where LoginId = @LoginId";
                    SqlCommand checkcmd = new SqlCommand(checkQuery, con);
                    checkcmd.Parameters.AddWithValue("@LoginId",LoginId);

                    con.Open();
                    int count = Convert.ToInt32(checkcmd.ExecuteScalar());
                    con.Close();

                    string query;

                    if(count > 0)
                    {
                         query = "UPDATE PersonalInformation SET NameOfTheParent=@NameOfTheParent,Nationality=@Nationality,MotherTongue=@MotherTongue,SchoolingStudied=@SchoolingStudied,Religion=@Religion,Nativity=@Nativity,Community=@Community,CasteWithSubCode=@CasteWithSubCode,CertificateNumber=@CertificateNumber,IssuedBy=@IssuedBy,IssuedTaluk=@IssuedTaluk,CommDistrict=@CommDistrict,IssuedDate=@IssuedDate WHERE LoginId=@LoginId";
                    }
                    else
                    {
                         query = "INSERT INTO PersonalInformation(LoginId,NameOfTheParent,Nationality,MotherTongue,SchoolingStudied,Religion,Nativity,Community,CasteWithSubCode,CertificateNumber,IssuedBy,IssuedTaluk,CommDistrict,IssuedDate) VALUES (@LoginId,@NameOfTheParent,@Nationality,@MotherTongue,@SchoolingStudied,@Religion,@Nativity,@Community,@CasteWithSubCode,@CertificateNumber,@IssuedBy,@IssuedTaluk,@CommDistrict,@IssuedDate)";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@LoginId", LoginId);
                    cmd.Parameters.AddWithValue("@NameOfTheParent", txtParent.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nationality", ddlNationality.SelectedValue);
                    cmd.Parameters.AddWithValue("@MotherTongue", ddlMotherTongue.SelectedValue);
                    cmd.Parameters.AddWithValue("@SchoolingStudied", ddlSchooling.SelectedValue);
                    cmd.Parameters.AddWithValue("@Religion", ddlReligion.SelectedValue);
                    cmd.Parameters.AddWithValue("@Nativity", ddlNativity.SelectedValue);
                    cmd.Parameters.AddWithValue("@Community", ddlCommunity.SelectedValue);
                    cmd.Parameters.AddWithValue("@CasteWithSubCode", ddlCaste.SelectedValue);
                    cmd.Parameters.AddWithValue("@CertificateNumber", txtCertificate.Text.Trim());
                    cmd.Parameters.AddWithValue("@IssuedBy", txtIssuedby.Text.Trim());
                    cmd.Parameters.AddWithValue("@IssuedTaluk", txtIssuedTaluk.Text.Trim());
                    cmd.Parameters.AddWithValue("@CommDistrict",ddlDistrict.SelectedValue );
                    cmd.Parameters.AddWithValue("@IssuedDate", txtDate.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script> alert('personal information added ') </script>");



                }

                Response.Redirect("splres.aspx");
            }
            catch(Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "') </script>");
            }
        }


        protected void loaduserdetails(string loginId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    string query = "SELECT * FROM PersonalInformation WHERE LoginId=@LoginId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LoginId", loginId);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            txtParent.Text = dr["NameOfTheParent"].ToString();

                            if (ddlNationality.Items.FindByValue(dr["Nationality"].ToString()) != null)
                            {
                                ddlNationality.SelectedValue = dr["Nationality"].ToString();
                            }

                            if (ddlMotherTongue.Items.FindByValue(dr["MotherTongue"].ToString()) != null)
                            {
                                ddlMotherTongue.SelectedValue = dr["MotherTongue"].ToString();
                            }

                            if (ddlSchooling.Items.FindByValue(dr["SchoolingStudied"].ToString()) != null)
                            {
                                ddlSchooling.SelectedValue = dr["SchoolingStudied"].ToString();
                            }

                            if (ddlReligion.Items.FindByValue(dr["Religion"].ToString()) != null)
                            {
                                ddlReligion.SelectedValue = dr["Religion"].ToString();
                            }

                            if (ddlNativity.Items.FindByValue(dr["Nativity"].ToString()) != null)
                            {
                                ddlNativity.SelectedValue = dr["Nativity"].ToString();
                            }

                            if (ddlCommunity.Items.FindByValue(dr["Community"].ToString()) != null)
                            {
                                ddlCommunity.SelectedValue = dr["Community"].ToString();
                            }

                            if (ddlCaste.Items.FindByValue(dr["CasteWithSubCode"].ToString()) != null)
                            {
                                ddlCaste.SelectedValue = dr["CasteWithSubCode"].ToString();
                            }

                            txtCertificate.Text = dr["CertificateNumber"].ToString();

                            txtIssuedby.Text = dr["IssuedBy"].ToString();

                            txtIssuedTaluk.Text = dr["IssuedTaluk"].ToString();

                            if (ddlDistrict.Items.FindByValue(dr["CommDistrict"].ToString()) != null)
                            {
                                ddlDistrict.SelectedValue = dr["CommDistrict"].ToString();
                            }

                            txtDate.Text = dr["IssuedDate"].ToString();







                        }
                    }


                }
            }
            catch(Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "') </script>");
            }
        }



















        /// .................. : DROPDOWN :.........................
        protected void BindNationalityDropDown()
        {
            
            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT NationalityName FROM Nationality "; 
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    string nationality = reader["NationalityName"].ToString();
                    ddlNationality.Items.Add(new ListItem(nationality));
                }
            }
        }

        protected void BindMotherTongueDropDown()
        {
            using(SqlConnection con= new SqlConnection(strcon))
            {
                string query = "SELECT MotherTongueName FROM MotherTongue";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string mothertongue = reader["MotherTongueName"].ToString();
                    ddlMotherTongue.Items.Add(new ListItem(mothertongue));
                }
            }
        }


        protected void BindReligionDropDown()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT ReligionName FROM Religion";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string religion = reader["ReligionName"].ToString();
                    ddlReligion.Items.Add(new ListItem(religion));
                }
            }
        }


        protected void BindNativityDropDown()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT NativityName FROM Nativity";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string nativity = reader["NativityName"].ToString();
                    ddlNativity.Items.Add(new ListItem(nativity));
                }
            }
        }


        protected void BindCommunityDropDown()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT CommunityId, CommunityName FROM Community";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                ddlCommunity.Items.Clear();

                ddlCommunity.Items.Add(new ListItem("-- Select Community --", ""));

                while (reader.Read())
                {
                    string communityName = reader["CommunityName"].ToString();
                    string communityId = reader["CommunityId"].ToString();
                    ddlCommunity.Items.Add(new ListItem(communityName, communityId));
                }
            }
        }

        protected void ddlCommunity_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCasteDropDown();
        }

        private void BindCasteDropDown()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT CasteId, CasteName FROM Caste WHERE CommunityId = @CommunityId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@CommunityId", ddlCommunity.SelectedValue);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                ddlCaste.Items.Clear();

                ddlCaste.Items.Add(new ListItem("-- Select Caste --", ""));

                while (reader.Read())
                {
                    string casteName = reader["CasteName"].ToString();
                    string casteId = reader["CasteId"].ToString();
                    ddlCaste.Items.Add(new ListItem(casteName, casteId));
                }
            }
        }


        protected void BindDistrictDropDown()
        {

            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT DistrictName FROM District ";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string district = reader["DistrictName"].ToString();
                    ddlDistrict.Items.Add(new ListItem(district));
                }
            }
        }



    }
}