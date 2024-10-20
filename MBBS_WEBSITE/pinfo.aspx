﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MBBS-BDS.Master" AutoEventWireup="true" CodeBehind="pinfo.aspx.cs" Inherits="MBBS_WEBSITE.pinfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div style="box-shadow: 0px 0px 50px grey; padding-top: 1px; padding-bottom: 1px;" class="mt-2 ms-3 mb-2 me-3">

        <div class="border border-info ms-2 mt-1 me-2" style="border-radius: 5px;">

            <div class="ps-3 pt-1 pb-1 " style="background-color: #dcebfb; box-sizing: border-box; border-radius: 5px;">
                <h5 style="color: #172e81">PERSONAL INFORMATION</h5>
            </div>


            <!-- PERSONAL INFORMATION -->

            <div>
                <div class="container-fluid">
                    <div class="row">

                        <div class="col-6">


                            <h6 style="color:#172e81;margin-bottom: 4px;" class="pt-3">NAME OF THE APPLICANT</h6>
                             <b id="username" runat="server">SATHRIYAN</b> 

                            
                            <h6 style="color:#172e81;margin-bottom: 4px;" class="pt-3">HSC/EQUIVALENT ROLL NO</h6>
                             <b id="hscrollno" runat="server">1915380151</b> 

                            
                            <h6 style="color:#172e81;margin-bottom: 4px;" class="pt-3">NEET ROLL NO</h6>
                             <b id="neetrollno" runat="server">611020104038</b> 


                            <h6 style="color:#172e81;margin-bottom: 4px;" class="pt-3">NAME OF THE PARENT / GUARDIAN</h6>
                             <asp:TextBox ID="txtParent" runat="server" placeholder="Name of the Parent/Guardian" style="width:60%;" class="mb-2"></asp:TextBox>


                             <h6 style="color:#172e81;margin-bottom: 4px;" class="pt-3">NATIONALITY</h6>
                            
                                <asp:DropDownList ID="ddlNationality" runat="server" Style="width: 60%;" class="mb-2">
                                    <asp:ListItem Value="" Disabled="True" Selected="True">-- Select Nationality --</asp:ListItem>
                                   
                                </asp:DropDownList>


                             <h6 style="color:#172e81;margin-bottom: 4px;" class="pt-3">MOTHER TONGUE</h6>
                                <asp:DropDownList ID="ddlMotherTongue" runat="server" Style="width: 60%;" class="mb-2">
                                    <asp:ListItem Value="" Disabled="True" Selected="True">-- Select Mother Tongue --</asp:ListItem>
                                  
                                </asp:DropDownList>




                        </div>


                        <div class="col-6">


                            <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">DATE OF BIRTH</h6>
                            <b id="dateofbirth" runat="server">13/11/2003</b>


                            <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">YEAR OF PASSING</h6>
                            <b id="yearofpassing" runat="server">2020</b>


                            <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">GENDER</h6>
                            <b id="gender" runat="server">MALE</b>

                             <h6 style="color:#172e81;margin-bottom: 4px;" class="pt-3">SCHOOLING  STUDIED (6<sup>th</sup> STD TO 12<sup>th</sup> STD)</h6>
                            <asp:DropDownList ID="ddlSchooling" runat="server" Style="width: 50%;" class="mb-2">
                                <asp:ListItem Value="" Disabled="True" Selected="True">-- Select Schooling --</asp:ListItem>
                                <asp:ListItem Value="Tamil Nadu">TamilNadu</asp:ListItem>
                                <asp:ListItem Value="Party Tamil Nadu">Party TamilNadu</asp:ListItem>
                                <asp:ListItem Value="Other States/Countries">Other States/Countries</asp:ListItem>
                            </asp:DropDownList>



                             <h6 style="color:#172e81;margin-bottom: 4px;" class="pt-3">RELIGION</h6>
                            <asp:DropDownList ID="ddlReligion" runat="server" Style="width: 50%;" class="mb-2">
                                <asp:ListItem Value="" Disabled="True" Selected="True">-- Select Religion --</asp:ListItem>
                               
                            </asp:DropDownList>


                             <h6 style="color:#172e81;margin-bottom: 4px;" class="pt-3">NATIVITY</h6>
                            <asp:DropDownList ID="ddlNativity" runat="server" Style="width: 50%;" class="mb-2">
                                <asp:ListItem Value="" Disabled="True" Selected="True">-- Select Nativity --</asp:ListItem>
                               
                            </asp:DropDownList>


                        </div>

                    </div>
                </div>



            </div>



            <!-- COMMUNITY INFORMATION -->
            
            <div  class="border border-info mt-3" style="border-radius:5px;">
                <div class="ps-3 pt-1 pb-1 " style="background-color: #dcebfb; box-sizing: border-box; border-radius: 5px;">
                    <h5 style="color: #172e81">COMMUNITY INFORMATION</h5>
                </div>

                <div class="container-fluid">
                    <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">COMMUNITY</h6>
                    <asp:DropDownList ID="ddlCommunity" runat="server" Style="width: 30%;" class="mb-2"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlCommunity_SelectedIndexChanged">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select Community --</asp:ListItem>
                    </asp:DropDownList>

                    <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">SUB CASTE WITH CODE</h6>
                    <asp:DropDownList ID="ddlCaste" runat="server" Style="width: 100%;" class="mb-2">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select Caste --</asp:ListItem>
                    </asp:DropDownList>
                </div>


                <div class="d-flex justify-content-around container-fluid ">

                    <div>
                         <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">CERTIFICATE NO</h6>
                        <asp:TextBox ID="txtCertificate" runat="server" placeholder="Certificate No." style="width:80%;" class="mb-2"></asp:TextBox>
                    </div>

                    <div>
                        <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">ISSUED BY</h6>
                        <asp:TextBox ID="txtIssuedby" runat="server" placeholder="Issued By" Style="width: 80%;" class="mb-2"></asp:TextBox>
                    </div>

                    <div>
                        <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">ISSUED TALUK</h6>
                        <asp:TextBox ID="txtIssuedTaluk" runat="server" placeholder="Issued Taluk" Style="width: 80%;" class="mb-2"></asp:TextBox>
                    </div>

                    <div>
                        <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">COMM DISTRICT</h6>
                        <asp:DropDownList ID="ddlDistrict" runat="server" Style="width: 80%;height:30px">
                            <asp:ListItem Value="" Disabled="True" Selected="True">-- Select District --</asp:ListItem>
                           
                        </asp:DropDownList>

                        
                    </div>

                    <div>
                        <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">ISSUED DATE</h6>
                        <asp:TextBox ID="txtDate" runat="server" placeholder=" Pick the Date" Textmode="Date" style="width:60%;" class="mb-2"   ></asp:TextBox>
                    </div>

                </div>







            </div>


            <div class="d-flex justify-content-center align-items-center mb-3" style="background-color: #dcebfb; box-sizing: border-box; border-radius: 5px;">
           

                <asp:Button  ID="btnSaveContinue" runat="server" class="btn btn-primary mt-1 mb-1" OnClick="btnSaveContinue_Click" Text="Save & Continue "></asp:Button>
                
            
            </div>


        </div>



 </div>







</asp:Content>










