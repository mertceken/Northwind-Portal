#pragma checksum "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "698721e6b4884ac2e476450ecb3c837ba3038a0f"
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
#line 2 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
using NorthwindCrudApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employee")]
    public partial class EmployeePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EmployeePage</h3>\r\n\r\n");
            __Blazor.NorthwindCrudApp.Pages.EmployeePage.TypeInference.CreateMatTable_0(__builder, 1, 2, 
#nullable restore
#line 7 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
                  employeesList

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.AddMarkupContent(4, "<th>EmployeeID</th>\r\n        ");
                __builder2.AddMarkupContent(5, "<th>LastName</th>\r\n        ");
                __builder2.AddMarkupContent(6, "<th>FirstName</th>\r\n        ");
                __builder2.AddMarkupContent(7, "<th>Title</th>\r\n        ");
                __builder2.AddMarkupContent(8, "<th>TitleOfCourtesy</th>\r\n        ");
                __builder2.AddMarkupContent(9, "<th>BirthDate</th>\r\n        ");
                __builder2.AddMarkupContent(10, "<th>HireDate</th>\r\n        ");
                __builder2.AddMarkupContent(11, "<th>Address</th>\r\n        ");
                __builder2.AddMarkupContent(12, "<th>City</th>\r\n        ");
                __builder2.AddMarkupContent(13, "<th>Region</th>\r\n        ");
                __builder2.AddMarkupContent(14, "<th>PostalCode</th>\r\n        ");
                __builder2.AddMarkupContent(15, "<th>Country</th>\r\n        ");
                __builder2.AddMarkupContent(16, "<th>HomePhone</th>\r\n        ");
                __builder2.AddMarkupContent(17, "<th>Extension</th>\r\n        ");
                __builder2.AddMarkupContent(18, "<th>Photo</th>\r\n        ");
                __builder2.AddMarkupContent(19, "<th>Notes</th>\r\n        ");
                __builder2.AddMarkupContent(20, "<th>ReportsTo</th>\r\n        ");
                __builder2.AddMarkupContent(21, "<th>PhotoPath</th>");
            }
            , 22, (context) => (__builder2) => {
                __builder2.OpenElement(23, "td");
#nullable restore
#line 29 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(24, context.EmployeeID);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "td");
#nullable restore
#line 30 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(27, context.LastName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "td");
#nullable restore
#line 31 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(30, context.FirstName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "td");
#nullable restore
#line 32 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(33, context.Title);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n        ");
                __builder2.OpenElement(35, "td");
#nullable restore
#line 33 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(36, context.TitleOfCourtesy);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "td");
#nullable restore
#line 34 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(39, context.BirthDate);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenElement(41, "td");
#nullable restore
#line 35 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(42, context.HireDate);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.OpenElement(44, "td");
#nullable restore
#line 36 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(45, context.Address);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenElement(47, "td");
#nullable restore
#line 37 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(48, context.City);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.OpenElement(50, "td");
#nullable restore
#line 38 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(51, context.Region);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.OpenElement(53, "td");
#nullable restore
#line 39 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(54, context.PostalCode);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "td");
#nullable restore
#line 40 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(57, context.Country);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n        ");
                __builder2.OpenElement(59, "td");
#nullable restore
#line 41 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(60, context.HomePhone);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.OpenElement(62, "td");
#nullable restore
#line 42 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(63, context.Extension);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenElement(65, "td");
#nullable restore
#line 43 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(66, context.Photo);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.OpenElement(68, "td");
#nullable restore
#line 44 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(69, context.Notes);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.OpenElement(71, "td");
#nullable restore
#line 45 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(72, context.ReportsTo);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.OpenElement(74, "td");
#nullable restore
#line 46 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
__builder2.AddContent(75, context.PhotoPath);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\EmployeePage.razor"
       
    private List<Employee> employeesList = new List<Employee>();
    Employee employee = new Employee();
    string message = "";

    private void GetEmployees()
    {
        employeesList = employeeService.GetEmployees();
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindCrudApp.IService.IEmployeesService employeeService { get; set; }
    }
}
namespace __Blazor.NorthwindCrudApp.Pages.EmployeePage
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg2)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "MatTableHeader", __arg1);
        __builder.AddAttribute(__seq2, "MatTableRow", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591