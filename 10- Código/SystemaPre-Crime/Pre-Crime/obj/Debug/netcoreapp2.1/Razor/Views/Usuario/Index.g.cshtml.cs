#pragma checksum "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e792628c05fad5572824b672f79aa3f00e83ed8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
#line 1 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\_ViewImports.cshtml"
using Pre_Crime;

#line default
#line hidden
#line 2 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\_ViewImports.cshtml"
using Pre_Crime.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e792628c05fad5572824b672f79aa3f00e83ed8", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91503b7d04aed8ba5f13e89a061b037992b74f8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Model.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Lista de Usuários";

#line default
#line hidden
            BeginContext(97, 41, true);
            WriteLiteral("\r\n<h2>Lista de Usuários</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(138, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d48591360a747068c63fcc19a1ee39f", async() => {
                BeginContext(161, 17, true);
                WriteLiteral("Adicionar um novo");
                EndContext();
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
            EndContext();
            BeginContext(182, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
#line 12 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
 if (Model == null)
{

#line default
#line hidden
            BeginContext(214, 43, true);
            WriteLiteral("    <p>Não existe pessoal cadastradas</p>\r\n");
            EndContext();
#line 15 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
}
else
{


#line default
#line hidden
            BeginContext(271, 104, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(376, 41, false);
#line 23 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(417, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(485, 41, false);
#line 26 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(526, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(594, 42, false);
#line 29 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(636, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(704, 42, false);
#line 32 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(746, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 38 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(909, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(982, 40, false);
#line 42 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1102, 40, false);
#line 45 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Senha));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1222, 41, false);
#line 48 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1343, 41, false);
#line 51 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Cidade));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1464, 53, false);
#line 54 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1546, 59, false);
#line 55 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1605, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1634, 57, false);
#line 56 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 59 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1758, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 62 "E:\UFS\UFS2018.1\2018.1\Engenharia 2\pre-crime\10- Código\SystemaPre-Crime\Pre-Crime\Views\Usuario\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Model.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
