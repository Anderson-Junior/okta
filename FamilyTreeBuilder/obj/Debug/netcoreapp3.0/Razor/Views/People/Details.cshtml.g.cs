#pragma checksum "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b218eb638cceb719ef29ff476679f9b0dd1915cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Details), @"mvc.1.0.view", @"/Views/People/Details.cshtml")]
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
#line 1 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\_ViewImports.cshtml"
using FamilyTreeBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\_ViewImports.cshtml"
using FamilyTreeBuilder.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b218eb638cceb719ef29ff476679f9b0dd1915cc", @"/Views/People/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ffc5f5395389f8772657b06d20c3cfe41d9c65", @"/Views/_ViewImports.cshtml")]
    public class Views_People_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FamilyTreeBuilder.Models.PersonViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
 if (Model.Person.MotherNavigation == null && Model.Person.FatherNavigation == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Nenhuma informação sobre os pais disponível</b>\r\n    <br />\r\n");
#nullable restore
#line 13 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
 if (Model.Person.FatherNavigation != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Pai: </b>");
#nullable restore
#line 16 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
            Write(Model.Person.FatherNavigation.FirstName + " " + Model.Person.FatherNavigation.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b218eb638cceb719ef29ff476679f9b0dd1915cc6228", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
                              WriteLiteral(Model.Person.FatherNavigation.Id);

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
            WriteLiteral("\r\n    <br />\r\n");
#nullable restore
#line 19 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
 if (Model.Person.MotherNavigation != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <b>Mãe: </b>");
#nullable restore
#line 22 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
            Write(Model.Person.MotherNavigation.FirstName + " " + Model.Person.MotherNavigation.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b218eb638cceb719ef29ff476679f9b0dd1915cc9416", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
                              WriteLiteral(Model.Person.MotherNavigation.Id);

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
            WriteLiteral("\r\n    <br />\r\n");
#nullable restore
#line 25 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 27 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
Write(Model.Person.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
                       Write(Model.Person.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<b>Sexo: ");
#nullable restore
#line 28 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
    Write(Model.Person.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n\r\n<table>\r\n    <tr>\r\n");
#nullable restore
#line 32 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
         if (Model.Person.BirthDate != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Data de nascimento</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
           Write(Model.Person.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 36 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n    <tr>\r\n");
#nullable restore
#line 39 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
         if (Model.Person.DeathDate != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Data da morte</td>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
           Write(Model.Person.DeathDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 43 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n</table>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b218eb638cceb719ef29ff476679f9b0dd1915cc14894", async() => {
                WriteLiteral("Editar");
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
#line 47 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
                           WriteLiteral(Model.Person.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b218eb638cceb719ef29ff476679f9b0dd1915cc17117", async() => {
                WriteLiteral("Voltar para a lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 50 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
 if (!Model.Children.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Sem filhos</h3>\r\n");
#nullable restore
#line 53 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <h4>Filhos</h4>
    <table class=""table"">
        <thead>
            <tr>
                <th>Primeiro nome</th>
                <th>Último nome</th>
                <th>Data de nascimento</th>
                <th>Data da morte</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 68 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
             foreach (var item in Model.Children)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 72 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
                   Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 73 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
                   Write(item.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 74 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
                   Write(item.DeathDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b218eb638cceb719ef29ff476679f9b0dd1915cc20983", async() => {
                WriteLiteral("Editar");
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
#line 76 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
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
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b218eb638cceb719ef29ff476679f9b0dd1915cc23238", async() => {
                WriteLiteral("Detalhes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
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
            WriteLiteral(" |\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b218eb638cceb719ef29ff476679f9b0dd1915cc25498", async() => {
                WriteLiteral("Deletar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 81 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 84 "C:\Users\a.lemos\Desktop\Estudos .NET\Projeto web okta developer\NovoFamilyTreeBuilder\FamilyTreeBuilder\FamilyTreeBuilder\Views\People\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FamilyTreeBuilder.Models.PersonViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
