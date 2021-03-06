#pragma checksum "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\Pages\Registros\RPrestamo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ba6d979c44f463a56aedd4c6ebb60a7fbda4c68"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace RegistroPrestamo.Pages.Registros
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\_Imports.razor"
using RegistroPrestamo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\_Imports.razor"
using RegistroPrestamo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\Pages\Registros\RPrestamo.razor"
using RegistroPrestamo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\Pages\Registros\RPrestamo.razor"
using RegistroPrestamo.BLL;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Prestamo")]
    public partial class RPrestamo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\RONALD\source\BlazorApp\RegistroPrestamo\Pages\Registros\RPrestamo.razor"
      
    private Prestamo prestamo = new Prestamo();

    public int PersonaSeleccionada { get; set; }

    List<Persona> ListaPersonas = new List<Persona>();

    [Parameter] public int PrestamoId { get; set; }

    protected override void OnInitialized()
    {
        Nuevo();
    }

    private void ObtenerBalance()
    {
        Persona persona = PersonaBLL.Buscar(PersonaSeleccionada);

        if (persona != null)
        {
            prestamo.PersonaId = persona.PersonaId;
            prestamo.Balance = persona.Balance;
        }
    }

    private void Nuevo()
    {
        prestamo = new Prestamo();
        ListaPersonas = PersonaBLL.GetList(c => true);
    }

    private void Guardar()
    {
        bool guardado;

        guardado = PrestamoBLL.Guardar(prestamo);

        if (guardado)
        {
            Nuevo();
            Toast.ShowSuccess("Se ha Guardado Exitosamente");
        }
        else
            Toast.ShowError("Error, no se pudo Guardar");
    }

    private void Buscar()
    {
         if (prestamo.PrestamoId > 0)
         {
             var encontrado = PrestamoBLL.Buscar(prestamo.PrestamoId);
             if (encontrado != null){
                 prestamo = encontrado;
				 Toast.ShowSuccess("Se ha Enconrado el Prestamo");
			 }else{
                 Toast.ShowWarning("No se pudo localizar el Prestamo indicado");
			 }
         }       
    }

    private void Eliminar()
    {
        bool elimino;

        elimino = PrestamoBLL.Eliminar(prestamo.PrestamoId);

        if (elimino)
        {
            Nuevo();
            Toast.ShowSuccess("Se ha Eliminado Exitosamente");
        }
        else
            Toast.ShowError("No se pudo localizar el Prestamo indicado");     
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService Toast { get; set; }
    }
}
#pragma warning restore 1591
