#pragma checksum "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/WeddingPlanner2/Views/Home/WeddingDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88675fde3b11dd4328a0f54c3bae785e572b7372"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_WeddingDetails), @"mvc.1.0.view", @"/Views/Home/WeddingDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/WeddingDetails.cshtml", typeof(AspNetCore.Views_Home_WeddingDetails))]
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
#line 1 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/WeddingPlanner2/Views/_ViewImports.cshtml"
using WeddingPlanner2;

#line default
#line hidden
#line 2 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/WeddingPlanner2/Views/_ViewImports.cshtml"
using WeddingPlanner2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88675fde3b11dd4328a0f54c3bae785e572b7372", @"/Views/Home/WeddingDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf73e64805b57163888471c1e1e0bb3846f9ee5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_WeddingDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wedding>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 105, true);
            WriteLiteral("\n<header>\n    <div class=\"wrapper flex\">\n        <div class=\"title\">\n            <h1 class=\"unique-font\">");
            EndContext();
            BeginContext(121, 15, false);
#line 6 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/WeddingPlanner2/Views/Home/WeddingDetails.cshtml"
                               Write(Model.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(136, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(138, 15, false);
#line 6 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/WeddingPlanner2/Views/Home/WeddingDetails.cshtml"
                                                Write(Model.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(153, 60, true);
            WriteLiteral("</h1>\n        </div>\n        <div class=\"link\">\n            ");
            EndContext();
            BeginContext(213, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88675fde3b11dd4328a0f54c3bae785e572b73725055", async() => {
                BeginContext(261, 9, true);
                WriteLiteral("Dashboard");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(274, 13, true);
            WriteLiteral("\n            ");
            EndContext();
            BeginContext(287, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88675fde3b11dd4328a0f54c3bae785e572b73726620", async() => {
                BeginContext(332, 6, true);
                WriteLiteral("Logout");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(342, 111, true);
            WriteLiteral("\n        </div>\n    </div>\n</header>\n\n<div class=\"wrapper flex-split\">\n    <div class=\"col\">\n        <h3>Date: ");
            EndContext();
            BeginContext(454, 34, false);
#line 17 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/WeddingPlanner2/Views/Home/WeddingDetails.cshtml"
             Write(Model.Date.ToString("MM dd, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(488, 45, true);
            WriteLiteral("</h3>\n\n        <h3>Guests:</h3>\n        <ul>\n");
            EndContext();
#line 21 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/WeddingPlanner2/Views/Home/WeddingDetails.cshtml"
         foreach(RSVP RSVP in @Model.RSVPs)
        {

#line default
#line hidden
            BeginContext(587, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(604, 20, false);
#line 23 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/WeddingPlanner2/Views/Home/WeddingDetails.cshtml"
           Write(RSVP.Guest.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(624, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(626, 19, false);
#line 23 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/WeddingPlanner2/Views/Home/WeddingDetails.cshtml"
                                 Write(RSVP.Guest.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(645, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 24 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/WeddingPlanner2/Views/Home/WeddingDetails.cshtml"
        }

#line default
#line hidden
            BeginContext(661, 68, true);
            WriteLiteral("        </ul>\n    </div>\n    <div class=\"col\">\n        <h3>Address: ");
            EndContext();
            BeginContext(730, 13, false);
#line 28 "/Users/rolandolopantzi/Documents/CodingDojo/Week10-12/WeddingPlanner2/Views/Home/WeddingDetails.cshtml"
                Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(743, 422, true);
            WriteLiteral(@"</h3>

        <div id=""googleMap"" style=""width:100%;height:400px""></div>
    </div>

</div>

<script>
function myMap() {
var mapProp= {
  center:new google.maps.LatLng(33.6945634,-117.9169291),
  zoom:5,
};
var map = new google.maps.Map(document.getElementById(""googleMap""),mapProp);
}
</script>



<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyDSb6p2Yw_Qwy-afHYbLVaR3QBmhEcvZcI&callback=myMap""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wedding> Html { get; private set; }
    }
}
#pragma warning restore 1591
