#pragma checksum "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Information\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7baa26e8ee7f5b31a183d1150a38ba6a0e7ba09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Information_Index), @"mvc.1.0.view", @"/Views/Information/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7baa26e8ee7f5b31a183d1150a38ba6a0e7ba09", @"/Views/Information/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f278c2e195091e15ef6b360e804c00589ff5a5c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Information_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Information\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_MemberNewLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">Çoklu Dil Desteği</h4>
                <a class=""heading-elements-toggle""><i class=""la la-ellipsis-v font-medium-3""></i></a>
                <div class=""heading-elements"">
                    <ul class=""list-inline mb-0"">
                        <li><a data-action=""collapse""><i class=""ft-minus""></i></a></li>
                        <li><a data-action=""reload""><i class=""ft-rotate-cw""></i></a></li>
                        <li><a data-action=""expand""><i class=""ft-maximize""></i></a></li>
                        <li><a data-action=""close""><i class=""ft-x""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""card-content collapse show"">
                <div class=""card-body"">
                    <p class=""card-text"">
                        ");
#nullable restore
#line 27 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Information\Index.cshtml"
                   Write(localizer["Merhaba"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("     ");
#nullable restore
#line 27 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Information\Index.cshtml"
                                             Write(localizer["Bugün"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("     ");
#nullable restore
#line 27 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Information\Index.cshtml"
                                                                     Write(localizer["Hava"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("     ");
#nullable restore
#line 27 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Information\Index.cshtml"
                                                                                            Write(localizer["Çok"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
#nullable restore
#line 27 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Information\Index.cshtml"
                                                                                                                 Write(localizer["Güzel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n                    </p>\r\n\r\n                    <h2> ");
#nullable restore
#line 30 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Information\Index.cshtml"
                    Write(localizer["Ulaşın"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Information\Index.cshtml"
                                         Write(localizer["Bize"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("   </h2>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
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
