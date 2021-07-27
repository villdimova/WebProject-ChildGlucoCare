#pragma checksum "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e640f9af6d5af6499627434a0754dcf95f9480d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserDashboard), @"mvc.1.0.view", @"/Views/Home/UserDashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e640f9af6d5af6499627434a0754dcf95f9480d", @"/Views/Home/UserDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de948d387faf47253f8bc0d8cf279830fb97c326", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChildGlucoCare.Web.ViewModels.Home.UserDashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
  
    ViewData["Title"] = "User dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"jumbotron\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <div class=\"d-grid gap-2\">\r\n                    <span><h1><i class=\"fas fa-tint\"></i> Blood Glucose  </h1></span>\r\n");
#nullable restore
#line 11 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                     if (Model.LastBloodGlucose == null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>No blood glucose records</span>\r\n");
#nullable restore
#line 14 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>");
#nullable restore
#line 17 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                         Write(Model.LastBloodGlucose.CurrentGlucoseLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mmol/L on ");
#nullable restore
#line 17 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                                                                               Write(Model.LastBloodGlucose.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 18 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col\">\r\n                <span><h1><i class=\"fas fa-running\"></i>  Sport Activity  </h1></span>\r\n");
#nullable restore
#line 23 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                 if (Model.LastSportActivitie == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>No sport activity records</span>\r\n");
#nullable restore
#line 26 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>");
#nullable restore
#line 29 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                     Write(Model.LastSportActivitie.SportName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 29 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                                                          Write(Model.LastSportActivitie.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min.) on ");
#nullable restore
#line 29 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                                                                                                      Write(Model.LastSportActivitie.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 30 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"w-100\"></div>\r\n            <div class=\"col\">\r\n                <span><h1><i class=\"fas fa-syringe\"></i>  Insulin Injection  </h1> </span>\r\n");
#nullable restore
#line 35 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                 if (Model.LastInjection == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>No insulin injection records</span>\r\n");
#nullable restore
#line 38 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>");
#nullable restore
#line 41 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                     Write(Model.LastInjection.InsulinDose);

#line default
#line hidden
#nullable disable
            WriteLiteral(" IU on ");
#nullable restore
#line 41 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                                                            Write(Model.LastInjection.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 42 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col\">\r\n                <span><h1><i class=\"fas fa-hamburger\"></i>  Meal BEU  </h1></span>\r\n");
#nullable restore
#line 46 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                 if (Model.LastInjection == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>No meal records</span>\r\n");
#nullable restore
#line 49 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>");
#nullable restore
#line 52 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                     Write(Model.LastMeal.TotalBeu);

#line default
#line hidden
#nullable disable
            WriteLiteral(" BEU  on ");
#nullable restore
#line 52 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                                                      Write(Model.LastMeal.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 53 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
    <br />
    <br />
    <br />
    <br />
    <h1 class=""text-center"">Last month blood glucose report </h1>

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
#line 73 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                                   Write(Model.BloodGlucoseReport.BloodGlucoseRecords);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th class=\"text-danger\">");
#nullable restore
#line 74 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                                   Write(Model.BloodGlucoseReport.HighPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th class=\"text-success\">");
#nullable restore
#line 75 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                                    Write(Model.BloodGlucoseReport.NormalPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th class=\"text-danger\">");
#nullable restore
#line 76 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
                                   Write(Model.BloodGlucoseReport.LowPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 77 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
               Write(Model.BloodGlucoseReport.AvgBloodGlucose);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <section>\r\n        <img class=\"img-thumbnail img-center\"");
            BeginWriteAttribute("src", " src=\"", 3274, "\"", 3317, 1);
#nullable restore
#line 84 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\UserDashboard.cshtml"
WriteAttributeValue("", 3280, Url.Content("~/images/userHome.jpg"), 3280, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3318, "\"", 3324, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </section>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChildGlucoCare.Web.ViewModels.Home.UserDashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
