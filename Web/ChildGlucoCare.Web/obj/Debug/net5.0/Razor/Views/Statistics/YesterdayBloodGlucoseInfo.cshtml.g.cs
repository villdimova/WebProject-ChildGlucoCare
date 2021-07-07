#pragma checksum "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ad101cc19085c240e9e035458b63c37eb274365"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistics_YesterdayBloodGlucoseInfo), @"mvc.1.0.view", @"/Views/Statistics/YesterdayBloodGlucoseInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ad101cc19085c240e9e035458b63c37eb274365", @"/Views/Statistics/YesterdayBloodGlucoseInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de948d387faf47253f8bc0d8cf279830fb97c326", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistics_YesterdayBloodGlucoseInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChildGlucoCare.Web.ViewModels.Statistics.StatisticInfoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
  
    this.ViewData["Title"] = "Blood Glucose statistic";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
  
    var date = @Model.YesterdayBloodGlucoses.Select(x => x.Date.Date).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Blood glucoses at ");
#nullable restore
#line 11 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
                                     Write(date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"table-bordered\">\r\n    <table class=\"table\" style=\"width:100%\">\r\n        <tr>\r\n            <th>Date</th>\r\n            <th>Glucose Level</th>\r\n            <th>Blood Glucose Status</th>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
         foreach (var bloodGlucose in this.Model.YesterdayBloodGlucoses)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
             if (bloodGlucose.BloodGlocoseStatus.ToString() == "High" || bloodGlucose.BloodGlocoseStatus.ToString() == "Low")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-danger\">\r\n                    <th>");
#nullable restore
#line 25 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
                   Write(bloodGlucose.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 26 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
                   Write(bloodGlucose.CurrentGlucoseLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 27 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
                   Write(bloodGlucose.BloodGlocoseStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                </tr>\r\n");
#nullable restore
#line 29 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
             if (bloodGlucose.BloodGlocoseStatus.ToString() == "Normal")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-success\">\r\n                    <th>");
#nullable restore
#line 33 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
                   Write(bloodGlucose.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 34 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
                   Write(bloodGlucose.CurrentGlucoseLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 35 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
                   Write(bloodGlucose.BloodGlocoseStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Statistics\YesterdayBloodGlucoseInfo.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChildGlucoCare.Web.ViewModels.Statistics.StatisticInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591