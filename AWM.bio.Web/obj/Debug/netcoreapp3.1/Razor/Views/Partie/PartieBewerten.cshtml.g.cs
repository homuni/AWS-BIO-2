#pragma checksum "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Partie/PartieBewerten.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12f3f566998f074385353fca6377a29467049882"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partie_PartieBewerten), @"mvc.1.0.view", @"/Views/Partie/PartieBewerten.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12f3f566998f074385353fca6377a29467049882", @"/Views/Partie/PartieBewerten.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"945512891e18412d472a3fcde3991b4d22e927ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Partie_PartieBewerten : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AWM.bio.Web.Data.AWM.Partie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Bewertung", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Partie/PartieBewerten.cshtml"
  
    ViewData["Title"] = "PartieBewerten";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <h1>Partie ");
#nullable restore
#line 8 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Partie/PartieBewerten.cshtml"
          Write(Model.Adresse);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Stellplatznotiz
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>
                    <ul>
                        ");
#nullable restore
#line 22 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Partie/PartieBewerten.cshtml"
                   Write(Model.Stellplatznotiz);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </ul>
                </td>
            </tr>
        </tbody>

    </table>


    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Tonnen
                </th>
            </tr>
        </thead>
        <tbody>
            <tr>
");
#nullable restore
#line 41 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Partie/PartieBewerten.cshtml"
                 foreach (var t in Model.Tonnen)
                {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                <td>");
#nullable restore
#line 45 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Partie/PartieBewerten.cshtml"
               Write(t.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12f3f566998f074385353fca6377a294670498825470", async() => {
                WriteLiteral("Tonne Bewerten");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Partie/PartieBewerten.cshtml"
                                                                        WriteLiteral(t.Id);

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
            WriteLiteral("\n                </td>\n                </tr>\n");
#nullable restore
#line 51 "/Users/huhuihui_mia/050526/AWM.bio.Web/Views/Partie/PartieBewerten.cshtml"
                
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </tr>\n            </tbody>\n    </table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AWM.bio.Web.Data.AWM.Partie> Html { get; private set; }
    }
}
#pragma warning restore 1591
