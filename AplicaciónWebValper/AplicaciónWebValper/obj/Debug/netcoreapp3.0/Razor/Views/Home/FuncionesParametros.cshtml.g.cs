#pragma checksum "C:\Users\gonza\source\repos\AplicaciónWebValper\AplicaciónWebValper\Views\Home\FuncionesParametros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db3811bc5a440a11e56ebba9b1f22bd480f1c508"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FuncionesParametros), @"mvc.1.0.view", @"/Views/Home/FuncionesParametros.cshtml")]
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
#line 1 "C:\Users\gonza\source\repos\AplicaciónWebValper\AplicaciónWebValper\Views\_ViewImports.cshtml"
using AplicaciónWebValper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gonza\source\repos\AplicaciónWebValper\AplicaciónWebValper\Views\_ViewImports.cshtml"
using AplicaciónWebValper.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db3811bc5a440a11e56ebba9b1f22bd480f1c508", @"/Views/Home/FuncionesParametros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"275a22a58f65bea9c7075eb6f2e80bf3e771ca66", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FuncionesParametros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AplicaciónWebValper.Controllers.HomeController.FuncionParametro>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\gonza\source\repos\AplicaciónWebValper\AplicaciónWebValper\Views\Home\FuncionesParametros.cshtml"
  
    ViewData["Title"] = "FuncionesParametros";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>FuncionesParametros</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\gonza\source\repos\AplicaciónWebValper\AplicaciónWebValper\Views\Home\FuncionesParametros.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 13 "C:\Users\gonza\source\repos\AplicaciónWebValper\AplicaciónWebValper\Views\Home\FuncionesParametros.cshtml"
   Write(Html.LabelFor(Model => Model.idFuncion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "C:\Users\gonza\source\repos\AplicaciónWebValper\AplicaciónWebValper\Views\Home\FuncionesParametros.cshtml"
   Write(Html.EditorFor(Model => Model.idFuncion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 18 "C:\Users\gonza\source\repos\AplicaciónWebValper\AplicaciónWebValper\Views\Home\FuncionesParametros.cshtml"
   Write(Html.LabelFor(Model => Model.idParametro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 19 "C:\Users\gonza\source\repos\AplicaciónWebValper\AplicaciónWebValper\Views\Home\FuncionesParametros.cshtml"
   Write(Html.EditorFor(Model => Model.idParametro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"enviar\" />\r\n");
#nullable restore
#line 23 "C:\Users\gonza\source\repos\AplicaciónWebValper\AplicaciónWebValper\Views\Home\FuncionesParametros.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AplicaciónWebValper.Controllers.HomeController.FuncionParametro> Html { get; private set; }
    }
}
#pragma warning restore 1591
