#pragma checksum "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "718430378431f748c65525685b9d6c4f419f4fa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_AllPurchaseReportPDF), @"mvc.1.0.view", @"/Views/Report/AllPurchaseReportPDF.cshtml")]
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
#line 1 "C:\SourceCodes\PurchaseSystem\Views\_ViewImports.cshtml"
using PurchaseSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SourceCodes\PurchaseSystem\Views\_ViewImports.cshtml"
using PurchaseSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"718430378431f748c65525685b9d6c4f419f4fa3", @"/Views/Report/AllPurchaseReportPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"354566da74be520e92fd5c1fc15e61d662677371", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_AllPurchaseReportPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PurchaseSystem.Models.Purchase>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
  
    ViewData["Title"] = "AllPurchaseReportPDF";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1 style=\"margin-top:10px; margin-left:200px;\"> Purchase Management System</h1>\r\n<h2 style=\"margin-top: 10px;\">\r\n    Purchase Detail Record - &nbsp; &nbsp; ");
#nullable restore
#line 12 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
                                      Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
           Write(Html.DisplayName("Purchase Item"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
           Write(Html.DisplayName("Purchase Quantity"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
           Write(Html.DisplayName("Purchase Date"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
           Write(Html.DisplayName("Price"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
           Write(Html.DisplayName("Vendor"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
               Write(Html.DisplayFor(modelItem => item.purchase_item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
               Write(Html.DisplayFor(modelItem => item.purchase_quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
               Write(Html.DisplayFor(modelItem => item.purchase_date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
               Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
               Write(Html.DisplayFor(modelItem => item.vendor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "C:\SourceCodes\PurchaseSystem\Views\Report\AllPurchaseReportPDF.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PurchaseSystem.Models.Purchase>> Html { get; private set; }
    }
}
#pragma warning restore 1591