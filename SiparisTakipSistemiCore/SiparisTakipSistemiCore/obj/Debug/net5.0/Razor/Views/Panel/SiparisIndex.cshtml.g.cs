#pragma checksum "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e62c607b3064f95a3e82716c86c7a14f3eda5e3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Panel_SiparisIndex), @"mvc.1.0.view", @"/Views/Panel/SiparisIndex.cshtml")]
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
#line 1 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\_ViewImports.cshtml"
using SiparisTakipSistemiCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\_ViewImports.cshtml"
using SiparisTakipSistemiCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
using SiparisTakipSistemiCore.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e62c607b3064f95a3e82716c86c7a14f3eda5e3a", @"/Views/Panel/SiparisIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"783dacec858d9e8307b10a111e2d979dcfb2b464", @"/Views/_ViewImports.cshtml")]
    public class Views_Panel_SiparisIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Siparis>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Panel/YeniSiparis"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
  
    ViewData["Title"] = "Sipariş Listesi";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""text-align:center;color:orange"">Sipariş Listesi</h1>
<br />
<br />

<table class=""table table-hover"">
    <tr>
        <th>
            Müşteri
        </th>
        <th>
            EPosta
        </th>
        <th>
            Telefon
        </th>
        <th>
            Ürün
        </th>
        <th>
            Adres
        </th>
        <th>
            Adet
        </th>
        <th>
            Tarih
        </th>
        <th>
            Onayla
        </th>
        <th>
            Reddet
        </th>


    </tr>
");
#nullable restore
#line 44 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
     foreach (var i in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
           Write(i.Musteri.MusteriAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
           Write(i.EPosta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
           Write(i.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
           Write(i.Urun);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
           Write(i.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
           Write(i.Adet);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
           Write(Convert.ToDateTime(i.Tarih).ToString("dd/MMMM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 68 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
             if (i.Durum == "Sipariş Beklemede")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e62c607b3064f95a3e82716c86c7a14f3eda5e3a8962", async() => {
                WriteLiteral("Onayla");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1417, "~/Panel/SiparisOnayla/", 1417, 22, true);
#nullable restore
#line 71 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
AddHtmlAttributeValue("", 1439, i.SiparisID, 1439, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e62c607b3064f95a3e82716c86c7a14f3eda5e3a10710", async() => {
                WriteLiteral("Reddet");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1560, "~/Panel/SiparisReddet/", 1560, 22, true);
#nullable restore
#line 74 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
AddHtmlAttributeValue("", 1582, i.SiparisID, 1582, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 76 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
            }
            else if (i.Durum == "Sipariş Onaylandı")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"alert alert-success\">Sipariş </td>\r\n                <td class=\"alert alert-success\">Onaylandı</td>\r\n");
#nullable restore
#line 81 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
            }
            else if (i.Durum == "Sipariş Reddedildi")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td class=\"alert alert-danger\">Sipariş </td>\r\n            <td class=\"alert alert-danger\">Reddedildi</td>\r\n");
#nullable restore
#line 86 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 88 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\Panel\SiparisIndex.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e62c607b3064f95a3e82716c86c7a14f3eda5e3a13888", async() => {
                WriteLiteral("Yeni Sipariş Ekle");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Siparis>> Html { get; private set; }
    }
}
#pragma warning restore 1591
