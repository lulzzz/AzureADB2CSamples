#pragma checksum "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.Web\Views\Home\CallAPI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "054e26ef35fb55dda3d6bc6b04b2a188319ce71c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CallAPI), @"mvc.1.0.view", @"/Views/Home/CallAPI.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/CallAPI.cshtml", typeof(AspNetCore.Views_Home_CallAPI))]
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
#line 1 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.Web\Views\_ViewImports.cshtml"
using AADB2C.Web;

#line default
#line hidden
#line 2 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.Web\Views\_ViewImports.cshtml"
using AADB2C.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"054e26ef35fb55dda3d6bc6b04b2a188319ce71c", @"/Views/Home/CallAPI.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00bef32ebe79b5602475e4c9dafd7e8c7d41c21b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CallAPI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 13 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.Web\Views\Home\CallAPI.cshtml"
  
    ViewData["Title"] = "Call API";

#line default
#line hidden
            BeginContext(683, 23, true);
            WriteLiteral("\r\n<h2>Call API</h2>\r\n\r\n");
            EndContext();
#line 19 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.Web\Views\Home\CallAPI.cshtml"
 if (ViewBag.Values != null)
{

#line default
#line hidden
            BeginContext(739, 35, true);
            WriteLiteral("    <h3>API Values</h3>\r\n    <ul>\r\n");
            EndContext();
#line 23 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.Web\Views\Home\CallAPI.cshtml"
         foreach (string value in ViewBag.Values)
        {

#line default
#line hidden
            BeginContext(836, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(853, 5, false);
#line 25 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.Web\Views\Home\CallAPI.cshtml"
           Write(value);

#line default
#line hidden
            EndContext();
            BeginContext(858, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 26 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.Web\Views\Home\CallAPI.cshtml"
        }

#line default
#line hidden
            BeginContext(876, 11, true);
            WriteLiteral("    </ul>\r\n");
            EndContext();
#line 28 "C:\Data\Source\Workspaces\Sample Code\AzureADB2CSamples-MSAL\AADB2C.Web\Views\Home\CallAPI.cshtml"
}

#line default
#line hidden
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