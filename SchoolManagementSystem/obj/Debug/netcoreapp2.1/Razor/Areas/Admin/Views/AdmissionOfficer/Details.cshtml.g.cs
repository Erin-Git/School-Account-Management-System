#pragma checksum "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a20b9b24e613257f0136b70f5332ed0cbd624f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdmissionOfficer_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AdmissionOfficer/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdmissionOfficer/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdmissionOfficer_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a20b9b24e613257f0136b70f5332ed0cbd624f2", @"/Areas/Admin/Views/AdmissionOfficer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d07f01e3c07cc979b1fe4cd526aeaff34bec21", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdmissionOfficer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SchoolManagementSystem.Areas.Admin.AdminVM.StudentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/images/ruthson-zimmerman-233522-unsplash.jpg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Student\'s Photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(68, 29, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n");
            EndContext();
            BeginContext(122, 812, true);
            WriteLiteral(@"

    <div class=""jumbotron"" style=""margin-top:20px;margin-left:10%; background-color:ghostwhite; box-shadow:0 5px 15px #686868;border-radius:10px 15px;width:80%;"">
        <h1 style=""text-align:center;font-family:'Century Gothic';font-weight:bold;"">Student's Details</h1>
        <hr style=""width:90%;"" />




        <h3 style=""text-align:center;font-family:'Century Gothic';font-style:italic;"">Student's Information</h3>
        <hr style=""width:50%;font-weight:bolder;text-align:left;"" />
        <div class=""row"" style=""margin-top:30px;"">
            <div class=""col-xs-8 col-sm-8 col-md-8 col-lg-8"">
                <table class=""table table-responsive"">
                    <tbody>

                        <tr>
                            <td>Name:</td>
                            <td>");
            EndContext();
            BeginContext(935, 17, false);
#line 24 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.stdntnameVM);

#line default
#line hidden
            EndContext();
            BeginContext(952, 145, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Class:</td>\r\n                            <td>");
            EndContext();
            BeginContext(1098, 16, false);
#line 28 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.stdntclsVM);

#line default
#line hidden
            EndContext();
            BeginContext(1114, 450, true);
            WriteLiteral(@"</td>
                        </tr>
                        <tr>
                            <td>Section:</td>
                            <td>A</td>
                        </tr>
                        <tr>
                            <td>Roll No:</td>
                            <td>01</td>
                        </tr>
                        <tr>
                            <td>Date of Birth:</td>
                            <td>");
            EndContext();
            BeginContext(1565, 11, false);
#line 40 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.dobVM);

#line default
#line hidden
            EndContext();
            BeginContext(1576, 151, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Nationality:</td>\r\n                            <td>");
            EndContext();
            BeginContext(1728, 19, false);
#line 44 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.stdntnationVM);

#line default
#line hidden
            EndContext();
            BeginContext(1747, 146, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Gender:</td>\r\n                            <td>");
            EndContext();
            BeginContext(1894, 19, false);
#line 48 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.stdntgenderVM);

#line default
#line hidden
            EndContext();
            BeginContext(1913, 151, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Blood Group:</td>\r\n                            <td>");
            EndContext();
            BeginContext(2065, 15, false);
#line 52 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.stdntbgVM);

#line default
#line hidden
            EndContext();
            BeginContext(2080, 159, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td>Date of Admission:</td>\r\n                            <td>");
            EndContext();
            BeginContext(2240, 16, false);
#line 57 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.stdntdoaVM);

#line default
#line hidden
            EndContext();
            BeginContext(2256, 157, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Year of Admission:</td>\r\n                            <td>");
            EndContext();
            BeginContext(2414, 17, false);
#line 61 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.stdntyearVM);

#line default
#line hidden
            EndContext();
            BeginContext(2431, 219, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        \r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <div class=\"col-xs-4 col-sm-4 col-md-4 col-lg-4\">\r\n                ");
            EndContext();
            BeginContext(2650, 230, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "927345b25e634045a03542c7e141b6e8", async() => {
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
#line 68 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
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
            BeginContext(2880, 584, true);
            WriteLiteral(@"

            </div>
        </div>



        <h3 style=""text-align:center;font-family:'Century Gothic';font-style:italic;"">Guardian's Information</h3>
        <hr style=""width:50%;font-weight:bolder;text-align:left;"" />
        <div class=""row"" style=""margin-top:30px;"">
            <div class=""col-xs-12 col-sm-12 col-md-10 col-md-offset-1 col-lg-10 col-lg-offset-1"">
                <table class=""table table-responsive"">
                    <tbody>

                        <tr>
                            <td>Father's Name:</td>
                            <td>");
            EndContext();
            BeginContext(3465, 14, false);
#line 84 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.gnameFVM);

#line default
#line hidden
            EndContext();
            BeginContext(3479, 153, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Mother\'s Name:</td>\r\n                            <td>");
            EndContext();
            BeginContext(3633, 14, false);
#line 88 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.gnameMVM);

#line default
#line hidden
            EndContext();
            BeginContext(3647, 159, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Father\'s Occupation:</td>\r\n                            <td>");
            EndContext();
            BeginContext(3807, 20, false);
#line 92 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.goccupationFVM);

#line default
#line hidden
            EndContext();
            BeginContext(3827, 161, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Father\'s Organization:</td>\r\n                            <td>");
            EndContext();
            BeginContext(3989, 22, false);
#line 96 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.gorganisationFVM);

#line default
#line hidden
            EndContext();
            BeginContext(4011, 160, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Father\'s Designation:</td>\r\n                            <td>");
            EndContext();
            BeginContext(4172, 21, false);
#line 100 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.gdesignationFVM);

#line default
#line hidden
            EndContext();
            BeginContext(4193, 163, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Father\'s E-mail Address:</td>\r\n                            <td>");
            EndContext();
            BeginContext(4357, 15, false);
#line 104 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.gemailMVM);

#line default
#line hidden
            EndContext();
            BeginContext(4372, 164, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Father\'s Phone/Mobile No:</td>\r\n                            <td>");
            EndContext();
            BeginContext(4537, 15, false);
#line 108 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.gphoneFVM);

#line default
#line hidden
            EndContext();
            BeginContext(4552, 159, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Mother\'s Occupation:</td>\r\n                            <td>");
            EndContext();
            BeginContext(4712, 20, false);
#line 112 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.goccupationMVM);

#line default
#line hidden
            EndContext();
            BeginContext(4732, 161, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Mother\'s Organization:</td>\r\n                            <td>");
            EndContext();
            BeginContext(4894, 22, false);
#line 116 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.gorganisationMVM);

#line default
#line hidden
            EndContext();
            BeginContext(4916, 160, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Mother\'s Designation:</td>\r\n                            <td>");
            EndContext();
            BeginContext(5077, 22, false);
#line 120 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.gdesignationsMVM);

#line default
#line hidden
            EndContext();
            BeginContext(5099, 163, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Mother\'s E-mail Address:</td>\r\n                            <td>");
            EndContext();
            BeginContext(5263, 15, false);
#line 124 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.gemailMVM);

#line default
#line hidden
            EndContext();
            BeginContext(5278, 164, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Mother\'s Phone/Mobile No:</td>\r\n                            <td>");
            EndContext();
            BeginContext(5443, 15, false);
#line 128 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.gphoneMVM);

#line default
#line hidden
            EndContext();
            BeginContext(5458, 155, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Current Address:</td>\r\n                            <td>");
            EndContext();
            BeginContext(5614, 20, false);
#line 132 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.stdntcaddrssVM);

#line default
#line hidden
            EndContext();
            BeginContext(5634, 157, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Permanent Address:</td>\r\n                            <td>");
            EndContext();
            BeginContext(5792, 20, false);
#line 136 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\Details.cshtml"
                           Write(Model.stdntpaddrssVM);

#line default
#line hidden
            EndContext();
            BeginContext(5812, 170, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SchoolManagementSystem.Areas.Admin.AdminVM.StudentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
