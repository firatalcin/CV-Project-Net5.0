#pragma checksum "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\PortfolioList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "838b82159c37522a256d10fb6a8e02b890857f78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PortfolioList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
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
#line 1 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\_ViewImports.cshtml"
using CoreCV_ProjectWithMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\_ViewImports.cshtml"
using CoreCV_ProjectWithMvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\PortfolioList\Default.cshtml"
using CoreCV_Project.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838b82159c37522a256d10fb6a8e02b890857f78", @"/Views/Shared/Components/PortfolioList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b5fa8ddf4aa2bcd5a9b0ad0a204bbd6457fcc95", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_PortfolioList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""section px-2 px-lg-4 pt-5"" id=""portfolio"">
    <div class=""container"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Portfolio </h2>
        </div>
        <div class=""grid bp-gallery pb-3"" data-aos=""zoom-in-up"" data-aos-delay=""100"">
            <div class=""grid-sizer""></div>
");
#nullable restore
#line 12 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\PortfolioList\Default.cshtml"
             foreach (var item in @Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"grid-item\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 527, "\"", 550, 1);
#nullable restore
#line 15 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\PortfolioList\Default.cshtml"
WriteAttributeValue("", 534, item.ProjectUrl, 534, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <figure class=\"portfolio-item\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 643, "\"", 663, 1);
#nullable restore
#line 17 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\PortfolioList\Default.cshtml"
WriteAttributeValue("", 649, item.ImageUrl, 649, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-bp=\"");
#nullable restore
#line 17 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\PortfolioList\Default.cshtml"
                                                          Write(item.ImageUrl2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n                            <figcaption>\r\n                                <h4 class=\"h5 mb-0\">");
#nullable restore
#line 19 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\PortfolioList\Default.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <div>");
#nullable restore
#line 20 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\PortfolioList\Default.cshtml"
                                Write(item.ProjectUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </figcaption>\r\n                        </figure>\r\n                    </a>\r\n                </div>             \r\n");
#nullable restore
#line 25 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Shared\Components\PortfolioList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
