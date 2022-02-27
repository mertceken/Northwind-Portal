// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NorthwindCrudApp.Pages.EditPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using NorthwindCrudApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using NorthwindCrudApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditSuppliers.razor"
using NorthwindCrudApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editsupplier/{supplierId:int}")]
    public partial class EditSuppliers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EditPages\EditSuppliers.razor"
       
    Supplier supplier = new Supplier();

    [Parameter]
    public int supplierId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if(supplierId!=0)
        {
            supplier = await supplierService.GetById(supplierId);
        }
    }



    protected async Task SupplierUpdate()
    {
        await supplierService.UpdateSupplier(supplier);
        navigationManager.NavigateTo("/suppliers");    
    }

    void Cancel()
    {
        navigationManager.NavigateTo("/suppliers");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindCrudApp.IService.ISupplierService supplierService { get; set; }
    }
}
#pragma warning restore 1591
