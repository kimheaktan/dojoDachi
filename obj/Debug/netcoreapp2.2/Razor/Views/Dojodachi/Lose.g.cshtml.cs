#pragma checksum "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojodachi/Views/Dojodachi/Lose.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42a050f67e206a17058b9a675f9670ac9bf3f332"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dojodachi_Lose), @"mvc.1.0.view", @"/Views/Dojodachi/Lose.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dojodachi/Lose.cshtml", typeof(AspNetCore.Views_Dojodachi_Lose))]
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
#line 1 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojodachi/Views/_ViewImports.cshtml"
using dojodachi;

#line default
#line hidden
#line 2 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojodachi/Views/_ViewImports.cshtml"
using dojodachi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a050f67e206a17058b9a675f9670ac9bf3f332", @"/Views/Dojodachi/Lose.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02c43adf8f00d921e1e3f242ef2bcc39f1c89303", @"/Views/_ViewImports.cshtml")]
    public class Views_Dojodachi_Lose : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dachi>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/straight.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "RestartPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojodachi/Views/Dojodachi/Lose.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(55, 70, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Play again?</h1>\n");
            EndContext();
            BeginContext(244, 53, true);
            WriteLiteral("</div>\n\n<div class=\"text-center\">\n    <div>Fullness: ");
            EndContext();
            BeginContext(298, 14, false);
#line 12 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojodachi/Views/Dojodachi/Lose.cshtml"
              Write(Model.Fullness);

#line default
#line hidden
            EndContext();
            BeginContext(312, 30, true);
            WriteLiteral("  </div> \n    <div>Happiness: ");
            EndContext();
            BeginContext(343, 15, false);
#line 13 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojodachi/Views/Dojodachi/Lose.cshtml"
               Write(Model.Happiness);

#line default
#line hidden
            EndContext();
            BeginContext(358, 22, true);
            WriteLiteral("</div>\n    <div>Meals:");
            EndContext();
            BeginContext(381, 11, false);
#line 14 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojodachi/Views/Dojodachi/Lose.cshtml"
          Write(Model.Meals);

#line default
#line hidden
            EndContext();
            BeginContext(392, 25, true);
            WriteLiteral(" </div>\n    <div>Energy: ");
            EndContext();
            BeginContext(418, 12, false);
#line 15 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojodachi/Views/Dojodachi/Lose.cshtml"
            Write(Model.Energy);

#line default
#line hidden
            EndContext();
            BeginContext(430, 103, true);
            WriteLiteral("</div> \n</div>\n    <div class=\"d-flex justify-content-around\" style=\"margin: 0 130px 0 130px\">\n        ");
            EndContext();
            BeginContext(533, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "42a050f67e206a17058b9a675f9670ac9bf3f3326497", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(593, 39, true);
            WriteLiteral("\n    </div>\n    <p class=\"text-center\">");
            EndContext();
            BeginContext(633, 15, false);
#line 20 "/Users/user/coding dojo/csharpNew/asp2_Mvc/dojodachi/Views/Dojodachi/Lose.cshtml"
                      Write(ViewBag.message);

#line default
#line hidden
            EndContext();
            BeginContext(648, 68, true);
            WriteLiteral("</p>\n\n<div class=\"d-flex justify-content-around mt-4\">\n    \n        ");
            EndContext();
            BeginContext(716, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "42a050f67e206a17058b9a675f9670ac9bf3f3328257", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(748, 10, true);
            WriteLiteral("\n</div>\n\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dachi> Html { get; private set; }
    }
}
#pragma warning restore 1591