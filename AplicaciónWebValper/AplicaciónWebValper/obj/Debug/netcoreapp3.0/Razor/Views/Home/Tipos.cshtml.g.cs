#pragma checksum "D:\Documentos\Valper\ProyectoEmpresaValper\AplicaciónWebValper\AplicaciónWebValper\Views\Home\Tipos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fb001059c86fe20ff2acb1e1fc4957ed2f4f991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tipos), @"mvc.1.0.view", @"/Views/Home/Tipos.cshtml")]
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
#line 1 "D:\Documentos\Valper\ProyectoEmpresaValper\AplicaciónWebValper\AplicaciónWebValper\Views\_ViewImports.cshtml"
using AplicaciónWebValper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documentos\Valper\ProyectoEmpresaValper\AplicaciónWebValper\AplicaciónWebValper\Views\_ViewImports.cshtml"
using AplicaciónWebValper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fb001059c86fe20ff2acb1e1fc4957ed2f4f991", @"/Views/Home/Tipos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"275a22a58f65bea9c7075eb6f2e80bf3e771ca66", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tipos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AplicaciónWebValper.Controllers.HomeController.Tipo>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Documentos\Valper\ProyectoEmpresaValper\AplicaciónWebValper\AplicaciónWebValper\Views\Home\Tipos.cshtml"
  
    ViewData["Title"] = "Tipos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Tipos</h1>\r\n\r\n");
#nullable restore
#line 9 "D:\Documentos\Valper\ProyectoEmpresaValper\AplicaciónWebValper\AplicaciónWebValper\Views\Home\Tipos.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 13 "D:\Documentos\Valper\ProyectoEmpresaValper\AplicaciónWebValper\AplicaciónWebValper\Views\Home\Tipos.cshtml"
   Write(Html.LabelFor(Model => Model.idTipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "D:\Documentos\Valper\ProyectoEmpresaValper\AplicaciónWebValper\AplicaciónWebValper\Views\Home\Tipos.cshtml"
   Write(Html.EditorFor(Model => Model.idTipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 18 "D:\Documentos\Valper\ProyectoEmpresaValper\AplicaciónWebValper\AplicaciónWebValper\Views\Home\Tipos.cshtml"
   Write(Html.LabelFor(Model => Model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "D:\Documentos\Valper\ProyectoEmpresaValper\AplicaciónWebValper\AplicaciónWebValper\Views\Home\Tipos.cshtml"
   Write(Html.EditorFor(Model => Model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 23 "D:\Documentos\Valper\ProyectoEmpresaValper\AplicaciónWebValper\AplicaciónWebValper\Views\Home\Tipos.cshtml"
   Write(Html.LabelFor(Model => Model.tipoBasico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 24 "D:\Documentos\Valper\ProyectoEmpresaValper\AplicaciónWebValper\AplicaciónWebValper\Views\Home\Tipos.cshtml"
   Write(Html.EditorFor(Model => Model.tipoBasico));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"enviar\" />\r\n");
#nullable restore
#line 28 "D:\Documentos\Valper\ProyectoEmpresaValper\AplicaciónWebValper\AplicaciónWebValper\Views\Home\Tipos.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AplicaciónWebValper.Controllers.HomeController.Tipo> Html { get; private set; }
    }
}
#pragma warning restore 1591
