#pragma checksum "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Shared\Components\_AdminNavbar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a12ee8dfefe95c49d95b4405bc04765871f5777"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__AdminNavbar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_AdminNavbar/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a12ee8dfefe95c49d95b4405bc04765871f5777", @"/Views/Shared/Components/_AdminNavbar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f278c2e195091e15ef6b360e804c00589ff5a5c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__AdminNavbar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NavbarViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<nav class=""layout-navbar container-xxl navbar navbar-expand-xl navbar-detached align-items-center bg-navbar-theme""
     id=""layout-navbar"">
    <div class=""layout-menu-toggle navbar-nav align-items-xl-center me-3 me-xl-0 d-xl-none"">
        <a class=""nav-item nav-link px-0 me-xl-4"" href=""javascript:void(0)"">
            <i class=""bx bx-menu bx-sm""></i>
        </a>
    </div>

    <div class=""navbar-nav-right d-flex align-items-center"" id=""navbar-collapse"">
        <!-- Search -->
        <div class=""navbar-nav align-items-center"">
            <div class=""nav-item d-flex align-items-center"">

            </div>
        </div>
        <!-- /Search -->

        <ul class=""navbar-nav flex-row align-items-center ms-auto"">
            <!-- Place this tag where you want the button to render. -->
            <!-- User -->
            <li class=""nav-item navbar-dropdown dropdown-user dropdown"">
                <a class=""nav-link dropdown-toggle hide-arrow"" href=""javascript:void(0);"" data-bs-to");
            WriteLiteral("ggle=\"dropdown\">\r\n                    <div class=\"avatar avatar-online\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1150, "\"", 1171, 1);
#nullable restore
#line 26 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Shared\Components\_AdminNavbar\Default.cshtml"
WriteAttributeValue("", 1156, Model.ImageUrl, 1156, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" altclass=""w-px-40 h-auto rounded-circle"" />
                    </div>
                </a>
                <ul class=""dropdown-menu dropdown-menu-end"">
                    <li>
                        <a class=""dropdown-item"" href=""#"">
                            <div class=""d-flex"">
                                <div class=""flex-shrink-0 me-3"">
                                    <div class=""avatar avatar-online"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 1648, "\"", 1669, 1);
#nullable restore
#line 35 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Shared\Components\_AdminNavbar\Default.cshtml"
WriteAttributeValue("", 1654, Model.ImageUrl, 1654, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" altclass=""w-px-40 h-auto rounded-circle"" />
                                    </div>
                                </div>
                                <div class=""flex-grow-1"">
                                    <span class=""fw-semibold d-block"">");
#nullable restore
#line 39 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Shared\Components\_AdminNavbar\Default.cshtml"
                                                                 Write(Model.AdminName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Shared\Components\_AdminNavbar\Default.cshtml"
                                                                                  Write(Model.AdminSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <small class=\"text-muted\">");
#nullable restore
#line 40 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Views\Shared\Components\_AdminNavbar\Default.cshtml"
                                                         Write(Model.Rol);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                </div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <div class=""dropdown-divider""></div>
                    </li>
                    <li>
                        <a class=""dropdown-item"" href=""#"">
                            <i class=""bx bx-user me-2""></i>
                            <span class=""align-middle"">Profilim</span>
                        </a>
                    </li>

                    <li>
                        <div class=""dropdown-divider""></div>
                    </li>
                    <li>
                        <a class=""dropdown-item"" href=""auth-login-basic.html"">
                            <i class=""bx bx-power-off me-2""></i>
                            <span class=""align-middle"">Log Out</span>
                        </a>
                    </li>
                </ul>
            </li>
            <!--/ User -->
   ");
            WriteLiteral("     </ul>\r\n    </div>\r\n</nav>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NavbarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
