#pragma checksum "C:\VILL\IT_Data\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AddedHighBloodGlucose.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16b19dd65251140f43ddc38e11d726a1a6a7e2c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BloodGlucoses_AddedHighBloodGlucose), @"mvc.1.0.view", @"/Views/BloodGlucoses/AddedHighBloodGlucose.cshtml")]
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
#line 1 "C:\VILL\IT_Data\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\_ViewImports.cshtml"
using ChildGlucoCare.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\VILL\IT_Data\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\_ViewImports.cshtml"
using ChildGlucoCare.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16b19dd65251140f43ddc38e11d726a1a6a7e2c3", @"/Views/BloodGlucoses/AddedHighBloodGlucose.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de948d387faf47253f8bc0d8cf279830fb97c326", @"/Views/_ViewImports.cshtml")]
    public class Views_BloodGlucoses_AddedHighBloodGlucose : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChildGlucoCare.Web.ViewModels.BloodGlucoses.SuggestedInsulinCorrectionViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\VILL\IT_Data\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AddedHighBloodGlucose.cshtml"
  
    this.ViewData["Title"] = "Added Blood Glucose";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h1 class=""text-center text-danger"">Your Blood glucose level is high. We suggest the following insulin dose correction!</h1>

<div class=""table-striped"">
    <table class=""table"" style=""width:100%"">
        <tr>
            <th>Date</th>
            <th>Current Glucose Level</th>
            <th>Suggested Correction Dose Insulin</th>
        </tr>
        <tr>
            <th>");
#nullable restore
#line 16 "C:\VILL\IT_Data\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AddedHighBloodGlucose.cshtml"
           Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 17 "C:\VILL\IT_Data\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AddedHighBloodGlucose.cshtml"
           Write(Model.CurrentGlucoseLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th> ");
#nullable restore
#line 18 "C:\VILL\IT_Data\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\BloodGlucoses\AddedHighBloodGlucose.cshtml"
            Write(Model.SuggestedCorrectionDoseInsulin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChildGlucoCare.Web.ViewModels.BloodGlucoses.SuggestedInsulinCorrectionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
