#pragma checksum "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\_SearchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4beae7cd62a574999248b541fbab117a591d569d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Destination__SearchPartial), @"mvc.1.0.view", @"/Areas/Member/Views/Destination/_SearchPartial.cshtml")]
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
#line 1 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\_ViewImports.cshtml"
using TraversalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\_ViewImports.cshtml"
using TraversalProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4beae7cd62a574999248b541fbab117a591d569d", @"/Areas/Member/Views/Destination/_SearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9108bca35cd76bb621b63eaa31acd78cf5f75c15", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Destination__SearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""table-responsive"" id=""searchResult"">

    <table class=""table"">
        <thead>
            <tr>
                <th>#</th>
                <th>Şehir</th>
                <th>Süre</th>
                <th>Kapasite</th>
                <th>Fiyat</th>
                <th>Detaylar</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 15 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\_SearchPartial.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\_SearchPartial.cshtml"
                   Write(item.DestinationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\_SearchPartial.cshtml"
                   Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\_SearchPartial.cshtml"
                   Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\_SearchPartial.cshtml"
                   Write(item.Capasity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\_SearchPartial.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 691, "\"", 749, 2);
            WriteAttributeValue("", 698, "/Destination/DestinationDetails/", 698, 32, true);
#nullable restore
#line 23 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\_SearchPartial.cshtml"
WriteAttributeValue("", 730, item.DestinationId, 730, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Detaylar</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\_SearchPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>");
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
