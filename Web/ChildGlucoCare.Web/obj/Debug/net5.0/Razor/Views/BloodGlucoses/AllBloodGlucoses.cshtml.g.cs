#pragma checksum "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AllBloodGlucoses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d58560e54b2f88551880698eb476eb0e3f49f57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BloodGlucoses_AllBloodGlucoses), @"mvc.1.0.view", @"/Views/BloodGlucoses/AllBloodGlucoses.cshtml")]
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
#nullable restore
#line 1 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\_ViewImports.cshtml"
using ChildGlucoCare.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\_ViewImports.cshtml"
using ChildGlucoCare.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d58560e54b2f88551880698eb476eb0e3f49f57", @"/Views/BloodGlucoses/AllBloodGlucoses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de948d387faf47253f8bc0d8cf279830fb97c326", @"/Views/_ViewImports.cshtml")]
    public class Views_BloodGlucoses_AllBloodGlucoses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChildGlucoCare.Web.ViewModels.BloodGlucoses.AllBloodGlucoses>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BloodGlucoses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete BloodGlucose"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AllBloodGlucoses.cshtml"
  
    this.ViewData["Title"] = "Your blood glucose records";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"text-center\">");
#nullable restore
#line 6 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AllBloodGlucoses.cshtml"
                   Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
<hr />
<div class=""row"">
    <div class=""col-md-12 border"">
        <div class=""text-center"">
            <a href=""/BloodGlucoses/AddBloodGlucose"" class=""btn btn-primary waves-effect m-2 custom-blue"" title=""Add Blood Glucose"">
                <i class=""fas fa-plus-circle""></i>
            </a>
        </div>
        <div class=""table-striped"">
            <table class=""table"" style=""width:100%"">
                <tr>
                    <th>Date</th>
                    <th>Glucose Level</th>
                    <th>Blood Glucose Status</th>
                    <th>Edit</th>
                    <th>Delete</th>
                </tr>
");
#nullable restore
#line 24 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AllBloodGlucoses.cshtml"
                 foreach (var bloodGlucose in this.Model.BloodGlucoses)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th>");
#nullable restore
#line 27 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AllBloodGlucoses.cshtml"
                       Write(bloodGlucose.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 28 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AllBloodGlucoses.cshtml"
                       Write(bloodGlucose.CurrentGlucoseLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 29 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AllBloodGlucoses.cshtml"
                       Write(bloodGlucose.BloodGlocoseStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th><a");
            BeginWriteAttribute("href", " href=\"", 1184, "\"", 1227, 2);
            WriteAttributeValue("", 1191, "/BloodGlucoses/Edit/", 1191, 20, true);
#nullable restore
#line 30 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AllBloodGlucoses.cshtml"
WriteAttributeValue("", 1211, bloodGlucose.Id, 1211, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-block btn-info\" title=\"Edit Food\"><i class=\"fas fa-edit\"></i></a></th>\r\n                        <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d58560e54b2f88551880698eb476eb0e3f49f578116", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AllBloodGlucoses.cshtml"
                                                                                    WriteLiteral(bloodGlucose.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</th>\r\n                    </tr>\r\n");
#nullable restore
#line 33 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AllBloodGlucoses.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChildGlucoCare.Web.ViewModels.BloodGlucoses.AllBloodGlucoses> Html { get; private set; }
    }
}
#pragma warning restore 1591