#pragma checksum "C:\Users\rooke\Desktop\ConferenceRoomManager\ConferenceRoomManager\Views\Shared\_MapsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "596e0c272a36026d2c0bb005d61f611a9fa4aabd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MapsPartial), @"mvc.1.0.view", @"/Views/Shared/_MapsPartial.cshtml")]
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
#line 1 "C:\Users\rooke\Desktop\ConferenceRoomManager\ConferenceRoomManager\Views\_ViewImports.cshtml"
using ConferenceRoomManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rooke\Desktop\ConferenceRoomManager\ConferenceRoomManager\Views\_ViewImports.cshtml"
using ConferenceRoomManager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596e0c272a36026d2c0bb005d61f611a9fa4aabd", @"/Views/Shared/_MapsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a05d21bce01ebbe67df1566de53142988f6e124", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MapsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<iframe width=\"530\" height=\"450\" style=\"border:0\" loading=\"lazy\" allowfullscreen");
            BeginWriteAttribute("src", "\r\n        src=", 419, "", 439, 1);
#nullable restore
#line 15 "C:\Users\rooke\Desktop\ConferenceRoomManager\ConferenceRoomManager\Views\Shared\_MapsPartial.cshtml"
WriteAttributeValue("", 433, Model, 433, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n</iframe>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591