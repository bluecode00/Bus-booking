#pragma checksum "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11bff81d42da14fca70de23675f2d1a5f4079fa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserList), @"mvc.1.0.view", @"/Views/Admin/UserList.cshtml")]
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
#line 1 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11bff81d42da14fca70de23675f2d1a5f4079fa7", @"/Views/Admin/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31bb9bd4c9780feb471d09906480cb4b810a9ee8", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link href=\"https://cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css\" rel=\"stylesheet\" />\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js\"></script>\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\'#userList\').DataTable();\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"<div class=""container"">
    <div class=""col-md-12"">
        <h6 class=""display-4"">User List</h6>
        <hr />
        <table data-page-length=""2"" class=""table table-dark table-sm table-bordered hover"" id=""userList"">
            <thead>
                <tr>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>User Name</th>
                    <th>Email</th>
                    <th>Email Confirmed</th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 29 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\UserList.cshtml"
                 if (Model.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\UserList.cshtml"
                     foreach (var user in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("class", " class=\"", 1081, "\"", 1131, 1);
#nullable restore
#line 33 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\UserList.cshtml"
WriteAttributeValue("", 1089, user.EmailConfirmed ? "" : "bg-warning", 1089, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#nullable restore
#line 34 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\UserList.cshtml"
                           Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\UserList.cshtml"
                           Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\UserList.cshtml"
                           Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\UserList.cshtml"
                           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\UserList.cshtml"
                           Write(user.EmailConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\UserList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\UserList.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <tr>
                        <td colspan=""6"">
                            <div class=""alert alert-warning"">
                                <h4>Herhangi bir kullanıcı bulunamadı!</h4>
                            </div>
                        </td>
                    </tr>
");
#nullable restore
#line 51 "C:\Users\Gezgin\Desktop\Bus-booking\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\UserList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
