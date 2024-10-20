<%@ Page Title="" Language="C#" MasterPageFile="~/MBBS-BDS.Master" AutoEventWireup="true" CodeBehind="sos.aspx.cs" Inherits="MBBS_WEBSITE.sos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


       <div style="box-shadow: 0px 0px 50px grey; padding-top: 1px; padding-bottom: 1px;" class="mt-2 ms-3 mb-2 me-3">

       <div class="border border-info ms-2 mt-1 me-2" style="border-radius: 5px;">

           <div class="ps-3 pt-1 pb-1 " style="background-color: #dcebfb; box-sizing: border-box; border-radius: 5px;">
               <h5 style="color: #172e81">ACADEMIC AND  SCHOOLING</h5>
           </div>


           <div class="container-fluid">

               <div class="row">

                   <div class="col-6">
                       <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">PASSED ALL THE SUBJECTS OF HSC EXAM IN NO. OF ATTEMPTS</h6>
                   </div>

                   <div class="col-6 mt-3">

                       <asp:DropDownList ID="ddlNumberOfAttempts" runat="server" Style="width: 20%; height: 30px">
                           <asp:ListItem Value="1">1</asp:ListItem>
                           <asp:ListItem Value="2">2</asp:ListItem>
                           <asp:ListItem Value="3">3</asp:ListItem>
                           <asp:ListItem Value="4">4</asp:ListItem>
                           <asp:ListItem Value="5">5</asp:ListItem>
                           <asp:ListItem Value="More than 5">More than 5</asp:ListItem>
                       </asp:DropDownList>


                   </div>


               </div>
           </div>


           <div class="d-flex justify-content-center align-content-center">

                <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3"><b>MARKS OBTAINED IN HSC (ACADEMIC/ EQUIVALENT) EXAMINATION</b></h6>


           </div>


          

               <div>

                   <table class="table table-bordered">
                       <thead class="table-secondary fw-bold ">
                           <tr class="text-center align-middle ">

                              
                               <td>SUBJECTS</td>
                               <td>REGISTER NUMBER</td>
                               <td>MONTH OF PASSED</td>
                               <td>YEAR OF PASSED</td>
                               <td>MAX.MARKS</td>
                               <td>OBT.MARKS</td>
                               
                           </tr>
                       </thead>

                       <tbody style="border-top:3px solid grey ">

                           <tr>
                              
                               <td>
                                   <h6 style="color: #172e81;"><b>PHYSICS</b></h6>
                               </td>
                               <td>
                                   <input id="RNPHY" runat="server" style="width: 70%;" />
                                   &nbsp;<a><i class="fa fa-copy"></i></a></td>
                               <td>

                                   <asp:DropDownList ID="MOPPHY" runat="server" Style="width: 70%; height: 30px">
                                       <asp:ListItem Value="" Disabled="True" Selected="True">Select</asp:ListItem>
                                       <asp:ListItem Value="January">January</asp:ListItem>
                                       <asp:ListItem Value="February">February</asp:ListItem>
                                       <asp:ListItem Value="March">March</asp:ListItem>
                                       <asp:ListItem Value="April">April</asp:ListItem>
                                       <asp:ListItem Value="May">May</asp:ListItem>
                                       <asp:ListItem Value="June">June</asp:ListItem>
                                       <asp:ListItem Value="July">July</asp:ListItem>
                                       <asp:ListItem Value="August">August</asp:ListItem>
                                       <asp:ListItem Value="September">September</asp:ListItem>
                                       <asp:ListItem Value="October">October</asp:ListItem>
                                       <asp:ListItem Value="November">November</asp:ListItem>
                                       <asp:ListItem Value="December">December</asp:ListItem>
                                   </asp:DropDownList>
                                   &nbsp;<a><i class="fa fa-copy"></i></a>

                               </td>
                               <td>
                                   <input id="YOPPHY" runat="server" style="width: 70%;" />
                                   &nbsp;<a><i class="fa fa-copy"></i></a></td>
                               <td>
                                   <asp:DropDownList ID="MAXMARKSPHY" runat="server" Style="width: 80%; height: 30px">
                                       <asp:ListItem Value="" Disabled="True" Selected="True">Select </asp:ListItem>
                                       <asp:ListItem Value="100">100</asp:ListItem>
                                       <asp:ListItem Value="150">150</asp:ListItem>
                                       <asp:ListItem Value="200">200</asp:ListItem>
                                       <asp:ListItem Value="250">250</asp:ListItem>
                                       <asp:ListItem Value="300">300</asp:ListItem>
                                       <asp:ListItem Value="350">350</asp:ListItem>
                                       <asp:ListItem Value="400">400</asp:ListItem>
                                   </asp:DropDownList>

                               </td>
                               <td>
                                   <input id="OBTMARKSPHY" runat="server" style="width: 50%;" />
                               </td>
                           </tr>

                           <tr>
                               
                               <td>
                                   <h6 style="color: #172e81;"><b>CHEMISTRY</b></h6>
                               </td>
                               <td>
                                   <input id="RNCHE" runat="server" style="width: 70%;" />
                               </td>
                               <td>

                                   <asp:DropDownList ID="MOPCHE" runat="server" Style="width: 70%; height: 30px">
                                       <asp:ListItem Value="" Disabled="True" Selected="True">Select</asp:ListItem>
                                       <asp:ListItem Value="January">January</asp:ListItem>
                                       <asp:ListItem Value="February">February</asp:ListItem>
                                       <asp:ListItem Value="March">March</asp:ListItem>
                                       <asp:ListItem Value="April">April</asp:ListItem>
                                       <asp:ListItem Value="May">May</asp:ListItem>
                                       <asp:ListItem Value="June">June</asp:ListItem>
                                       <asp:ListItem Value="July">July</asp:ListItem>
                                       <asp:ListItem Value="August">August</asp:ListItem>
                                       <asp:ListItem Value="September">September</asp:ListItem>
                                       <asp:ListItem Value="October">October</asp:ListItem>
                                       <asp:ListItem Value="November">November</asp:ListItem>
                                       <asp:ListItem Value="December">December</asp:ListItem>
                                   </asp:DropDownList>


                               </td>
                               <td>
                                   <input id="YOPCHE" runat="server" style="width: 70%;" />
                               </td>
                               <td>
                                   <asp:DropDownList ID="MAXMARKSCHE" runat="server" Style="width: 80%; height: 30px">
                                       <asp:ListItem Value="" Disabled="True" Selected="True">Select </asp:ListItem>
                                       <asp:ListItem Value="100">100</asp:ListItem>
                                       <asp:ListItem Value="150">150</asp:ListItem>
                                       <asp:ListItem Value="200">200</asp:ListItem>
                                       <asp:ListItem Value="250">250</asp:ListItem>
                                       <asp:ListItem Value="300">300</asp:ListItem>
                                       <asp:ListItem Value="350">350</asp:ListItem>
                                       <asp:ListItem Value="400">400</asp:ListItem>
                                   </asp:DropDownList>

                               </td>
                               <td>
                                   <input id="OBTMARKSCHE" runat="server" style="width: 50%;" />
                               </td>
                           </tr>

                           <tr  >
                              
                               <td>
                                   <h6 style="color: #172e81;"><b>BOTANY</b></h6>
                               </td>
                               <td>
                                   <input id="RNBOT" runat="server" style="width: 70%;" />
                               </td>
                               <td>

                                   <asp:DropDownList ID="MOPBOT" runat="server" Style="width: 70%; height: 30px">
                                       <asp:ListItem Value="" Disabled="True" Selected="True">Select</asp:ListItem>
                                       <asp:ListItem Value="January">January</asp:ListItem>
                                       <asp:ListItem Value="February">February</asp:ListItem>
                                       <asp:ListItem Value="March">March</asp:ListItem>
                                       <asp:ListItem Value="April">April</asp:ListItem>
                                       <asp:ListItem Value="May">May</asp:ListItem>
                                       <asp:ListItem Value="June">June</asp:ListItem>
                                       <asp:ListItem Value="July">July</asp:ListItem>
                                       <asp:ListItem Value="August">August</asp:ListItem>
                                       <asp:ListItem Value="September">September</asp:ListItem>
                                       <asp:ListItem Value="October">October</asp:ListItem>
                                       <asp:ListItem Value="November">November</asp:ListItem>
                                       <asp:ListItem Value="December">December</asp:ListItem>
                                   </asp:DropDownList>


                               </td>
                               <td>
                                   <input id="YOPBOT" runat="server" style="width: 70%;" />
                               </td>
                               <td>
                                   <asp:DropDownList ID="MAXMARKSBOT" runat="server" Style="width: 80%; height: 30px">
                                       <asp:ListItem Value="" Disabled="True" Selected="True">Select </asp:ListItem>
                                       <asp:ListItem Value="100">100</asp:ListItem>
                                       <asp:ListItem Value="150">150</asp:ListItem>
                                       <asp:ListItem Value="200">200</asp:ListItem>
                                       <asp:ListItem Value="250">250</asp:ListItem>
                                       <asp:ListItem Value="300">300</asp:ListItem>
                                       <asp:ListItem Value="350">350</asp:ListItem>
                                       <asp:ListItem Value="400">400</asp:ListItem>
                                   </asp:DropDownList>

                               </td>
                               <td>
                                   <input id="OBTMARKSBOT" runat="server" style="width: 50%;" />
                               </td>
                           </tr>

                           <tr>
                               
                               <td>
                                   <h6 style="color: #172e81;"><b>ZOOLOGY</b></h6>
                               </td>
                               <td>
                                   <input id="RNZOO" runat="server" style="width: 70%;" />
                               </td>
                               <td>

                                   <asp:DropDownList ID="MOPZOO" runat="server" Style="width: 70%; height: 30px">
                                       <asp:ListItem Value="" Disabled="True" Selected="True">Select</asp:ListItem>
                                       <asp:ListItem Value="January">January</asp:ListItem>
                                       <asp:ListItem Value="February">February</asp:ListItem>
                                       <asp:ListItem Value="March">March</asp:ListItem>
                                       <asp:ListItem Value="April">April</asp:ListItem>
                                       <asp:ListItem Value="May">May</asp:ListItem>
                                       <asp:ListItem Value="June">June</asp:ListItem>
                                       <asp:ListItem Value="July">July</asp:ListItem>
                                       <asp:ListItem Value="August">August</asp:ListItem>
                                       <asp:ListItem Value="September">September</asp:ListItem>
                                       <asp:ListItem Value="October">October</asp:ListItem>
                                       <asp:ListItem Value="November">November</asp:ListItem>
                                       <asp:ListItem Value="December">December</asp:ListItem>
                                   </asp:DropDownList>


                               </td>
                               <td>
                                   <input id="YOPZOO" runat="server" style="width: 70%;" />
                               </td>
                               <td>
                                   <asp:DropDownList ID="MAXMARKSZOO" runat="server" Style="width: 80%; height: 30px">
                                       <asp:ListItem Value="" Disabled="True" Selected="True">Select </asp:ListItem>
                                       <asp:ListItem Value="100">100</asp:ListItem>
                                       <asp:ListItem Value="150">150</asp:ListItem>
                                       <asp:ListItem Value="200">200</asp:ListItem>
                                       <asp:ListItem Value="250">250</asp:ListItem>
                                       <asp:ListItem Value="300">300</asp:ListItem>
                                       <asp:ListItem Value="350">350</asp:ListItem>
                                       <asp:ListItem Value="400">400</asp:ListItem>
                                   </asp:DropDownList>

                               </td>
                               <td>
                                   <input id="OBTMARKSZOO" runat="server" style="width: 50%;" />
                               </td>
                           </tr>

                       </tbody>

                   </table>







               </div>


          <div class="border border-indo mt-2 mb-2" style="border-bottom:none;">

          </div>






           <div class="container-fluid">

               <div class="row">

                   
                   <div class="col-5">

                        <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">MEDIUM OF INSTRUCTION </h6>

                   </div>

                   <div class="col-7 mt-2">
                       <asp:DropDownList ID="ddlMediumOfInstruction" runat="server" Style="width: 50%;height:25px" class="mb-2">
                           <asp:ListItem Value="" Disabled="True" Selected="True">-- Select --</asp:ListItem>
                           
                       </asp:DropDownList>

                   </div>

               </div>


               <div class="row">


                   <div class="col-5 ">

                       <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">CIVIC SCHOOL</h6>

                   </div>

                   <div class="col-7 mt-2">
                       <asp:DropDownList ID="ddlCivicSchool" runat="server" Style="width: 50%; height: 25px;">
                           <asp:ListItem Value="" Disabled="True" Selected="True">-- Select --</asp:ListItem>
                          
                       </asp:DropDownList>


                   </div>

               </div>



               <div class="row">


                   <div class="col-5 ">

                       <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">CIVIC NATIVE</h6>

                   </div>

                   <div class="col-7 mt-2">
                       <asp:DropDownList ID="ddlCivicNative" runat="server" Style="width: 50%; height: 25px;">
                           <asp:ListItem Value="" Disabled="True" Selected="True">-- Select --</asp:ListItem>
                          
                       </asp:DropDownList>


                   </div>

               </div>




           </div>


              <div>
    <table class="table table-bordered mt-2">
        <thead class="table-secondary fw-bold">
            <tr class="text-center align-middle">
                <td>CLASS</td>
                <td>YEAR OF PASSING</td>
                <td>NAME OF THE SCHOOL</td>
                <td>STATE</td>
                <td>DISTRICT</td>
            </tr>
        </thead>
        <tbody style="border-top:3px solid grey">

            <tr >
                <td><h6 style="color: #172e81;"><b>VI</b></h6></td>
                <td><input id="YOP6" runat="server" style="width:40%;" /> &nbsp; <i class="fa fa-angle-down"> </i></td>
                <td><input id="NOTS6" runat="server" style="width:270px" /> &nbsp;<a><i class="fa fa-copy"></i></a></td>
                <td>
                    <asp:DropDownList ID="STATE6" runat="server" Style="width: 100px;">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select  </asp:ListItem>
                        
                    </asp:DropDownList>
                   &nbsp;<a><i class="fa fa-copy"></i></a>

                </td>
                <td>
                    <asp:DropDownList ID="DISTRICT6" runat="server" Style="width: 100px; ">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select </asp:ListItem>
                       
                    </asp:DropDownList>
                    &nbsp;<a><i class="fa fa-copy"></i></a>

                </td>
            </tr>

            <tr>
                <td>
                    <h6 style="color: #172e81;"><b>VII</b></h6>
                </td>
                <td>
                    <input id="YOP7" runat="server" style="width: 40%;" />
                 </td>
                <td>
                    <input id="NOTS7" runat="server" style="width: 270px" />
                </td>
                <td>
                    <asp:DropDownList ID="STATE7" runat="server" Style="width: 100px;">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select  </asp:ListItem>
                        
                    </asp:DropDownList>
                    

                </td>
                <td>
                    <asp:DropDownList ID="DISTRICT7" runat="server" Style="width: 100px;">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select </asp:ListItem>
                       
                    </asp:DropDownList>
                    

                </td>
            </tr>

            <tr>
                <td>
                    <h6 style="color: #172e81;"><b>VIII</b></h6>
                </td>
                <td>
                    <input id="YOP8" runat="server" style="width: 40%;" />
                    </td>
                <td>
                    <input id="NOTS8" runat="server" style="width: 270px" />
                   </td>
                <td>
                    <asp:DropDownList ID="STATE8" runat="server" Style="width: 100px;">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select  </asp:ListItem>

                    </asp:DropDownList>
                    

                </td>
                <td>
                    <asp:DropDownList ID="DISTRICT8" runat="server" Style="width: 100px;">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select </asp:ListItem>
                       
                    </asp:DropDownList>
                   

                </td>
            </tr>

            <tr>
                <td>
                    <h6 style="color: #172e81;"><b>IX</b></h6>
                </td>
                <td>
                    <input id="YOP9" runat="server" style="width: 40%;" />
                    </td>
                <td>
                    <input id="NOTS9" runat="server" style="width: 270px" />
                   </td>
                <td>
                    <asp:DropDownList ID="STATE9" runat="server" Style="width: 100px;">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select  </asp:ListItem>

                    </asp:DropDownList>
                   

                </td>
                <td>
                    <asp:DropDownList ID="DISTRICT9" runat="server" Style="width: 100px;">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select </asp:ListItem>
                        
                    </asp:DropDownList>
                   

                </td>
            </tr>

            <tr>
                <td>
                    <h6 style="color: #172e81;"><b>X</b></h6>
                </td>
                <td>
                    <input id="YOP10" runat="server" style="width: 40%;" />
                    </td>
                <td>
                    <input id="NOTS10" runat="server" style="width: 270px" />
                   </td>
                <td>
                    <asp:DropDownList ID="STATE10" runat="server" Style="width: 100px;">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select  </asp:ListItem>

                    </asp:DropDownList>
                   

                </td>
                <td>
                    <asp:DropDownList ID="DISTRICT10" runat="server" Style="width: 100px;">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select </asp:ListItem>
                       
                    </asp:DropDownList>
                   

                </td>
            </tr>

            <tr>
                <td>
                    <h6 style="color: #172e81;"><b>XI</b></h6>
                </td>
                <td>
                    <input id="YOP11" runat="server" style="width: 40%;" />
                    </td>
                <td>
                    <input id="NOTS11" runat="server" style="width: 270px" />
                    </td>
                <td>
                    <asp:DropDownList ID="STATE11" runat="server" Style="width: 100px;">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select  </asp:ListItem>

                    </asp:DropDownList>
                  

                </td>
                <td>
                    <asp:DropDownList ID="DISTRICT11" runat="server" Style="width: 100px;">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select </asp:ListItem>
                       
                    </asp:DropDownList>
                 

                </td>
            </tr>

            <tr>
                <td>
                    <h6 style="color: #172e81;"><b>XII</b></h6>
                </td>
                <td>
                    <input id="YOP12" runat="server" style="width: 40%;" />
                    </td>
                <td>
                    <input id="NOTS12" runat="server" style="width: 270px" />
                    </td>
                <td>
                    <asp:DropDownList ID="STATE12" runat="server" Style="width: 100px;">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select  </asp:ListItem>

                    </asp:DropDownList>
                    

                </td>
                <td>
                    <asp:DropDownList ID="DISTRICT12" runat="server" Style="width: 100px;">
                        <asp:ListItem Value="" Disabled="True" Selected="True">-- Select </asp:ListItem>
            
                    </asp:DropDownList>
                    

                </td>
            </tr>



        </tbody>
    </table>
</div>



           <div class="border border-indo mt-2 mb-2" style="border-bottom: none;">
           </div>


           <div class="container-fluid">

               <div class="row ">

                   <div class="col-5">

                        <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">NUMBER OF NEET ATTEMPT</h6>

                   </div>

                   <div class="col-7 mt-2">

                       <asp:DropDownList ID="NEETATTEMPT" runat="server" Style="width: 40%; height: 30px">
                           <asp:ListItem Value="1st Attempt" Selected="True">1st Attempt</asp:ListItem>
                           <asp:ListItem Value="2nd Attempt">2nd Attempt</asp:ListItem>
                           <asp:ListItem Value="3rd Attempt">3rd Attempt</asp:ListItem>
                           <asp:ListItem Value="4th Attempt">4th Attempt</asp:ListItem>
                           <asp:ListItem Value="5th Attempt">5th Attempt</asp:ListItem>
                           <asp:ListItem Value="More than 5 Attempts">More than 5 Attempts</asp:ListItem>
                       </asp:DropDownList>

                   </div>

               </div>



               <div class="row">

                   <div class="col-5">

                         <h6 style="color: #172e81; margin-bottom: 4px;" class="pt-3">DID YOU WENT TO NEET COACHING</h6>

                   </div>

                   <div class="col-7 mt-2">


                    
                       <asp:RadioButtonList ID="NeetCoachingOptions" runat="server" RepeatDirection="Horizontal">
                           <asp:ListItem Text="Yes" Value="Yes"  ></asp:ListItem>
                           <asp:ListItem Text="No" Value="No" Selected="True"  style="padding-left:10px;"></asp:ListItem>
                       </asp:RadioButtonList>


                   </div>

               </div>



           </div>


           
                <div class=" d-flex justify-content-center align-items-center mb-3 mt-2" style="background-color: #dcebfb; box-sizing: border-box; ">


    <asp:Button  ID="btnSaveContinue" runat="server" class="btn btn-primary mt-1 mb-1" OnClick="btnSaveContinue_Click" Text="Save & Continue "></asp:Button>


 </div>

       </div>


</div>



</asp:Content>
