#pragma checksum "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Areas\Writer\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a4e3c4b0f8d8de3121a0d0bd569bd330e115c57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Writer/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a4e3c4b0f8d8de3121a0d0bd569bd330e115c57", @"/Areas/Writer/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/skydash/images/dashboard/people.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("people"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Areas\Writer\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 grid-margin\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 col-xl-8 mb-4 mb-xl-0\">\r\n                <h3 class=\"font-weight-bold\">Hoşgeldin ");
#nullable restore
#line 11 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Areas\Writer\Views\Dashboard\Index.cshtml"
                                                  Write(ViewBag.v);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                <h6 class=""font-weight-normal mb-0"">AspNet Core Yazar Dashboard Paneli! Yeni Duyurular İçin <span class=""text-primary""><a href=""/Writer/Default/Index/"">Hemen Tıkla!</a></span></h6>
            </div>
            <div class=""col-12 col-xl-4"">
                <div class=""justify-content-end d-flex"">
                    <div class=""dropdown flex-md-grow-1 flex-xl-grow-0"">
                        <button class=""btn btn-sm btn-light bg-white dropdown-toggle"" type=""button"" id=""dropdownMenuDate2"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""true"">
                            <i class=""mdi mdi-calendar""></i> ");
#nullable restore
#line 18 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Areas\Writer\Views\Dashboard\Index.cshtml"
                                                        Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </button>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-6 grid-margin stretch-card"">
        <div class=""card tale-bg"">
            <div class=""card-people mt-auto"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9a4e3c4b0f8d8de3121a0d0bd569bd330e115c575892", async() => {
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
            WriteLiteral("\r\n                <div class=\"weather-info\">\r\n                    <div class=\"d-flex\">\r\n                        <div>\r\n                            <h2 class=\"mb-0 font-weight-normal\"><i class=\"icon-sun mr-2\"></i>");
#nullable restore
#line 35 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Areas\Writer\Views\Dashboard\Index.cshtml"
                                                                                        Write(ViewBag.v5);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<sup>C</sup></h2>
                        </div>
                        <div class=""ml-2"">
                            <h4 class=""location font-weight-normal"">İstanbul</h4>
                            <h6 class=""font-weight-normal"">Türkiye</h6>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-6 grid-margin transparent"">
        <div class=""row"">
            <div class=""col-md-6 mb-4 stretch-card transparent"">
                <div class=""card card-tale"">
                    <div class=""card-body"">
                        <p class=""mb-4"">Gelen Mesaj Sayısı</p>
                        <p class=""fs-30 mb-2"">");
#nullable restore
#line 52 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Areas\Writer\Views\Dashboard\Index.cshtml"
                                         Write(ViewBag.v1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 mb-4 stretch-card transparent"">
                <div class=""card card-dark-blue"">
                    <div class=""card-body"">
                        <p class=""mb-4"">Duyuru Sayısı</p>
                        <p class=""fs-30 mb-2"">");
#nullable restore
#line 60 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Areas\Writer\Views\Dashboard\Index.cshtml"
                                         Write(ViewBag.v2);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 mb-4 mb-lg-0 stretch-card transparent"">
                <div class=""card card-light-blue"">
                    <div class=""card-body"">
                        <p class=""mb-4"">Toplam Kullanıcı Sayısı</p>
                        <p class=""fs-30 mb-2"">");
#nullable restore
#line 70 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Areas\Writer\Views\Dashboard\Index.cshtml"
                                         Write(ViewBag.v3);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 stretch-card transparent"">
                <div class=""card card-light-danger"">
                    <div class=""card-body"">
                        <p class=""mb-4"">Toplam Yetenek Sayısı</p>
                        <p class=""fs-30 mb-2"">");
#nullable restore
#line 78 "C:\Users\firatalcin\Documents\GitHub\Mini-CV-Project-Net5.0\CoreCV_Project\CoreCV_ProjectWithMvc\Areas\Writer\Views\Dashboard\Index.cshtml"
                                         Write(ViewBag.v4);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-md-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <p class=""card-title"">Yazar Paneli</p>
                <p class=""font-weight-500"">Yazarlar için mesaj, duyuru, dashboard gibi bilgileri barındıran sayfadır. Yardıma ihtiyacınız olursa iletişim kısmından bize ulaşabilirsiniz.</p>
            </div>
        </div>
    </div>
    <div class=""col-md-6 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""d-flex justify-content-between"">
                    <p class=""card-title"">Dashboard Sayfası</p>
                </div>
                <p class=""font-weight-500"">Projemizin yazar panelinde bazı istatistiksel değerler ve hava durumu apisi üzerinden bulunduğun şehrin hava bilgisin öğrenebilirsin.</p>
            </div>
       ");
            WriteLiteral(" </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
