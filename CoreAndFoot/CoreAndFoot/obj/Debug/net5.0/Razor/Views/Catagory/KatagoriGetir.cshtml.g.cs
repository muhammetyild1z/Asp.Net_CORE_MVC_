#pragma checksum "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Catagory\KatagoriGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a587fe85f3dd5b8b00cef3abfadbfc7d3835e71c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catagory_KatagoriGetir), @"mvc.1.0.view", @"/Views/Catagory/KatagoriGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a587fe85f3dd5b8b00cef3abfadbfc7d3835e71c", @"/Views/Catagory/KatagoriGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2404951fb3d3c24fc6ef8540fe126c299c7a950", @"/Views/_ViewImports.cshtml")]
    public class Views_Catagory_KatagoriGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFoot.Data.Models.Catagory>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Catagory\KatagoriGetir.cshtml"
  
    ViewData["Title"] = "KatagoriGetir";
    Layout = "~/Views/Shared/_Layout_1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Katagori Güncelle</h1>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a587fe85f3dd5b8b00cef3abfadbfc7d3835e71c3974", async() => {
                WriteLiteral("\r\n    <strong>Katagori Ad</strong>\r\n    ");
#nullable restore
#line 11 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Catagory\KatagoriGetir.cshtml"
Write(Html.TextBoxFor(x => x.CatagoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <strong>Katagori Açıklama</strong>\r\n    <br />\r\n    ");
#nullable restore
#line 15 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Catagory\KatagoriGetir.cshtml"
Write(Html.TextAreaFor(x => x.CatagoryDesc, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <strong>Durum</strong>\r\n    ");
#nullable restore
#line 18 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Catagory\KatagoriGetir.cshtml"
Write(Html.TextBoxFor(x => x.Status, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <br />\r\n    <button class=\"btn btn-info\">\r\n        Güncelle\r\n    </button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 191, "/Catagory/KatagoriGuncelle/", 191, 27, true);
#nullable restore
#line 9 "C:\Users\Muhammet\Desktop\Doyalar\projeler\.CORE\CoreAndFoot\CoreAndFoot\Views\Catagory\KatagoriGetir.cshtml"
AddHtmlAttributeValue("", 218, Model.CatagoryID, 218, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFoot.Data.Models.Catagory> Html { get; private set; }
    }
}
#pragma warning restore 1591