<%@ Page Title="" Language="C#" MasterPageFile="~/MBBS.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="MBBS_WEBSITE.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="d-flex justify-content-center align-items-center">
        <h4 class="mt-4" style="color: darkblue"><b>Welcome to the 2025-2026 Academic Year</b></h4>
    </div>

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4 text-center">
                <div class="border-bottom w100p">
                    <h5><b style="color: darkblue">Quick Links</b></h5>
                </div>
            </div>



            <div class="col-md-4 mt-3">
                <div class="text-center text-white" style="background-color: #3d6d8c; margin-bottom: 0;">
                    <h5 class="mb-0"><b>USER LOGIN</b></h5>
                </div>

                <div class="border border-info" style="padding-left: 13px; padding-right: 13px;">
                    <!-- Add padding to the container -->
                    <nav class="navbar-nav">
                        <div class="row d-flex flex-row justify-content-evenly">
                            <div class="col-6 text-center p-0" id="userid-container">
                                <button type="button" class="nav-item ms-0 me-0" id="btnuserid" style="border: none; width: 100%; height: 40px; background-color: transparent; color: blue">
                                    UserID
                                </button>
                            </div>
                            <div class="col-6 text-center p-0" id="password-container">
                                <button type="button" class="nav-item mx-auto ms-0" id="btnpassword" style="border: none; width: 100%; height: 40px; background-color: transparent; color: blue">
                                    Mobile
                                </button>
                            </div>
                        </div>
                    </nav>

                    


                </div>

                <!-- USER CONTENT DISPLAY -->

                 <div class="border border-info" >
                     

                     <div class=" container mt-4" id="usercontentdisplay">

                         <h6>User Id</h6>
                         <asp:TextBox  ID="txtuserid" runat="server"  CssClass="form-control" style="width:100%" placeholder=" User ID"></asp:TextBox>

                         <br />

                         <h6>Password</h6>
                          <asp:TextBox  ID="txtPassword" runat="server"  CssClass="form-control" style="width:100%" placeholder="Password"></asp:TextBox>
                         
                         <div class="mt-2 mb-4 d-flex justify-content-center">

                             <asp:Button ID="btnLogin" runat="server" Text="LOGIN" class="btn btn-primary " OnClick="btnLogin_Click" /> &nbsp;
                             <asp:Button ID="btnClear" runat="server" Text="CLEAR" class="btn btn-secondary" />

                         </div>

                     </div>

                    
                     <!-- MOBILE CONTENT DISPLAY -->

                     <div class=" container mt-4" id="mobilecontentdisplay">

    <h6>Registered Mobile No.</h6>
    <div class="d-flex justify-content-between">
         <asp:TextBox  ID="TextBox1" runat="server"  CssClass="form-control ms-2 me-3" style="width:100%" placeholder=" Mobile No."></asp:TextBox>
    </div>

    <br />

    <h6>Date Of Birth</h6>
     <asp:TextBox  ID="TextBox2" runat="server"  CssClass="form-control ms-5 me-5" style="width:80%" placeholder="DD/MM/YYYY"></asp:TextBox>
    
    <div class="mt-2 mb-4 d-flex justify-content-center">

        <asp:Button ID="btnOtp" runat="server" Text="SEND OTP" class="btn btn-primary " /> &nbsp;
        <asp:Button ID="btnClearM" runat="server" Text="CLEAR" class="btn btn-secondary" />

    </div>

</div>


                </div>

            </div>



        <div class="col-md-4 text-center">
            <div class="border-bottom w100p">
                <h5><b style="color: darkblue">Announcements</b></h5>
            </div>
        </div>
    </div>

    </div>



    <script>
        const btnuserid = document.getElementById("btnuserid");
        const btnpassword = document.getElementById("btnpassword");
        const useridcontainer = document.getElementById("userid-container");
        const passwordcontainer = document.getElementById("password-container");

        const usercontentdisplay = document.getElementById("usercontentdisplay");
        const mobilecontentdisplay = document.getElementById("mobilecontentdisplay");

        btnuserid.addEventListener("click", () => {
            localStorage.setItem("selectedButton", "userid"); // Store the selected button in localStorage
            location.reload(); // Refresh the page
        });

        btnpassword.addEventListener("click", () => {
            localStorage.setItem("selectedButton", "password"); // Store the selected button in localStorage
            location.reload(); // Refresh the page
        });

        window.onload = () => {
            // Check which button was selected and change the background color accordingly
            const selectedButton = localStorage.getItem("selectedButton");

            if (selectedButton === "userid") {

                useridcontainer.style.backgroundColor = "aliceblue"; // Change background color for UserID

                mobilecontentdisplay.style.display = "none";


            } else if (selectedButton === "password") {

                passwordcontainer.style.backgroundColor = "aliceblue"; // Change background color for Mobile

                usercontentdisplay.style.display = "none";

            } else {

                useridcontainer.style.backgroundColor = "aliceblue"; // Default to UserID

                mobilecontentdisplay.style.display = "none";
            }
        }
        </script>
</asp:Content>
