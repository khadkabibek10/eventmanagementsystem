#pragma checksum "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "277cb868fd4835894c44b859fccf0d9e02d7b476"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Category), @"mvc.1.0.view", @"/Views/Event/Category.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"277cb868fd4835894c44b859fccf0d9e02d7b476", @"/Views/Event/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff0a7c1f19b4f4ab0bf911a397b24d7ceb3a5af", @"/Views/_ViewImports.cshtml")]
    public class Views_Event_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EventManagement.ViewModels.CategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n    <div style=\"height:10px;\"></div>\n    <div class=\"container\"><h3>Categories</h3></div>\n<hr />\n\n    <ul>\n");
#nullable restore
#line 8 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/Category.cshtml"
         foreach (var name in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\n                <a");
            BeginWriteAttribute("href", " href=\"", 249, "\"", 307, 1);
#nullable restore
#line 12 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/Category.cshtml"
WriteAttributeValue("", 256, Url.Action("Index", "Event" , new { id=@name.Id }), 256, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/Category.cshtml"
                                                                         Write(name.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n            </li>\n");
#nullable restore
#line 14 "/Users/bibekkhadka/Documents/Future/C# Bootcamp/MiniProject/EventManagement/EventManagement/Views/Event/Category.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EventManagement.ViewModels.CategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
