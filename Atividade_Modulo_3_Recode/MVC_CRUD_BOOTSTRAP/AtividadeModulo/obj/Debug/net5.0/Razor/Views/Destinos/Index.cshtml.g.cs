#pragma checksum "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\Destinos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6a8df3fee5247f4a3e5441e69ee84d75dff46e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destinos_Index), @"mvc.1.0.view", @"/Views/Destinos/Index.cshtml")]
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
#line 1 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\_ViewImports.cshtml"
using AtividadeModulo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\_ViewImports.cshtml"
using AtividadeModulo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6a8df3fee5247f4a3e5441e69ee84d75dff46e0", @"/Views/Destinos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"264c2145d8a876959308215e50450ae46fcc40ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Destinos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AtividadeModulo.Models.Destino>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\Destinos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--   -------------------------------------------------------------  -->\r\n   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6a8df3fee5247f4a3e5441e69ee84d75dff46e07692", async() => {
                WriteLiteral("\r\n<!-- bootstrap css -->\r\n      <link rel=\"stylesheet\" href=\"css/bootstrap.min.css\">\r\n      <!-- style css -->\r\n      <link rel=\"stylesheet\" href=\"css/style.css\">\r\n      <!-- Responsive-->\r\n      <link rel=\"stylesheet\" href=\"css/responsive.css\">\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d6a8df3fee5247f4a3e5441e69ee84d75dff46e08225", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d6a8df3fee5247f4a3e5441e69ee84d75dff46e09405", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n      <link rel=\"stylesheet\" href=\"https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css\">\r\n");
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
            WriteLiteral("\r\n\r\n\r\n<h1>Lista de Destinos Cadastrados no Banco de Dados</h1>\r\n<p>Para adicionar um novo destino clique no botão!</p>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6a8df3fee5247f4a3e5441e69ee84d75dff46e011540", async() => {
                WriteLiteral("Adicionar Novo Destino");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\Destinos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\Destinos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\Destinos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Pais));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\Destinos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\Destinos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\Destinos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\Destinos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Pais));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6a8df3fee5247f4a3e5441e69ee84d75dff46e015533", async() => {
                WriteLiteral("Atualizar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\Destinos\Index.cshtml"
                                                            WriteLiteral(item.IdDestino);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6a8df3fee5247f4a3e5441e69ee84d75dff46e017877", async() => {
                WriteLiteral("Detalhes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\Destinos\Index.cshtml"
                                                                    WriteLiteral(item.IdDestino);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6a8df3fee5247f4a3e5441e69ee84d75dff46e020228", async() => {
                WriteLiteral("Remover");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\Destinos\Index.cshtml"
                                                                WriteLiteral(item.IdDestino);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 59 "C:\Users\Remakker\Desktop\Atividade prática módulo 3\Atividade_Modulo_3_Recode\MVC_CRUD_BOOTSTRAP\AtividadeModulo\Views\Destinos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<hr />

<!-- Destinos -->
      <div  class=""our_room"">
         <div class=""container"">
            <div class=""row"">
               <div class=""col-md-12"">
                  <div class=""titlepage"">
                     <h2>Destinos</h2>
                     <p>Descubra lugares incríveis </p>
                  </div>
               </div>
            </div>
            <div class=""row"">
               <div class=""col-md-4 col-sm-6"">
                  <div id=""serv_hover""  class=""room"">
                     <div class=""room_img"">
                        <figure><img src=""https://img-s-msn-com.akamaized.net/tenant/amp/entityid/AAsLSK4.img?h=552&w=750&m=6&q=60&u=t&o=f&l=f&x=1245&y=1406"" alt=""#""/></figure>
                     </div>
                     <div class=""bed_room"">
                        <h3>Cairo - Egito</h3>
                        <p>Cairo, a grande capital do Egito, está localizada às margens do rio Nilo.
                                Em seu centro");
            WriteLiteral(@",
                                ficam a Praça Tahrir e o amplo Museu Egípcio, que exibe uma coleção de antiguidades,
                                como múmias reais e artefatos dourados do Rei Tutancâmon. Perto dali fica Gizé, local
                                das famosas pirâmides e da Grande Esfinge, que data do século XXVI a.C. Na área
                                arborizada de Zamalek, na ilha de Gezira, a Torre do Cairo, com 187 m de altura,
                                proporciona vistas panorâmicas da cidade. </p>
                     </div>
                  </div>
               </div>
               <div class=""col-md-4 col-sm-6"">
                  <div id=""serv_hover""  class=""room"">
                     <div class=""room_img"">
                        <figure><img src=""https://www.passagenspromo.com.br/blog/wp-content/uploads/2019/06/pontos-turisticos-de-roma-740x415.jpg"" alt=""#""/></figure>
                     </div>
                     <div class=""bed_room"">
          ");
            WriteLiteral(@"              <h3>Roma - Itália</h3>
                        <p>Roma, a capital da Itália, é uma cidade cosmopolita, enorme, com quase
                                3.000 anos de
                                arte, arquitetura e cultura influentes no mundo todo e à mostra. Ruínas antigas como o
                                Fórum e o Coliseu evocam o poder do antigo Império Romano. A Cidade do Vaticano, sede da
                                Igreja Católica Romana, tem a Basílica de São Pedro e os museus do Vaticano, que abrigam
                                obras-primas como os afrescos da Capela Sistina de Michelângelo. </p>
                     </div>
                  </div>
               </div>
               <div class=""col-md-4 col-sm-6"">
                  <div id=""serv_hover""  class=""room"">
                     <div class=""room_img"">
                        <figure><img src=""https://s2.glbimg.com/K4ASyiPUaK-mB4Lh-i9Fc9jv7gg=/e.glbimg.com/og/ed/f/original/2016/01/07/torre_eiffel_");
            WriteLiteral(@"1.jpg"" alt=""#""/></figure>
                     </div>
                     <div class=""bed_room"">
                        <h3>Paris - França</h3>
                        <p>Paris, a capital da França, é uma importante cidade europeia e um centro
                                mundial de arte,
                                moda, gastronomia e cultura. Sua paisagem urbana do século XIX é cortada por avenidas
                                largas e pelo rio Sena. A cidade é conhecida por monumentos como a Torre Eiffel e a
                                Catedral de Notre-Dame, uma construção gótica do século XII, sendo famosa também pela
                                cultura dos cafés e por lojas de estilistas famosos na Rue du Faubourg Saint-Honoré. </p>
                     </div>
                  </div>
               </div>
               <div class=""col-md-4 col-sm-6"">
                  <div id=""serv_hover""  class=""room"">
                     <div class=""room_img"">
                   ");
            WriteLiteral(@"     <figure><img src=""https://media-cdn.tripadvisor.com/media/photo-s/16/70/02/04/preciso-de-dicas-para.jpg"" alt=""#""/></figure>
                     </div>
                     <div class=""bed_room"">
                        <h3>Tokyo - Japão</h3>
                        <p>A Metrópole de Tóquio está dividida em 23 regiões especiais e 30 outros
                                municípios comuns
                                (cidades, vilas e aldeias). As regiões especiais ocupam a terra que era originalmente a
                                Cidade de Tóquio antes de ser abolida em 1943. A população total das 23 regiões especias
                                é de 8,28 milhões (estimativa de 2002) – ou seja, cerca de dois terços da população da
                                Metrópole de Tóquio e um quarto da população da Área da Grande Tóquio. A sua densidade
                                populacional é de 13.333 habitantes por quilómetro quadrado. </p>
                     </div>
          ");
            WriteLiteral(@"        </div>
               </div>
               <div class=""col-md-4 col-sm-6"">
                  <div id=""serv_hover""  class=""room"">
                     <div class=""room_img"">
                        <figure><img src=""https://aiesec.org.br/wp-content/uploads/2021/05/Destinos-America-do-Sul_Machu-Picchu.jpeg"" alt=""#""/></figure>
                     </div>
                     <div class=""bed_room"">
                        <h3>Machu Picchu - Peru</h3>
                        <p> Machu Picchu é uma cidadela inca que fica no alto da Cordilheira dos Andes
                                no Peru, acima do vale do rio Urubamba. Construída no século XV e posteriormente abandonada, ela é
                                conhecida pelas sofisticadas muralhas de pedra contínuas, cujos imensos blocos foram
                                unidos sem o uso de argamassa, pelas construções intrigantes que levam em conta o
                                alinhamento dos astros e pelas vistas panorâmicas. A a");
            WriteLiteral(@"ntiga utilidade dessas construções
                                segue sendo um mistério. </p>
                     </div>
                  </div>
               </div>
               <div class=""col-md-4 col-sm-6"">
                  <div id=""serv_hover""  class=""room"">
                     <div class=""room_img"">
                        <figure><img src=""https://visita.ai/wp-content/uploads/2021/04/atracoes-rio-de-janeiro-cristo.jpg"" alt=""#""/></figure>
                     </div>
                     <div class=""bed_room"">
                        <h3>Rio de Janeiro - Brasil</h3>
                        <p>O Rio de Janeiro é uma grande cidade brasileira à beira-mar, famosa pelas
                                praias de
                                Copacabana e Ipanema, pela estátua de 38 metros de altura do Cristo Redentor, no topo do
                                Corcovado, e pelo Pão de Açúcar, um pico de granito com teleféricos até seu cume. A
                                cidade t");
            WriteLiteral(@"ambém é conhecida pelas grandes favelas. O empolgante Carnaval, com carros
                                alegóricos, fantasias extravagantes e sambistas, é considerado o maior do mundo. </p>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
      <!-- Fim Destinos -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AtividadeModulo.Models.Destino>> Html { get; private set; }
    }
}
#pragma warning restore 1591
