#pragma checksum "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c8620cd397380186e2620663bfbfca87c46bd58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Index), @"mvc.1.0.view", @"/Views/Food/Index.cshtml")]
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
#line 1 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\_ViewImports.cshtml"
using CoreAndFoot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\_ViewImports.cshtml"
using CoreAndFoot.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c8620cd397380186e2620663bfbfca87c46bd58", @"/Views/Food/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2404951fb3d3c24fc6ef8540fe126c299c7a950", @"/Views/_ViewImports.cshtml")]
    public class Views_Food_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<CoreAndFoot.Data.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout_1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <br />
<h2>Ürün Listesi</h2>
<br />
<table class=""table table-bordered"">
    <tr>
        <th>ID</th>
        <th>Ad</th>
        <th>Fiyat</th>
        <th>Stok</th>
        <th>Katagori adı</th>
        <th>Sil</th>
        <th>Güncelle</th>
        <th>Detay</th>
    </tr>
");
#nullable restore
#line 25 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
           Write(item.FoodID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
           Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
           Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
           Write(item.Catagory.CatagoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 785, "\"", 818, 2);
            WriteAttributeValue("", 792, "/Food/FoodSil/", 792, 14, true);
#nullable restore
#line 33 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
WriteAttributeValue("", 806, item.FoodID, 806, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 875, "\"", 910, 2);
            WriteAttributeValue("", 882, "/Food/FoodGetir/", 882, 16, true);
#nullable restore
#line 34 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
WriteAttributeValue("", 898, item.FoodID, 898, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 973, "\"", 1008, 2);
            WriteAttributeValue("", 980, "/Food/FoodDetay/", 980, 16, true);
#nullable restore
#line 35 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
WriteAttributeValue("", 996, item.FoodID, 996, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Detay</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
#nullable restore
#line 42 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Food\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page   }), new PagedListRenderOptions {
                                                                          LiElementClasses = new string[] { "page-item" },
                                                                          PageClasses = new string[] { "page-link" },
                                                                          Display = PagedListDisplayMode.IfNeeded
}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<a href=\"/Food/FoodEkle\" class=\"btn btn-primary\">Yeni Ürün Ekle</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<CoreAndFoot.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
