using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MBBS_WEBSITE
{

    public partial class register : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGenderRadioButton(); //  radio button for gender
                BindQualifyingExaminationDropDown(); // dropdown for qualifying examination
            }

           
        }


        /// SUBMIT BUTTON CLICK
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (checkuserexists())
            {
                Response.Write("<script> alert('login already exists,try with different login id...') </script>");
            }
            else { 
                 newuserregister();
            }
        }

        // checking user exists

        bool checkuserexists()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    string query = "SELECT * FROM UserRegister where LoginId= '"+ txtLoginid.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, con);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if(dt.Rows.Count >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                   
                   
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "') </script>");
                return false;
            }


            
        }

        //register the user
        protected void newuserregister()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    string query = "INSERT INTO UserRegister (UserName,Email,Gender,Mobile,DateOfBirth,PlusOnePassed,HSCRollNumber,NEETRollNumber,QualifyingExamination,QualifiedYear,NEETMarks,LoginId,UserPassword) values (@UserName, @Email, @Gender, @Mobile, @DateOfBirth, @PlusOnePassed, @HSCRollNumber, @NEETRollNumber, @QualifyingExamination, @QualifiedYear, @NEETMarks, @LoginId, @UserPassword)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserName", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", rblGender.SelectedValue);
                    cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text.Trim());
                    cmd.Parameters.AddWithValue("@DateOfBirth", txtDate.Text.Trim());
                    cmd.Parameters.AddWithValue("@PlusOnePassed", Plusonepassed.SelectedValue);
                    cmd.Parameters.AddWithValue("@HSCRollNumber", txtHsc.Text.Trim());
                    cmd.Parameters.AddWithValue("@NEETRollNumber", txtNeet.Text.Trim());
                    cmd.Parameters.AddWithValue("@QualifyingExamination", ddlQualifyingExamination.SelectedValue);
                    cmd.Parameters.AddWithValue("@QualifiedYear", ddlQualifiedYear.SelectedValue);
                    cmd.Parameters.AddWithValue("@NEETMarks", txtNeetMarks.Text.Trim());
                    cmd.Parameters.AddWithValue("@LoginId", txtLoginid.Text.Trim());
                    cmd.Parameters.AddWithValue("@UserPassword", txtPassword.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script> alert('Registration successful, go to login page for login'); </script>");
                   
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "') </script>");
            }
        }




        // ...............: DROPDOWNS :....................
        protected void BindGenderRadioButton()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                String query = "SELECT GenderName FROM Gender";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String gender = reader["GenderName"].ToString();
                    ListItem listItem = new ListItem(gender);
                    listItem.Attributes.Add("style", "margin-right: 20px;");
                    rblGender.Items.Add(listItem);
                }

            }
        }

        protected void BindQualifyingExaminationDropDown()
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                String query = "SELECT QualifyingExaminationName FROM QualifyingExamination";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    String qualifyingexamination = reader["QualifyingExaminationName"].ToString();

                    ddlQualifyingExamination.Items.Add(new ListItem(qualifyingexamination));
                }

            }

        }

    }
}