#pragma checksum "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d414233bf661350ca9fb224fc9b310f852b69d86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\Index.cshtml"
using ChildGlucoCare.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d414233bf661350ca9fb224fc9b310f852b69d86", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de948d387faf47253f8bc0d8cf279830fb97c326", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\Index.cshtml"
  
    this.ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to ");
#nullable restore
#line 7 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\Index.cshtml"
                                Write(GlobalConstants.SystemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n    <h1>This site is made to help of children and their parents to manage Diabet T1 and to accomplish better control of blood glucose levels. </h1>\r\n\r\n\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 346, "\"", 392, 1);
#nullable restore
#line 11 "C:\VILL\IT uchebni materiali\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 352, Url.Content("~/images/imageChild1.jpg"), 352, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 393, "\"", 399, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591