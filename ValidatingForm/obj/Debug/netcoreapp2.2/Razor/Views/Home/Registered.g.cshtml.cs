#pragma checksum "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ValidatingForm/Views/Home/Registered.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ea0753ebab4d422d04567d6b4a804d2d0a22a6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Registered), @"mvc.1.0.view", @"/Views/Home/Registered.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Registered.cshtml", typeof(AspNetCore.Views_Home_Registered))]
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
#line 1 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ValidatingForm/Views/_ViewImports.cshtml"
using ValidatingForm;

#line default
#line hidden
#line 2 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ValidatingForm/Views/_ViewImports.cshtml"
using ValidatingForm.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ea0753ebab4d422d04567d6b4a804d2d0a22a6d", @"/Views/Home/Registered.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86d6d63e4321c0c68df0b7433674ab56c581441c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Registered : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 164, true);
            WriteLiteral("<header>\n    <div class=\"wrapper\">\n        <h1>Validating a Form</h1>\n        <h4>You have registered</h4>\n    </div>\n</header>\n\n<div class=\"wrapper\">\n    <p>Name: ");
            EndContext();
            BeginContext(177, 15, false);
#line 10 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ValidatingForm/Views/Home/Registered.cshtml"
        Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(192, 23, true);
            WriteLiteral("</p>\n    <p>Last name: ");
            EndContext();
            BeginContext(216, 14, false);
#line 11 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ValidatingForm/Views/Home/Registered.cshtml"
             Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(230, 17, true);
            WriteLiteral("</p>\n    <p>Age: ");
            EndContext();
            BeginContext(248, 9, false);
#line 12 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ValidatingForm/Views/Home/Registered.cshtml"
       Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(257, 27, true);
            WriteLiteral("</p>\n    <p>Email address: ");
            EndContext();
            BeginContext(285, 11, false);
#line 13 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ValidatingForm/Views/Home/Registered.cshtml"
                 Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(296, 13, true);
            WriteLiteral("</p>\n</div>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
