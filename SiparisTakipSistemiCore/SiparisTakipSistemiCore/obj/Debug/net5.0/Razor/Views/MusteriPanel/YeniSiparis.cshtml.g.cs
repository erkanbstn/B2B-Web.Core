#pragma checksum "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\MusteriPanel\YeniSiparis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db712b774f29adeb5e0985ff80eda0acefb5a5ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MusteriPanel_YeniSiparis), @"mvc.1.0.view", @"/Views/MusteriPanel/YeniSiparis.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db712b774f29adeb5e0985ff80eda0acefb5a5ae", @"/Views/MusteriPanel/YeniSiparis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"783dacec858d9e8307b10a111e2d979dcfb2b464", @"/Views/_ViewImports.cshtml")]
    public class Views_MusteriPanel_YeniSiparis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiparisTakipSistemiCore.Models.Entities.Siparis>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\MusteriPanel\YeniSiparis.cshtml"
  
    ViewData["Title"] = "YeniSiparis";
    Layout = "~/Views/Shared/Panel.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 style=\"text-align:center;color:orange\">Yeni Sipariş Ekle</h1>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 11 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\MusteriPanel\YeniSiparis.cshtml"
 if (ViewBag.skayit != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">");
#nullable restore
#line 13 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\MusteriPanel\YeniSiparis.cshtml"
                                Write(ViewBag.skayit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <br />\r\n");
#nullable restore
#line 15 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\MusteriPanel\YeniSiparis.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\MusteriPanel\YeniSiparis.cshtml"
 using (Html.BeginForm("YeniSiparis", "MusteriPanel", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>Müşteri Telefon</label>\r\n    <input class=\"form-control\" name=\"Telefon\"");
            BeginWriteAttribute("value", " value=\"", 501, "\"", 525, 1);
#nullable restore
#line 19 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\MusteriPanel\YeniSiparis.cshtml"
WriteAttributeValue("", 509, ViewBag.telefon, 509, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Telefon Giriniz\" required />\r\n    <br />\r\n    <label>Müşteri EPosta</label>\r\n    <input class=\"form-control\" name=\"EPosta\"");
            BeginWriteAttribute("value", " value=\"", 662, "\"", 685, 1);
#nullable restore
#line 22 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\MusteriPanel\YeniSiparis.cshtml"
WriteAttributeValue("", 670, ViewBag.eposta, 670, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""EPosta Giriniz"" required />
    <br />
    <label>Ürün Adı</label>
    <input class=""form-control"" name=""Urun"" placeholder=""Ürün Giriniz"" required />
    <br />
    <label>Adres</label>
    <input class=""form-control"" name=""Adres"" placeholder=""Adres Giriniz"" required />
    <br />
    <label>Adet</label>
    <input class=""form-control"" name=""Adet"" placeholder=""Adet Giriniz"" required />
    <br />
    <input type=""submit"" value=""Sipariş Kaydet"" class=""btn btn-secondary"" required />
");
#nullable restore
#line 34 "C:\Users\profe\Desktop\VisualProjects\DevamEdenProjeler\SiparisTakipSistemiCore\SiparisTakipSistemiCore\Views\MusteriPanel\YeniSiparis.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiparisTakipSistemiCore.Models.Entities.Siparis> Html { get; private set; }
    }
}
#pragma warning restore 1591
