#pragma checksum "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\RoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5086d692cd1c43c4459593b95c9579adec78cef9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoleList), @"mvc.1.0.view", @"/Views/Admin/RoleList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5086d692cd1c43c4459593b95c9579adec78cef9", @"/Views/Admin/RoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17f4c89c0ac2f153dd15835b0509b83489b711e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/Role/Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""container mt-4"">
        <div class=""row"">
            <div class=""col-md-12"">
                <h6 class=""display-4"">Admin Roles Management</h6>
                <hr />
                <a href=""/admin/role/create"" class=""btn btn-sm btn-primary"">Create Role</a>
                <hr />
                <table class=""table table-bordered mt-2"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Name</th>
                            <th width=""150"">Actions</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 19 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\RoleList.cshtml"
                         if (Model.Count() > 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\RoleList.cshtml"
                             foreach (var role in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>");
#nullable restore
#line 24 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\RoleList.cshtml"
                                   Write(role.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>");
#nullable restore
#line 25 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\RoleList.cshtml"
                                   Write(role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>\n\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1066, "\"", 1093, 2);
            WriteAttributeValue("", 1073, "/admin/role/", 1073, 12, true);
#nullable restore
#line 28 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\RoleList.cshtml"
WriteAttributeValue("", 1085, role.Id, 1085, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-primary mr-1\">Edit</a>\n\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5086d692cd1c43c4459593b95c9579adec78cef97666", async() => {
                WriteLiteral("\n                                            <input type=\"hidden\" name=\"roleId\"");
                BeginWriteAttribute("value", " value=\"", 1325, "\"", 1341, 1);
#nullable restore
#line 31 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\RoleList.cshtml"
WriteAttributeValue("", 1333, role.Id, 1333, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                            <button type=\"submit\" class=\"btn btn-sm btn-danger\">Delete</button>\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    </td>\n                                </tr>\n");
#nullable restore
#line 36 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\RoleList.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\RoleList.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-danger\">\n                                <h3>Kayıtlı rol yoktur!</h3>\n                            </div>\n");
#nullable restore
#line 43 "C:\Users\Wissen\Desktop\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Admin\RoleList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591