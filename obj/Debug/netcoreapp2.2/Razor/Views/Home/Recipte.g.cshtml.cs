#pragma checksum "C:\Users\dakot\source\repos\Lab25\Views\Home\Recipte.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5896c62883d65e893ab21bb9be1f7790c6ccc42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Recipte), @"mvc.1.0.view", @"/Views/Home/Recipte.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Recipte.cshtml", typeof(AspNetCore.Views_Home_Recipte))]
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
#line 1 "C:\Users\dakot\source\repos\Lab25\Views\_ViewImports.cshtml"
using Lab25;

#line default
#line hidden
#line 2 "C:\Users\dakot\source\repos\Lab25\Views\_ViewImports.cshtml"
using Lab25.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5896c62883d65e893ab21bb9be1f7790c6ccc42", @"/Views/Home/Recipte.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afb444276fbdf49c8ce4c6f7c04e0cfb0f2e5558", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Recipte : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lab25.Models.Purchase>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dakot\source\repos\Lab25\Views\Home\Recipte.cshtml"
   
    double price = @Model.Price;
    double quantity = Model.Quantity;
    double total = (price *quantity);

#line default
#line hidden
            BeginContext(153, 24, true);
            WriteLiteral("\r\n<h2>Enjoy your coffee ");
            EndContext();
            BeginContext(178, 10, false);
#line 9 "C:\Users\dakot\source\repos\Lab25\Views\Home\Recipte.cshtml"
                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(188, 24, true);
            WriteLiteral("</h2>\r\n<p>You purchsed \"");
            EndContext();
            BeginContext(213, 17, false);
#line 10 "C:\Users\dakot\source\repos\Lab25\Views\Home\Recipte.cshtml"
            Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(230, 23, true);
            WriteLiteral("\"</p>\r\n<p>You payed us ");
            EndContext();
            BeginContext(254, 5, false);
#line 11 "C:\Users\dakot\source\repos\Lab25\Views\Home\Recipte.cshtml"
           Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(259, 82, true);
            WriteLiteral(" with you credit card.</p>\r\n<p>Thank you for you business we appreciate you!</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lab25.Models.Purchase> Html { get; private set; }
    }
}
#pragma warning restore 1591
