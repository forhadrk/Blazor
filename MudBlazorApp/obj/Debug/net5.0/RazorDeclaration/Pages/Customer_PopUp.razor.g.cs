// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MudBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hossain\source\repos\MudBlazorApp\MudBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hossain\source\repos\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hossain\source\repos\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hossain\source\repos\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hossain\source\repos\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hossain\source\repos\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hossain\source\repos\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hossain\source\repos\MudBlazorApp\MudBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hossain\source\repos\MudBlazorApp\MudBlazorApp\_Imports.razor"
using MudBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hossain\source\repos\MudBlazorApp\MudBlazorApp\_Imports.razor"
using MudBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hossain\source\repos\MudBlazorApp\MudBlazorApp\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hossain\source\repos\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
using MudBlazorApp.Data;

#line default
#line hidden
#nullable disable
    public partial class Customer_PopUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\hossain\source\repos\MudBlazorApp\MudBlazorApp\Pages\Customer_PopUp.razor"
       
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }
    private Customer customer = new Customer();
    private List<Customer> customers = new List<Customer>();

    void Submit() => MudDialog.Close(DialogResult.Ok(true));
    void Cancel() => MudDialog.Cancel();

    private List<Customer> GetAllCustomer()
    {
        customers = customerService.GetCustomers();
        return customers;
    }

    private void Save()
    {
        customerService.SaveCustomer(customer);

        customer = new Customer();
        GetAllCustomer();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerService customerService { get; set; }
    }
}
#pragma warning restore 1591
