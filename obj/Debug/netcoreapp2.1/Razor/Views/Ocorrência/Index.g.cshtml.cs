#pragma checksum "C:\Users\lucas\Google Drive\PIM IV\HelpDesk\Views\Ocorrência\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbdcb15415b9afbb25e767ed0acb0c6d340b7258"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ocorrência_Index), @"mvc.1.0.view", @"/Views/Ocorrência/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ocorrência/Index.cshtml", typeof(AspNetCore.Views_Ocorrência_Index))]
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
#line 1 "C:\Users\lucas\Google Drive\PIM IV\HelpDesk\Views\_ViewImports.cshtml"
using HelpDesk;

#line default
#line hidden
#line 2 "C:\Users\lucas\Google Drive\PIM IV\HelpDesk\Views\_ViewImports.cshtml"
using HelpDesk.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbdcb15415b9afbb25e767ed0acb0c6d340b7258", @"/Views/Ocorrência/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c247f7295ac14acf1ea99fed5a7a4fde8a5af2", @"/Views/_ViewImports.cshtml")]
    public class Views_Ocorrência_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ocorrenciaForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lucas\Google Drive\PIM IV\HelpDesk\Views\Ocorrência\Index.cshtml"
  
    ViewData["Title"] = "Cadastrar ocorrência";

#line default
#line hidden
            BeginContext(56, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(61, 17, false);
#line 4 "C:\Users\lucas\Google Drive\PIM IV\HelpDesk\Views\Ocorrência\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(78, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(90, 19, false);
#line 5 "C:\Users\lucas\Google Drive\PIM IV\HelpDesk\Views\Ocorrência\Index.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(109, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 6 "C:\Users\lucas\Google Drive\PIM IV\HelpDesk\Views\Ocorrência\Index.cshtml"
  /*
            public string Numero { get; set; }
        public DateTime DataDeRegistro { get; set; }
        public DateTime DataDeVencimento { get; set; }
        public DateTime DataDeEncerramento { get; set; }
        public string Descrição { get; set; }
        public enum Status : int {Pendente = 0, Cancelada = 1, Resolvida = 2};
        public List<Acompanhamento> Acompanhamentos = new List<Acompanhamento>();
*/

#line default
#line hidden
            BeginContext(553, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3588d87f99004509a9cdcc68b0a7ef5f", async() => {
                BeginContext(581, 9, true);
                WriteLiteral(" \r\n    \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(597, 83, true);
            WriteLiteral("\r\n\r\n<textarea rows=\"8\" cols=\"50\" name=\"comment\" form=\"ocorrenciaForm\"></textarea>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
