#pragma checksum "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\BloodGlucoseReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20a620fe675f27558257115c582f62c5bce39729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistics_BloodGlucoseReport), @"mvc.1.0.view", @"/Views/Statistics/BloodGlucoseReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a620fe675f27558257115c582f62c5bce39729", @"/Views/Statistics/BloodGlucoseReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de948d387faf47253f8bc0d8cf279830fb97c326", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistics_BloodGlucoseReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChildGlucoCare.Web.ViewModels.Statistics.BloodGlucoseReportViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\BloodGlucoseReport.cshtml"
  
    this.ViewData["Title"] = "Blood Glucose report";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Blood glucose report for the period  ");
#nullable restore
#line 7 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\BloodGlucoseReport.cshtml"
                                                        Write(Model.PeriodStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("- ");
#nullable restore
#line 7 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\BloodGlucoseReport.cshtml"
                                                                            Write(DateTime.Today);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""table-bordered"">
    <table class=""table"" style=""width:100%"">
        <tr>
            <th>Blood glucose records</th>
            <th>Blood glucose High</th>
            <th>Blood glucose Normal</th>
            <th>Blood glucose Low</th>
            <th>Blood glucose Average value</th>
        </tr>
        <tr class=""table-info"">
            <th class=""text-danger"">");
#nullable restore
#line 19 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\BloodGlucoseReport.cshtml"
                               Write(Model.BloodGlucoseRecords);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th class=\"text-danger\">");
#nullable restore
#line 20 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\BloodGlucoseReport.cshtml"
                               Write(Model.HighPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th class=\"text-success\">");
#nullable restore
#line 21 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\BloodGlucoseReport.cshtml"
                                Write(Model.NormalPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th class=\"text-danger\">");
#nullable restore
#line 22 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\BloodGlucoseReport.cshtml"
                               Write(Model.LowPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 23 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\BloodGlucoseReport.cshtml"
           Write(Model.AvgBloodGlucose);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChildGlucoCare.Web.ViewModels.Statistics.BloodGlucoseReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591