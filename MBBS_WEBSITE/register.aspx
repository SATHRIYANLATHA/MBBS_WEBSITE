<%@ Page Title="" Language="C#" MasterPageFile="~/MBBS.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="MBBS_WEBSITE.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   

    <h5 class="d-flex justify-content-center align-items-center mt-3" style="color:darkblue"><b>USER REGISTRATION</b></h5>


    <div class="container-fluid mt-4">
        <div class="row">
            <div class="col-2 text-center">
                <div class="border-bottom w100p">
                   
                </div>
            </div>

            <!--CENTER CONTENT-->


            <div class="col-8">

                <!-- PANEL 1 -->


                <div class="panel ">
                    <div class="panel-heading p-1 ps-3" style="background-color:#3d6d8c; color:white;border-radius:5px;">Personal Information</div>


                    <div class="panel-body ps-4 pt-4 pb-4" style="border: 1px solid #3d6d8c;border-color:#3d6d8c;border-radius:5px;">
                        
                        <div class="row ">

                            <div class="col-6 ">

                                <h6 style="color:darkblue">Name ( As in 12th Mark Sheet)</h6>
                                <asp:TextBox ID="txtName" runat="server" placeholder="Name" style="width:70%;" class="mb-2"></asp:TextBox>

                                
                             

                                <h6 style="color:darkblue">Email</h6>
                                <asp:TextBox ID="txtEmail" runat="server" placeholder="Email Address" style="width:70%;" class="mb-2" ></asp:TextBox>

                                

                                <h6 style="color: darkblue">Gender</h6>

                               <asp:RadioButtonList ID="rblGender" runat="server"  RepeatDirection="Horizontal" class="ms-4 " ></asp:RadioButtonList>

                            </div>

                            <div class="col-6">


                                <h6 style="color:darkblue">Mobile</h6>
                                <div>
                                    <b style="color:darkblue">(+91) </b>
                                    <asp:TextBox ID="txtMobile" runat="server" placeholder="Mobile No." class="ms-0 mb-2" style="width:70%;" ></asp:TextBox>
                              </div>
                                
                                 

                                <h6 style="color:darkblue">Date Of Birth</h6>
                                <asp:TextBox ID="txtDate" runat="server" placeholder=" Pick the Date" Textmode="Date" style="width:70%;" class="mb-2"  Max="2005-12-31" ></asp:TextBox>



                            </div>


                        </div>





                    </div>
                </div>

                
                <!-- PANEL 2 -->

                <div class="panel ">
                    <div class="panel-heading p-1 ps-3" style="background-color: #3d6d8c; color: white; border-radius: 5px;">Educational Information</div>

                    <div class="panel-body ps-4 pt-4 pb-4" style="border: 1px solid #3d6d8c; border-color: #3d6d8c; border-radius: 5px;">

                        <div class="row ">


                            <div class="col-6">


                                 <h6 style="color: darkblue">Whether +1 Passed</h6>

                                <asp:RadioButtonList ID="Plusonepassed" runat="server" RepeatDirection="Horizontal">
                                    <asp:ListItem Text="Yes" Value="Yes" Selected="True"></asp:ListItem>
                                    <asp:ListItem Text="No" Value="No"  style="padding-left: 10px;"></asp:ListItem>
                                </asp:RadioButtonList>

                                

                                <h6 style="color: darkblue" class="mt-2">HSC Roll Number</h6>
                                <asp:TextBox ID="txtHsc" runat="server" placeholder="HSC Roll No" Style="width: 50%;" class="mb-2"></asp:TextBox>




                                <h6 style="color: darkblue">NEET Roll Number</h6>
                                <asp:TextBox ID="txtNeet" runat="server" placeholder="NEET Roll No" Style="width: 50%;" class="mb-2"></asp:TextBox>

                            </div>

                             <div class="col-6">

                                 <h6 style="color: darkblue">Qualifying Examination</h6>
                                 <asp:DropDownList ID="ddlQualifyingExamination" runat="server" Style="width: 50%;" class="mb-2">
                                     <asp:ListItem Value="" Disabled="True" Selected="True">-- Examination --</asp:ListItem>
                                     
                                 </asp:DropDownList>


                                 <h6 style="color: darkblue">Qualified Year</h6>
                                 <asp:DropDownList ID="ddlQualifiedYear" runat="server" Style="width: 50%;" class="mb-2">
                                     <asp:ListItem Value="" Disabled="True" Selected="True">-- Select Year --</asp:ListItem>
                                     <asp:ListItem Value="2006">2006</asp:ListItem>
                                     <asp:ListItem Value="2007">2007</asp:ListItem>
                                     <asp:ListItem Value="2008">2008</asp:ListItem>
                                     <asp:ListItem Value="2009">2009</asp:ListItem>
                                     <asp:ListItem Value="2010">2010</asp:ListItem>
                                     <asp:ListItem Value="2011">2011</asp:ListItem>
                                     <asp:ListItem Value="2012">2012</asp:ListItem>
                                     <asp:ListItem Value="2013">2013</asp:ListItem>
                                     <asp:ListItem Value="2014">2014</asp:ListItem>
                                     <asp:ListItem Value="2015">2015</asp:ListItem>
                                     <asp:ListItem Value="2016">2016</asp:ListItem>
                                     <asp:ListItem Value="2017">2017</asp:ListItem>
                                     <asp:ListItem Value="2018">2018</asp:ListItem>
                                     <asp:ListItem Value="2019">2019</asp:ListItem>
                                     <asp:ListItem Value="2020">2020</asp:ListItem>
                                     <asp:ListItem Value="2021">2021</asp:ListItem>
                                     <asp:ListItem Value="2022">2022</asp:ListItem>
                                     <asp:ListItem Value="2023">2023</asp:ListItem>
                                     <asp:ListItem Value="2024">2024</asp:ListItem>
                                 </asp:DropDownList>

                                 <h6 style="color: darkblue">NEET Marks</h6>
                                 <asp:TextBox ID="txtNeetMarks" runat="server" placeholder="NEET Obtained Marks" Style="width: 50%;" class="mb-2"></asp:TextBox>

                             </div>


                        </div>
                    </div>

                </div>


                <!-- PANEL 3 -->

                <div class="panel ">
                    <div class="panel-heading p-1 ps-3" style="background-color: #3d6d8c; color: white; border-radius: 5px;">Login Information</div>

                    <div class="panel-body ps-4 pt-4 pb-4" style="border: 1px solid #3d6d8c; border-color: #3d6d8c; border-radius: 5px;">

                        <div class="row ">


                            

                                <div class="col-4">
                                <h6 style="color: darkblue">Login ID</h6>
                                <asp:TextBox ID="txtLoginid" runat="server" placeholder=" Login Id"  Style="width: 70%;" class="mb-2" ></asp:TextBox>
                                </div>

                                <div class="col-4">
                                <h6 style="color: darkblue"> Password</h6>
                                <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" Style="width: 70%;" class="mb-2"></asp:TextBox>
                                </div>

                                <div class="col-4">
                                <h6 style="color: darkblue">Confirm Password</h6>
                                <asp:TextBox ID="txtConfpassword" runat="server" placeholder=" Confirm Password" Style="width: 70%;" class="mb-2"></asp:TextBox>
                                 </div>

                            </div>

                        <div class="ms-5" style="color: green; padding-left: 230px;">
    <span class="text-small d-block" style="font-size: 0.8em;">> Password length between 6 to 12 characters</span>
    <span class="text-small d-block" style="font-size: 0.8em;">> Password should contain alphabets, numbers & special characters</span>
</div>



                        </div>
                    </div>


                 <!-- PANEL 4 -->

                <div class="panel mb-4">
                    <div class="panel-heading p-1 ps-3" style="background-color: #3d6d8c; color: white; ">

                        <div class="d-flex justify-content-center">
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-primary" OnClick="btnSubmit_Click"/> &nbsp;
                            <asp:Button ID="btnReset" runat="server" Text="Reset" class="btn btn-secondary" />
                        </div>
                    </div>
                </div>

          </div>


               
            



   




            <div class="col-2 text-center">
                <div class="border-bottom w100p">
                </div>
            </div>

            </div>
        </div>
    


</asp:Content>
