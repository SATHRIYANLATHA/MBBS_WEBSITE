<%@ Page Title="" Language="C#" MasterPageFile="~/MBBS-BDS.Master" AutoEventWireup="true" CodeBehind="splres.aspx.cs" Inherits="MBBS_WEBSITE.splres" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
    <div style="box-shadow: 0px 0px 50px grey; padding-top: 1px; padding-bottom: 1px;" class="mt-2 ms-3 mb-2 me-3">

        <div class="border border-info ms-2 mt-1 me-2" style="border-radius: 5px;">

            <div class="ps-3 pt-1 pb-1 " style="background-color: #dcebfb; box-sizing: border-box; border-radius: 5px;">
                <h5 style="color: #172e81">SPECIAL RESERVATION</h5>
            </div>

            <div class="container-fluid ">

                <div class="row ">


                    <div class="col-5">

                        <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">EMINENT SPORTS PERSON</h6>

                    </div>

                    <div class="col-7 mt-3">
                        <asp:RadioButtonList ID="EminentSportsOptions" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="Yes"  style="padding-left: 10px;"></asp:ListItem>
                            <asp:ListItem Text="No" Value="No"  Selected="True" style="padding-left: 10px;"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>


                </div>



                <div class="row ">


                    <div class="col-5">

                        <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">EX-SERVICEMEN  </h6>

                    </div>

                    <div class="col-7 mt-3">
                        <asp:RadioButtonList ID="ExServicemenOptions" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="Yes"  style="padding-left: 10px;"></asp:ListItem>
                            <asp:ListItem Text="No" Value="No" Selected="True"  style="padding-left: 10px;"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>


                </div>



                <div class="row ">


                    <div class="col-5">

                        <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">DIFFERENTLY ABLED PERSON  </h6>

                    </div>

                    <div class="col-7 mt-3">
                        <asp:RadioButtonList ID="DifferentlyAbledPersonOptions" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="Yes"  style="padding-left: 10px;"></asp:ListItem>
                            <asp:ListItem Text="No" Value="No" Selected="True"  style="padding-left: 10px;"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>


                </div>



                <div class="row ">


                    <div class="col-5">

                        <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">QUALIFYING EXAMINATION </h6>

                    </div>

                    <div class="col-7 mt-3">
                        <asp:DropDownList ID="ddlQualifyingExamination" runat="server" Style="width: 40%; height: 30px" CssClass="ms-3">
                            <asp:ListItem Value="" Disabled="True" Selected="True">-- Select  --</asp:ListItem>
                           
                        </asp:DropDownList>


                    </div>


                </div>



                <div class="row ">


                    <div class="col-5">

                        <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">HSC GROUP & GROUP CODE (TN STATE ONLY)</h6>

                    </div>

                    <div class="col-7 mt-3">
                        <asp:RadioButtonList ID="HscGroupOptions" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="Yes"  style="padding-left: 10px;"></asp:ListItem>
                            <asp:ListItem Text="No" Value="No" Selected="True"  style="padding-left: 10px;"></asp:ListItem>
                        </asp:RadioButtonList>


                    </div>


                </div>



                <div class="row ">


                    <div class="col-5">

                        <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">NAME OF THE BOARD OF EXAMINATION </h6>

                    </div>

                    <div class="col-7 mt-3">
                        <asp:DropDownList ID="ddlBoardOfExamination" runat="server" Style="width: 40%; height: 30px" CssClass="ms-3">
                            <asp:ListItem Value="" Disabled="True" Selected="True">-- Select --</asp:ListItem>
                           
                        </asp:DropDownList>



                    </div>


                </div>



                <div class="row  mb-3">


                    <div class="col-5">

                        <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">UNDERGOING/ COMPLETED ANY PROFESSIONAL COURSES</h6>

                    </div>

                    <div class="col-7 mt-3">
                        <asp:RadioButtonList ID="ProfessionalCourseOptions" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Yes" Value="Yes"  style="padding-left: 10px;"></asp:ListItem>
                            <asp:ListItem Text="No" Value="No" Selected="True"  style="padding-left: 10px;"></asp:ListItem>
                        </asp:RadioButtonList>


                    </div>


                </div>




            </div>


         
        </div>



        

        <div class=" d-flex justify-content-center align-items-center mb-3 ms-2 me-2" style="background-color: #dcebfb; box-sizing: border-box; ">


             <asp:Button  ID="btnSaveContinue" runat="server" class="btn btn-primary mt-1 mb-1" OnClick="btnSaveContinue_Click" Text="Save & Continue "></asp:Button>


        </div>
  

 </div>





</asp:Content>

