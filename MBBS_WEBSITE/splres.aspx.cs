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
    public partial class splres : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {

                BindQualifyingExaminationDropDown(); // dropdown for qualifying examination ...
                BindBoardOfExaminationDropDown(); // dropdown for board of examination ...


                

               String loginId = Session["LoginId"] as string;
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
                    String checkQuery = "SELECT COUNT(*) FROM SpecialReservation where LoginId = @LoginId";
                    SqlCommand checkcmd = new SqlCommand(checkQuery, con);
                    checkcmd.Parameters.AddWithValue("@LoginId", LoginId);

                    con.Open();
                    int count = Convert.ToInt32(checkcmd.ExecuteScalar());
                    con.Close();

                    string query;

                    if (count > 0)
                    {
                        query = "UPDATE SpecialReservation SET EminentSportsPerson=@EminentSportsPerson,EXservicemen=@EXservicemen,DifferentlyAbledPerson=@DifferentlyAbledPerson,QualifyingExamination=@QualifyingExamination,HSCgroupcode=@HSCgroupcode,BoardOfExamination=@BoardOfExamination,CoursesUndergoingCompleted=@CoursesUndergoingCompleted WHERE LoginId=@LoginId";
                    }
                    else
                    {
                        query = "INSERT INTO SpecialReservation(LoginId,EminentSportsPerson,EXservicemen,DifferentlyAbledPerson,QualifyingExamination,HSCgroupcode,BoardOfExamination,CoursesUndergoingCompleted) VALUES (@LoginId,@EminentSportsPerson,@EXservicemen,@DifferentlyAbledPerson,@QualifyingExamination,@HSCgroupcode,@BoardOfExamination,@CoursesUndergoingCompleted)";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@LoginId", LoginId);
                    cmd.Parameters.AddWithValue("@EminentSportsPerson", EminentSportsOptions.SelectedValue);
                    cmd.Parameters.AddWithValue("@EXservicemen", ExServicemenOptions.SelectedValue);
                    cmd.Parameters.AddWithValue("@DifferentlyAbledPerson", DifferentlyAbledPersonOptions.SelectedValue);
                    cmd.Parameters.AddWithValue("@QualifyingExamination", ddlQualifyingExamination.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@HSCgroupcode", HscGroupOptions.SelectedValue);
                    cmd.Parameters.AddWithValue("@BoardOfExamination",ddlBoardOfExamination.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@CoursesUndergoingCompleted", ProfessionalCourseOptions.SelectedValue);
                    

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script> alert('special reservation added ') </script>");


                    
                }

               Response.Redirect("sos.aspx");
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
                    string query = "SELECT * FROM SpecialReservation WHERE LoginId=@LoginId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LoginId", loginId);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            //foreach (ListItem item in EminentSportsOptions.Items)
                            //{
                            //    if (item.Value.Equals(dr["EminentSportsPerson"].ToString().Trim()))
                            //    {
                            //        item.Selected = true;
                                   
                            //    }
                            //}



                            if (EminentSportsOptions.Items.FindByValue(dr["EminentSportsPerson"].ToString()) != null)
                            {
                                EminentSportsOptions.SelectedValue = dr["EminentSportsPerson"].ToString();
                            }



                            //foreach (ListItem item in ExServicemenOptions.Items)
                            //{
                            //    if (item.Value.Equals(dr["EXservicemen"].ToString().Trim()))
                            //    {
                            //        item.Selected = true;
                                    
                            //    }
                            //}


                            if (ExServicemenOptions.Items.FindByValue(dr["EXservicemen"].ToString()) != null)
                            {
                                ExServicemenOptions.SelectedValue = dr["EXservicemen"].ToString();
                            }




                            //foreach (ListItem item in DifferentlyAbledPersonOptions.Items)
                            //{
                            //    if (item.Value.Equals(dr["DifferentlyAbledPerson"].ToString().Trim()))
                            //    {
                            //        item.Selected = true;
                                   
                            //    }
                            //}

                            if (DifferentlyAbledPersonOptions.Items.FindByValue(dr["DifferentlyAbledPerson"].ToString()) != null)
                            {
                                DifferentlyAbledPersonOptions.SelectedValue = dr["DifferentlyAbledPerson"].ToString();
                            }



                            if (ddlQualifyingExamination.Items.FindByValue(dr["QualifyingExamination"].ToString().Trim()) != null)
                            {
                                ddlQualifyingExamination.SelectedValue = dr["QualifyingExamination"].ToString().Trim();
                            }




                            //foreach (ListItem item in HscGroupOptions.Items)
                            //{
                            //    if (item.Value.Equals(dr["HSCgroupcode"].ToString().Trim()))
                            //    {
                            //        item.Selected = true;
                                   
                            //    }
                            //}

                            if (HscGroupOptions.Items.FindByValue(dr["HSCgroupcode"].ToString()) != null)
                            {
                                HscGroupOptions.SelectedValue = dr["HSCgroupcode"].ToString();
                            }



                            if (ddlBoardOfExamination.Items.FindByValue(dr["BoardOfExamination"].ToString().Trim()) != null)
                            {
                                ddlBoardOfExamination.SelectedValue = dr["BoardOfExamination"].ToString().Trim();
                            }


                            //foreach (ListItem item in ProfessionalCourseOptions.Items)
                            //{
                            //    if (item.Value.Equals(dr["CoursesUndergoingCompleted"].ToString().Trim()))
                            //    {
                            //        item.Selected = true;
                            //        break;
                            //    }
                            //}


                            if (ProfessionalCourseOptions.Items.FindByValue(dr["CoursesUndergoingCompleted"].ToString()) != null)
                            {
                                ProfessionalCourseOptions.SelectedValue = dr["CoursesUndergoingCompleted"].ToString();
                            }


                        }
                    }


                }
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "') </script>");
            }
        }



        // ...............: DROPDOWNS :...................

        protected void BindQualifyingExaminationDropDown()
        {

            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT QualifyingExaminationName FROM QualifyingExamination ";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string qualifyingexamination = reader["QualifyingExaminationName"].ToString().Trim();
                    ddlQualifyingExamination.Items.Add(new ListItem(qualifyingexamination));
                }
            }
        }


        protected void BindBoardOfExaminationDropDown()
        {

            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT BoardOfExaminationName FROM  BoardOfExamination";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string boardofexamination = reader["BoardOfExaminationName"].ToString().Trim();
                    ddlBoardOfExamination.Items.Add(new ListItem(boardofexamination));
                }
            }
        }


    }
}