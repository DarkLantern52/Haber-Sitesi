#pragma checksum "C:\Users\Batuhan DEMİRTÜRK\OneDrive\Masaüstü\Deneme\Web Programlama\Final\NewsPortal\Views\Home\NewsInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3d431cfd2311e52477c6eba106ef6e5be4b5d44"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewsInfo), @"mvc.1.0.view", @"/Views/Home/NewsInfo.cshtml")]
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
#line 5 "C:\Users\Batuhan DEMİRTÜRK\OneDrive\Masaüstü\Deneme\Web Programlama\Final\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Batuhan DEMİRTÜRK\OneDrive\Masaüstü\Deneme\Web Programlama\Final\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Batuhan DEMİRTÜRK\OneDrive\Masaüstü\Deneme\Web Programlama\Final\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Batuhan DEMİRTÜRK\OneDrive\Masaüstü\Deneme\Web Programlama\Final\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3d431cfd2311e52477c6eba106ef6e5be4b5d44", @"/Views/Home/NewsInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0766ed622a0894951e70dd115b514ffe7aa71236", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_NewsInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsPortal.Models.News>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Batuhan DEMİRTÜRK\OneDrive\Masaüstü\Deneme\Web Programlama\Final\NewsPortal\Views\Home\NewsInfo.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3d431cfd2311e52477c6eba106ef6e5be4b5d446046", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3d431cfd2311e52477c6eba106ef6e5be4b5d446308", async() => {
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
                WriteLiteral("\r\n    <title>");
#nullable restore
#line 10 "C:\Users\Batuhan DEMİRTÜRK\OneDrive\Masaüstü\Deneme\Web Programlama\Final\NewsPortal\Views\Home\NewsInfo.cshtml"
      Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3d431cfd2311e52477c6eba106ef6e5be4b5d448468", async() => {
                WriteLiteral(@"
    <div class=""container-fluid bg-light"">
        <!--Üst Kısım-->
        <div class=""row"">
            <div class=""col-md-12"">
                <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
                    <a class=""navbar-brand"" href=""#"">Haber Portalı</a>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarNav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""navbar-toggler-icon""></span>
                    </button>
                    <div class=""collapse navbar-collapse"" id=""navbarNav"">
                        <ul class=""navbar-nav"">
                            <li class=""nav-item"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3d431cfd2311e52477c6eba106ef6e5be4b5d449543", async() => {
                    WriteLiteral("Ana Sayfa");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Dünya</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Türkiye</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">İş</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Teknoloji</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Bilim</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" href=""#"">Spor</a>
                            </li>
                        </ul>
      ");
                WriteLiteral("              </div>\r\n                </nav>\r\n            </div>\r\n        </div>\r\n        <!--Üst Kısım-->\r\n        <!--Başlık-->\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <h1 class=\"text-center mt-3 mb-3\">");
#nullable restore
#line 54 "C:\Users\Batuhan DEMİRTÜRK\OneDrive\Masaüstü\Deneme\Web Programlama\Final\NewsPortal\Views\Home\NewsInfo.cshtml"
                                             Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n        <!--Başlık-->\r\n        <!--İçerikler-->\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8\">\r\n                <img");
                BeginWriteAttribute("src", " src=\"", 2536, "\"", 2554, 1);
#nullable restore
#line 61 "C:\Users\Batuhan DEMİRTÜRK\OneDrive\Masaüstü\Deneme\Web Programlama\Final\NewsPortal\Views\Home\NewsInfo.cshtml"
WriteAttributeValue("", 2542, Model.Image, 2542, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid mx-auto d-block mb-3\" alt=\"Article Image\" style=\"border: solid 5px #ccc; width: 60%; height: auto;\">\r\n                <p class=\"serif\">");
#nullable restore
#line 62 "C:\Users\Batuhan DEMİRTÜRK\OneDrive\Masaüstü\Deneme\Web Programlama\Final\NewsPortal\Views\Home\NewsInfo.cshtml"
                            Write(Model.Content);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <p class=\"text-center mt-3 mb-3\">");
#nullable restore
#line 65 "C:\Users\Batuhan DEMİRTÜRK\OneDrive\Masaüstü\Deneme\Web Programlama\Final\NewsPortal\Views\Home\NewsInfo.cshtml"
                                            Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                <p class=\"text-center\">Kategori: ");
#nullable restore
#line 66 "C:\Users\Batuhan DEMİRTÜRK\OneDrive\Masaüstü\Deneme\Web Programlama\Final\NewsPortal\Views\Home\NewsInfo.cshtml"
                                            Write(Model.Category);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
            </div>
        </div>
        <!--İçerikler-->
        <!--Footer-->
        <div class=""row"">
            <div class=""col-md-12"">
                <footer>
                    <p class=""text-center"">Copyright © 2023 Haber Portal</p>
                </footer>
            </div>
        </div>
        <!--Footer-->
    </div>

");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsPortal.Models.News> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
