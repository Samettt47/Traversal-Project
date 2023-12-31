#pragma checksum "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d86e43197cb36536bf4106022398275ea0fb1d31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminsArea_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/AdminsArea/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject.Areas.AdminsArea.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Results.DestinationResult;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Results.GuideResult;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\_ViewImports.cshtml"
using TraversalProject.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d86e43197cb36536bf4106022398275ea0fb1d31", @"/Areas/AdminsArea/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e351ef1cd32c7e48a494c3599e7c439888248f", @"/Areas/AdminsArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminsArea_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n\r\n<html lang=\"en\"\r\n      class=\"light-style layout-menu-fixed\"\r\n      dir=\"ltr\"\r\n      data-theme=\"theme-default\"\r\n      data-assets-path=\"../assets/\"\r\n      data-template=\"vertical-menu-template-free\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d86e43197cb36536bf4106022398275ea0fb1d315479", async() => {
                WriteLiteral("\r\n   \r\n    \r\n    <div class=\"row\">\r\n\r\n        ");
#nullable restore
#line 22 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("_DashboardBanner"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 24 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("_Cards1Statistik"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 26 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("_TotalRevenue"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 28 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("_Cards2Statistic"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n    <div class=\"row\">\r\n        <!-- Order Statistics -->\r\n        ");
#nullable restore
#line 33 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("_DestinationStatistic"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!--/ Order Statistics -->\r\n        <!-- Expense Overview -->\r\n        ");
#nullable restore
#line 36 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("_DestinationStatistic2"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!--/ Expense Overview -->\r\n        <!-- Transactions -->\r\n        ");
#nullable restore
#line 39 "C:\Users\samet\source\repos\TraversalProject\TraversalProject\Areas\AdminsArea\Views\Dashboard\Index.cshtml"
   Write(await Component.InvokeAsync("_AdminGuideList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!--/ Transactions -->\r\n    </div>\r\n   \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
