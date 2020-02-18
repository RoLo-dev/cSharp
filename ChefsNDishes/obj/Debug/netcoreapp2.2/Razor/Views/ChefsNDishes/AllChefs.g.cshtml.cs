#pragma checksum "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ChefsNDishes/Views/ChefsNDishes/AllChefs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "767dfee65be5f4871d49fc43c117a305ae3419f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChefsNDishes_AllChefs), @"mvc.1.0.view", @"/Views/ChefsNDishes/AllChefs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ChefsNDishes/AllChefs.cshtml", typeof(AspNetCore.Views_ChefsNDishes_AllChefs))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"767dfee65be5f4871d49fc43c117a305ae3419f1", @"/Views/ChefsNDishes/AllChefs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_ChefsNDishes_AllChefs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 466, true);
            WriteLiteral(@"
<header>
    <div class=""wrapper flex"">
        <div class=""title"">
            <h1>Chefs | <a href=""dishes"">Dishes</a></h1>
        </div>
        <div class=""link"">
            <a href=""chef/new"">Add a Chef</a>
        </div>
    </div>
</header>

<div class=""wrapper"">
    <h3>Check out all the Chefs</h3>

    <table>
        <tr>
            <th class=""padding"">Name</th>
            <th>Age</th>
            <th class=""padding""># of Dishes</th>
        </tr>
");
            EndContext();
#line 23 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ChefsNDishes/Views/ChefsNDishes/AllChefs.cshtml"
         foreach(var chef in Model)
        {

#line default
#line hidden
            BeginContext(530, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(560, 14, false);
#line 26 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ChefsNDishes/Views/ChefsNDishes/AllChefs.cshtml"
           Write(chef.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(574, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(576, 13, false);
#line 26 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ChefsNDishes/Views/ChefsNDishes/AllChefs.cshtml"
                           Write(chef.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(589, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(613, 41, false);
#line 27 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ChefsNDishes/Views/ChefsNDishes/AllChefs.cshtml"
            Write(DateTime.Now.Year - chef.DateOfBirth.Year);

#line default
#line hidden
            EndContext();
            BeginContext(655, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(678, 24, false);
#line 28 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ChefsNDishes/Views/ChefsNDishes/AllChefs.cshtml"
           Write(chef.CreatedDishes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(702, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 30 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/ChefsNDishes/Views/ChefsNDishes/AllChefs.cshtml"
        }

#line default
#line hidden
            BeginContext(732, 19, true);
            WriteLiteral("    </table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591