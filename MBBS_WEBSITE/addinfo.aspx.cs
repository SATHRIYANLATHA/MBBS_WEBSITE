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
    public partial class addinfo : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDistrictDropDown(); // dropdown for district ...
                BindStateDropDown(); // dropdown for states ...
                BindAnnualIncomeDropDown(); // dropdown for annual income ...
                BindParentsOccupationDropDown(); // dropdown for parents occupation ...


                String loginId = Session["LoginId"] as string;
                loaduserdetails(loginId);

            }
            
        }

        protected void loaduserdetails(string loginId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    string query = "SELECT * FROM AdditionalInformation WHERE LoginId=@LoginId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LoginId", loginId);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            if (FirstGraduateOptions.Items.FindByValue(dr["FGApplicant"].ToString()) != null)
                            {
                                FirstGraduateOptions.SelectedValue = dr["FGApplicant"].ToString();
                            }


                            if (ddlParentsOccupation.Items.FindByValue(dr["ParentOccupation"].ToString()) != null)
                            {
                                ddlParentsOccupation.SelectedValue = dr["ParentOccupation"].ToString();
                            }

                            if (ddlAnnualIncome.Items.FindByValue(dr["ParentAnnualIncome"].ToString()) != null)
                            {
                                ddlAnnualIncome.SelectedValue = dr["ParentAnnualIncome"].ToString();
                            }

                            if (ddlNativeState.Items.FindByValue(dr["NativeState"].ToString()) != null)
                            {
                                ddlNativeState.SelectedValue = dr["NativeState"].ToString();
                            }

                            if (ddlNativeDistrict.Items.FindByValue(dr["NativeDistrict"].ToString()) != null)
                            {
                                ddlNativeDistrict.SelectedValue = dr["NativeDistrict"].ToString();
                            }


                            IDENTMARKS.InnerText = dr["IdentificationMarks"].ToString();

                            AADHARNO.Value = dr["AadharNumber"].ToString();

                            EMAILID.Value = dr["EmailId"].ToString();

                            PHONENO.Value = dr["PhoneNumber"].ToString();

                            Text1.InnerText = dr["AddressForCorrespondence"].ToString();

                        }
                    }


                }
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "') </script>");
            }
        }


        protected void btnSaveContinue_Click(object sender, EventArgs e)
        {
            try
            {
                String LoginId = Session["LoginId"] as string;

                using (SqlConnection con = new SqlConnection(strcon))
                {
                    String checkQuery = "SELECT COUNT(*) FROM AdditionalInformation where LoginId = @LoginId";
                    SqlCommand checkcmd = new SqlCommand(checkQuery, con);
                    checkcmd.Parameters.AddWithValue("@LoginId", LoginId);

                    con.Open();
                    int count = Convert.ToInt32(checkcmd.ExecuteScalar());
                    con.Close();

                    string query;

                    if (count > 0)
                    {
                        query = "UPDATE AdditionalInformation SET FGApplicant=@FGApplicant,ParentOccupation=@ParentOccupation,ParentAnnualIncome=@ParentAnnualIncome,NativeState=@NativeState,NativeDistrict=@NativeDistrict,IdentificationMarks=@IdentificationMarks,AadharNumber=@AadharNumber,EmailId=@EmailId,PhoneNumber=@PhoneNumber,AddressForCorrespondence=@AddressForCorrespondence WHERE LoginId=@LoginId";
                    }
                    else
                    {
                        query = "INSERT INTO AdditionalInformation(LoginId,FGApplicant,ParentOccupation,ParentAnnualIncome,NativeState,NativeDistrict,IdentificationMarks,AadharNumber,EmailId,PhoneNumber,AddressForCorrespondence) VALUES (@LoginId,@FGApplicant,@ParentOccupation,@ParentAnnualIncome,@NativeState,@NativeDistrict,@IdentificationMarks,@AadharNumber,@EmailId,@PhoneNumber,@AddressForCorrespondence)";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@LoginId", LoginId);
                    cmd.Parameters.AddWithValue("@FGApplicant", FirstGraduateOptions.SelectedValue);
                    cmd.Parameters.AddWithValue("@ParentOccupation", ddlParentsOccupation.SelectedValue);
                    cmd.Parameters.AddWithValue("@ParentAnnualIncome", ddlAnnualIncome.SelectedValue);
                    cmd.Parameters.AddWithValue("@NativeState", ddlNativeState.SelectedValue);
                    cmd.Parameters.AddWithValue("@NativeDistrict", ddlNativeDistrict.SelectedValue);
                    cmd.Parameters.AddWithValue("@IdentificationMarks",IDENTMARKS.InnerText.Trim());
                    cmd.Parameters.AddWithValue("@AadharNumber", AADHARNO.Value);
                    cmd.Parameters.AddWithValue("@EmailId", EMAILID.Value);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PHONENO.Value);
                    cmd.Parameters.AddWithValue("@AddressForCorrespondence", Text1.InnerText.Trim());


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script> alert(' additional information  added. ') </script>");



                }

                 Response.Redirect("upload.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "') </script>");
            }
        }









        // ............: DROPDOWN :...................

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
                    ddlNativeDistrict.Items.Add(new ListItem(district));
                }
            }
        }


        protected void BindStateDropDown()
        {

            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT StateName FROM States ";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string states = reader["StateName"].ToString();
                    ddlNativeState.Items.Add(new ListItem(states));
                }
            }
        }


        protected void BindAnnualIncomeDropDown()
        {

            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT AnnualIncomeAmount FROM AnnualIncome ";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string annualincome = reader["AnnualIncomeAmount"].ToString();
                    ddlAnnualIncome.Items.Add(new ListItem(annualincome));
                }
            }
        }


        protected void BindParentsOccupationDropDown()
        {

            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT ParentsOccupationName FROM ParentsOccupation ";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string parentsoccupation = reader["ParentsOccupationName"].ToString();
                    ddlParentsOccupation.Items.Add(new ListItem(parentsoccupation));
                }
            }
        }


    }
}