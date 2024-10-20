using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MBBS_WEBSITE
{
    public partial class upload : System.Web.UI.Page
    {
        String strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadLeftThumbImpression();    // 0
                LoadPassPortSizePhoto();      // 1
                LoadPostCardSizePhoto();       // 2
                LoadSSLCMarkSheet();         // 3
                LoadHSCMarkSheet();          // 4
                LoadNEETScoreCard();        // 5
                LoadTransferCertificate();   // 6
                LoadSchoolBonafideCertificate(); //7
                LoadCommunityCertificate();      //8
                LoadNativityCertificate();       // 9
                LoadParentCommunityCertificate();  // 10
                LoadParentStudyCertificate();      // 11
                LoadParentAddressProof();          // 12

            }

        }

        protected void btnSaveContinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("apppreview.aspx");
        }


        //..........LEFT THUMB IMPRESSION..............  0


        private void LoadLeftThumbImpression()
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (!string.IsNullOrEmpty(loginId))
                {
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        // Query to get file details for the given LoginId
                        string query = "SELECT NameOfTheFile, PathOfTheFile FROM LeftThumbImpressionFilesUpload WHERE LoginId = @LoginId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LoginId", loginId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string fileName = reader["NameOfTheFile"].ToString();
                            string filePath = reader["PathOfTheFile"].ToString();


                            lblLeftThumbImpression.InnerHtml = "file already uploaded.";
                            // Set the link to view the image
                            viewImageLink.NavigateUrl = ResolveUrl(filePath);
                            viewImageLink.Visible = true; // Make the link visible
                        }
                        else
                        {
                           
                            viewImageLink.Visible = false; // Hide the link if no file is uploaded
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {
                    
                    viewImageLink.Visible = false;
                }
            }
            catch (Exception ex)
            {
                lblLeftThumbImpression.InnerHtml = "Error loading user details: " + ex.Message;
                viewImageLink.Visible = false;
            }
        }

        protected void btnLeftThumbImpressionUploadFile_Click(object sender, EventArgs e)
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (LeftThumbImpressionFileUpload.HasFile)
                {
                    if (LeftThumbImpressionFileUpload.PostedFile.ContentType == "image/jpeg" &&
                        LeftThumbImpressionFileUpload.PostedFile.ContentLength >= 10240 &&
                        LeftThumbImpressionFileUpload.PostedFile.ContentLength <= 51200)
                    {
                        string folderPath = Server.MapPath("~/UploadedFiles/LeftThumbImpression/");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string fileName = Path.GetFileName(LeftThumbImpressionFileUpload.FileName);
                        string filePath = folderPath + fileName;
                        LeftThumbImpressionFileUpload.SaveAs(filePath);

                        using (SqlConnection con = new SqlConnection(strcon))
                        {
                            string checkQuery = "SELECT COUNT(*) FROM LeftThumbImpressionFilesUpload WHERE LoginId = @LoginId";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@LoginId", loginId);

                            con.Open();
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            con.Close();

                            string query;
                            if (count > 0)
                            {
                                query = "UPDATE LeftThumbImpressionFilesUpload SET NameOfTheFile = @FileName, PathOfTheFile = @FilePath WHERE LoginId = @LoginId";
                            }
                            else
                            {
                                query = "INSERT INTO LeftThumbImpressionFilesUpload (LoginId, NameOfTheFile, PathOfTheFile) VALUES (@LoginId, @FileName, @FilePath)";
                            }

                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@LoginId", loginId);
                            cmd.Parameters.AddWithValue("@FileName", fileName);
                            cmd.Parameters.AddWithValue("@FilePath", "~/UploadedFiles/LeftThumbImpression/" + fileName);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            lblLeftThumbImpression.InnerHtml = "File uploaded successfully.";
                            viewImageLink.NavigateUrl = ResolveUrl("~/UploadedFiles/LeftThumbImpression/" + fileName);
                            viewImageLink.Visible = true; // Show the [VIEW IMAGE] link after uploading
                        }
                    }
                    else
                    {
                        lblLeftThumbImpression.InnerHtml = "Invalid file type or size. Please upload a JPG file between 10KB and 50KB.";
                        viewImageLink.Visible = false;
                    }
                }
                else
                {
                    lblLeftThumbImpression.InnerHtml = "Please select a file to upload.";
                    viewImageLink.Visible = false;
                }
            }
            catch (Exception ex)
            {
                lblLeftThumbImpression.InnerHtml = "File upload failed: " + ex.Message;
                viewImageLink.Visible = false;
            }
        }








        //.................:   PASS PORT SIZE PHOTO ............................1
       
        protected void LoadPassPortSizePhoto()
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (!string.IsNullOrEmpty(loginId))
                {
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        // Query to get file details for the given LoginId
                        string query = "SELECT NameOfTheFile, PathOfTheFile FROM PassPortSizePhotoFilesUpload WHERE LoginId = @LoginId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LoginId", loginId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string fileName = reader["NameOfTheFile"].ToString();
                            string filePath = reader["PathOfTheFile"].ToString();


                            B1.InnerHtml = "file already uploaded.";
                            // Set the link to view the image
                            HyperLink1.NavigateUrl = ResolveUrl(filePath);
                            HyperLink1.Visible = true; // Make the link visible
                        }
                        else
                        {

                            HyperLink1.Visible = false; // Hide the link if no file is uploaded
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {

                    HyperLink1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B1.InnerHtml = "Error loading user details: " + ex.Message;
                HyperLink1.Visible = false;
            }
        }


        protected void btnButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (FileUpload1.HasFile)
                {
                    if (FileUpload1.PostedFile.ContentType == "image/jpeg" &&
                        FileUpload1.PostedFile.ContentLength >= 10240 &&
                        FileUpload1.PostedFile.ContentLength <= 51200)
                    {
                        string folderPath = Server.MapPath("~/UploadedFiles/PassPortSizePhoto/");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string fileName = Path.GetFileName(FileUpload1.FileName);
                        string filePath = folderPath + fileName;
                        FileUpload1.SaveAs(filePath);

                        using (SqlConnection con = new SqlConnection(strcon))
                        {
                            string checkQuery = "SELECT COUNT(*) FROM PassPortSizePhotoFilesUpload WHERE LoginId = @LoginId";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@LoginId", loginId);

                            con.Open();
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            con.Close();

                            string query;
                            if (count > 0)
                            {
                                query = "UPDATE PassPortSizePhotoFilesUpload SET NameOfTheFile = @FileName, PathOfTheFile = @FilePath WHERE LoginId = @LoginId";
                            }
                            else
                            {
                                query = "INSERT INTO PassPortSizePhotoFilesUpload (LoginId, NameOfTheFile, PathOfTheFile) VALUES (@LoginId, @FileName, @FilePath)";
                            }

                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@LoginId", loginId);
                            cmd.Parameters.AddWithValue("@FileName", fileName);
                            cmd.Parameters.AddWithValue("@FilePath", "~/UploadedFiles/PassPortSizePhoto/" + fileName);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            B1.InnerHtml = "File uploaded successfully.";
                            HyperLink1.NavigateUrl = ResolveUrl("~/UploadedFiles/PassPortSizePhoto/" + fileName);
                            HyperLink1.Visible = true; // Show the [VIEW IMAGE] link after uploading
                        }
                    }
                    else
                    {
                        B1.InnerHtml = "Invalid file type or size. Please upload a JPG file between 10KB and 50KB.";
                        HyperLink1.Visible = false;
                    }
                }
                else
                {
                    B1.InnerHtml = "Please select a file to upload.";
                    HyperLink1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B1.InnerHtml = "File upload failed: " + ex.Message;
                HyperLink1.Visible = false;
            }
        }







        //   .......................... POST CARD SIZE PHOTO........................... 2



        protected void LoadPostCardSizePhoto()
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (!string.IsNullOrEmpty(loginId))
                {
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        // Query to get file details for the given LoginId
                        string query = "SELECT NameOfTheFile, PathOfTheFile FROM PostCardSizePhotoFilesUpload WHERE LoginId = @LoginId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LoginId", loginId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string fileName = reader["NameOfTheFile"].ToString();
                            string filePath = reader["PathOfTheFile"].ToString();


                            B2.InnerHtml = "file already uploaded.";
                            // Set the link to view the image
                            HyperLink2.NavigateUrl = ResolveUrl(filePath);
                            HyperLink2.Visible = true; // Make the link visible
                        }
                        else
                        {

                            HyperLink2.Visible = false; // Hide the link if no file is uploaded
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {

                    HyperLink2.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B2.InnerHtml = "Error loading user details: " + ex.Message;
                HyperLink2.Visible = false;
            }
        }


        protected void btnButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (FileUpload2.HasFile)
                {
                    if (FileUpload2.PostedFile.ContentType == "image/jpeg" &&
                        FileUpload2.PostedFile.ContentLength >= 10240 &&
                        FileUpload2.PostedFile.ContentLength <= 51200)
                    {
                        string folderPath = Server.MapPath("~/UploadedFiles/PostCardSizePhoto/");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string fileName = Path.GetFileName(FileUpload2.FileName);
                        string filePath = folderPath + fileName;
                        FileUpload2.SaveAs(filePath);

                        using (SqlConnection con = new SqlConnection(strcon))
                        {
                            string checkQuery = "SELECT COUNT(*) FROM PostCardSizePhotoFilesUpload WHERE LoginId = @LoginId";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@LoginId", loginId);

                            con.Open();
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            con.Close();

                            string query;
                            if (count > 0)
                            {
                                query = "UPDATE PostCardSizePhotoFilesUpload SET NameOfTheFile = @FileName, PathOfTheFile = @FilePath WHERE LoginId = @LoginId";
                            }
                            else
                            {
                                query = "INSERT INTO PostCardSizePhotoFilesUpload (LoginId, NameOfTheFile, PathOfTheFile) VALUES (@LoginId, @FileName, @FilePath)";
                            }

                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@LoginId", loginId);
                            cmd.Parameters.AddWithValue("@FileName", fileName);
                            cmd.Parameters.AddWithValue("@FilePath", "~/UploadedFiles/PostCardSizePhoto/" + fileName);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            B2.InnerHtml = "File uploaded successfully.";
                            HyperLink2.NavigateUrl = ResolveUrl("~/UploadedFiles/PostCardSizePhoto/" + fileName);
                            HyperLink2.Visible = true; // Show the [VIEW IMAGE] link after uploading
                        }
                    }
                    else
                    {
                        B2.InnerHtml = "Invalid file type or size. Please upload a JPG file between 10KB and 50KB.";
                        HyperLink2.Visible = false;
                    }
                }
                else
                {
                    B2.InnerHtml = "Please select a file to upload.";
                    HyperLink2.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B2.InnerHtml = "File upload failed: " + ex.Message;
                HyperLink2.Visible = false;
            }
        }







        // .................SSLC MARK SHEET........................ 3


        protected void LoadSSLCMarkSheet()
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (!string.IsNullOrEmpty(loginId))
                {
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        // Query to get file details for the given LoginId
                        string query = "SELECT NameOfTheFile, PathOfTheFile FROM SSLCMarkSheetFilesUpload WHERE LoginId = @LoginId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LoginId", loginId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string fileName = reader["NameOfTheFile"].ToString();
                            string filePath = reader["PathOfTheFile"].ToString();


                            B3.InnerHtml = "file already uploaded.";
                            // Set the link to view the image
                            HyperLink3.NavigateUrl = ResolveUrl(filePath);
                            HyperLink3.Visible = true; // Make the link visible
                        }
                        else
                        {

                            HyperLink3.Visible = false; // Hide the link if no file is uploaded
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {

                    HyperLink3.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B3.InnerHtml = "Error loading user details: " + ex.Message;
                HyperLink3.Visible = false;
            }
        }


        protected void btnButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (FileUpload3.HasFile)
                {
                    if (FileUpload3.PostedFile.ContentType == "image/jpeg" &&
                        FileUpload3.PostedFile.ContentLength >= 10240 &&
                        FileUpload3.PostedFile.ContentLength <= 51200)
                    {
                        string folderPath = Server.MapPath("~/UploadedFiles/SSLCMarkSheet/");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string fileName = Path.GetFileName(FileUpload3.FileName);
                        string filePath = folderPath + fileName;
                        FileUpload3.SaveAs(filePath);

                        using (SqlConnection con = new SqlConnection(strcon))
                        {
                            string checkQuery = "SELECT COUNT(*) FROM SSLCMarkSheetFilesUpload WHERE LoginId = @LoginId";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@LoginId", loginId);

                            con.Open();
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            con.Close();

                            string query;
                            if (count > 0)
                            {
                                query = "UPDATE SSLCMarkSheetFilesUpload SET NameOfTheFile = @FileName, PathOfTheFile = @FilePath WHERE LoginId = @LoginId";
                            }
                            else
                            {
                                query = "INSERT INTO SSLCMarkSheetFilesUpload (LoginId, NameOfTheFile, PathOfTheFile) VALUES (@LoginId, @FileName, @FilePath)";
                            }

                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@LoginId", loginId);
                            cmd.Parameters.AddWithValue("@FileName", fileName);
                            cmd.Parameters.AddWithValue("@FilePath", "~/UploadedFiles/SSLCMarkSheet/" + fileName);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            B3.InnerHtml = "File uploaded successfully.";
                            HyperLink3.NavigateUrl = ResolveUrl("~/UploadedFiles/SSLCMarkSheet/" + fileName);
                            HyperLink3.Visible = true; // Show the [VIEW IMAGE] link after uploading
                        }
                    }
                    else
                    {
                        B3.InnerHtml = "Invalid file type or size. Please upload a JPG file between 10KB and 50KB.";
                        HyperLink3.Visible = false;
                    }
                }
                else
                {
                    B3.InnerHtml = "Please select a file to upload.";
                    HyperLink3.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B3.InnerHtml = "File upload failed: " + ex.Message;
                HyperLink3.Visible = false;
            }
        }







        //...............HSC MARK SHEET........................... 4

        protected void LoadHSCMarkSheet()
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (!string.IsNullOrEmpty(loginId))
                {
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        // Query to get file details for the given LoginId
                        string query = "SELECT NameOfTheFile, PathOfTheFile FROM HSCMarkSheetFilesUpload WHERE LoginId = @LoginId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LoginId", loginId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string fileName = reader["NameOfTheFile"].ToString();
                            string filePath = reader["PathOfTheFile"].ToString();


                            B4.InnerHtml = "file already uploaded.";
                            // Set the link to view the image
                            HyperLink4.NavigateUrl = ResolveUrl(filePath);
                            HyperLink4.Visible = true; // Make the link visible
                        }
                        else
                        {

                            HyperLink4.Visible = false; // Hide the link if no file is uploaded
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {

                    HyperLink4.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B4.InnerHtml = "Error loading user details: " + ex.Message;
                HyperLink4.Visible = false;
            }
        }


        protected void btnButton4_Click(object sender, EventArgs e)
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (FileUpload4.HasFile)
                {
                    if (FileUpload4.PostedFile.ContentType == "image/jpeg" &&
                        FileUpload4.PostedFile.ContentLength >= 10240 &&
                        FileUpload4.PostedFile.ContentLength <= 51200)
                    {
                        string folderPath = Server.MapPath("~/UploadedFiles/HSCMarkSheet/");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string fileName = Path.GetFileName(FileUpload4.FileName);
                        string filePath = folderPath + fileName;
                        FileUpload4.SaveAs(filePath);

                        using (SqlConnection con = new SqlConnection(strcon))
                        {
                            string checkQuery = "SELECT COUNT(*) FROM HSCMarkSheetFilesUpload WHERE LoginId = @LoginId";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@LoginId", loginId);

                            con.Open();
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            con.Close();

                            string query;
                            if (count > 0)
                            {
                                query = "UPDATE HSCMarkSheetFilesUpload SET NameOfTheFile = @FileName, PathOfTheFile = @FilePath WHERE LoginId = @LoginId";
                            }
                            else
                            {
                                query = "INSERT INTO HSCMarkSheetFilesUpload (LoginId, NameOfTheFile, PathOfTheFile) VALUES (@LoginId, @FileName, @FilePath)";
                            }

                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@LoginId", loginId);
                            cmd.Parameters.AddWithValue("@FileName", fileName);
                            cmd.Parameters.AddWithValue("@FilePath", "~/UploadedFiles/HSCMarkSheet/" + fileName);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            B4.InnerHtml = "File uploaded successfully.";
                            HyperLink4.NavigateUrl = ResolveUrl("~/UploadedFiles/HSCMarkSheet/" + fileName);
                            HyperLink4.Visible = true; // Show the [VIEW IMAGE] link after uploading
                        }
                    }
                    else
                    {
                        B4.InnerHtml = "Invalid file type or size. Please upload a JPG file between 10KB and 50KB.";
                        HyperLink4.Visible = false;
                    }
                }
                else
                {
                    B4.InnerHtml = "Please select a file to upload.";
                    HyperLink4.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B4.InnerHtml = "File upload failed: " + ex.Message;
                HyperLink4.Visible = false;
            }
        }






        //.......................NEET SCORE CARD........................... 5

        protected void LoadNEETScoreCard()
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (!string.IsNullOrEmpty(loginId))
                {
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        // Query to get file details for the given LoginId
                        string query = "SELECT NameOfTheFile, PathOfTheFile FROM NeetScoreCardFilesUpload WHERE LoginId = @LoginId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LoginId", loginId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string fileName = reader["NameOfTheFile"].ToString();
                            string filePath = reader["PathOfTheFile"].ToString();


                            B5.InnerHtml = "file already uploaded.";
                            // Set the link to view the image
                            HyperLink5.NavigateUrl = ResolveUrl(filePath);
                            HyperLink5.Visible = true; // Make the link visible
                        }
                        else
                        {

                            HyperLink5.Visible = false; // Hide the link if no file is uploaded
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {

                    HyperLink5.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B5.InnerHtml = "Error loading user details: " + ex.Message;
                HyperLink5.Visible = false;
            }
        }


        protected void btnButton5_Click(object sender, EventArgs e)
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (FileUpload5.HasFile)
                {
                    if (FileUpload5.PostedFile.ContentType == "image/jpeg" &&
                        FileUpload5.PostedFile.ContentLength >= 10240 &&
                        FileUpload5.PostedFile.ContentLength <= 51200)
                    {
                        string folderPath = Server.MapPath("~/UploadedFiles/NEETScoreCard/");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string fileName = Path.GetFileName(FileUpload5.FileName);
                        string filePath = folderPath + fileName;
                        FileUpload5.SaveAs(filePath);

                        using (SqlConnection con = new SqlConnection(strcon))
                        {
                            string checkQuery = "SELECT COUNT(*) FROM NeetScoreCardFilesUpload WHERE LoginId = @LoginId";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@LoginId", loginId);

                            con.Open();
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            con.Close();

                            string query;
                            if (count > 0)
                            {
                                query = "UPDATE NeetScoreCardFilesUpload SET NameOfTheFile = @FileName, PathOfTheFile = @FilePath WHERE LoginId = @LoginId";
                            }
                            else
                            {
                                query = "INSERT INTO NeetScoreCardFilesUpload (LoginId, NameOfTheFile, PathOfTheFile) VALUES (@LoginId, @FileName, @FilePath)";
                            }

                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@LoginId", loginId);
                            cmd.Parameters.AddWithValue("@FileName", fileName);
                            cmd.Parameters.AddWithValue("@FilePath", "~/UploadedFiles/NEETScoreCard/" + fileName);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            B5.InnerHtml = "File uploaded successfully.";
                            HyperLink5.NavigateUrl = ResolveUrl("~/UploadedFiles/NEETScoreCard/" + fileName);
                            HyperLink5.Visible = true; // Show the [VIEW IMAGE] link after uploading
                        }
                    }
                    else
                    {
                        B5.InnerHtml = "Invalid file type or size. Please upload a JPG file between 10KB and 50KB.";
                        HyperLink5.Visible = false;
                    }
                }
                else
                {
                    B5.InnerHtml = "Please select a file to upload.";
                    HyperLink5.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B5.InnerHtml = "File upload failed: " + ex.Message;
                HyperLink5.Visible = false;
            }
        }







        //.........................TRANSFER CERTIFICATE....................... 6

        protected void LoadTransferCertificate()
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (!string.IsNullOrEmpty(loginId))
                {
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        // Query to get file details for the given LoginId
                        string query = "SELECT NameOfTheFile, PathOfTheFile FROM TransferCertificateFilesUpload WHERE LoginId = @LoginId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LoginId", loginId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string fileName = reader["NameOfTheFile"].ToString();
                            string filePath = reader["PathOfTheFile"].ToString();


                            B6.InnerHtml = "file already uploaded.";
                            // Set the link to view the image
                            HyperLink6.NavigateUrl = ResolveUrl(filePath);
                            HyperLink6.Visible = true; // Make the link visible
                        }
                        else
                        {

                            HyperLink6.Visible = false; // Hide the link if no file is uploaded
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {

                    HyperLink6.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B6.InnerHtml = "Error loading user details: " + ex.Message;
                HyperLink6.Visible = false;
            }
        }


        protected void btnButton6_Click(object sender, EventArgs e)
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (FileUpload6.HasFile)
                {
                    if (FileUpload6.PostedFile.ContentType == "image/jpeg" &&
                        FileUpload6.PostedFile.ContentLength >= 10240 &&
                        FileUpload6.PostedFile.ContentLength <= 51200)
                    {
                        string folderPath = Server.MapPath("~/UploadedFiles/TransferCertificate/");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string fileName = Path.GetFileName(FileUpload6.FileName);
                        string filePath = folderPath + fileName;
                        FileUpload6.SaveAs(filePath);

                        using (SqlConnection con = new SqlConnection(strcon))
                        {
                            string checkQuery = "SELECT COUNT(*) FROM TransferCertificateFilesUpload WHERE LoginId = @LoginId";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@LoginId", loginId);

                            con.Open();
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            con.Close();

                            string query;
                            if (count > 0)
                            {
                                query = "UPDATE TransferCertificateFilesUpload SET NameOfTheFile = @FileName, PathOfTheFile = @FilePath WHERE LoginId = @LoginId";
                            }
                            else
                            {
                                query = "INSERT INTO TransferCertificateFilesUpload (LoginId, NameOfTheFile, PathOfTheFile) VALUES (@LoginId, @FileName, @FilePath)";
                            }

                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@LoginId", loginId);
                            cmd.Parameters.AddWithValue("@FileName", fileName);
                            cmd.Parameters.AddWithValue("@FilePath", "~/UploadedFiles/TransferCertificate/" + fileName);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            B6.InnerHtml = "File uploaded successfully.";
                            HyperLink6.NavigateUrl = ResolveUrl("~/UploadedFiles/TransferCertificate/" + fileName);
                            HyperLink6.Visible = true; // Show the [VIEW IMAGE] link after uploading
                        }
                    }
                    else
                    {
                        B6.InnerHtml = "Invalid file type or size. Please upload a JPG file between 10KB and 50KB.";
                        HyperLink6.Visible = false;
                    }
                }
                else
                {
                    B6.InnerHtml = "Please select a file to upload.";
                    HyperLink6.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B6.InnerHtml = "File upload failed: " + ex.Message;
                HyperLink6.Visible = false;
            }
        }









        // .........................SCHOOL BONAFIDE CERTIFICATE............................. 7


        protected void LoadSchoolBonafideCertificate()
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (!string.IsNullOrEmpty(loginId))
                {
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        // Query to get file details for the given LoginId
                        string query = "SELECT NameOfTheFile, PathOfTheFile FROM SchoolBonafideCertificateFilesUpload WHERE LoginId = @LoginId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LoginId", loginId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string fileName = reader["NameOfTheFile"].ToString();
                            string filePath = reader["PathOfTheFile"].ToString();


                            B7.InnerHtml = "file already uploaded.";
                            // Set the link to view the image
                            HyperLink7.NavigateUrl = ResolveUrl(filePath);
                            HyperLink7.Visible = true; // Make the link visible
                        }
                        else
                        {

                            HyperLink7.Visible = false; // Hide the link if no file is uploaded
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {

                    HyperLink7.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B7.InnerHtml = "Error loading user details: " + ex.Message;
                HyperLink7.Visible = false;
            }
        }


        protected void btnButton7_Click(object sender, EventArgs e)
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (FileUpload7.HasFile)
                {
                    if (FileUpload7.PostedFile.ContentType == "image/jpeg" &&
                        FileUpload7.PostedFile.ContentLength >= 10240 &&
                        FileUpload7.PostedFile.ContentLength <= 51200)
                    {
                        string folderPath = Server.MapPath("~/UploadedFiles/SchoolBonafideCertificate/");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string fileName = Path.GetFileName(FileUpload7.FileName);
                        string filePath = folderPath + fileName;
                        FileUpload7.SaveAs(filePath);

                        using (SqlConnection con = new SqlConnection(strcon))
                        {
                            string checkQuery = "SELECT COUNT(*) FROM SchoolBonafideCertificateFilesUpload WHERE LoginId = @LoginId";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@LoginId", loginId);

                            con.Open();
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            con.Close();

                            string query;
                            if (count > 0)
                            {
                                query = "UPDATE SchoolBonafideCertificateFilesUpload SET NameOfTheFile = @FileName, PathOfTheFile = @FilePath WHERE LoginId = @LoginId";
                            }
                            else
                            {
                                query = "INSERT INTO SchoolBonafideCertificateFilesUpload (LoginId, NameOfTheFile, PathOfTheFile) VALUES (@LoginId, @FileName, @FilePath)";
                            }

                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@LoginId", loginId);
                            cmd.Parameters.AddWithValue("@FileName", fileName);
                            cmd.Parameters.AddWithValue("@FilePath", "~/UploadedFiles/SchoolBonafideCertificate/" + fileName);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            B7.InnerHtml = "File uploaded successfully.";
                            HyperLink7.NavigateUrl = ResolveUrl("~/UploadedFiles/SchoolBonafideCertificate/" + fileName);
                            HyperLink7.Visible = true; // Show the [VIEW IMAGE] link after uploading
                        }
                    }
                    else
                    {
                        B7.InnerHtml = "Invalid file type or size. Please upload a JPG file between 10KB and 50KB.";
                        HyperLink7.Visible = false;
                    }
                }
                else
                {
                    B7.InnerHtml = "Please select a file to upload.";
                    HyperLink7.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B7.InnerHtml = "File upload failed: " + ex.Message;
                HyperLink7.Visible = false;
            }
        }







        // .............................COMMUNITY CERTIFICATE.....................................8


        protected void LoadCommunityCertificate()
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (!string.IsNullOrEmpty(loginId))
                {
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        // Query to get file details for the given LoginId
                        string query = "SELECT NameOfTheFile, PathOfTheFile FROM CommunityCertificateFilesUpload WHERE LoginId = @LoginId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LoginId", loginId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string fileName = reader["NameOfTheFile"].ToString();
                            string filePath = reader["PathOfTheFile"].ToString();


                            B8.InnerHtml = "file already uploaded.";
                            // Set the link to view the image
                            HyperLink8.NavigateUrl = ResolveUrl(filePath);
                            HyperLink8.Visible = true; // Make the link visible
                        }
                        else
                        {

                            HyperLink8.Visible = false; // Hide the link if no file is uploaded
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {

                    HyperLink8.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B8.InnerHtml = "Error loading user details: " + ex.Message;
                HyperLink8.Visible = false;
            }
        }


        protected void btnButton8_Click(object sender, EventArgs e)
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (FileUpload8.HasFile)
                {
                    if (FileUpload8.PostedFile.ContentType == "image/jpeg" &&
                        FileUpload8.PostedFile.ContentLength >= 10240 &&
                        FileUpload8.PostedFile.ContentLength <= 51200)
                    {
                        string folderPath = Server.MapPath("~/UploadedFiles/CommunityCertificate/");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string fileName = Path.GetFileName(FileUpload8.FileName);
                        string filePath = folderPath + fileName;
                        FileUpload8.SaveAs(filePath);

                        using (SqlConnection con = new SqlConnection(strcon))
                        {
                            string checkQuery = "SELECT COUNT(*) FROM CommunityCertificateFilesUpload WHERE LoginId = @LoginId";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@LoginId", loginId);

                            con.Open();
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            con.Close();

                            string query;
                            if (count > 0)
                            {
                                query = "UPDATE CommunityCertificateFilesUpload SET NameOfTheFile = @FileName, PathOfTheFile = @FilePath WHERE LoginId = @LoginId";
                            }
                            else
                            {
                                query = "INSERT INTO CommunityCertificateFilesUpload (LoginId, NameOfTheFile, PathOfTheFile) VALUES (@LoginId, @FileName, @FilePath)";
                            }

                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@LoginId", loginId);
                            cmd.Parameters.AddWithValue("@FileName", fileName);
                            cmd.Parameters.AddWithValue("@FilePath", "~/UploadedFiles/CommunityCertificate/" + fileName);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            B8.InnerHtml = "File uploaded successfully.";
                            HyperLink8.NavigateUrl = ResolveUrl("~/UploadedFiles/CommunityCertificate/" + fileName);
                            HyperLink8.Visible = true; // Show the [VIEW IMAGE] link after uploading
                        }
                    }
                    else
                    {
                        B8.InnerHtml = "Invalid file type or size. Please upload a JPG file between 10KB and 50KB.";
                        HyperLink8.Visible = false;
                    }
                }
                else
                {
                    B8.InnerHtml = "Please select a file to upload.";
                    HyperLink8.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B8.InnerHtml = "File upload failed: " + ex.Message;
                HyperLink8.Visible = false;
            }
        }







        //.......................NATIVITY CERTIFICATE............................................... 9



        protected void LoadNativityCertificate()
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (!string.IsNullOrEmpty(loginId))
                {
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        // Query to get file details for the given LoginId
                        string query = "SELECT NameOfTheFile, PathOfTheFile FROM NativityCertificateFilesUpload WHERE LoginId = @LoginId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LoginId", loginId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string fileName = reader["NameOfTheFile"].ToString();
                            string filePath = reader["PathOfTheFile"].ToString();


                            B9.InnerHtml = "file already uploaded.";
                            // Set the link to view the image
                            HyperLink9.NavigateUrl = ResolveUrl(filePath);
                            HyperLink9.Visible = true; // Make the link visible
                        }
                        else
                        {

                            HyperLink9.Visible = false; // Hide the link if no file is uploaded
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {

                    HyperLink9.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B9.InnerHtml = "Error loading user details: " + ex.Message;
                HyperLink9.Visible = false;
            }
        }


        protected void btnButton9_Click(object sender, EventArgs e)
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (FileUpload9.HasFile)
                {
                    if (FileUpload9.PostedFile.ContentType == "image/jpeg" &&
                        FileUpload9.PostedFile.ContentLength >= 10240 &&
                        FileUpload9.PostedFile.ContentLength <= 51200)
                    {
                        string folderPath = Server.MapPath("~/UploadedFiles/NativityCertificate/");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string fileName = Path.GetFileName(FileUpload9.FileName);
                        string filePath = folderPath + fileName;
                        FileUpload9.SaveAs(filePath);

                        using (SqlConnection con = new SqlConnection(strcon))
                        {
                            string checkQuery = "SELECT COUNT(*) FROM NativityCertificateFilesUpload WHERE LoginId = @LoginId";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@LoginId", loginId);

                            con.Open();
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            con.Close();

                            string query;
                            if (count > 0)
                            {
                                query = "UPDATE NativityCertificateFilesUpload SET NameOfTheFile = @FileName, PathOfTheFile = @FilePath WHERE LoginId = @LoginId";
                            }
                            else
                            {
                                query = "INSERT INTO NativityCertificateFilesUpload (LoginId, NameOfTheFile, PathOfTheFile) VALUES (@LoginId, @FileName, @FilePath)";
                            }

                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@LoginId", loginId);
                            cmd.Parameters.AddWithValue("@FileName", fileName);
                            cmd.Parameters.AddWithValue("@FilePath", "~/UploadedFiles/NativityCertificate/" + fileName);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            B9.InnerHtml = "File uploaded successfully.";
                            HyperLink9.NavigateUrl = ResolveUrl("~/UploadedFiles/NativityCertificate/" + fileName);
                            HyperLink9.Visible = true; // Show the [VIEW IMAGE] link after uploading
                        }
                    }
                    else
                    {
                        B9.InnerHtml = "Invalid file type or size. Please upload a JPG file between 10KB and 50KB.";
                        HyperLink9.Visible = false;
                    }
                }
                else
                {
                    B9.InnerHtml = "Please select a file to upload.";
                    HyperLink9.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B9.InnerHtml = "File upload failed: " + ex.Message;
                HyperLink9.Visible = false;
            }
        }






        //................PARENT COMMUNITY CERTIFICATE.....................................10



        protected void LoadParentCommunityCertificate()
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (!string.IsNullOrEmpty(loginId))
                {
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        // Query to get file details for the given LoginId
                        string query = "SELECT NameOfTheFile, PathOfTheFile FROM ParentCommunityCertificateFilesUpload WHERE LoginId = @LoginId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LoginId", loginId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string fileName = reader["NameOfTheFile"].ToString();
                            string filePath = reader["PathOfTheFile"].ToString();


                            B10.InnerHtml = "file already uploaded.";
                            // Set the link to view the image
                            HyperLink10.NavigateUrl = ResolveUrl(filePath);
                            HyperLink10.Visible = true; // Make the link visible
                        }
                        else
                        {

                            HyperLink10.Visible = false; // Hide the link if no file is uploaded
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {

                    HyperLink10.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B10.InnerHtml = "Error loading user details: " + ex.Message;
                HyperLink10.Visible = false;
            }
        }


        protected void btnButton10_Click(object sender, EventArgs e)
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (FileUpload10.HasFile)
                {
                    if (FileUpload10.PostedFile.ContentType == "image/jpeg" &&
                        FileUpload10.PostedFile.ContentLength >= 10240 &&
                        FileUpload10.PostedFile.ContentLength <= 51200)
                    {
                        string folderPath = Server.MapPath("~/UploadedFiles/ParentCommunityCertificate/");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string fileName = Path.GetFileName(FileUpload10.FileName);
                        string filePath = folderPath + fileName;
                        FileUpload10.SaveAs(filePath);

                        using (SqlConnection con = new SqlConnection(strcon))
                        {
                            string checkQuery = "SELECT COUNT(*) FROM ParentCommunityCertificateFilesUpload WHERE LoginId = @LoginId";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@LoginId", loginId);

                            con.Open();
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            con.Close();

                            string query;
                            if (count > 0)
                            {
                                query = "UPDATE ParentCommunityCertificateFilesUpload SET NameOfTheFile = @FileName, PathOfTheFile = @FilePath WHERE LoginId = @LoginId";
                            }
                            else
                            {
                                query = "INSERT INTO ParentCommunityCertificateFilesUpload (LoginId, NameOfTheFile, PathOfTheFile) VALUES (@LoginId, @FileName, @FilePath)";
                            }

                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@LoginId", loginId);
                            cmd.Parameters.AddWithValue("@FileName", fileName);
                            cmd.Parameters.AddWithValue("@FilePath", "~/UploadedFiles/ParentCommunityCertificate/" + fileName);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            B10.InnerHtml = "File uploaded successfully.";
                            HyperLink10.NavigateUrl = ResolveUrl("~/UploadedFiles/ParentCommunityCertificate/" + fileName);
                            HyperLink10.Visible = true; // Show the [VIEW IMAGE] link after uploading
                        }
                    }
                    else
                    {
                        B10.InnerHtml = "Invalid file type or size. Please upload a JPG file between 10KB and 50KB.";
                        HyperLink10.Visible = false;
                    }
                }
                else
                {
                    B10.InnerHtml = "Please select a file to upload.";
                    HyperLink10.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B10.InnerHtml = "File upload failed: " + ex.Message;
                HyperLink10.Visible = false;
            }
        }






        //.....................PARENT STUDY CERTIFICATE............................... 11


        protected void LoadParentStudyCertificate()
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (!string.IsNullOrEmpty(loginId))
                {
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        // Query to get file details for the given LoginId
                        string query = "SELECT NameOfTheFile, PathOfTheFile FROM ParentStudyProofCertificateFilesUpload WHERE LoginId = @LoginId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LoginId", loginId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string fileName = reader["NameOfTheFile"].ToString();
                            string filePath = reader["PathOfTheFile"].ToString();


                            B11.InnerHtml = "file already uploaded.";
                            // Set the link to view the image
                            HyperLink11.NavigateUrl = ResolveUrl(filePath);
                            HyperLink11.Visible = true; // Make the link visible
                        }
                        else
                        {

                            HyperLink11.Visible = false; // Hide the link if no file is uploaded
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {

                    HyperLink11.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B11.InnerHtml = "Error loading user details: " + ex.Message;
                HyperLink11.Visible = false;
            }
        }


        protected void btnButton11_Click(object sender, EventArgs e)
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (FileUpload11.HasFile)
                {
                    if (FileUpload11.PostedFile.ContentType == "image/jpeg" &&
                        FileUpload11.PostedFile.ContentLength >= 10240 &&
                        FileUpload11.PostedFile.ContentLength <= 51200)
                    {
                        string folderPath = Server.MapPath("~/UploadedFiles/ParentStudyCertificate/");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string fileName = Path.GetFileName(FileUpload11.FileName);
                        string filePath = folderPath + fileName;
                        FileUpload11.SaveAs(filePath);

                        using (SqlConnection con = new SqlConnection(strcon))
                        {
                            string checkQuery = "SELECT COUNT(*) FROM ParentStudyProofCertificateFilesUpload WHERE LoginId = @LoginId";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@LoginId", loginId);

                            con.Open();
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            con.Close();

                            string query;
                            if (count > 0)
                            {
                                query = "UPDATE ParentStudyProofCertificateFilesUpload SET NameOfTheFile = @FileName, PathOfTheFile = @FilePath WHERE LoginId = @LoginId";
                            }
                            else
                            {
                                query = "INSERT INTO ParentStudyProofCertificateFilesUpload (LoginId, NameOfTheFile, PathOfTheFile) VALUES (@LoginId, @FileName, @FilePath)";
                            }

                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@LoginId", loginId);
                            cmd.Parameters.AddWithValue("@FileName", fileName);
                            cmd.Parameters.AddWithValue("@FilePath", "~/UploadedFiles/ParentStudyCertificate/" + fileName);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            B11.InnerHtml = "File uploaded successfully.";
                            HyperLink11.NavigateUrl = ResolveUrl("~/UploadedFiles/ParentStudyCertificate/" + fileName);
                            HyperLink11.Visible = true; // Show the [VIEW IMAGE] link after uploading
                        }
                    }
                    else
                    {
                        B11.InnerHtml = "Invalid file type or size. Please upload a JPG file between 10KB and 50KB.";
                        HyperLink11.Visible = false;
                    }
                }
                else
                {
                    B11.InnerHtml = "Please select a file to upload.";
                    HyperLink11.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B11.InnerHtml = "File upload failed: " + ex.Message;
                HyperLink11.Visible = false;
            }
        }




        //........................PARENT ADDRESS PROOF................................... 12



        protected void LoadParentAddressProof()
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (!string.IsNullOrEmpty(loginId))
                {
                    using (SqlConnection con = new SqlConnection(strcon))
                    {
                        // Query to get file details for the given LoginId
                        string query = "SELECT NameOfTheFile, PathOfTheFile FROM ParentAddressProofCertificateFilesUpload WHERE LoginId = @LoginId";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@LoginId", loginId);

                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string fileName = reader["NameOfTheFile"].ToString();
                            string filePath = reader["PathOfTheFile"].ToString();


                            B12.InnerHtml = "file already uploaded.";
                            // Set the link to view the image
                            HyperLink12.NavigateUrl = ResolveUrl(filePath);
                            HyperLink12.Visible = true; // Make the link visible
                        }
                        else
                        {

                            HyperLink12.Visible = false; // Hide the link if no file is uploaded
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {

                    HyperLink12.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B12.InnerHtml = "Error loading user details: " + ex.Message;
                HyperLink12.Visible = false;
            }
        }


        protected void btnButton12_Click(object sender, EventArgs e)
        {
            try
            {
                string loginId = Session["LoginId"] as string;

                if (FileUpload12.HasFile)
                {
                    if (FileUpload12.PostedFile.ContentType == "image/jpeg" &&
                        FileUpload12.PostedFile.ContentLength >= 10240 &&
                        FileUpload12.PostedFile.ContentLength <= 51200)
                    {
                        string folderPath = Server.MapPath("~/UploadedFiles/ParentAddressProof/");
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        string fileName = Path.GetFileName(FileUpload12.FileName);
                        string filePath = folderPath + fileName;
                        FileUpload12.SaveAs(filePath);

                        using (SqlConnection con = new SqlConnection(strcon))
                        {
                            string checkQuery = "SELECT COUNT(*) FROM ParentAddressProofCertificateFilesUpload WHERE LoginId = @LoginId";
                            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                            checkCmd.Parameters.AddWithValue("@LoginId", loginId);

                            con.Open();
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            con.Close();

                            string query;
                            if (count > 0)
                            {
                                query = "UPDATE ParentAddressProofCertificateFilesUpload SET NameOfTheFile = @FileName, PathOfTheFile = @FilePath WHERE LoginId = @LoginId";
                            }
                            else
                            {
                                query = "INSERT INTO ParentAddressProofCertificateFilesUpload (LoginId, NameOfTheFile, PathOfTheFile) VALUES (@LoginId, @FileName, @FilePath)";
                            }

                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@LoginId", loginId);
                            cmd.Parameters.AddWithValue("@FileName", fileName);
                            cmd.Parameters.AddWithValue("@FilePath", "~/UploadedFiles/ParentAddressProof/" + fileName);

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            B12.InnerHtml = "File uploaded successfully.";
                            HyperLink12.NavigateUrl = ResolveUrl("~/UploadedFiles/ParentAddressProof/" + fileName);
                            HyperLink12.Visible = true; // Show the [VIEW IMAGE] link after uploading
                        }
                    }
                    else
                    {
                        B12.InnerHtml = "Invalid file type or size. Please upload a JPG file between 10KB and 50KB.";
                        HyperLink12.Visible = false;
                    }
                }
                else
                {
                    B12.InnerHtml = "Please select a file to upload.";
                    HyperLink12.Visible = false;
                }
            }
            catch (Exception ex)
            {
                B12.InnerHtml = "File upload failed: " + ex.Message;
                HyperLink12.Visible = false;
            }
        }










    }
}