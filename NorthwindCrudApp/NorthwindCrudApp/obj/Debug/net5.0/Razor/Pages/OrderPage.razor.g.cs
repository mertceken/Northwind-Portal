#pragma checksum "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef15553b86b32f36ae5b6e2d6ec381c198385d54"
// <auto-generated/>
#pragma warning disable 1591
namespace NorthwindCrudApp.Pages
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
#line 2 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
using NorthwindCrudApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/order")]
    public partial class OrderPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Order List Page</h3>\r\n\r\n");
            __Blazor.NorthwindCrudApp.Pages.OrderPage.TypeInference.CreateMatTable_0(__builder, 1, 2, 
#nullable restore
#line 6 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
                  orders

#line default
#line hidden
#nullable disable
            , 3, "oi-elevator", 4, (__builder2) => {
                __builder2.AddMarkupContent(5, "<th>OrderID</th>\r\n        ");
                __builder2.AddMarkupContent(6, "<th>CustomerID</th>\r\n        ");
                __builder2.AddMarkupContent(7, "<th>EmployeeID</th>\r\n        ");
                __builder2.AddMarkupContent(8, "<th>OrderDate</th>\r\n        ");
                __builder2.AddMarkupContent(9, "<th>RequiredDate</th>\r\n        ");
                __builder2.AddMarkupContent(10, "<th>ShippedDate</th>\r\n        ");
                __builder2.AddMarkupContent(11, "<th>ShipVia</th>\r\n        ");
                __builder2.AddMarkupContent(12, "<th>Freight</th>\r\n        ");
                __builder2.AddMarkupContent(13, "<th>ShipName</th>\r\n        ");
                __builder2.AddMarkupContent(14, "<th>ShipAddress</th>\r\n        ");
                __builder2.AddMarkupContent(15, "<th>ShipCity</th>\r\n        ");
                __builder2.AddMarkupContent(16, "<th>ShipRegion</th>\r\n        ");
                __builder2.AddMarkupContent(17, "<th>ShipPostalCode</th>\r\n        ");
                __builder2.AddMarkupContent(18, "<th>ShipCountry</th>");
            }
            , 19, (context) => (__builder2) => {
                __builder2.OpenElement(20, "td");
#nullable restore
#line 24 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(21, context.OrderID);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "td");
#nullable restore
#line 25 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(24, context.CustomerID);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "td");
#nullable restore
#line 26 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(27, context.EmployeeID);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "td");
#nullable restore
#line 27 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(30, context.OrderDate);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "td");
#nullable restore
#line 28 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(33, context.RequiredDate);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenElement(35, "td");
#nullable restore
#line 29 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(36, context.ShippedDate);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "td");
#nullable restore
#line 30 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(39, context.ShipVia);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenElement(41, "td");
#nullable restore
#line 31 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(42, context.Freight);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenElement(44, "td");
#nullable restore
#line 32 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(45, context.ShipName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenElement(47, "td");
#nullable restore
#line 33 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(48, context.ShipAddress);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.OpenElement(50, "td");
#nullable restore
#line 34 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(51, context.ShipCity);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.OpenElement(53, "td");
#nullable restore
#line 35 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(54, context.ShipRegion);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "td");
#nullable restore
#line 36 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(57, context.ShipPostalCode);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.OpenElement(59, "td");
#nullable restore
#line 37 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
__builder2.AddContent(60, context.ShipCountry);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\OrderPage.razor"
       
    //private SfGrid<Orders> OrderGrid;
    private List<Orders> orders = new List<Orders>();
    Orders order = new Orders();

    string Message = "";

    protected override async Task OnInitializedAsync()
    {
        GetOrders();
    }

    private void GetOrders()
    {
        orders = orderService.GetOrders();
    }

  



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindCrudApp.IService.IOrderService orderService { get; set; }
    }
}
namespace __Blazor.NorthwindCrudApp.Pages.OrderPage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "MatTableHeader", __arg2);
        __builder.AddAttribute(__seq3, "MatTableRow", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591