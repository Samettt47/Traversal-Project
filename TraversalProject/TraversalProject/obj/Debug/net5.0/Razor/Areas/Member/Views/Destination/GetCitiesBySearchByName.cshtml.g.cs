#pragma checksum "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\GetCitiesBySearchByName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad9cb0fa91e835e6f36b709bad1f5e10c81064a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Destination_GetCitiesBySearchByName), @"mvc.1.0.view", @"/Areas/Member/Views/Destination/GetCitiesBySearchByName.cshtml")]
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
#line 1 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\GetCitiesBySearchByName.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad9cb0fa91e835e6f36b709bad1f5e10c81064a0", @"/Areas/Member/Views/Destination/GetCitiesBySearchByName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9108bca35cd76bb621b63eaa31acd78cf5f75c15", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Destination_GetCitiesBySearchByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\GetCitiesBySearchByName.cshtml"
  
    ViewData["Title"] = "GetCitiesBySearchByName";
    Layout = "~/Views/Shared/_MemberNewLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">Tur Rotası Arama Sayfası</h4>
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
                        Alanında uzman rehberlerimiz ile Balkanlar'dan Orta A");
            WriteLiteral(@"sya'ya , Amekerika'dan  Rusya'ya , Doğu Anadolu'nun dört bir yanına
                        en uygun fiyatlarala sunduğumuz tur listemize ve tur detaylarına aşağıdaki tablodan erişebilirsiniz.
                    </p>

                    
                            <p>
                                Lütfen Aranacak Şehri Giriniz: <input type=""text"" class=""form-control"" id=""searchString""  autocomplete=""off"" name=""searchString""  />
                                <br />
                                
                            </p>
                       

");
            WriteLiteral("\r\n                    ");
#nullable restore
#line 42 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\Member\Views\Destination\GetCitiesBySearchByName.cshtml"
               Write(Html.Partial("~/Areas/Member/Views/Destination/_SearchPartial.cshtml", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"
                   
                </div>
            </div>
        </div>
    </div>
</div>

<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>

<script>
    $(document).ready(function () {
        $('#searchString').on('input', function () {
            var searchText = $(this).val();
            if (searchText.length >= 2) {
                $.ajax({
                    url: '/Member/Destination/GetCitiesBySearchByName',                  
                    type: 'Get',
                    data: {
                        searchString: searchText
                    },
                    success: function (result) {
                        let w = jQuery.parseJSON(result);
                        console.log(w);

                        let tablehtml = ""<table class=table table-bordered><tr><th> # </th> <th> Şehir Adı </th> <th> Süre </th> <th> Kapasite </th> <th> Fiyat </th> <th> Detaylar </th> </tr>"";
                        $.each(w, (index, value) => {
   ");
            WriteLiteral(@"                         tablehtml += `<tr> <td>${value.DestinationId}</td>  <td>${value.City}</td> <td>${value.DayNight}</td>  <td>${value.Capasity}  </td> <td>${value.Price} ₺ </td> <td><a href=""/Destination/DestinationDetails/${value.DestinationId}"" class=""btn btn-outline-info"">Detaylar</a>  </td>  </tr>`
                        });
                        tablehtml += ""</table>"";
                        $(""#searchResult"").html(tablehtml);

                  
                    }
                });
            }
        });
    });

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; }
    }
}
#pragma warning restore 1591