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
    public partial class sos : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            { 
                BindMediumOfInstructionDropDown(); // dropdown for medium of instruction ...
                BindCivicSchoolDropDown(); // dropdown for civic school
                BindCivicNativeDropDown(); // dropdown for civic native


                BindStateDropDown(STATE6); // dropdown for states
                BindStateDropDown(STATE7);
                BindStateDropDown(STATE8);
                BindStateDropDown(STATE9);
                BindStateDropDown(STATE10);
                BindStateDropDown(STATE11);
                BindStateDropDown(STATE12);


                BindDistrictDropDown(DISTRICT6); // dropdown for district
                BindDistrictDropDown(DISTRICT7);
                BindDistrictDropDown(DISTRICT8);
                BindDistrictDropDown(DISTRICT9);
                BindDistrictDropDown(DISTRICT10);
                BindDistrictDropDown(DISTRICT11);
                BindDistrictDropDown(DISTRICT12);



                String loginId = Session["LoginId"] as string;
                loadotherdetails(loginId);
                loadsubjectdetails(loginId);
                loadstudydetails(loginId);
            }

        }

        protected void loadotherdetails(String loginId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    string query = "SELECT * FROM AcademicAndSchooling WHERE LoginId=@LoginId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LoginId", loginId);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            if (ddlNumberOfAttempts.Items.FindByValue(dr["NumberOfHSCAttempt"].ToString().Trim()) != null)
                            {
                                ddlNumberOfAttempts.SelectedValue = dr["NumberOfHSCAttempt"].ToString().Trim();
                            }



                            if (ddlMediumOfInstruction.Items.FindByValue(dr["MediumOfInstruction"].ToString()) != null)
                            {
                                ddlMediumOfInstruction.SelectedValue = dr["MediumOfInstruction"].ToString();
                            }


                            if (ddlCivicSchool.Items.FindByValue(dr["CivicSchool"].ToString()) != null)
                            {
                                ddlCivicSchool.SelectedValue = dr["CivicSchool"].ToString();
                            }


                            if (ddlCivicNative.Items.FindByValue(dr["CivicNative"].ToString()) != null)
                            {
                                ddlCivicNative.SelectedValue = dr["CivicNative"].ToString();
                            }



                            if (NEETATTEMPT.Items.FindByValue(dr["NumberOfNEETAttempt"].ToString().Trim()) != null)
                            {
                                NEETATTEMPT.SelectedValue = dr["NumberOfNEETAttempt"].ToString().Trim();
                            }



                            if (NeetCoachingOptions.Items.FindByValue(dr["NEETCoaching"].ToString().Trim()) != null)
                            {
                                NeetCoachingOptions.SelectedValue = dr["NEETCoaching"].ToString().Trim();
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


        protected void loadsubjectdetails(String loginId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    string query = "SELECT * FROM SubjectDetails WHERE LoginId=@LoginId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LoginId", loginId);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            // PHYSICS .......

                            RNPHY.Value = dr["RNPHY"].ToString();

                            if (MOPPHY.Items.FindByValue(dr["MOPPHY"].ToString().Trim()) != null)
                            {
                                MOPPHY.SelectedValue = dr["MOPPHY"].ToString().Trim();
                            }

                            YOPPHY.Value = dr["YOPPHY"].ToString();

                            if (MAXMARKSPHY.Items.FindByValue(dr["MAXMARKSPHY"].ToString().Trim()) != null)
                            {
                                MAXMARKSPHY.SelectedValue = dr["MAXMARKSPHY"].ToString().Trim();
                            }

                            OBTMARKSPHY.Value = dr["OBTMARKSPHY"].ToString();


                            // CHEMISTRY.......


                            RNCHE.Value = dr["RNCHE"].ToString();

                            if (MOPCHE.Items.FindByValue(dr["MOPCHE"].ToString().Trim()) != null)
                            {
                                MOPCHE.SelectedValue = dr["MOPCHE"].ToString().Trim();
                            }

                            YOPCHE.Value = dr["YOPCHE"].ToString();

                            if (MAXMARKSCHE.Items.FindByValue(dr["MAXMARKSCHE"].ToString().Trim()) != null)
                            {
                                MAXMARKSCHE.SelectedValue = dr["MAXMARKSCHE"].ToString().Trim();
                            }

                            OBTMARKSCHE.Value = dr["OBTMARKSCHE"].ToString();



                            // BOTANY....................


                            RNBOT.Value = dr["RNBOT"].ToString();

                            if (MOPBOT.Items.FindByValue(dr["MOPBOT"].ToString().Trim()) != null)
                            {
                                MOPBOT.SelectedValue = dr["MOPBOT"].ToString().Trim();
                            }

                            YOPBOT.Value = dr["YOPBOT"].ToString();

                            if (MAXMARKSBOT.Items.FindByValue(dr["MAXMARKSBOT"].ToString().Trim()) != null)
                            {
                                MAXMARKSBOT.SelectedValue = dr["MAXMARKSBOT"].ToString().Trim();
                            }

                            OBTMARKSBOT.Value = dr["OBTMARKSBOT"].ToString();



                            // ZOOLOGY..............................


                            RNZOO.Value = dr["RNZOO"].ToString();

                            if (MOPZOO.Items.FindByValue(dr["MOPZOO"].ToString().Trim()) != null)
                            {
                                MOPZOO.SelectedValue = dr["MOPZOO"].ToString().Trim();
                            }

                            YOPZOO.Value = dr["YOPZOO"].ToString();

                            if (MAXMARKSZOO.Items.FindByValue(dr["MAXMARKSZOO"].ToString().Trim()) != null)
                            {
                                MAXMARKSZOO.SelectedValue = dr["MAXMARKSZOO"].ToString().Trim();
                            }

                            OBTMARKSZOO.Value = dr["OBTMARKSZOO"].ToString();

                        }
                    }


                }
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "') </script>");
            }
        }



        protected void loadstudydetails(String loginId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    string query = "SELECT * FROM StudyDetails WHERE LoginId=@LoginId";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@LoginId", loginId);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            // .................. 6 ..............

                            YOP6.Value = dr["YOP6"].ToString();
                           
                            NOTS6.Value = dr["NOTS6"].ToString();

                            if (STATE6.Items.FindByValue(dr["STATE6"].ToString()) != null)
                            {
                                STATE6.SelectedValue = dr["STATE6"].ToString();
                            }


                            if (DISTRICT6.Items.FindByValue(dr["DISTRICT6"].ToString()) != null)
                            {
                                DISTRICT6.SelectedValue = dr["DISTRICT6"].ToString();
                            }



                            // .................. 7 ..............

                            YOP7.Value = dr["YOP7"].ToString();

                            NOTS7.Value = dr["NOTS7"].ToString();

                            if (STATE7.Items.FindByValue(dr["STATE7"].ToString()) != null)
                            {
                                STATE7.SelectedValue = dr["STATE7"].ToString();
                            }


                            if (DISTRICT7.Items.FindByValue(dr["DISTRICT7"].ToString()) != null)
                            {
                                DISTRICT7.SelectedValue = dr["DISTRICT7"].ToString();
                            }


                            // .................. 8 ..............

                            YOP8.Value = dr["YOP8"].ToString();

                            NOTS8.Value = dr["NOTS8"].ToString();

                            if (STATE8.Items.FindByValue(dr["STATE8"].ToString()) != null)
                            {
                                STATE8.SelectedValue = dr["STATE8"].ToString();
                            }


                            if (DISTRICT8.Items.FindByValue(dr["DISTRICT8"].ToString()) != null)
                            {
                                DISTRICT8.SelectedValue = dr["DISTRICT8"].ToString();
                            }


                            // .................. 9 ..............

                            YOP9.Value = dr["YOP9"].ToString();

                            NOTS9.Value = dr["NOTS9"].ToString();

                            if (STATE9.Items.FindByValue(dr["STATE9"].ToString()) != null)
                            {
                                STATE9.SelectedValue = dr["STATE9"].ToString();
                            }


                            if (DISTRICT9.Items.FindByValue(dr["DISTRICT9"].ToString()) != null)
                            {
                                DISTRICT9.SelectedValue = dr["DISTRICT9"].ToString();
                            }


                            // .................. 10 ..............

                            YOP10.Value = dr["YOP10"].ToString();

                            NOTS10.Value = dr["NOTS10"].ToString();

                            if (STATE10.Items.FindByValue(dr["STATE10"].ToString()) != null)
                            {
                                STATE10.SelectedValue = dr["STATE10"].ToString();
                            }


                            if (DISTRICT10.Items.FindByValue(dr["DISTRICT10"].ToString()) != null)
                            {
                                DISTRICT10.SelectedValue = dr["DISTRICT10"].ToString();
                            }

                            // .................. 11 ..............

                            YOP11.Value = dr["YOP11"].ToString();

                            NOTS11.Value = dr["NOTS11"].ToString();

                            if (STATE11.Items.FindByValue(dr["STATE11"].ToString()) != null)
                            {
                                STATE11.SelectedValue = dr["STATE11"].ToString();
                            }


                            if (DISTRICT11.Items.FindByValue(dr["DISTRICT11"].ToString()) != null)
                            {
                                DISTRICT11.SelectedValue = dr["DISTRICT11"].ToString();
                            }


                            // .................. 12 ..............

                            YOP12.Value = dr["YOP12"].ToString();

                            NOTS12.Value = dr["NOTS12"].ToString();

                            if (STATE12.Items.FindByValue(dr["STATE12"].ToString()) != null)
                            {
                                STATE12.SelectedValue = dr["STATE12"].ToString();
                            }


                            if (DISTRICT12.Items.FindByValue(dr["DISTRICT12"].ToString()) != null)
                            {
                                DISTRICT12.SelectedValue = dr["DISTRICT12"].ToString();
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




        protected void btnSaveContinue_Click(object sender, EventArgs e)
        {
            OtherDetails();
            SubjectDetails();
            StudyDetails();
            Response.Redirect("addinfo.aspx");
        }

        protected void OtherDetails()
        {
            try
            {
                String LoginId = Session["LoginId"] as string;

                using (SqlConnection con = new SqlConnection(strcon))
                {
                    String checkQuery = "SELECT COUNT(*) FROM AcademicAndSchooling where LoginId = @LoginId";
                    SqlCommand checkcmd = new SqlCommand(checkQuery, con);
                    checkcmd.Parameters.AddWithValue("@LoginId", LoginId);

                    con.Open();
                    int count = Convert.ToInt32(checkcmd.ExecuteScalar());
                    con.Close();

                    string query;

                    if (count > 0)
                    {
                        query = "UPDATE AcademicAndSchooling SET NumberOfHSCAttempt=@NumberOfHSCAttempt,MediumOfInstruction=@MediumOfInstruction,CivicSchool=@CivicSchool,CivicNative=@CivicNative,NumberOfNEETAttempt=@NumberOfNEETAttempt,NEETCoaching=@NEETCoaching WHERE LoginId=@LoginId";
                    }
                    else
                    {
                        query = "INSERT INTO AcademicAndSchooling(LoginId,NumberOfHSCAttempt,MediumOfInstruction,CivicSchool,CivicNative,NumberOfNEETAttempt,NEETCoaching) VALUES (@LoginId,@NumberOfHSCAttempt,@MediumOfInstruction,@CivicSchool,@CivicNative,@NumberOfNEETAttempt,@NEETCoaching)";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@LoginId", LoginId);
                    cmd.Parameters.AddWithValue("@NumberOfHSCAttempt", ddlNumberOfAttempts.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@MediumOfInstruction", ddlMediumOfInstruction.SelectedValue);
                    cmd.Parameters.AddWithValue("@CivicSchool", ddlCivicSchool.SelectedValue);
                    cmd.Parameters.AddWithValue("@CivicNative", ddlCivicNative.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@NumberOfNEETAttempt", NEETATTEMPT.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@NEETCoaching", NeetCoachingOptions.SelectedValue.Trim());


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script> alert(' academic and schooling added. ') </script>");



                }

                
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "') </script>");
            }
        }

        protected void SubjectDetails()
        {
            try
            {
                String LoginId = Session["LoginId"] as string;

                using (SqlConnection con = new SqlConnection(strcon))
                {
                    String checkQuery = "SELECT COUNT(*) FROM SubjectDetails where LoginId = @LoginId";
                    SqlCommand checkcmd = new SqlCommand(checkQuery, con);
                    checkcmd.Parameters.AddWithValue("@LoginId", LoginId);

                    con.Open();
                    int count = Convert.ToInt32(checkcmd.ExecuteScalar());
                    con.Close();

                    string query;

                    if (count > 0)
                    {
                        query = "UPDATE SubjectDetails SET RNPHY=@RNPHY,MOPPHY=@MOPPHY,YOPPHY=@YOPPHY,MAXMARKSPHY=@MAXMARKSPHY,OBTMARKSPHY=@OBTMARKSPHY,RNCHE=@RNCHE,MOPCHE=@MOPCHE,YOPCHE=@YOPCHE,MAXMARKSCHE=@MAXMARKSCHE,OBTMARKSCHE=@OBTMARKSCHE,RNBOT=@RNBOT,MOPBOT=@MOPBOT,YOPBOT=@YOPBOT,MAXMARKSBOT=@MAXMARKSBOT,OBTMARKSBOT=@OBTMARKSBOT,RNZOO=@RNZOO,MOPZOO=@MOPZOO,YOPZOO=@YOPZOO,MAXMARKSZOO=@MAXMARKSZOO,OBTMARKSZOO=@OBTMARKSZOO WHERE LoginId=@LoginId";
                    }
                    else
                    {
                        query = "INSERT INTO SubjectDetails(LoginId,RNPHY,MOPPHY,YOPPHY,MAXMARKSPHY,OBTMARKSPHY,RNCHE,MOPCHE,YOPCHE,MAXMARKSCHE,OBTMARKSCHE,RNBOT,MOPBOT,YOPBOT,MAXMARKSBOT,OBTMARKSBOT,RNZOO,MOPZOO,YOPZOO,MAXMARKSZOO,OBTMARKSZOO) VALUES(@LoginId,@RNPHY,@MOPPHY,@YOPPHY,@MAXMARKSPHY,@OBTMARKSPHY,@RNCHE,@MOPCHE,@YOPCHE,@MAXMARKSCHE,@OBTMARKSCHE,@RNBOT,@MOPBOT,@YOPBOT,@MAXMARKSBOT,@OBTMARKSBOT,@RNZOO,@MOPZOO,@YOPZOO,@MAXMARKSZOO,@OBTMARKSZOO)";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@LoginId", LoginId);
                    cmd.Parameters.AddWithValue("@RNPHY", RNPHY.Value);
                    cmd.Parameters.AddWithValue("@MOPPHY", MOPPHY.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@YOPPHY", YOPPHY.Value);
                    cmd.Parameters.AddWithValue("@MAXMARKSPHY", MAXMARKSPHY.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@OBTMARKSPHY", OBTMARKSPHY.Value);

                    cmd.Parameters.AddWithValue("@RNCHE", RNCHE.Value);
                    cmd.Parameters.AddWithValue("@MOPCHE", MOPCHE.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@YOPCHE", YOPCHE.Value);
                    cmd.Parameters.AddWithValue("@MAXMARKSCHE", MAXMARKSCHE.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@OBTMARKSCHE", OBTMARKSCHE.Value);

                    cmd.Parameters.AddWithValue("@RNBOT", RNBOT.Value);
                    cmd.Parameters.AddWithValue("@MOPBOT", MOPBOT.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@YOPBOT", YOPBOT.Value);
                    cmd.Parameters.AddWithValue("@MAXMARKSBOT", MAXMARKSBOT.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@OBTMARKSBOT", OBTMARKSBOT.Value);

                    cmd.Parameters.AddWithValue("@RNZOO", RNZOO.Value);
                    cmd.Parameters.AddWithValue("@MOPZOO", MOPZOO.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@YOPZOO", YOPZOO.Value);
                    cmd.Parameters.AddWithValue("@MAXMARKSZOO", MAXMARKSZOO.SelectedValue.Trim());
                    cmd.Parameters.AddWithValue("@OBTMARKSZOO", OBTMARKSZOO.Value);




                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script> alert('Subject Details added. ') </script>");



                }

                
            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "') </script>");
            }
        }


        protected void StudyDetails()
        {
            try
            {
                String LoginId = Session["LoginId"] as string;

                using (SqlConnection con = new SqlConnection(strcon))
                {
                    String checkQuery = "SELECT COUNT(*) FROM StudyDetails where LoginId = @LoginId";
                    SqlCommand checkcmd = new SqlCommand(checkQuery, con);
                    checkcmd.Parameters.AddWithValue("@LoginId", LoginId);

                    con.Open();
                    int count = Convert.ToInt32(checkcmd.ExecuteScalar());
                    con.Close();

                    string query;

                    if (count > 0)
                    {
                        query = "UPDATE StudyDetails SET YOP6=@YOP6,NOTS6=@NOTS6,STATE6=@STATE6,DISTRICT6=@DISTRICT6,YOP7=@YOP7,NOTS7=@NOTS7,STATE7=@STATE7,DISTRICT7=@DISTRICT7,YOP8=@YOP8,NOTS8=@NOTS8,STATE8=@STATE8,DISTRICT8=@DISTRICT8,YOP9=@YOP9,NOTS9=@NOTS9,STATE9=@STATE9,DISTRICT9=@DISTRICT9,YOP10=@YOP10,NOTS10=@NOTS10,STATE10=@STATE10,DISTRICT10=@DISTRICT10,YOP11=@YOP11,NOTS11=@NOTS11,STATE11=@STATE11,DISTRICT11=@DISTRICT11,YOP12=@YOP12,NOTS12=@NOTS12,STATE12=@STATE12,DISTRICT12=@DISTRICT12 WHERE LoginId=@LoginId";
                    }
                    else
                    {
                        query = "INSERT INTO StudyDetails(LoginId,YOP6,NOTS6,STATE6,DISTRICT6,YOP7,NOTS7,STATE7,DISTRICT7,YOP8,NOTS8,STATE8,DISTRICT8,YOP9,NOTS9,STATE9,DISTRICT9,YOP10,NOTS10,STATE10,DISTRICT10,YOP11,NOTS11,STATE11,DISTRICT11,YOP12,NOTS12,STATE12,DISTRICT12) VALUES(@LoginId,@YOP6,@NOTS6,@STATE6,@DISTRICT6,@YOP7,@NOTS7,@STATE7,@DISTRICT7,@YOP8,@NOTS8,@STATE8,@DISTRICT8,@YOP9,@NOTS9,@STATE9,@DISTRICT9,@YOP10,@NOTS10,@STATE10,@DISTRICT10,@YOP11,@NOTS11,@STATE11,@DISTRICT11,@YOP12,@NOTS12,@STATE12,@DISTRICT12)";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@LoginId", LoginId);
                    cmd.Parameters.AddWithValue("@YOP6", YOP6.Value);
                    cmd.Parameters.AddWithValue("@NOTS6", NOTS6.Value);
                    cmd.Parameters.AddWithValue("@STATE6", STATE6.SelectedValue);
                    cmd.Parameters.AddWithValue("@DISTRICT6", DISTRICT6.SelectedValue);

                    cmd.Parameters.AddWithValue("@YOP7", YOP7.Value);
                    cmd.Parameters.AddWithValue("@NOTS7", NOTS7.Value);
                    cmd.Parameters.AddWithValue("@STATE7", STATE7.SelectedValue);
                    cmd.Parameters.AddWithValue("@DISTRICT7", DISTRICT7.SelectedValue);

                    cmd.Parameters.AddWithValue("@YOP8", YOP8.Value);
                    cmd.Parameters.AddWithValue("@NOTS8", NOTS8.Value);
                    cmd.Parameters.AddWithValue("@STATE8", STATE8.SelectedValue);
                    cmd.Parameters.AddWithValue("@DISTRICT8", DISTRICT8.SelectedValue);

                    cmd.Parameters.AddWithValue("@YOP9", YOP9.Value);
                    cmd.Parameters.AddWithValue("@NOTS9", NOTS9.Value);
                    cmd.Parameters.AddWithValue("@STATE9", STATE9.SelectedValue);
                    cmd.Parameters.AddWithValue("@DISTRICT9", DISTRICT9.SelectedValue);

                    cmd.Parameters.AddWithValue("@YOP10", YOP10.Value);
                    cmd.Parameters.AddWithValue("@NOTS10", NOTS10.Value);
                    cmd.Parameters.AddWithValue("@STATE10", STATE10.SelectedValue);
                    cmd.Parameters.AddWithValue("@DISTRICT10", DISTRICT10.SelectedValue);

                    cmd.Parameters.AddWithValue("@YOP11", YOP11.Value);
                    cmd.Parameters.AddWithValue("@NOTS11", NOTS11.Value);
                    cmd.Parameters.AddWithValue("@STATE11", STATE11.SelectedValue);
                    cmd.Parameters.AddWithValue("@DISTRICT11", DISTRICT11.SelectedValue);

                    cmd.Parameters.AddWithValue("@YOP12", YOP12.Value);
                    cmd.Parameters.AddWithValue("@NOTS12", NOTS12.Value);
                    cmd.Parameters.AddWithValue("@STATE12", STATE12.SelectedValue);
                    cmd.Parameters.AddWithValue("@DISTRICT12", DISTRICT12.SelectedValue);




                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script> alert('Subject Details added. ') </script>");



                }


            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "') </script>");
            }
        }


        // ............. : DROPDOWNS :.....................

        protected void BindMediumOfInstructionDropDown()
        {

            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT MediumOfInstructionName FROM MediumOfInstruction ";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string mediumofinstruction = reader["MediumOfInstructionName"].ToString();
                    ddlMediumOfInstruction.Items.Add(new ListItem(mediumofinstruction));
                }
            }
        }


        protected void BindCivicSchoolDropDown()
        {

            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT CivicSchoolName FROM CivicSchool ";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string civicschool = reader["CivicSchoolName"].ToString();
                    ddlCivicSchool.Items.Add(new ListItem(civicschool));
                }
            }
        }


        protected void BindCivicNativeDropDown()
        {

            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT CivicNativeName FROM CivicNative ";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string civicnative = reader["CivicNativeName"].ToString();
                    ddlCivicNative.Items.Add(new ListItem(civicnative));
                }
            }
        }

        protected void BindStateDropDown(DropDownList ddlState)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT StateName FROM States";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                ddlState.Items.Clear(); // Clear existing items
                ddlState.Items.Add(new ListItem("-- Select --", "")); // Add default item

                while (reader.Read())
                {
                    string stateName = reader["StateName"].ToString();
                    ddlState.Items.Add(new ListItem(stateName));
                }
            }
        }


        protected void BindDistrictDropDown(DropDownList ddlDistrict)
        {
            using (SqlConnection con = new SqlConnection(strcon))
            {
                string query = "SELECT DistrictName FROM District";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                ddlDistrict.Items.Clear(); // Clear existing items
                ddlDistrict.Items.Add(new ListItem("-- Select --", "")); // Add default item

                while (reader.Read())
                {
                    string district = reader["DistrictName"].ToString();
                    ddlDistrict.Items.Add(new ListItem(district));
                }
            }
        }




    }
}