#pragma checksum "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93aa5a1802a3f2169244be9b7e10d1b975f4d930"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Index), @"mvc.1.0.view", @"/Views/Portfolio/Index.cshtml")]
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
#line 1 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
using CoreCV_Project.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93aa5a1802a3f2169244be9b7e10d1b975f4d930", @"/Views/Portfolio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b5fa8ddf4aa2bcd5a9b0ad0a204bbd6457fcc95", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/argon-dashboard-master/assets/img/theme/team-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/argon-dashboard-master/assets/img/theme/team-2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/argon-dashboard-master/assets/img/theme/team-3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/argon-dashboard-master/assets/img/theme/team-4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col"">
        <div class=""card bg-default shadow"">
            <div class=""card-header bg-transparent border-0"">
                <h3 class=""text-white mb-0"">Projelerim</h3>
            </div>
            <div class=""table-responsive"">
                <table class=""table align-items-center table-dark table-flush"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"" class=""sort"" data-sort=""name"">Platform</th>
                            <th scope=""col"" class=""sort"" data-sort=""budget"">Ücret</th>
                            <th scope=""col"" class=""sort"" data-sort=""status"">Durum</th>
                            <th scope=""col"">Görseller</th>
                            <th scope=""col"" class=""sort"" data-sort=""completion"">Tamamlanma Yüzdesi</th>
                            <th scope=""col""></th>
                        </tr>
                    </thead>
                    <tbody class=""list"">
");
#nullable restore
#line 28 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
                         foreach (var item in @Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr>
                                <th scope=""row"">
                                    <div class=""media align-items-center"">
                                        <a href=""#"" class=""avatar rounded-circle mr-3"">
                                            <img alt=""Image placeholder""");
            BeginWriteAttribute("src", " src=\"", 1587, "\"", 1607, 1);
#nullable restore
#line 34 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 1593, item.Platform, 1593, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </a>\r\n                                        <div class=\"media-body\">\r\n                                            <span class=\"name mb-0 text-sm\">");
#nullable restore
#line 37 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                    </div>\r\n                                </th>\r\n                                <td class=\"budget\">\r\n                                    ");
#nullable restore
#line 42 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <span class=\"badge badge-dot mr-4\">\r\n");
#nullable restore
#line 46 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
                                         if (@item.Value == 100)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"bg-success\"></i>\r\n");
#nullable restore
#line 49 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <i class=\"bg-warning\"></i>\r\n");
#nullable restore
#line 53 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <span class=\"status\">\r\n");
#nullable restore
#line 56 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
                                             if (@item.Value == 100)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span>Tamamlandı</span>\r\n");
#nullable restore
#line 59 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"

                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span>Devam Ediyor</span>\r\n");
#nullable restore
#line 64 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </span>
                                    </span>
                                </td>
                                <td>
                                    <div class=""avatar-group"">
                                        <a href=""#"" class=""avatar avatar-sm rounded-circle"" data-toggle=""tooltip"" data-original-title=""Ryan Tompson"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93aa5a1802a3f2169244be9b7e10d1b975f4d93011999", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </a>\r\n                                        <a href=\"#\" class=\"avatar avatar-sm rounded-circle\" data-toggle=\"tooltip\" data-original-title=\"Romina Hadid\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93aa5a1802a3f2169244be9b7e10d1b975f4d93013367", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </a>\r\n                                        <a href=\"#\" class=\"avatar avatar-sm rounded-circle\" data-toggle=\"tooltip\" data-original-title=\"Alexander Smith\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93aa5a1802a3f2169244be9b7e10d1b975f4d93014738", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </a>\r\n                                        <a href=\"#\" class=\"avatar avatar-sm rounded-circle\" data-toggle=\"tooltip\" data-original-title=\"Jessica Doe\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "93aa5a1802a3f2169244be9b7e10d1b975f4d93016105", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </a>
                                    </div>
                                </td>
                                <td>
                                    <div class=""d-flex align-items-center"">
                                        <span class=""completion mr-2"">");
#nullable restore
#line 87 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
                                                                 Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n                                        <div>\r\n                                            <div class=\"progress\">\r\n                                                <div class=\"progress-bar bg-warning\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 5222, "\"", 5249, 1);
#nullable restore
#line 90 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
WriteAttributeValue("", 5238, item.Value, 5238, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 5288, "\"", 5316, 3);
            WriteAttributeValue("", 5296, "width:", 5296, 6, true);
#nullable restore
#line 90 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
WriteAttributeValue(" ", 5302, item.Value, 5303, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5314, "%;", 5314, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td class=""text-right"">
                                    <div class=""dropdown"">
                                        <a class=""btn btn-sm btn-icon-only text-light"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                            <i class=""fas fa-ellipsis-v""></i>
                                        </a>
                                        <div class=""dropdown-menu dropdown-menu-right dropdown-menu-arrow"">
                                            <a class=""dropdown-item"" href=""#"">Action</a>
                                            <a class=""dropdown-item"" href=""#"">Another action</a>
                                            <a class=""dropdown-item"" href=""#"">Something else here</a>
            ");
            WriteLiteral("                            </div>\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 108 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Views\Portfolio\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<a href=\"/Portfolio/AddPortfolio\" class=\"btn btn-primary\">Ekle</a>\r\n\r\n");
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