#pragma checksum "D:\Codecool\C#\RedBook\WebApplicationZlogowaniem\Views\Child\BasicData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b29e9dbd4bb00fb11465691fad0eced3d68399b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b29e9dbd4bb00fb11465691fad0eced3d68399b", @"/Views/Child/BasicData.cshtml")]
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
            <div class=""form-css"" id=""form_1"" style=""float:left; left: 0;"">
                <div class=""buttons"">
                    <button id=""first_btn1"" class=""button btn-type-1"">Save</button>
                    <button id=""first_btn2"" class=""button btn-type-2"">Edit</button>
                </div>
                <div class=""input-group mb-3"">
                    <div class=""input-group-prepend prepend-group"">
                        <span class=""input-group-text prepend-span"" id=""surname-addon"">Nazwisko</span>
                    </div>
                    <input type=""text"" id=""surname"" class=""form-control"" aria-label=""Surname"" aria-describedby=""surname-addon"" disabled>
                </div>
                <div class=""input-group mb-3"">
                    <div class=""input-group-prepend prepend-group"">
                        <span class=");
            WriteLiteral(@"""input-group-text prepend-span"" id=""name-addon"">Imię (imiona)</span>
                    </div>
                    <input type=""text"" id=""name"" class=""form-control"" aria-label=""Name"" aria-describedby=""name-addon"" disabled>
                </div>
                <div class=""input-group mb-3"">
                    <div class=""input-group-prepend prepend-group"">
                        <span class=""input-group-text prepend-span"" id=""birthdate-addon"">Data urodzenia</span>
                    </div>
                    <input type=""date"" id=""birthdate"" class=""form-control"" aria-label=""Birthdate"" aria-describedby=""birthdate-addon"" disabled>
                </div>
                <div class=""input-group mb-3"">
                    <div class=""input-group-prepend prepend-group"">
                        <span class=""input-group-text prepend-span"" id=""birthplace-addon"">Miejsce urodzenia</span>
                    </div>
                    <input type=""text"" id=""birthplace"" class=""form-control"" aria-label=");
            WriteLiteral(@"""Birthplace"" aria-describedby=""birthplace-addon"" disabled>
                </div>
                <div class=""input-group mb-3"">
                    <div class=""input-group-prepend prepend-group"">
                        <span class=""input-group-text prepend-span"" id=""address-addon"">Adres(y)</span>
                    </div>
                    <input type=""text"" id=""address"" class=""form-control"" aria-label=""Address"" aria-describedby=""address-addon"" disabled>
                </div>
            </div>

            <div class=""form-css"" id=""form_2"" style=""float:right; left: 10px"">
                <div class=""buttons"">
                    <button id=""second_btn1"" class=""button btn-type-1"">Save</button>
                    <button id=""second_btn2"" class=""button btn-type-2"">Edit</button>
                </div>
                <span class=""form-title"" style=""left:26%"">Numer ewidencyjny PESEL</span>
                <div class=""input-group group-2"">
                    <input type=""text"" id=""pesel"" c");
            WriteLiteral(@"lass=""form-control input-2"" disabled/>
                </div>
            </div>

            <div class=""form-css"" id=""form_3"" style=""float: right; left: 10px; margin-top: 10px"">
                <span class=""buttons"">
                    <button id=""third_btn1"" class=""button btn-type-1"">Save</button>
                    <button id=""third_btn2"" class=""button btn-type-2"">Edit</button>
                </span>
                <span class=""form-title"">Grupa krwi i czynnik Rh dziecka</span>
                <div style=""margin-top: 29px"">
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend prepend-group"">
                            <span class=""input-group-text prepend-span"" id=""blood-type-addon"">Grupa krwi</span>
                        </div>
                        <input type=""text"" id=""blood_type"" class=""form-control"" aria-label=""Blood Type"" aria-describedby=""blood-type-addon"" disabled>
                        <div class=""input-group-prepen");
            WriteLiteral(@"d"" style=""width: 8%;"">
                            <span class=""input-group-text"" id=""blood-rh-addon"">Rh</span>
                        </div>
                        <input type=""text"" id=""blood_rh"" class=""form-control"" aria-label=""Blood RH"" aria-describedby=""blood-rh-addon"" disabled>
                    </div>
                    <div class=""input-group mb-3"">
                        <div class=""input-group-prepend prepend-group"">
                            <span class=""input-group-text prepend-span"" id=""exam-date-addon"">Data badania</span>
                        </div>
                        <input type=""date"" id=""exam_date"" class=""form-control"" aria-label=""Exam Date"" aria-describedby=""exam-date-addon"" disabled>
                    </div>
                </div>
                <div class=""input-group"" id=""asd"" disabled=""true"">
                    <input type=""text"" id=""id_lab"" class=""form-control"" placeholder=""Id laboratorium"" disabled/>
                    <input type=""text"" id=""id_user"" ");
            WriteLiteral("class=\"form-control\" placeholder=\"Id osoby upoważnionej\" disabled/>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
