#pragma checksum "D:\Codecool\C#\RedBook\WebApplicationZlogowaniem\Views\Child\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "645e997033dfd408860834e0dc911c41a02a7708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Child_Search), @"mvc.1.0.view", @"/Views/Child/Search.cshtml")]
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
#line 1 "D:\Codecool\C#\RedBook\WebApplicationZlogowaniem\Views\_ViewImports.cshtml"
using WebApplicationZlogowaniem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Codecool\C#\RedBook\WebApplicationZlogowaniem\Views\_ViewImports.cshtml"
using WebApplicationZlogowaniem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"645e997033dfd408860834e0dc911c41a02a7708", @"/Views/Child/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6eedc06e7c0e8f789d648afcebdfc8db80cc47d", @"/Views/_ViewImports.cshtml")]
    public class Views_Child_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Codecool\C#\RedBook\WebApplicationZlogowaniem\Views\Child\Search.cshtml"
  
    ViewData["Title"] = "Child Page - Search";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main child"">
    <div class=""container pb-3"">
        <div class=""text-center"">
            <h1 class=""display-4"">Wyszukiwanie</h1>

            <div>
                <span class=""tbl-span-search"">
                    <input type=""text"" placeholder=""Search"">
                    <button id=""btn_search"" class=""button btn-type-2"">Search</button>
                </span>
                <span class=""tbl-span-pages"">
                    <button id=""btn_prev"" class=""button btn-type-2"">Previous</button>
                    <button id=""btn_next"" class=""button btn-type-2"">Next</button>
                </span>
                <table class=""tbl"">
                    <tr>
                        <th style=""width:60%;"">Imię,Nazwisko</th>
                        <th style=""width:40%;"">PESEL</th>
                    </tr>
                    <tr>
                        <td>Alfreds Futterkiste</td>
                        <td>90031206959</td>
                    </tr>
                    ");
            WriteLiteral(@"<tr>
                        <td>Berglunds snabbkop</td>
                        <td>95198498819</td>
                    </tr>
                    <tr>
                        <td>Island Trading</td>
                        <td>61515195159</td>
                    </tr>
                    <tr>
                        <td>Koniglich Essen</td>
                        <td>15811591555</td>
                    </tr>
                    <tr>
                        <td>Laughing Bacchus Winecellars</td>
                        <td>19559159195</td>
                    </tr>
                </table>
            </div>
        </div>
    </div>
</div>
");
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
