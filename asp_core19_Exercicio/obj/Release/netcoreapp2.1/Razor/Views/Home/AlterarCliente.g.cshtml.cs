#pragma checksum "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0b5737f91a30db7a91fec5a6244a513ebc13d4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AlterarCliente), @"mvc.1.0.view", @"/Views/Home/AlterarCliente.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AlterarCliente.cshtml", typeof(AspNetCore.Views_Home_AlterarCliente))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b5737f91a30db7a91fec5a6244a513ebc13d4b", @"/Views/Home/AlterarCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AlterarCliente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<asp_core19_Exercicio.Models.Cliente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListarClientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AlterarClienteGravar1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarCliente.cshtml"
  
    ViewData["SubTitle"] = "Alterar Cliente "; //Model.Nome
    int id = Model.Id_Cliente;

#line default
#line hidden
            BeginContext(144, 21, true);
            WriteLiteral("\r\n<h2 class=\"titulo\">");
            EndContext();
            BeginContext(166, 16, false);
#line 7 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarCliente.cshtml"
              Write(ViewBag.SubTitle);

#line default
#line hidden
            EndContext();
            BeginContext(182, 52, true);
            WriteLiteral("</h2>\r\n<hr />\r\n<div class=\"card bg-light p-5\">\r\n    ");
            EndContext();
            BeginContext(234, 819, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a0874062924b399d7716af38742235", async() => {
                BeginContext(319, 11, true);
                WriteLiteral("\r\n         ");
                EndContext();
                BeginContext(331, 41, false);
#line 11 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarCliente.cshtml"
    Write(Html.HiddenFor(model => model.Id_Cliente));

#line default
#line hidden
                EndContext();
                BeginContext(372, 48, true);
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
                EndContext();
                BeginContext(421, 34, false);
#line 13 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarCliente.cshtml"
       Write(Html.LabelFor(model => model.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(455, 20, true);
                WriteLiteral("<br />\r\n            ");
                EndContext();
                BeginContext(476, 35, false);
#line 14 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarCliente.cshtml"
       Write(Html.EditorFor(model => model.Nome));

#line default
#line hidden
                EndContext();
                BeginContext(511, 20, true);
                WriteLiteral("<br />\r\n            ");
                EndContext();
                BeginContext(532, 38, false);
#line 15 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarCliente.cshtml"
       Write(Html.LabelFor(model => model.Telefone));

#line default
#line hidden
                EndContext();
                BeginContext(570, 20, true);
                WriteLiteral("<br />\r\n            ");
                EndContext();
                BeginContext(591, 39, false);
#line 16 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarCliente.cshtml"
       Write(Html.EditorFor(model => model.Telefone));

#line default
#line hidden
                EndContext();
                BeginContext(630, 20, true);
                WriteLiteral("<br />\r\n            ");
                EndContext();
                BeginContext(651, 36, false);
#line 17 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarCliente.cshtml"
       Write(Html.LabelFor(model => model.Morada));

#line default
#line hidden
                EndContext();
                BeginContext(687, 21, true);
                WriteLiteral(" <br />\r\n            ");
                EndContext();
                BeginContext(709, 37, false);
#line 18 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarCliente.cshtml"
       Write(Html.EditorFor(model => model.Morada));

#line default
#line hidden
                EndContext();
                BeginContext(746, 20, true);
                WriteLiteral("<br />\r\n            ");
                EndContext();
                BeginContext(767, 33, false);
#line 19 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarCliente.cshtml"
       Write(Html.LabelFor(model => model.Cep));

#line default
#line hidden
                EndContext();
                BeginContext(800, 20, true);
                WriteLiteral("<br />\r\n            ");
                EndContext();
                BeginContext(821, 34, false);
#line 20 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarCliente.cshtml"
       Write(Html.EditorFor(model => model.Cep));

#line default
#line hidden
                EndContext();
                BeginContext(855, 32, true);
                WriteLiteral("<br />\r\n        </div>\r\n        ");
                EndContext();
                BeginContext(887, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef19b54c4e164bf8b4bbb7feb74de264", async() => {
                    BeginContext(964, 15, true);
                    WriteLiteral("Cancelar\\Voltar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(983, 63, true);
                WriteLiteral("\r\n        <button class=\"btn btn-primary\">Gravar</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarCliente.cshtml"
                                                                     WriteLiteral(Model);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1053, 16, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<asp_core19_Exercicio.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
