<%@ Page Title="" Language="C#" MasterPageFile="~/MBBS-BDS.Master" AutoEventWireup="true" CodeBehind="upload.aspx.cs" Inherits="MBBS_WEBSITE.upload" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


       <div style="box-shadow: 0px 0px 50px grey; padding-top: 1px; padding-bottom: 1px;" class="mt-2 ms-3 mb-2 me-3">

       <div class="border border-info ms-2 mt-1 me-2" style="border-radius: 5px;">

           <div class="ps-3 pt-1 pb-1 " style="background-color: #dcebfb; box-sizing: border-box; border-radius: 5px;">
               <h5 style="color: #172e81"> DOCUMENTS UPLOAD  </h5>
           </div>




           <div class="border border-dark mt-3">

               <div class="container-fluid">

                   <div class="row">

                       <div class="col-6 pt-1 pb-1">
                           <h6 style="color: #172e81">LEFT THUMB IMPRESSION  </h6>
                           <span style="background-color: pink; font-size: small">Image 40mm X 60mm JPG format and filesize should be between </span>
                           <br />
                           <span style="background-color: pink; font-size: small">10KB and 50KB</span>
                           <br />
                           <b style="color:green;font-size: small" id="lblLeftThumbImpression" runat="server"></b>
                           <br />
                            <asp:HyperLink ID="viewImageLink" runat="server" NavigateUrl="#" Target="_blank" 
                               Text="[VIEW IMAGE]" Style="color: green; font-size: small;" Visible="false"></asp:HyperLink>
                       </div>

                       <div class="col-6 pt-1 ">

                          

                           <asp:FileUpload ID="LeftThumbImpressionFileUpload" runat="server" />
                           <asp:Button ID="btnLeftThumbImpressionUploadFile" runat="server" Text="Upload" Style="border: 1px solid; padding: 5px 10px;" CssClass="ms-0"  OnClick="btnLeftThumbImpressionUploadFile_Click"/>

                       </div>

                   </div>


               </div>

           </div>


           <div class="border border-dark ">

               <div class="container-fluid">

                   <div class="row">

                       <div class="col-6 pt-1 pb-1">
                           <h6 style="color: #172e81">LATEST PASSPORT SIZE PHOTO  </h6>
                           <span style="background-color: pink; font-size: small">Image 35mm X 45mm JPG format and filesize should be between </span>
                           <br />
                           <span style="background-color: pink; font-size: small">50KB and 100KB</span>
                           <br />
                           <b style="color: green; font-size: small" id="B1" runat="server"></b>
                           <br />
                           <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="#" Target="_blank"
                               Text="[VIEW IMAGE]" Style="color: green; font-size: small;" Visible="false">
                           </asp:HyperLink>
                       </div>

                       <div class="col-6 pt-1 ">

                           <asp:FileUpload ID="FileUpload1" runat="server" />
                           <asp:Button ID="Button1" runat="server" Text="Upload" Style="border: 1px solid; padding: 5px 10px;" CssClass="ms-0"  OnClick="btnButton1_Click"/>

                       </div>

                   </div>


               </div>

           </div>

           

            <div class="border border-dark ">

     <div class="container-fluid">

         <div class="row">

             <div class="col-6 pt-1 pb-1">
                 <h6 style="color: #172e81">POST CARD SIZE PHOTO  </h6>
                 <span style="background-color: pink; font-size: small">Image 140mm X 90mm JPG format and filesize should be between </span>
                 <br />
                 <span style="background-color: pink; font-size: small">100KB and 300KB</span>
                 <br />
                 <b style="color: green; font-size: small" id="B2" runat="server"></b>
                 <br />
                 <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="#" Target="_blank"
                     Text="[VIEW IMAGE]" Style="color: green; font-size: small;" Visible="false">
                 </asp:HyperLink>
             </div>

             <div class="col-6 pt-1 ">

                 <asp:FileUpload ID="FileUpload2" runat="server" />
                 <asp:Button ID="Button2" runat="server" Text="Upload" Style="border: 1px solid; padding: 5px 10px;" CssClass="ms-0" OnClick="btnButton2_Click" />

             </div>

         </div>


     </div>

 </div>


           <div class="border border-dark ">

               <div class="container-fluid">

                   <div class="row">

                       <div class="col-6 pt-1 pb-1">
                           <h6 style="color: #172e81">SSLC MARK SHEET  </h6>
                           <span style="background-color: pink; font-size: small">File in PDF format and file size should not exceed 3MB</span>
                           <br />
                           <b style="color: green; font-size: small" id="B3" runat="server"></b>
                           <br />
                           <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="#" Target="_blank"
                               Text="[VIEW IMAGE]" Style="color: green; font-size: small;" Visible="false">
                           </asp:HyperLink>
                       </div>

                       <div class="col-6 pt-1 ">

                           <asp:FileUpload ID="FileUpload3" runat="server" />
                           <asp:Button ID="Button3" runat="server" Text="Upload" Style="border: 1px solid; padding: 5px 10px;" CssClass="ms-0" OnClick="btnButton3_Click" />

                       </div>

                   </div>


               </div>

           </div>


           <div class="border border-dark ">

               <div class="container-fluid">

                   <div class="row">

                       <div class="col-6 pt-1 pb-1">
                           <h6 style="color: #172e81">HSC MARK SHEET  </h6>
                           <span style="background-color: pink; font-size: small">File in PDF format and file size should not exceed 3MB </span>
                           <br />
                           <b style="color: green; font-size: small" id="B4" runat="server"></b>
                           <br />
                           <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="#" Target="_blank"
                               Text="[VIEW IMAGE]" Style="color: green; font-size: small;" Visible="false">
                           </asp:HyperLink>

                       </div>

                       <div class="col-6 pt-1 ">

                           <asp:FileUpload ID="FileUpload4" runat="server" />
                           <asp:Button ID="Button4" runat="server" Text="Upload" Style="border: 1px solid; padding: 5px 10px;" CssClass="ms-0" OnClick="btnButton4_Click" />

                       </div>

                   </div>


               </div>

           </div>


           <div class="border border-dark ">

               <div class="container-fluid">

                   <div class="row">

                       <div class="col-6 pt-1 pb-1">
                           <h6 style="color: #172e81">NEET SCORE CARD </h6>
                           <span style="background-color: pink; font-size: small">File in PDF format and file size should not exceed 3MB</span>
                           <br />
                           <b style="color: green; font-size: small" id="B5" runat="server"></b>
                           <br />
                           <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="#" Target="_blank"
                               Text="[VIEW IMAGE]" Style="color: green; font-size: small;" Visible="false">
                           </asp:HyperLink>
                       </div>

                       <div class="col-6 pt-1 ">

                           <asp:FileUpload ID="FileUpload5" runat="server" />
                           <asp:Button ID="Button5" runat="server" Text="Upload" Style="border: 1px solid; padding: 5px 10px;" CssClass="ms-0" OnClick="btnButton5_Click" />

                       </div>

                   </div>


               </div>

           </div>



           <div class="border border-dark ">

               <div class="container-fluid">

                   <div class="row">

                       <div class="col-6 pt-1 pb-1">
                           <h6 style="color: #172e81">TRANSFER CERTIFICATE  </h6>
                           <span style="background-color: pink; font-size: small">File in PDF format and file size should not exceed 3MB </span>
                           <br />
                           <b style="color: green; font-size: small" id="B6" runat="server"></b>
                           <br />
                           <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="#" Target="_blank"
                               Text="[VIEW IMAGE]" Style="color: green; font-size: small;" Visible="false">
                           </asp:HyperLink>
                       </div>

                       <div class="col-6 pt-1 ">

                          
                           <asp:FileUpload ID="FileUpload6" runat="server" />
                           <asp:Button ID="Button6" runat="server" Text="Upload" Style="border: 1px solid; padding: 5px 10px;" CssClass="ms-0" OnClick="btnButton6_Click" />

                       </div>

                   </div>


               </div>

           </div>



           <div class="border border-dark ">

               <div class="container-fluid">

                   <div class="row">

                       <div class="col-6 pt-1 pb-1">
                           <h6 style="color: #172e81">SCHOOL BONAFIDE CERTIFICATE  </h6>
                           <span style="background-color: pink; font-size: small">File in PDF format and file size should not exceed 3MB </span>
                           <br />
                           <b style="color: green; font-size: small" id="B7" runat="server"></b>
                           <br />
                           <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="#" Target="_blank"
                               Text="[VIEW IMAGE]" Style="color: green; font-size: small;" Visible="false">
                           </asp:HyperLink>
                       </div>

                       <div class="col-6 pt-1 ">

                           <asp:FileUpload ID="FileUpload7" runat="server" />
                           <asp:Button ID="Button7" runat="server" Text="Upload" Style="border: 1px solid; padding: 5px 10px;" CssClass="ms-0" OnClick="btnButton7_Click" />

                       </div>

                   </div>


               </div>

           </div>




           <div class="border border-dark ">

               <div class="container-fluid">

                   <div class="row">

                       <div class="col-6 pt-1 pb-1">
                           <h6 style="color: #172e81">COMMUNITY CERTIFICATE  </h6>
                           <span style="background-color: pink; font-size: small">File in PDF format and file size should not exceed 3MB </span>
                           <br />
                           <b style="color: green; font-size: small" id="B8" runat="server"></b>
                           <br />
                           <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="#" Target="_blank"
                               Text="[VIEW IMAGE]" Style="color: green; font-size: small;" Visible="false">
                           </asp:HyperLink>
                       </div>

                       <div class="col-6 pt-1 ">

                           <asp:FileUpload ID="FileUpload8" runat="server" />
                           <asp:Button ID="Button8" runat="server" Text="Upload" Style="border: 1px solid; padding: 5px 10px;" CssClass="ms-0" OnClick="btnButton8_Click" />

                       </div>

                   </div>


               </div>

           </div>



           <div class="border border-dark ">

               <div class="container-fluid">

                   <div class="row">

                       <div class="col-6 pt-1 pb-1">
                           <h6 style="color: #172e81">NATIVITY CERTIFICATE  </h6>
                           <span style="background-color: pink; font-size: small">File in PDF format and file size should not exceed 3MB </span>
                           <br />
                           <b style="color: green; font-size: small" id="B9" runat="server"></b>
                           <br />
                           <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="#" Target="_blank"
                               Text="[VIEW IMAGE]" Style="color: green; font-size: small;" Visible="false">
                           </asp:HyperLink>
                       </div>

                       <div class="col-6 pt-1 ">

                           <asp:FileUpload ID="FileUpload9" runat="server" />
                           <asp:Button ID="Button9" runat="server" Text="Upload" Style="border: 1px solid; padding: 5px 10px;" CssClass="ms-0" OnClick="btnButton9_Click" />

                       </div>

                   </div>


               </div>

           </div>



           <div class="border border-dark ">

               <div class="container-fluid">

                   <div class="row">

                       <div class="col-6 pt-1 pb-1">
                           <h6 style="color: #172e81">PARENT COMMUNITY CERTIFICATE  </h6>
                           <span style="background-color: pink; font-size: small">File in PDF format and file size should not exceed 3MB </span>
                           <br />
                           <b style="color: green; font-size: small" id="B10" runat="server"></b>
                           <br />
                           <asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="#" Target="_blank"
                               Text="[VIEW IMAGE]" Style="color: green; font-size: small;" Visible="false">
                           </asp:HyperLink>
                       </div>

                       <div class="col-6 pt-1 ">

                           <asp:FileUpload ID="FileUpload10" runat="server" />
                           <asp:Button ID="Button10" runat="server" Text="Upload" Style="border: 1px solid; padding: 5px 10px;" CssClass="ms-0" OnClick="btnButton10_Click" />

                       </div>

                   </div>


               </div>

           </div>




           <div class="border border-dark ">

               <div class="container-fluid">

                   <div class="row">

                       <div class="col-6 pt-1 pb-1">
                           <h6 style="color: #172e81">PARENT STUDY CERTIFICATE (10<sup>TH</sup>/12<sup>TH</sup>/DEGREE)  </h6>
                           <span style="background-color: pink; font-size: small">File in PDF format and file size should not exceed 3MB </span>
                           <br />
                           <b style="color: green; font-size: small" id="B11" runat="server"></b>
                           <br />
                           <asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="#" Target="_blank"
                               Text="[VIEW IMAGE]" Style="color: green; font-size: small;" Visible="false">
                           </asp:HyperLink>
                       </div>

                       <div class="col-6 pt-1 ">

                           <asp:FileUpload ID="FileUpload11" runat="server" />
                           <asp:Button ID="Button11" runat="server" Text="Upload" Style="border: 1px solid; padding: 5px 10px;" CssClass="ms-0" OnClick="btnButton11_Click" />

                       </div>

                   </div>


               </div>

           </div>



           <div class="border border-dark ">

                <div class="container-fluid">

                    <div class="row">

                        <div class="col-6 pt-1 pb-1">
                            <h6 style="color: #172e81">PARENT ADDRESS PROOF(DL/VOTER ID/ETC.,)  </h6>
                            <span style="background-color: pink; font-size: small">File in PDF format and file size should not exceed 3MB </span>
                            <br />
                            <b style="color: green; font-size: small" id="B12" runat="server"></b>
                            <br />
                            <asp:HyperLink ID="HyperLink12" runat="server" NavigateUrl="#" Target="_blank"
                                Text="[VIEW IMAGE]" Style="color: green; font-size: small;" Visible="false">
                            </asp:HyperLink>
                        </div>

                        <div class="col-6 pt-1 ">

                            <asp:FileUpload ID="FileUpload12" runat="server" />
                            <asp:Button ID="Button12" runat="server" Text="Upload" Style="border: 1px solid; padding: 5px 10px;" CssClass="ms-0" OnClick="btnButton12_Click" />

                        </div>

                    </div>


                </div>

            </div>

           
           <div class=" d-flex justify-content-center align-items-center  mt-2" style="background-color: #dcebfb; box-sizing: border-box;">


              <asp:Button  ID="btnSaveContinue" runat="server" class="btn btn-primary mt-1 mb-1" OnClick="btnSaveContinue_Click" Text="Save & Continue "></asp:Button>


           </div>

       </div>

</div>
   

</asp:Content>
