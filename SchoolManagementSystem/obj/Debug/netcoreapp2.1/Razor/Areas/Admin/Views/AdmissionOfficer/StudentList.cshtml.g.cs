#pragma checksum "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e33a39907df40756732643fdaa99895f669e2d9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdmissionOfficer_StudentList), @"mvc.1.0.view", @"/Areas/Admin/Views/AdmissionOfficer/StudentList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdmissionOfficer/StudentList.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdmissionOfficer_StudentList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e33a39907df40756732643fdaa99895f669e2d9e", @"/Areas/Admin/Views/AdmissionOfficer/StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d07f01e3c07cc979b1fe4cd526aeaff34bec21", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdmissionOfficer_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SchoolManagementSystem.Areas.Admin.AdminVM.StudentViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/ruthson-zimmerman-233522-unsplash.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdmissionOfficer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(80, 813, true);
            WriteLiteral(@"

<div class=""container"">
    <p class=""h2"" style=""text-align:center;"">Student List<br /><div style=""border-bottom:    1px solid #686868""></div> </p>

    <table class=""table table-striped table-responsive"">
        <thead>
            <tr>
                <th class=""h3"">
                    Serial
                </th>
                <th class="" h3 "">
                    Photo
                </th>
                <th class="" h3  "">
                    ID
                </th>
                <th class="" h3  "">
                    Name
                </th>
                <th class="" h3  "">
                    Class
                </th>
                <th class="" h3  "">
                    Action
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 34 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\StudentList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(950, 60, true);
            WriteLiteral("                <tr>\r\n                    <td class=\" h4  \">");
            EndContext();
            BeginContext(1011, 11, false);
#line 37 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\StudentList.cshtml"
                                 Write(item.Serial);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 45, true);
            WriteLiteral("</td>\r\n                    <td class=\" h4  \">");
            EndContext();
            BeginContext(1067, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b21605d0d734b35a446322350008412", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1160, 45, true);
            WriteLiteral("</td>\r\n                    <td class=\" h4  \">");
            EndContext();
            BeginContext(1206, 14, false);
#line 39 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\StudentList.cshtml"
                                 Write(item.stdntidVM);

#line default
#line hidden
            EndContext();
            BeginContext(1220, 45, true);
            WriteLiteral("</td>\r\n                    <td class=\" h4  \">");
            EndContext();
            BeginContext(1266, 16, false);
#line 40 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\StudentList.cshtml"
                                 Write(item.stdntnameVM);

#line default
#line hidden
            EndContext();
            BeginContext(1282, 45, true);
            WriteLiteral("</td>\r\n                    <td class=\" h4  \">");
            EndContext();
            BeginContext(1328, 15, false);
#line 41 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\StudentList.cshtml"
                                 Write(item.stdntclsVM);

#line default
#line hidden
            EndContext();
            BeginContext(1343, 71, true);
            WriteLiteral("</td>\r\n                    <td class=\" h4  \">\r\n                        ");
            EndContext();
            BeginContext(1414, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2aabf2742d1e43a1b39501b5e2784fe1", async() => {
                BeginContext(1526, 70, true);
                WriteLiteral("<i class=\"fa fa-pencil-square\" style=\"font-size:25px;color:green\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\StudentList.cshtml"
                                                                                                           WriteLiteral(item.stdntidVM);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1600, 70, true);
            WriteLiteral("\r\n                        &nbsp;&nbsp;&nbsp;\r\n                        ");
            EndContext();
            BeginContext(1670, 183, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd0a08a83e68437f9b33a0e9e6c0bfc7", async() => {
                BeginContext(1776, 73, true);
                WriteLiteral("<i class=\"fa fa-info-circle\" style=\"font-size:25px;color:dodgerblue\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\StudentList.cshtml"
                                                                                                     WriteLiteral(item.stdntidVM);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1853, 54, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 49 "C:\Users\Avro\Desktop\FinalTeest\Another\SchoolManagementSystem\SchoolManagementSystem\Areas\Admin\Views\AdmissionOfficer\StudentList.cshtml"
            }

#line default
#line hidden
            BeginContext(1922, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SchoolManagementSystem.Areas.Admin.AdminVM.StudentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
