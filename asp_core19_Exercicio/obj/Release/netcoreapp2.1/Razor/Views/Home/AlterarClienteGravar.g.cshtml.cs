#pragma checksum "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarClienteGravar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d428c98c0781f2bb56261794e0e52c952118009c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AlterarClienteGravar), @"mvc.1.0.view", @"/Views/Home/AlterarClienteGravar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/AlterarClienteGravar.cshtml", typeof(AspNetCore.Views_Home_AlterarClienteGravar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d428c98c0781f2bb56261794e0e52c952118009c", @"/Views/Home/AlterarClienteGravar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AlterarClienteGravar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<asp_core19_Exercicio.Models.Cliente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AlterarCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListarClientes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarClienteGravar.cshtml"
  
    ViewData["SubTitle"] = "Validando a Alteração de Cliente";
    int id_cliente = Convert.ToUInt16(Model.Id_Cliente);
    string sNome = string.Empty;
    string sMorada = string.Empty;

    // coletando Nome
    if (Model.Nome == null)
    {
        sNome = string.Empty;
    }
    else
    {
        sNome = Model.Nome.ToString();
    }
    // coletando Morada
    if (Model.Morada == null)
    {
        sMorada = string.Empty;
    }
    else
    {
        sMorada = Model.Morada.ToString();
    }


#line default
#line hidden
            BeginContext(579, 21, true);
            WriteLiteral("\r\n<h2 class=\"titulo\">");
            EndContext();
            BeginContext(601, 16, false);
#line 29 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarClienteGravar.cshtml"
              Write(ViewBag.SubTitle);

#line default
#line hidden
            EndContext();
            BeginContext(617, 50, true);
            WriteLiteral("</h2>\r\n<hr />\r\n<div class=\"card bg-light p-5\">\r\n\r\n");
            EndContext();
#line 33 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarClienteGravar.cshtml"
      

        bool avancar = true;


        if ((id_cliente == 0) || (sNome == string.Empty) ||(sMorada == string.Empty) )
        {
            avancar = false;

#line default
#line hidden
            BeginContext(840, 100, true);
            WriteLiteral("            <h1>ATENÇÃO !</h1><p>Preencha Corretamente TODOS os campos</p>            \r\n            ");
            EndContext();
            BeginContext(940, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77796ee9889b4d8283bc3d03d3176c44", async() => {
                BeginContext(1050, 6, true);
                WriteLiteral("Voltar");
                EndContext();
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
#line 42 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarClienteGravar.cshtml"
                                                                   WriteLiteral(Model.Id_Cliente);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1060, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarClienteGravar.cshtml"
        }
        if (avancar)
        {
            asp_core19_Exercicio.Models.Dados.AlterarCliente(Model);

#line default
#line hidden
            BeginContext(1176, 80, true);
            WriteLiteral("            <h3>ATENÇÃO !</h3><p>Cliente Alterado com SUCESSO!</p>\r\n            ");
            EndContext();
            BeginContext(1256, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f22b586d7630459b98631d59a421ee80", async() => {
                BeginContext(1333, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1343, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 49 "C:\Users\rossa\OneDrive\Documentos\C#\ASPNET_Core\asp_core19_Exercicio\asp_core19_Exercicio\Views\Home\AlterarClienteGravar.cshtml"
        }
    

#line default
#line hidden
            BeginContext(1363, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
