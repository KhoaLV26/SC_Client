#pragma checksum "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9c574e36e0dd371d8a3224b954ead82da9d39177a0627557deda7b785a922554"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\_ViewImports.cshtml"
using Shopping.Client

#nullable disable
    ;
#nullable restore
#line 2 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\_ViewImports.cshtml"
using Shopping.Client.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9c574e36e0dd371d8a3224b954ead82da9d39177a0627557deda7b785a922554", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0545d5609cffa9a7d06352d85baaebdf0a7b9cedadbecd4037c45c98ebcf4d13", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Shopping.Client.Models.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable

            WriteLiteral("\n<h1>Products - Updated V3 from AKS Deployment - last run</h1>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            Write(
#nullable restore
#line 12 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml"
                 Html.DisplayNameFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </th>\n            <th>\n                ");
            Write(
#nullable restore
#line 15 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml"
                 Html.DisplayNameFor(model => model.Category)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </th>\n            <th>\n                ");
            Write(
#nullable restore
#line 18 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml"
                 Html.DisplayNameFor(model => model.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </th>\n            <th>\n                ");
            Write(
#nullable restore
#line 21 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml"
                 Html.DisplayNameFor(model => model.ImageFile)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </th>\n            <th>\n                ");
            Write(
#nullable restore
#line 24 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml"
                 Html.DisplayNameFor(model => model.Price)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 30 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\n                <td>\n                    ");
            Write(
#nullable restore
#line 34 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            Write(
#nullable restore
#line 37 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Category)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            Write(
#nullable restore
#line 40 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Description)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            Write(
#nullable restore
#line 43 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml"
                     Html.DisplayFor(modelItem => item.ImageFile)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            Write(
#nullable restore
#line 46 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml"
                     Html.DisplayFor(modelItem => item.Price)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 49 "D:\COMPANY\Devops\run-devops-main\Shopping\Shopping.Client\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </tbody>\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Shopping.Client.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
