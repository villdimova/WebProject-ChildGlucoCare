#pragma checksum "C:\VILL\IT_Data\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f46296958f19860d66b0155c8110bf31803c221a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f46296958f19860d66b0155c8110bf31803c221a", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de948d387faf47253f8bc0d8cf279830fb97c326", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\VILL\IT_Data\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\About.cshtml"
  
    this.ViewData["Title"] = "About Diabet T1";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1  class=\"text-center\">");
#nullable restore
#line 4 "C:\VILL\IT_Data\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\About.cshtml"
                    Write(this.ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<section>
    <p>Type 1 diabetes is a lifelong disease that affects the body's ability to convert glucose from food into energy. In most cases, type 1 diabetes develops early in life and is often diagnosed during childhood.</p>
    <p>
        Different factors, including genetics and some viruses, may contribute to type 1 diabetes. The disease starts when the immune system attacks cells in the pancreas that produce insulin,
        the hormone that helps convert glucose into energy for the body's cells. Without daily injections of insulin, people living with type 1 would not be able to survive.
    </p>
    <p>Despite active research, type 1 diabetes has no cure. Treatment focuses on managing blood sugar levels with insulin, diet and lifestyle to prevent complications.</p>
    <p>
        Making daily entries in Diabetic diary is very important for every diabetic.
        When keeping a food diary to understand the relationship between carbohydrates,
        exercise, and their blood gluco");
            WriteLiteral(@"se level, the diabetic can get results very quickly and
        achieve better control of blood glucose.
    </p>
</section>
<section>
    <h3>  Facts about type 1 diabetes:</h3>
    <ul>
        <li>
            Over 1.1m children and adolescents are living with type 1 diabetes globally.
        </li>
        <li>
            About  56% of people with diabetes worry about the risk of hypoglycaemia.
        </li>
        <li>
            About   60%+ of family members of people with diabetes are worried about the risk of hypoglycaemia to their loved one.
        </li>
    </ul>
    
    <img class=""img-center""");
            BeginWriteAttribute("src", "src=\"", 1763, "\"", 1807, 1);
#nullable restore
#line 34 "C:\VILL\IT_Data\Programming\GitHub\WebProject-ChildGlucoCare\Web\ChildGlucoCare.Web\Views\Home\About.cshtml"
WriteAttributeValue("", 1768, Url.Content("~/images/imageAbout.png"), 1768, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1808, "\"", 1814, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n</section>");
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
