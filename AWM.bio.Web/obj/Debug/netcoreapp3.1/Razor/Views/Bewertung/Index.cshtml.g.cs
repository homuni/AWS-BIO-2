#pragma checksum "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71514e098f73ea76f4b571275eb5430bfcb161c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bewertung_Index), @"mvc.1.0.view", @"/Views/Bewertung/Index.cshtml")]
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
#line 1 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/_ViewImports.cshtml"
using AWM.bio.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/_ViewImports.cshtml"
using AWM.bio.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71514e098f73ea76f4b571275eb5430bfcb161c7", @"/Views/Bewertung/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"945512891e18412d472a3fcde3991b4d22e927ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Bewertung_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AWM.bio.Web.Data.AWM.Bewertung>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!-- CSS Aufruf -->\n");
#nullable restore
#line 4 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71514e098f73ea76f4b571275eb5430bfcb161c74457", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>Index</title>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71514e098f73ea76f4b571275eb5430bfcb161c75494", async() => {
                WriteLiteral("\n\n        <p>\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71514e098f73ea76f4b571275eb5430bfcb161c75775", async() => {
                    WriteLiteral("Create New");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </p>\n\n    <table class=\"table\">\n        <thead>\n            <tr>\n                <th>\n                    ");
#nullable restore
#line 25 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Datum));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 28 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    PartieAdresse\n                </th>\n                <th>\n                    ");
#nullable restore
#line 34 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Tonne));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    Kunde\n                </th>\n                <th>\n                    ");
#nullable restore
#line 40 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Notiz));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 43 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Foto));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 46 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Defekt));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </th>\n            </tr>\n        </thead>\n        <tbody>\n\n");
#nullable restore
#line 52 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 56 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Datum));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\r\n                    ");
#nullable restore
#line 59 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
#nullable disable
                WriteLiteral("             \r\n                </td>\n                <td>\n                    ");
#nullable restore
#line 62 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
               Write(Html.DisplayFor(modelitem=> item.Tonne.Partie.Adresse));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 65 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tonne));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\r\n                    ");
#nullable restore
#line 68 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.Tonne.Partie.Kunde.Nachname));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\n                <td>\n                    ");
#nullable restore
#line 71 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Notiz));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </td>\n                <td>\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71514e098f73ea76f4b571275eb5430bfcb161c711317", async() => {
                    WriteLiteral("Details");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" |\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71514e098f73ea76f4b571275eb5430bfcb161c713548", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 78 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Bewertung/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\n    </table>\n");
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
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AWM.bio.Web.Data.AWM.Bewertung>> Html { get; private set; }
    }
}
#pragma warning restore 1591
