#pragma checksum "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ea5f56959a7df53917eca7524e65f44df413696"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\_Imports.razor"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\_Imports.razor"
using Assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
using Assignment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
using Assignment.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
           [Authorize(Policy = "LogIn")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Adults</h1>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Search adult by ID:\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
                                     (arg) => FilterById(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width: 50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddMarkupContent(9, "\r\n    Search adult by name:\r\n    ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
                                   (arg) => FilterByFirstName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
 if (adults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<p><em>Loading...</em></p>");
#nullable restore
#line 21 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
}
else if (!adults.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<p><em>No adults exist. You should add some.</em></p>");
#nullable restore
#line 27 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table");
            __builder.AddMarkupContent(17, "<thead><tr><th>ID</th>\r\n            <th>First name</th>\r\n            <th>Last name</th>\r\n            <th>Age</th>\r\n            <th>Sex</th>\r\n            <th>Remove</th></tr></thead>\r\n        ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 44 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
         foreach (var item in filteredAdults)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 47 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 48 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 49 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 50 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 51 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
                                        () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "<i class=\"oi oi-trash\" style=\"color: red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\Iana Postolachi\RiderProjects\Assignment1\Assignment\Pages\Adults.razor"
 
    private IList<Adult> filteredAdults;
    private IList<Adult> adults;

    private int? filterById;
    private string? filterByFirstName;
    
    private void FilterById(ChangeEventArgs arg)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(arg.Value.ToString());
        }
        catch (Exception e)
        {
            
        }
        filteredAdults = adults.Where(a => (filterById != null && a.Id == filterById || filterById == null)).ToList();
    }
    
    private async Task RemoveAdult(int Id)
    {
        Adult adultToRemove = adults.First(a => a.Id == Id);
        try
        {
            await FileContext.RevomeAdultsAsync(Id);
            adults.Remove(adultToRemove);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    
    private void FilterByFirstName(ChangeEventArgs arg)
    {
        filterByFirstName = null;
        try
        {
            filterByFirstName = arg.Value.ToString();
        }
        catch (Exception e)
        {

        }
        filteredAdults = adults.Where(a => (!filterByFirstName.Equals(null) && a.FirstName.Equals(filterByFirstName) || filterByFirstName.Equals(null))).ToList();
    }
    
    protected override async Task OnInitializedAsync()
    {
        try
        {
            adults = await FileContext.GetAdultsAsync();
            filteredAdults = adults;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileContext FileContext { get; set; }
    }
}
#pragma warning restore 1591
