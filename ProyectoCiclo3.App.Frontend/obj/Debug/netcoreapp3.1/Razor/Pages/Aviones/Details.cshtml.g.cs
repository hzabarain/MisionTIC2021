#pragma checksum "J:\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aviones\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba480a40115d8f55e906f7f3122df91753eace5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoCiclo3.App.Frontend.Pages.Aviones.Pages_Aviones_Details), @"mvc.1.0.razor-page", @"/Pages/Aviones/Details.cshtml")]
namespace ProyectoCiclo3.App.Frontend.Pages.Aviones
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
#line 1 "J:\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\_ViewImports.cshtml"
using ProyectoCiclo3.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba480a40115d8f55e906f7f3122df91753eace5a", @"/Pages/Aviones/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fac2ae24fef211f78e08fb554a390914631813e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Aviones_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "J:\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aviones\Details.cshtml"
  
    var avion = Model.Avion;

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<ul class=\"list-group list-group-flush\">\r\n  <li class=\"list-group-item\"> <b>id: </b> ");
#nullable restore
#line 8 "J:\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aviones\Details.cshtml"
                                      Write(avion.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n   <li class=\"list-group-item\"> <b>Marca: </b> ");
#nullable restore
#line 9 "J:\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aviones\Details.cshtml"
                                          Write(avion.marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"> <b>Modelo: </b> ");
#nullable restore
#line 10 "J:\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aviones\Details.cshtml"
                                          Write(avion.modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>Numero de Baños: </b> ");
#nullable restore
#line 11 "J:\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aviones\Details.cshtml"
                                                  Write(avion.numero_banos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>Numero de Asientos: </b> ");
#nullable restore
#line 12 "J:\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aviones\Details.cshtml"
                                                     Write(avion.numero_asientos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  <li class=\"list-group-item\"><b>Capacidad Maxima de Carga Y: </b> ");
#nullable restore
#line 13 "J:\ProyectoCiclo3.App\ProyectoCiclo3.App.Frontend\Pages\Aviones\Details.cshtml"
                                                              Write(avion.capacidad_max_carga);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\t\r\n  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoCiclo3.App.Frontend.Pages.DetailsAvionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsAvionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoCiclo3.App.Frontend.Pages.DetailsAvionModel>)PageContext?.ViewData;
        public ProyectoCiclo3.App.Frontend.Pages.DetailsAvionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
