#pragma checksum "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c2791dbbf05200757ad5e1afb59cb452361359e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Reservation_MyCurrentReservation), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyCurrentReservation.cshtml")]
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
#line 2 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c2791dbbf05200757ad5e1afb59cb452361359e", @"/Areas/Member/Views/Reservation/MyCurrentReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9108bca35cd76bb621b63eaa31acd78cf5f75c15", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Reservation_MyCurrentReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
  
    ViewData["Title"] = "MyCurrentReservation";
    Layout = "~/Views/Shared/_MemberNewLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">Aktif Rezervasyonlar</h4>
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
                    <p class=""card-text""> Web Sitemiz Traversal üzerinde yapmış olduğunuz aktif rezervasyon listenize aşağ");
            WriteLiteral("ıdan ulaşabilirsiniz.</p>\r\n                  \r\n                    <div class=\"table-responsive\">\r\n\r\n\r\n");
#nullable restore
#line 33 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                         if (!string.IsNullOrEmpty(ViewBag.msg))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3>");
#nullable restore
#line 35 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                           Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 36 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Lokasyon</th>
                                    <th>Kişi Sayısı</th>
                                    <th>Rezervasyon Tarihi</th>
                                    <th>Durum</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 50 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 53 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                                       Write(item.ReservationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 54 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                                       Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 55 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                                       Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 56 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                                       Write(item.ReservationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 57 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                                       Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 59 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n");
#nullable restore
#line 62 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Reservation\MyCurrentReservation.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
