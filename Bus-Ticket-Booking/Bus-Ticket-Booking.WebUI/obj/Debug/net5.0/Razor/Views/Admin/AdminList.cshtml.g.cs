#pragma checksum "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b27fc62517d7e674104e474802249f17fa272040"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminList), @"mvc.1.0.view", @"/Views/Admin/AdminList.cshtml")]
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
#line 1 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b27fc62517d7e674104e474802249f17fa272040", @"/Views/Admin/AdminList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17f4c89c0ac2f153dd15835b0509b83489b711e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RouteTicket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-2 w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListRoute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("CancelTicket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n<div class=\"mt-3 container\">\n    <div class=\"row\">\n        <div class=\"col-sm-2 mt-4\">\n            <ul class=\" form-control text-white \">\n                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b27fc62517d7e674104e474802249f17fa2720407392", async() => {
                WriteLiteral("Routes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n                <li> <a href=\"/admin/role/list\" class=\"btn btn-primary mb-2 w-100\">Roles</a></li>\n                <li><a href=\"/admin/user/list\" class=\"btn btn-primary mb-2 w-100\">Users</a></li>\n                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b27fc62517d7e674104e474802249f17fa2720409064", async() => {
                WriteLiteral("Log Out");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
            </ul>
        </div>

        <div class=""col-md-10"">
            <h1 class=""h3""> Bilet Kontrol</h1> <hr /> <br />
            <table class=""table table table-bordered shadow-sm mt-3"">
                <thead>
                    <tr>
                        <th style=""width:20px;"">BiletID</th>
                        <th style=""width:145px;"">Ad - Soyad</th>
                        <th");
            BeginWriteAttribute("style", " style=\"", 988, "\"", 996, 0);
            EndWriteAttribute();
            WriteLiteral(@">Tel</th>
                        <th>Peron Number</th>
                        <th style=""width:25px;"">Başlangıç</th>
                        <th style=""width:25px;"">Bitiş</th>
                        <th style=""width:70px;"">KoltukNo</th>
                        <th style=""width:80px;"">Fiyat</th>
                        <th style=""width:85px;"">GüzergahNo</th>
                        <th style=""width:165px;"">İptal</th>
                    </tr>
                <tbody>
");
#nullable restore
#line 33 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
                     if (Model.Tickets.Count > 0)
                    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
         foreach (var item in Model.Tickets)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 38 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.TicketId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 39 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.CostumerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
                      Write(item.CosturmerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 40 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 41 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.PeronNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 42 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.TravelFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 43 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.TravelTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 44 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.SeatNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 45 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\n    <td>");
#nullable restore
#line 46 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
   Write(item.RouteId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b27fc62517d7e674104e474802249f17fa27204014620", async() => {
                WriteLiteral("\n            <input type=\"hidden\" name=\"ticketId\"");
                BeginWriteAttribute("value", " value=\"", 2021, "\"", 2043, 1);
#nullable restore
#line 49 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
WriteAttributeValue("", 2029, item.TicketId, 2029, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n            <button type=\"submit\" class=\"btn btn-danger btn-md mr-2\" style=\"color: white;\">Bileti İptal Et</button>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    </td>\n</tr>");
#nullable restore
#line 54 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
       }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>Sistemde henüz kayıtlı bilet yok!</td>\n</tr>");
#nullable restore
#line 59 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\AdminList.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n\n            </table>\n        </div>\n\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RouteTicket> Html { get; private set; }
    }
}
#pragma warning restore 1591
