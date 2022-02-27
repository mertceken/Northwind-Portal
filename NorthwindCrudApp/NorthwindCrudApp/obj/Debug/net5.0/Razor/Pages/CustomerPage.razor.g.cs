#pragma checksum "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b120286af1203537d3463567249a78248d60d03b"
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
#line 2 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
using NorthwindCrudApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customer")]
    public partial class CustomerPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MatBlazor.MatButton>(0);
            __builder.AddAttribute(1, "Outlined", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 4 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                                       e=>OpenDialog(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(4, "Add New Customer");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __Blazor.NorthwindCrudApp.Pages.CustomerPage.TypeInference.CreateMatTable_0(__builder, 6, 7, 
#nullable restore
#line 5 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                  customerList

#line default
#line hidden
#nullable disable
            , 8, "oi-elevator", 9, (__builder2) => {
                __builder2.AddMarkupContent(10, "<th>CustomerID</th>\r\n        ");
                __builder2.AddMarkupContent(11, "<th>CompanyName</th>\r\n        ");
                __builder2.AddMarkupContent(12, "<th>ContactName</th>\r\n        ");
                __builder2.AddMarkupContent(13, "<th>ContactTitle</th>\r\n        ");
                __builder2.AddMarkupContent(14, "<th>Address</th>\r\n        ");
                __builder2.AddMarkupContent(15, "<th>City</th>\r\n        ");
                __builder2.AddMarkupContent(16, "<th>Region</th>\r\n        ");
                __builder2.AddMarkupContent(17, "<th>PostalCode</th>\r\n        ");
                __builder2.AddMarkupContent(18, "<th>Country</th>\r\n        ");
                __builder2.AddMarkupContent(19, "<th>Phone</th>\r\n        ");
                __builder2.AddMarkupContent(20, "<th>Fax</th>");
            }
            , 21, (context) => (__builder2) => {
                __builder2.OpenElement(22, "td");
#nullable restore
#line 20 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
__builder2.AddContent(23, context.CustomerID);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "td");
#nullable restore
#line 21 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
__builder2.AddContent(26, context.CompanyName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "td");
#nullable restore
#line 22 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
__builder2.AddContent(29, context.ContactName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenElement(31, "td");
#nullable restore
#line 23 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
__builder2.AddContent(32, context.ContactTitle);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenElement(34, "td");
#nullable restore
#line 24 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
__builder2.AddContent(35, context.Address);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.OpenElement(37, "td");
#nullable restore
#line 25 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
__builder2.AddContent(38, context.City);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
                __builder2.OpenElement(40, "td");
#nullable restore
#line 26 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
__builder2.AddContent(41, context.Region);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n        ");
                __builder2.OpenElement(43, "td");
#nullable restore
#line 27 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
__builder2.AddContent(44, context.PostalCode);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.OpenElement(46, "td");
#nullable restore
#line 28 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
__builder2.AddContent(47, context.Country);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.OpenElement(49, "td");
#nullable restore
#line 29 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
__builder2.AddContent(50, context.Phone);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenElement(52, "td");
#nullable restore
#line 30 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
__builder2.AddContent(53, context.Fax);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            );
            __builder.AddMarkupContent(54, "\r\n");
            __builder.OpenComponent<MatBlazor.MatDialog>(55);
            __builder.AddAttribute(56, "isOpen", 
#nullable restore
#line 33 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                          dialogIsOpen

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(57, "isOpenChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => dialogIsOpen = __value, dialogIsOpen));
            __builder.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MatBlazor.MatDialogTitle>(59);
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(61, " Add New Customer");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogContent>(63);
                __builder2.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.NorthwindCrudApp.Pages.CustomerPage.TypeInference.CreateMatTextField_1(__builder3, 65, 66, "CustomerID", 67, 
#nullable restore
#line 36 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                                                       customer.CustomerID

#line default
#line hidden
#nullable disable
                    , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.CustomerID = __value, customer.CustomerID)), 69, () => customer.CustomerID);
                    __builder3.AddMarkupContent(70, "\r\n        ");
                    __Blazor.NorthwindCrudApp.Pages.CustomerPage.TypeInference.CreateMatTextField_2(__builder3, 71, 72, "Company Name", 73, 
#nullable restore
#line 37 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                                                         customer.CompanyName

#line default
#line hidden
#nullable disable
                    , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.CompanyName = __value, customer.CompanyName)), 75, () => customer.CompanyName);
                    __builder3.AddMarkupContent(76, "\r\n        ");
                    __Blazor.NorthwindCrudApp.Pages.CustomerPage.TypeInference.CreateMatTextField_3(__builder3, 77, 78, "Contact Name", 79, 
#nullable restore
#line 38 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                                                         customer.ContactName

#line default
#line hidden
#nullable disable
                    , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.ContactName = __value, customer.ContactName)), 81, () => customer.ContactName);
                    __builder3.AddMarkupContent(82, "\r\n         ");
                    __Blazor.NorthwindCrudApp.Pages.CustomerPage.TypeInference.CreateMatTextField_4(__builder3, 83, 84, "Contact Title", 85, 
#nullable restore
#line 39 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                                                           customer.ContactTitle

#line default
#line hidden
#nullable disable
                    , 86, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.ContactTitle = __value, customer.ContactTitle)), 87, () => customer.ContactTitle);
                    __builder3.AddMarkupContent(88, "\r\n          ");
                    __Blazor.NorthwindCrudApp.Pages.CustomerPage.TypeInference.CreateMatTextField_5(__builder3, 89, 90, "Address", 91, 
#nullable restore
#line 40 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                                                      customer.Address

#line default
#line hidden
#nullable disable
                    , 92, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.Address = __value, customer.Address)), 93, () => customer.Address);
                    __builder3.AddMarkupContent(94, "\r\n           ");
                    __Blazor.NorthwindCrudApp.Pages.CustomerPage.TypeInference.CreateMatTextField_6(__builder3, 95, 96, "City", 97, 
#nullable restore
#line 41 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                                                    customer.City

#line default
#line hidden
#nullable disable
                    , 98, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.City = __value, customer.City)), 99, () => customer.City);
                    __builder3.AddMarkupContent(100, "\r\n            ");
                    __Blazor.NorthwindCrudApp.Pages.CustomerPage.TypeInference.CreateMatTextField_7(__builder3, 101, 102, "Region", 103, 
#nullable restore
#line 42 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                                                       customer.Region

#line default
#line hidden
#nullable disable
                    , 104, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.Region = __value, customer.Region)), 105, () => customer.Region);
                    __builder3.AddMarkupContent(106, "\r\n             ");
                    __Blazor.NorthwindCrudApp.Pages.CustomerPage.TypeInference.CreateMatTextField_8(__builder3, 107, 108, "Postal Code", 109, 
#nullable restore
#line 43 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                                                             customer.PostalCode

#line default
#line hidden
#nullable disable
                    , 110, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.PostalCode = __value, customer.PostalCode)), 111, () => customer.PostalCode);
                    __builder3.AddMarkupContent(112, "\r\n              ");
                    __Blazor.NorthwindCrudApp.Pages.CustomerPage.TypeInference.CreateMatTextField_9(__builder3, 113, 114, "Country", 115, 
#nullable restore
#line 44 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                                                          customer.Country

#line default
#line hidden
#nullable disable
                    , 116, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.Country = __value, customer.Country)), 117, () => customer.Country);
                    __builder3.AddMarkupContent(118, "\r\n               ");
                    __Blazor.NorthwindCrudApp.Pages.CustomerPage.TypeInference.CreateMatTextField_10(__builder3, 119, 120, "Phone", 121, 
#nullable restore
#line 45 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                                                         customer.Phone

#line default
#line hidden
#nullable disable
                    , 122, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.Phone = __value, customer.Phone)), 123, () => customer.Phone);
                    __builder3.AddMarkupContent(124, "\r\n                ");
                    __Blazor.NorthwindCrudApp.Pages.CustomerPage.TypeInference.CreateMatTextField_11(__builder3, 125, 126, "Fax", 127, 
#nullable restore
#line 46 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                                                        customer.Fax

#line default
#line hidden
#nullable disable
                    , 128, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => customer.Fax = __value, customer.Fax)), 129, () => customer.Fax);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(130, "\r\n    ");
                __builder2.OpenComponent<MatBlazor.MatDialogActions>(131);
                __builder2.AddAttribute(132, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MatBlazor.MatButton>(133);
                    __builder3.AddAttribute(134, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                            OkClick

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(135, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(136, "Add");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(137, "\r\n        ");
                    __builder3.OpenComponent<MatBlazor.MatButton>(138);
                    __builder3.AddAttribute(139, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
                            CloseDialog

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(140, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(141, "Close");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\User\source\repos\NorthwindCrudApp\NorthwindCrudApp\Pages\CustomerPage.razor"
       
    private List<Customer> customerList = new List<Customer>();
    Customer customer = new Customer();
    bool _isEdit = false;
    bool dialogIsOpen = false;

    protected override async Task OnInitializedAsync()
    {
        GetCustomers();
    }

    private void GetCustomers()
    {
        customerList = customerService.GetCustomers();
    }
    protected async Task AddCustomers()
    {
        await customerService.Add(customer);
    }
    private void OpenDialog(bool isEdit)
    {
        _isEdit = isEdit;
        if (!_isEdit) customer = new Customer();
        dialogIsOpen = true;
    }
    private async void OkClick()
    {
        dialogIsOpen = false;
        if (!_isEdit) AddCustomers();

    }
    private void CloseDialog()
    {
        dialogIsOpen = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NorthwindCrudApp.IService.ICustomerService customerService { get; set; }
    }
}
namespace __Blazor.NorthwindCrudApp.Pages.CustomerPage
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
        public static void CreateMatTextField_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateMatTextField_11<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTextField<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591