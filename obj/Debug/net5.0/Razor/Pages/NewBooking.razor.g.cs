#pragma checksum "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f568f33e0001723a1331a380fc8b23f44b4311a7"
// <auto-generated/>
#pragma warning disable 1591
namespace Simple_booking_system.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Bruger\RiderProjects\Simple booking system\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\RiderProjects\Simple booking system\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\RiderProjects\Simple booking system\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Bruger\RiderProjects\Simple booking system\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Bruger\RiderProjects\Simple booking system\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Bruger\RiderProjects\Simple booking system\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Bruger\RiderProjects\Simple booking system\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Bruger\RiderProjects\Simple booking system\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Bruger\RiderProjects\Simple booking system\_Imports.razor"
using Simple_booking_system;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Bruger\RiderProjects\Simple booking system\_Imports.razor"
using Simple_booking_system.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Bruger\RiderProjects\Simple booking system\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Bruger\RiderProjects\Simple booking system\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
using Simple_booking_system.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
using Simple_booking_system.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/NewBooking")]
    public partial class NewBooking : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
 if (ShowConfirmation)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
                      Booking

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
                                               OnBookingConfirmation

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "modal fade show d-block");
                __builder2.AddAttribute(6, "id", "exampleModal");
                __builder2.AddAttribute(7, "tabindex", "-1");
                __builder2.AddAttribute(8, "role", "dialog");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "modal-dialog");
                __builder2.AddAttribute(11, "role", "document");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "modal-content");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "modal-header");
                __builder2.OpenElement(16, "h5");
                __builder2.AddAttribute(17, "class", "modal-title");
                __builder2.AddAttribute(18, "id", "exampleModalLabel");
                __builder2.AddContent(19, "Booking ");
                __builder2.AddContent(20, 
#nullable restore
#line 14 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
                                                                                Resource.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "button");
                __builder2.AddAttribute(23, "type", "button");
                __builder2.AddAttribute(24, "class", "close");
                __builder2.AddAttribute(25, "data-dismiss", "modal");
                __builder2.AddAttribute(26, "aria-label", "Close");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
                                          () => CloseBookingModule()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(28, "<span aria-hidden=\"true\">&times;</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                    ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "modal-body");
                __builder2.OpenElement(32, "p");
                __builder2.AddContent(33, " Resourse Name: ");
                __builder2.AddContent(34, 
#nullable restore
#line 22 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
                                            Resource.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddContent(38, " Date From : ");
                __Blazor.Simple_booking_system.Pages.NewBooking.TypeInference.CreateInputDate_0(__builder2, 39, 40, 
#nullable restore
#line 23 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
                                                                                     Booking.DateFrom

#line default
#line hidden
#nullable disable
                , 41, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Booking.DateFrom = __value, Booking.DateFrom)), 42, () => Booking.DateFrom);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddContent(46, " Date To : ");
                __Blazor.Simple_booking_system.Pages.NewBooking.TypeInference.CreateInputDate_1(__builder2, 47, 48, 
#nullable restore
#line 24 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
                                                                                   Booking.DateTo

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Booking.DateTo = __value, Booking.DateTo)), 50, () => Booking.DateTo);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n                        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddContent(54, " Max Quantity: ");
                __builder2.AddContent(55, 
#nullable restore
#line 26 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
                                                                Resource.Quantity

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddContent(59, " Quantity: ");
                __Blazor.Simple_booking_system.Pages.NewBooking.TypeInference.CreateInputNumber_2(__builder2, 60, 61, "4", 62, 
#nullable restore
#line 27 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
                                                                                              Booking.BookedQuantity

#line default
#line hidden
#nullable disable
                , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Booking.BookedQuantity = __value, Booking.BookedQuantity)), 64, () => Booking.BookedQuantity);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "modal-footer");
                __builder2.OpenElement(68, "button");
                __builder2.AddAttribute(69, "type", "button");
                __builder2.AddAttribute(70, "class", "btn btn-secondary");
                __builder2.AddAttribute(71, "data-dismiss", "modal");
                __builder2.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
                                          () => CloseBookingModule()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(73, "\r\n                            Cancel\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                        ");
                __builder2.OpenElement(75, "button");
                __builder2.AddAttribute(76, "type", "button");
                __builder2.AddAttribute(77, "class", "btn btn-danger");
                __builder2.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
                                                                               () => OnBookingConfirmation()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(79, "\r\n                            Book\r\n                        ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 44 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Bruger\RiderProjects\Simple booking system\Pages\NewBooking.razor"
       

    public DateTime PresentDateTime { get; set; }

    public bool ShowConfirmation { get; set; }

    public Resource Resource { get; set; }

    public Booking Booking { get; set; }

    protected override async Task OnInitializedAsync()
    {
        PresentDateTime = DateTime.Now;
        Resource = new Resource();
        Booking = new Booking();
    }

    public async Task Show(Resource resource)
    {
        ShowConfirmation = true;
        Resource = resource;
        Booking.ResourceId = Resource.Id;
        StateHasChanged();
    }


    private async Task OnBookingConfirmation()
    {
        Booking returnedBooking = await BookingManager.NewBooking(Booking);

        if (returnedBooking != null)
        {
            Console.WriteLine("EMAIL SENT TO admin@admin.com FOR CREATED BOOKING WITH ID " + returnedBooking.Id);
            CloseBookingModule();
        }
        else
        {
            Console.WriteLine("Smth went wrong");
        }
    }


    // Closes the Booking Module
    private void CloseBookingModule()
    {
        ShowConfirmation = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookingManager BookingManager { get; set; }
    }
}
namespace __Blazor.Simple_booking_system.Pages.NewBooking
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "rows", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
