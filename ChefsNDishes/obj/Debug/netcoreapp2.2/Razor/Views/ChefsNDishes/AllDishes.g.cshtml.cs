#pragma checksum "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ChefsNDishes/Views/ChefsNDishes/AllDishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "718e19ed9f688e96f85697c1e4d5603f34286f0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChefsNDishes_AllDishes), @"mvc.1.0.view", @"/Views/ChefsNDishes/AllDishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ChefsNDishes/AllDishes.cshtml", typeof(AspNetCore.Views_ChefsNDishes_AllDishes))]
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
#line 1 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#line 2 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"718e19ed9f688e96f85697c1e4d5603f34286f0d", @"/Views/ChefsNDishes/AllDishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_ChefsNDishes_AllDishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 607, true);
            WriteLiteral(@"<header>
    <div class=""wrapper flex"">
        <div class=""title"">
            <h1><a href=""/"">Chefs</a> | Dishes</h1>
        </div>
        <div class=""link"">
            <a href=""dishes/new"">Add a Dish</a>
        </div>
    </div>
</header>

<div class=""wrapper"">
    <h3>Check out all the Chefs</h3>
    
    <table>
        <tr>
            <th class=""padding"">Name</th>
            <th class=""padding"">Chef</th>
            <th>Tastiness</th>
            <th>Calories</th>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
        </tr>
    </table>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
