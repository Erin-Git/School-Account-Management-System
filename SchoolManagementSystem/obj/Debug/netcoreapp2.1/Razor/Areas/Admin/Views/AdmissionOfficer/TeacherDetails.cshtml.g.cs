#pragma checksum "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b612c429fc71f3c409b1ed764fdf9c23ad10acde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdmissionOfficer_TeacherDetails), @"mvc.1.0.view", @"/Areas/Admin/Views/AdmissionOfficer/TeacherDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdmissionOfficer/TeacherDetails.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdmissionOfficer_TeacherDetails))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\_ViewImports.cshtml"
using SchoolManagementSystem;

#line default
#line hidden
#line 2 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\_ViewImports.cshtml"
using SchoolManagementSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b612c429fc71f3c409b1ed764fdf9c23ad10acde", @"/Areas/Admin/Views/AdmissionOfficer/TeacherDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d07f01e3c07cc979b1fe4cd526aeaff34bec21", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdmissionOfficer_TeacherDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolManagementSystem.Areas.Admin.AdminVM.TeacherViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/ruthson-zimmerman-233522-unsplash.jpg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Teacher\'s Photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:left;height:auto;max-width:100%;border-radius:5px 5px;box-shadow:0 5px 20px #686868;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 845, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""jumbotron"" style=""margin-top:20px;margin-left:10%; background-color:ghostwhite; box-shadow:0 5px 15px #686868;border-radius:10px 15px;width:80%;"">
        <h1 style=""text-align:center;font-family:'Century Gothic';font-weight:bold;"">Teacher's Details</h1>
        <hr style=""width:90%;"" />



        <h3 style=""text-align:center;font-family:'Century Gothic';font-style:italic;"">Teacher's Information</h3>
        <hr style=""width:50%;font-weight:bolder;text-align:left;"" />
        <div class=""row"" style=""margin-top:30px;"">

            <div class=""col-xs-8 col-sm-8 col-md-8 col-lg-8"">
                <table class=""table table-responsive"">
                    <tbody>

                        <tr>
                            <td>Teacher's Name:</td>
                            <td>");
            EndContext();
            BeginContext(914, 15, false);
#line 20 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrnameVM);

#line default
#line hidden
            EndContext();
            BeginContext(929, 151, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Designation:</td>\r\n                            <td>");
            EndContext();
            BeginContext(1081, 16, false);
#line 24 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrdesigVM);

#line default
#line hidden
            EndContext();
            BeginContext(1097, 151, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Nationality:</td>\r\n                            <td>");
            EndContext();
            BeginContext(1249, 17, false);
#line 28 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrnationVM);

#line default
#line hidden
            EndContext();
            BeginContext(1266, 146, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Gender:</td>\r\n                            <td>");
            EndContext();
            BeginContext(1413, 17, false);
#line 32 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrgenderVM);

#line default
#line hidden
            EndContext();
            BeginContext(1430, 153, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Date of Birth:</td>\r\n                            <td>");
            EndContext();
            BeginContext(1584, 14, false);
#line 36 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrdobVM);

#line default
#line hidden
            EndContext();
            BeginContext(1598, 151, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Blood Group:</td>\r\n                            <td>");
            EndContext();
            BeginContext(1750, 13, false);
#line 40 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrbgVM);

#line default
#line hidden
            EndContext();
            BeginContext(1763, 147, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Contact:</td>\r\n                            <td>");
            EndContext();
            BeginContext(1911, 16, false);
#line 44 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrphoneVM);

#line default
#line hidden
            EndContext();
            BeginContext(1927, 154, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>E-mail Address:</td>\r\n                            <td>");
            EndContext();
            BeginContext(2082, 16, false);
#line 48 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcremailVM);

#line default
#line hidden
            EndContext();
            BeginContext(2098, 155, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Current Address:</td>\r\n                            <td>");
            EndContext();
            BeginContext(2254, 18, false);
#line 52 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrcaddrssVM);

#line default
#line hidden
            EndContext();
            BeginContext(2272, 157, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Permanent Address:</td>\r\n                            <td>");
            EndContext();
            BeginContext(2430, 18, false);
#line 56 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrpaddrssVM);

#line default
#line hidden
            EndContext();
            BeginContext(2448, 195, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <div class=\"col-xs-4 col-sm-4 col-md-4 col-lg-4\">\r\n                ");
            EndContext();
            BeginContext(2643, 230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14156cb38ef844b5864fafa447adc22f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 63 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2873, 597, true);
            WriteLiteral(@"

            </div>
        </div>




        <h3 style=""text-align:center;font-family:'Century Gothic';font-style:italic;"">About Teacher's Qualification</h3>
        <hr style=""width:50%;font-weight:bolder;text-align:left;"" />
        <div class=""row"" style=""margin-top:30px;"">
            <div class=""col-xs-12 col-sm-12 col-md-10 col-md-offset-1 col-lg-10 col-lg-offset-1"">
                <table class=""table table-responsive"">
                    <tbody>

                        <tr>
                            <td>Insitution of SSC:</td>
                            <td>");
            EndContext();
            BeginContext(3471, 18, false);
#line 80 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrqsscinsVM);

#line default
#line hidden
            EndContext();
            BeginContext(3489, 156, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>SSC Passing Year:</td>\r\n                            <td>");
            EndContext();
            BeginContext(3646, 19, false);
#line 84 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrqsscyearVM);

#line default
#line hidden
            EndContext();
            BeginContext(3665, 150, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>GPA of SSC:</td>\r\n                            <td>");
            EndContext();
            BeginContext(3816, 20, false);
#line 88 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrqsscgradeVM);

#line default
#line hidden
            EndContext();
            BeginContext(3836, 157, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Insitution of HSC:</td>\r\n                            <td>");
            EndContext();
            BeginContext(3994, 18, false);
#line 92 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrqhscinsVM);

#line default
#line hidden
            EndContext();
            BeginContext(4012, 156, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>HSC Passing Year:</td>\r\n                            <td>");
            EndContext();
            BeginContext(4169, 18, false);
#line 96 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrqhscinsVM);

#line default
#line hidden
            EndContext();
            BeginContext(4187, 150, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>GPA of HSC:</td>\r\n                            <td>");
            EndContext();
            BeginContext(4338, 20, false);
#line 100 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrqhscgradeVM);

#line default
#line hidden
            EndContext();
            BeginContext(4358, 158, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Insitution of Hons:</td>\r\n                            <td>");
            EndContext();
            BeginContext(4517, 19, false);
#line 104 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrqhonsinsVM);

#line default
#line hidden
            EndContext();
            BeginContext(4536, 157, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Hons Passing Year:</td>\r\n                            <td>");
            EndContext();
            BeginContext(4694, 20, false);
#line 108 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrqhonsyearVM);

#line default
#line hidden
            EndContext();
            BeginContext(4714, 151, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>GPA of Hons:</td>\r\n                            <td>");
            EndContext();
            BeginContext(4866, 20, false);
#line 112 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                           Write(Model.TcrqhonsyearVM);

#line default
#line hidden
            EndContext();
            BeginContext(4886, 648, true);
            WriteLiteral(@"</td>
                        </tr>

                    </tbody>
                </table>
            </div>
        </div>

        <h3 style=""text-align:center;font-family:'Century Gothic';font-style:italic;"">About Teacher's Documents</h3>
        <hr style=""width:50%;font-weight:bolder;text-align:left;"" />
        <div class=""row"" style=""margin-top:30px;"">
            <div class=""col-xs-12 col-sm-12 col-md-10 col-md-offset-1 col-lg-10 col-lg-offset-1"">
                <table class=""table table-responsive"">
                    <tbody>

                        <tr>
                            <td>Certificate of SSC:</td>
");
            EndContext();
#line 129 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                             if (Model.TcrdocsubssccrtfctVM == true)
                            {

#line default
#line hidden
            BeginContext(5635, 52, true);
            WriteLiteral("                                <td>Submitted</td>\r\n");
            EndContext();
#line 132 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5783, 56, true);
            WriteLiteral("                                <td>Not Submitted</td>\r\n");
            EndContext();
#line 136 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                            }

#line default
#line hidden
            BeginContext(5870, 116, true);
            WriteLiteral("\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Marksheet SSC:</td>\r\n");
            EndContext();
#line 141 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                             if (Model.TcrdocsubsscmarkVM == true)
                            {

#line default
#line hidden
            BeginContext(6085, 52, true);
            WriteLiteral("                                <td>Submitted</td>\r\n");
            EndContext();
#line 144 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(6233, 56, true);
            WriteLiteral("                                <td>Not Submitted</td>\r\n");
            EndContext();
#line 148 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                            }

#line default
#line hidden
            BeginContext(6320, 119, true);
            WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <td>Certificate of HSC:</td>\r\n");
            EndContext();
#line 152 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                             if (Model.TcrdocsubhsccrtfctVM == true)
                            {

#line default
#line hidden
            BeginContext(6540, 52, true);
            WriteLiteral("                                <td>Submitted</td>\r\n");
            EndContext();
#line 155 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(6688, 56, true);
            WriteLiteral("                                <td>Not Submitted</td>\r\n");
            EndContext();
#line 159 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                            }

#line default
#line hidden
            BeginContext(6775, 116, true);
            WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <td>Maksheet of HSC:</td>\r\n");
            EndContext();
#line 163 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                             if (Model.TcrdocsubhscmarkVM == true)
                            {

#line default
#line hidden
            BeginContext(6990, 52, true);
            WriteLiteral("                                <td>Submitted</td>\r\n");
            EndContext();
#line 166 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(7138, 56, true);
            WriteLiteral("                                <td>Not Submitted</td>\r\n");
            EndContext();
#line 170 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                            }

#line default
#line hidden
            BeginContext(7225, 115, true);
            WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <td>Marksheet Hons:</td>\r\n");
            EndContext();
#line 174 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                             if (Model.TcrdocsubhonsmarkVM == true)
                            {

#line default
#line hidden
            BeginContext(7440, 52, true);
            WriteLiteral("                                <td>Submitted</td>\r\n");
            EndContext();
#line 177 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(7588, 56, true);
            WriteLiteral("                                <td>Not Submitted</td>\r\n");
            EndContext();
#line 181 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                            }

#line default
#line hidden
            BeginContext(7675, 120, true);
            WriteLiteral("                        </tr>\r\n                        <tr>\r\n                            <td>Certificate of Hons:</td>\r\n");
            EndContext();
#line 185 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                             if (Model.TcrdocsubhonscrtfctVM == true)
                            {

#line default
#line hidden
            BeginContext(7897, 52, true);
            WriteLiteral("                                <td>Submitted</td>\r\n");
            EndContext();
#line 188 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(8045, 56, true);
            WriteLiteral("                                <td>Not Submitted</td>\r\n");
            EndContext();
#line 192 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\TeacherDetails.cshtml"
                            }

#line default
#line hidden
            BeginContext(8132, 169, true);
            WriteLiteral("                        </tr>\r\n                        \r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolManagementSystem.Areas.Admin.AdminVM.TeacherViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
