#pragma checksum "C:\Users\usuario\Desktop\ComIT\C#\Grupo compartido\tarea-grupal\MVC_Grupo_Form\Views\Home\ConsultaEnviada.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b7e1219d8a044503e2583729004ae5a9706a1a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ConsultaEnviada), @"mvc.1.0.view", @"/Views/Home/ConsultaEnviada.cshtml")]
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
#line 1 "C:\Users\usuario\Desktop\ComIT\C#\Grupo compartido\tarea-grupal\MVC_Grupo_Form\Views\_ViewImports.cshtml"
using MVC_Grupo_Form;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\usuario\Desktop\ComIT\C#\Grupo compartido\tarea-grupal\MVC_Grupo_Form\Views\_ViewImports.cshtml"
using MVC_Grupo_Form.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b7e1219d8a044503e2583729004ae5a9706a1a6", @"/Views/Home/ConsultaEnviada.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77758e04adc250c47af728eae5749375a497209d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ConsultaEnviada : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>\r\n    Gracias ");
#nullable restore
#line 2 "C:\Users\usuario\Desktop\ComIT\C#\Grupo compartido\tarea-grupal\MVC_Grupo_Form\Views\Home\ConsultaEnviada.cshtml"
       Write(ViewBag.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" por contactarte con nosotros.\r\n    Nos llego la siguiente consulta ");
#nullable restore
#line 3 "C:\Users\usuario\Desktop\ComIT\C#\Grupo compartido\tarea-grupal\MVC_Grupo_Form\Views\Home\ConsultaEnviada.cshtml"
                               Write(ViewBag.Consulta);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    La respuesta será enviada al siguiente mail ");
#nullable restore
#line 4 "C:\Users\usuario\Desktop\ComIT\C#\Grupo compartido\tarea-grupal\MVC_Grupo_Form\Views\Home\ConsultaEnviada.cshtml"
                                           Write(ViewBag.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <h3 style=\"color:blue\">\r\n        ");
#nullable restore
#line 7 "C:\Users\usuario\Desktop\ComIT\C#\Grupo compartido\tarea-grupal\MVC_Grupo_Form\Views\Home\ConsultaEnviada.cshtml"
   Write(ViewBag.Mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n\r\n         <h3 style=\"color:blue\">\r\n        ");
#nullable restore
#line 11 "C:\Users\usuario\Desktop\ComIT\C#\Grupo compartido\tarea-grupal\MVC_Grupo_Form\Views\Home\ConsultaEnviada.cshtml"
   Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h3>\r\n\r\n</p>");
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
