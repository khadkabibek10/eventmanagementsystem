#pragma checksum "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbe34492959337d6b082c067bb0d1b4417f352a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_EditEvent), @"mvc.1.0.view", @"/Views/Event/EditEvent.cshtml")]
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
#line 1 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/_ViewImports.cshtml"
using EventManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/_ViewImports.cshtml"
using EventManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbe34492959337d6b082c067bb0d1b4417f352a2", @"/Views/Event/EditEvent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff0a7c1f19b4f4ab0bf911a397b24d7ceb3a5af", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_EditEvent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventManagement.ViewModels.EventViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n\n<div style=\"height:10px;\"></div>\n\n<h4>Edit Event</h4>\n<hr>\n\n<div class=\"float-right\"> <a");
            BeginWriteAttribute("href", " href=\"", 140, "\"", 191, 1);
#nullable restore
#line 10 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
WriteAttributeValue("", 147, Url.Action("Index", "Event" , new { id=0 }), 147, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Back to Home</a> </div>\n\n\n\n<div class=\"container\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbe34492959337d6b082c067bb0d1b4417f352a24214", async() => {
                WriteLiteral("\n\n");
#nullable restore
#line 17 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
         if (!string.IsNullOrEmpty(ViewBag.DisplayMessage))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"alert alert-success\" role=\"alert\">");
#nullable restore
#line 19 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
                                                     Write(ViewBag.DisplayMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\n");
#nullable restore
#line 20 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <span class=\"text-danger\">");
#nullable restore
#line 21 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
                             Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n\n        <div class=\"row\" style=\"display:none\">\n\n            <div class=\"col-md-3\"> <label for=\"eventId\">Event Id</label></div>\n            <div class=\"col-md-1\">\n                ");
#nullable restore
#line 27 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
           Write(Html.TextBoxFor(m => m.EventId, new
    {
    @class = "form-control",
    @id = "eventId",
    @placeholder = "Event Name",
    @readonly = true
    }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n        </div>\n        <div style=\"height:10px;\"></div>\n\n        <div class=\"row\">\n\n            <div class=\"col-md-3\"><label for=\"eventname\">Event Name</label></div>\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 42 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
           Write(Html.TextBoxFor(m => m.Name, new
                        {
                        @class = "form-control",
                        @id = "eventname",
                        @placeholder = "Event Name"
                        }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                <span class=\"error\"> ");
#nullable restore
#line 48 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
                                Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n\n            </div>\n\n\n\n        </div>\n        <div style=\"height:10px;\"></div>\n\n        <div class=\"row\">\n\n            <div class=\"col-md-3\"><label for=\"category\">Category</label></div>\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 61 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
           Write(Html.DropDownListFor(m => m.CategoryId,
                          new SelectList(Model.Categories, "Value", "Text", Model.CategoryId), "--Select--",
                          new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                <span class=\"error\"> ");
#nullable restore
#line 64 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
                                Write(Html.ValidationMessageFor(x => x.CategoryId));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n\n            </div>\n\n        </div>\n\n        <div style=\"height:10px;\"></div>\n        <div class=\"row\">\n\n            <div class=\"col-md-3\"><label for=\"organizer\">Organizer</label></div>\n            <div class=\"col-md-6\">\n                ");
#nullable restore
#line 75 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
           Write(Html.TextBoxFor(m => m.Organizer, new
                        {
                        @class = "form-control",
                        @id = "organizer",
                        @placeholder = "Organizer"
                        }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n        </div>\n\n\n        <div style=\"height:10px;\"></div>\n        <div class=\"row\">\n\n            <div class=\"col-md-3\"><label for=\"addressline1\">Address Line 1</label></div>\n            <div class=\"col-md-4\">\n                ");
#nullable restore
#line 91 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
           Write(Html.TextBoxFor(m => m.Location.Addressline1, new
                        {
                        @class = "form-control",
                        @id = "addressline1",
                        @placeholder = "Address Line 1"
                        }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n            </div>\n            <div class=\"col-md-3\"><label for=\"line2\">Address Line 2        </label></div>\n            <div class=\"col-md-2\">\n                ");
#nullable restore
#line 101 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
           Write(Html.TextBoxFor(m => m.Location.Line2, new
                                {
                               @class = "form-control",
                               @id = "line2",
                               @placeholder = "Address Line 2"
                            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n\n        </div>\n        <div style=\"height:10px;\"></div>\n        <div class=\"row\">\n            <div class=\"col-md-3\"> <label for=\"city\">City</label></div>\n            <div class=\"col-md-2\">\n                ");
#nullable restore
#line 115 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
           Write(Html.TextBoxFor(m => m.Location.City, new
                        {
                        @class = "form-control",
                        @id = "city",
                        @placeholder = "City"
                        }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n            <div class=\"col-md-1\"><label for=\"state\">State</label></div>\n            <div class=\"col-md-2\">\n                ");
#nullable restore
#line 124 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
           Write(Html.TextBoxFor(m => m.Location.State, new
                {
               @class = "form-control",
               @id = "state",
               @placeholder = "State"
           }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n            <div class=\"col-md-2\"><label for=\"zipcode\">Zip Code</label></div>\n            <div class=\"col-md-2\">\n                ");
#nullable restore
#line 133 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
           Write(Html.TextBoxFor(m => m.Location.ZipCode, new
    {
    @class = "form-control",
    @id = "zipcode",
    @placeholder = "Zip Code"
    }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                <span class=\"error\"> ");
#nullable restore
#line 139 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
                                Write(Html.ValidationMessageFor(x => x.Location.ZipCode));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>


            </div>


        </div>
        <div style=""height:10px;""></div>
        <div class=""row"">

            <div class=""col-md-3""><label for=""description"">Brief Description</label></div>
            <div class=""col-md-6"">
                ");
#nullable restore
#line 151 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
           Write(Html.TextAreaFor(m => m.BriefDescription, new
          {
         @class = "form-control",
         @id = "description",
         @placeholder = "Brief Description"
     }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n            </div>\n\n        </div>\n        <div style=\"height:10px;\"></div>\n\n        <div class=\"row\">\n\n            <div class=\"col-md-3\"> <label for=\"datetime\">Date Time</label></div>\n            <div class=\"col-md-3\">\n                ");
#nullable restore
#line 167 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
           Write(Html.TextBoxFor(m => m.Datetime, new
           {
               @class = "form-control datepicker",
               @id = "DatetTime",
               @placeholder = "MM/DD/YYYY hh:mm",
               @data_provider = "datepicker"
           }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n\n        </div>\n\n        <div style=\"height:10px;\"></div>\n        <div class=\"row\">\n\n            <div class=\"col-md-3\"> <label for=\"category\">Status</label></div>\n            <div class=\"col-md-3\">\n                ");
#nullable restore
#line 183 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
           Write(Html.DropDownListFor(m => m.Status, new SelectList(Model.Statuslist, "Text", "Text", Model.Status), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>


        </div>
        <div style=""height:10px;""></div>
        <div class=""row float-right"">
            <div class=""col-md-2"">
                <button type=""submit"" style=""text-align:center"" class=""btn btn-primary"">Update</button>
            </div>
        </div>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/EditEvent.cshtml"
AddHtmlAttributeValue("", 276, Url.Action("Event", "Event"), 276, 29, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/jquery-ui-timepicker-addon/1.6.3/jquery-ui-timepicker-addon.min.css"" />

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-ui-timepicker-addon/1.6.3/jquery-ui-timepicker-addon.min.js""></script>

    <script>$(function () {

            $('.datepicker').datetimepicker();
        });</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventManagement.ViewModels.EventViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591