#pragma checksum "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Guide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eea71aa0dd76c01cd62038dc5c93a8e681fc5a3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guide_Index), @"mvc.1.0.view", @"/Views/Guide/Index.cshtml")]
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
#line 1 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\_ViewImports.cshtml"
using TraversalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eea71aa0dd76c01cd62038dc5c93a8e681fc5a3a", @"/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f278c2e195091e15ef6b360e804c00589ff5a5c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""w3l-about-breadcrumb text-left"">
    <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
        <div class=""container py-2"">
            <h2 class=""title"">Contact Us</h2>
            <ul class=""breadcrumbs-custom-path mt-2"">
                <li><a href=""/Default/Index/"">AnaSayfa</a></li>
                <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Rehberlerimiz </li>
            </ul>
        </div>
    </div>
</section>

<section class=""w3l-team"" id=""team"">
    <div class=""team-block py-5"">
        <div class=""container py-lg-5"">
            <div class=""title-content text-center mb-lg-3 mb-4"">
                
                <h6 class=""sub-title"">Ekip Arkadaşlarımız </h6>
                <h3 class=""hny-title"">Rehberlimizle Tanışın</h3>
            </div>
            <div class=""row"">
");
#nullable restore
#line 27 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Guide\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-6 mt-lg-5 mt-4\">\r\n                        <div class=\"box16\">\r\n                            <a href=\"#url\"><img");
            BeginWriteAttribute("src", " src=\"", 1212, "\"", 1229, 1);
#nullable restore
#line 31 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1218, item.Image, 1218, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1230, "\"", 1236, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" /></a>\r\n                            <div class=\"box-content\">\r\n                                <h3 class=\"title\"><a href=\"#url\">");
#nullable restore
#line 33 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Guide\Index.cshtml"
                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <span class=\"post\">");
#nullable restore
#line 34 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Guide\Index.cshtml"
                                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <ul class=\"social\">\r\n                                    <li>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1619, "\"", 1644, 1);
#nullable restore
#line 37 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1626, item.InstagramUrl, 1626, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""instagram"">
                                            <span class=""fa fa-instagram""></span>
                                        </a>
                                    </li>
                                    <li>
                                        <a");
            BeginWriteAttribute("href", " href=\"", 1922, "\"", 1945, 1);
#nullable restore
#line 42 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1929, item.TwitterUrl, 1929, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""twitter"">
                                            <span class=""fa fa-twitter""></span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 50 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Guide\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; }
    }
}
#pragma warning restore 1591
