#pragma checksum "C:\Users\Wissen\Desktop\Bus-booking-main\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4b9ab15fbaa85096c83a6509fad3d90ccdb1b98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Wissen\Desktop\Bus-booking-main\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wissen\Desktop\Bus-booking-main\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wissen\Desktop\Bus-booking-main\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wissen\Desktop\Bus-booking-main\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Wissen\Desktop\Bus-booking-main\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Wissen\Desktop\Bus-booking-main\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4b9ab15fbaa85096c83a6509fad3d90ccdb1b98", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17f4c89c0ac2f153dd15835b0509b83489b711e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "startLocation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select form-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("from-place"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "endLocation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/home/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("home/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/bus2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("song"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/bus1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/bus3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/b1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"home\" id=\"home\">\n    <div class=\"container\">\n        <h1>Make Memories</h1>\n\n        <div class=\"mt-4\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4b9ab15fbaa85096c83a6509fad3d90ccdb1b988901", async() => {
                WriteLiteral("\n                <div class=\"row\">\n                    <div class=\"col-md-3 text-white fw-bolder\">\n                        <label for=\"from\" class=\"mb-2\">From:</label>\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4b9ab15fbaa85096c83a6509fad3d90ccdb1b989359", async() => {
                    WriteLiteral("\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4b9ab15fbaa85096c83a6509fad3d90ccdb1b989653", async() => {
                        WriteLiteral("Start Location");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 10 "C:\Users\Wissen\Desktop\Bus-booking-main\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Cities;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    </div>\n                    <div class=\"col-md-3 text-white fw-bolder \">\n                        <label for=\"from\" class=\"mb-2\">To:</label>\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4b9ab15fbaa85096c83a6509fad3d90ccdb1b9813234", async() => {
                    WriteLiteral("\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4b9ab15fbaa85096c83a6509fad3d90ccdb1b9813529", async() => {
                        WriteLiteral("End Location");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 16 "C:\Users\Wissen\Desktop\Bus-booking-main\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.Cities;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                    <div class=""col-md-3 text-white fw-bolder"">
                        <label for=""date-start"" class=""mb-2"">Check In:</label>
                        <input type=""date"" class=""form-control"" name=""Date"" />
                    </div>
                    <div class=""col-md-3"">
                        <label class=""mb-2"">&nbsp</label>
                        <button type=""submit"" class=""btn btn-danger w-100 text-white fw-bolder""> Find My Journey </button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div class=\"row\">\n            <div class=\"col-md-3 text-white fw-bolder mt-4\">\n                <div class=\"mt-5\">\n                    <label class=\"mb-2\">Ticket Check:</label>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4b9ab15fbaa85096c83a6509fad3d90ccdb1b9818698", async() => {
                WriteLiteral("\n                        <div");
                BeginWriteAttribute("class", " class=\"", 1795, "\"", 1803, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <input type=""search"" class=""form-control"" name=""PeronNumber"" placeholder=""Search with PRN..."" required />
                            <button type=""submit"" class=""form-control btn-danger mt-2"">Search</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-md-9 "">
                <div class=""slider-home"">
                    <input type=""radio"" name=""slider"" id=""item-1"" checked>
                    <input type=""radio"" name=""slider"" id=""item-2"">
                    <input type=""radio"" name=""slider"" id=""item-3"">
                    <div class=""slider-cards"">
                        <label class=""slider-card"" for=""item-1"" id=""song-1"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d4b9ab15fbaa85096c83a6509fad3d90ccdb1b9821005", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </label>\n                        <label class=\"slider-card\" for=\"item-2\" id=\"song-2\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d4b9ab15fbaa85096c83a6509fad3d90ccdb1b9822264", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </label>\n                        <label class=\"slider-card\" for=\"item-3\" id=\"song-3\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d4b9ab15fbaa85096c83a6509fad3d90ccdb1b9823523", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </label>
                    </div>

                </div>
            </div>
        </div>
        
    </div>
</section>


<section class=""wrapper2"">
    <div class=""container"">
        <div class=""heading mtop"">
            <h5>FACILITIES</h5>
            <h2>Giving entirely awesome </h2>
        </div>

        <div class=""content grid mtop"">
            <div class=""box"">
                <i class=""fas fa-shipping-fast""></i>
                <h3>Pick Up & Drop</h3>
                <p>parkn ipsum dolor sit amet, consectetur adiing elit sed do eiu</p>
                <span class='far fa-long-arrow-alt-right'></span>
            </div>
            <div class=""box"">
                <i class=""fas fa-mug-hot""></i>
                <h3>Pick Up & Drop</h3>
                <p>parkn ipsum dolor sit amet, consectetur adiing elit sed do eiu</p>
                <span class='far fa-long-arrow-alt-right'></span>
            </div>
            <div class=""box"">
                <i class=""fas fa-car");
            WriteLiteral(@"""></i>
                <h3>Pick Up & Drop</h3>
                <p>parkn ipsum dolor sit amet, consectetur adiing elit sed do eiu</p>
                <span class='far fa-long-arrow-alt-right'></span>
            </div>
            <div class=""box"">
                <i class=""far fa-water""></i>
                <h3>Pick Up & Drop</h3>
                <p>parkn ipsum dolor sit amet, consectetur adiing elit sed do eiu</p>
                <span class='far fa-long-arrow-alt-right'></span>
            </div>
        </div>
    </div>
</section>




<section class=""timer about wrapper"">
    <div class=""background""> </div>
    <div class=""container"">
        <div class=""heading"">
            <h5>LAST MINUTE!</h5>
            <h2> <span>Incredible!</span> Are you coming today</h2>
        </div>

        <div id=""time"" class=""flex1 mtop""> </div>
    </div>
</section>
<script src=""js/jquery.countdown.js"" charset=""utf-8""></script>
<script src=""js/jquery.countdown.min.js"" charset=""utf-8""></script>
<script type=""text/javascri");
            WriteLiteral(@"pt"">
    $('#time').countdown('2024/01/01', function (event) {
      $(this).html(event.strftime(
        '<div class=""clock""><span>%d</span> <p>Days</p></div> ' +
        '<div class=""clock""><span>%H</span> <p>Hours</p></div> ' +
        '<div class=""clock""><span>%M</span> <p>Minutes</p></div> ' +
        '<div class=""clock""><span>%S</span> <p>Seconds</p></div> '
      ));
    });
</script>

<section class=""blog top"" id=""blog"">
    <div class=""container"">
        <div class=""heading"">
            <h5>OUR BLOG</h5>
            <h3>News & articles updates</h3>
        </div>

        <div class=""content grid mtop"">
            <div class=""box"">
                <div class=""img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d4b9ab15fbaa85096c83a6509fad3d90ccdb1b9827521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <span>HOTEL</span>
                </div>
                <div class=""text"">
                    <div class=""flex"">
                        <i class=""far fa-user""> <label>Admin</label> </i>
                        <i class=""far fa-comments""> <label>Comment</label> </i>
                    </div>
                    <h3>Celebrating Decade Years Of Hotel In 2020</h3>
                    <p>
                        Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est
                        laborum.
                    </p>
                    <a href=""#"">Read More <i class='far fa-long-arrow-alt-right'></i> </a>
                </div>
            </div>
            <div class=""box"">
                <div class=""img"">
                    <img src=""/img/b2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 6593, "\"", 6599, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <span>HOTEL</span>
                </div>
                <div class=""text"">
                    <div class=""flex"">
                        <i class=""far fa-user""> <label>Admin</label> </i>
                        <i class=""far fa-comments""> <label>Comment</label> </i>
                    </div>
                    <h3>Celebrating Decade Years Of Hotel In 2020</h3>
                    <p>
                        Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est
                        laborum.
                    </p>
                    <a href=""#"">Read More <i class='far fa-long-arrow-alt-right'></i> </a>
                </div>
            </div>
            <div class=""box"">
                <div class=""img"">
                    <img src=""/img/b3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7437, "\"", 7443, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <span>HOTEL</span>
                </div>
                <div class=""text"">
                    <div class=""flex"">
                        <i class=""far fa-user""> <label>Admin</label> </i>
                        <i class=""far fa-comments""> <label>Comment</label> </i>
                    </div>
                    <h3>Celebrating Decade Years Of Hotel In 2020</h3>
                    <p>
                        Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est
                        laborum.
                    </p>
                    <a href=""#"">Read More <i class='far fa-long-arrow-alt-right'></i> </a>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
