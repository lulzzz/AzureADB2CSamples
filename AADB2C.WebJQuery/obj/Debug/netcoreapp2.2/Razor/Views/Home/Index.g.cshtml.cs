#pragma checksum "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.WebJQuery\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e48d86deae0f71cb23e99aaff4f7e7c600338eb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.WebJQuery\Views\_ViewImports.cshtml"
using AADB2C.WebJQuery;

#line default
#line hidden
#line 2 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.WebJQuery\Views\_ViewImports.cshtml"
using AADB2C.WebJQuery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e48d86deae0f71cb23e99aaff4f7e7c600338eb3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d35f691d3ecbb8d31b252e37b91a70844771970", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 639, true);
            WriteLiteral(@"<!--
//===============================================================================
// Microsoft FastTrack for Azure
// Azure Active Directory B2C Authentication Samples
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED ""AS IS"" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
-->
");
            EndContext();
#line 13 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.WebJQuery\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(684, 489, true);
            WriteLiteral(@"
<div class=""text-center"" id=""divIndex"">
    <h3>Welcome to the Azure AD B2C Sample Application</h3>
    <input type=""button"" id=""btnCallAPI"" class=""btn btn-lg btn-primary"" value=""Call API"" />
</div>

<div id=""divCallAPI"" style=""display:none"">
    <h2>Call API</h2>

    <h3>API Values</h3>
    <ul id=""ulValues""></ul>
</div>

<div id=""divPrivacy"" style=""display:none"">
    <h1>Privacy Policy</h1>

    <p>Use this page to detail your site's privacy policy.</p>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1191, 203, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        // On document ready initialize the JavaScript functionality for the page\r\n        $(document).ready(function () {\r\n            AADB2C.WebJQuery.initIndex(\'");
                EndContext();
                BeginContext(1395, 16, false);
#line 39 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.WebJQuery\Views\Home\Index.cshtml"
                                   Write(ViewBag.ClientId);

#line default
#line hidden
                EndContext();
                BeginContext(1411, 4, true);
                WriteLiteral("\', \'");
                EndContext();
                BeginContext(1416, 17, false);
#line 39 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.WebJQuery\Views\Home\Index.cshtml"
                                                        Write(ViewBag.Authority);

#line default
#line hidden
                EndContext();
                BeginContext(1433, 4, true);
                WriteLiteral("\', \'");
                EndContext();
                BeginContext(1438, 17, false);
#line 39 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.WebJQuery\Views\Home\Index.cshtml"
                                                                              Write(ViewBag.ApiScopes);

#line default
#line hidden
                EndContext();
                BeginContext(1455, 4, true);
                WriteLiteral("\', \'");
                EndContext();
                BeginContext(1460, 14, false);
#line 39 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.WebJQuery\Views\Home\Index.cshtml"
                                                                                                    Write(ViewBag.ApiUrl);

#line default
#line hidden
                EndContext();
                BeginContext(1474, 33, true);
                WriteLiteral("\');\r\n        });\r\n    </script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
