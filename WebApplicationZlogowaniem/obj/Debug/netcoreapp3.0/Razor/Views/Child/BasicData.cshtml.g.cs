#pragma checksum "D:\Codecool\C#\RedBook\WebApplicationZlogowaniem\Views\Child\BasicData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce372b03ef4935b02387122b06b655b0dd2a6296"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Child_BasicData), @"mvc.1.0.view", @"/Views/Child/BasicData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce372b03ef4935b02387122b06b655b0dd2a6296", @"/Views/Child/BasicData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6eedc06e7c0e8f789d648afcebdfc8db80cc47d", @"/Views/_ViewImports.cshtml")]
    public class Views_Child_BasicData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Codecool\C#\RedBook\WebApplicationZlogowaniem\Views\Child\BasicData.cshtml"
  
    ViewData["Title"] = "Dane dziecka";
    Layout = "_ChildLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main child"">
    <div class=""container pb-3"">
        <div class=""text-center"">
            <h1 class=""display-4"">Dane dziecka</h1>
            <div class=""form-css"" id=""form-css"" style=""float:left; left: 0;"">
                <div class=""buttons"">
                    <button id=""first_btn1"" style=""display: none;"">Save</button>
                    <button id=""first_btn2"" style=""display: inline;"">Edit</button>
                </div>
                <div style=""width: 100%; float: inherit;"">
                    <label for=""surname"">Nazwisko:</label>
                    <input class=""input-1"" type=""text"" id=""surname"" />
                </div>
                <label for=""names"">Imię (imiona):</label>
                <input class=""input-1"" type=""text"" id=""names"" /><br />
                <label for=""birth-date"">Data urodzenia:</label>
                <input type=""date"" id=""birthdate"" /><br />
                <label for=""birth-place"">Miejsce urodzenia:</label>
                <input cl");
            WriteLiteral(@"ass=""input-1"" type=""text"" id=""birthplace"" /><br />
                <label for=""address"">Adres(y):</label>
                <input class=""input-1"" type=""text"" id=""address"" /><br />
            </div>

            <div class=""form-css"" id=""form-css"" style=""float:right; left: 10px"">
                <div class=""buttons"">
                    <button id=""second_btn1"" style=""display: none;"">Save</button>
                    <button id=""second_btn2"" style=""display: inline;"">Edit</button>
                </div>
                <span class=""form-title"" style=""left:26%"">Numer ewidencyjny PESEL</span>
                <div style=""width: 100%; float: inherit; margin-top: 10px;"">
                    <input type=""text"" id=""pesel"" style=""width: 32%; font-size:20px; margin-left: 5px; text-align: center; letter-spacing: 3px;"" />
                </div>
            </div>

            <div class=""form-css"" id=""form-css"" style=""float: right; left: 10px; margin-top: 10px"">
                <span class=""buttons"">
   ");
            WriteLiteral(@"                 <button id=""third_btn1"" style=""display: none;"">Save</button>
                    <button id=""third_btn2"" style=""display: inline;"">Edit</button>
                </span>
                <span class=""form-title"">Grupa krwi i czynnik Rh dziecka</span>
                <div style=""margin-top: 29px"">
                    <label for=""blood-type"">Grupa krwi:</label>
                    <input type=""text"" id=""blood-type"" style=""margin: 10px 4px 10px 10px;"" />
                    <label for=""blood-rh"">Rh:</label>
                    <input type=""text"" id=""blood-rh"" /><br />
                    <label for=""date-exam"">Data badania:</label>
                    <input type=""text"" id=""date-exam"" style=""width: 70%;"" /><br /><br />
                </div>

                <input type=""text"" id=""pesel"" style=""width: 48%;"" placeholder=""Id laboratorium"" />
                <input type=""text"" id=""pesel"" style=""width: 48%;"" placeholder=""Id osoby upoważnionej"" />
            </div>

        </div>
   ");
            WriteLiteral(" </div>\r\n</div>\r\n\r\n\r\n");
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
