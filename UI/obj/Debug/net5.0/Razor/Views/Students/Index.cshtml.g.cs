#pragma checksum "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a9cc2b70c808551042c414bdca2ddcaf4750e22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 1 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\_ViewImports.cshtml"
using BLL.Utilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a9cc2b70c808551042c414bdca2ddcaf4750e22", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"debea549169587090681e0b60b5a4ca3b1235f0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Entities.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info fload-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
  
    ViewData["Title"] = "لیست دانش آموزان";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        .pagination2 {
            display: inline-block
        }

            .pagination2 a {
                color: #000;
                float: left;
                padding: 8px 16px;
                text-decoration: none;
                border: 1px solid gray;
                border-radius: 30px
            }

                .pagination2 a.active {
                    background-color: green;
                    color: #fff
                }

                .pagination2 a:hover:not(.active) {
                    background-color: #ddd
                }
    </style>
");
            }
            );
            WriteLiteral("\r\n<h1>لیست دانش آموزان</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9cc2b70c808551042c414bdca2ddcaf4750e226328", async() => {
                WriteLiteral("ایجاد دانش آموز");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CodeMeli));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                عکس\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 61 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CodeMeli));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 74 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
                     if (@item.ImgPath != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img style=\"width:75px;height:75px;border-radius:10px;\"");
            BeginWriteAttribute("src", " src=\"", 2058, "\"", 2111, 1);
#nullable restore
#line 76 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
WriteAttributeValue("", 2064, DirectoryManager.GetStudentImage(item.ImgPath), 2064, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2112, "\"", 2152, 3);
            WriteAttributeValue("", 2118, "عکس", 2118, 3, true);
#nullable restore
#line 76 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
WriteAttributeValue(" ", 2121, item.FirstName, 2122, 15, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
WriteAttributeValue(" ", 2137, item.LastName, 2138, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 77 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 80 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
                      
                        var birthPers = DatePersian.ToJalaliShow(item.BirthDate);
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 84 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
               Write(birthPers);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9cc2b70c808551042c414bdca2ddcaf4750e2212559", async() => {
                WriteLiteral("ویرایش");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
                                           WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9cc2b70c808551042c414bdca2ddcaf4750e2214814", async() => {
                WriteLiteral("حذف");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 88 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
                                             WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 91 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"text-center\">\r\n    <p class=\"text-center\">\r\n        تعداد : ");
#nullable restore
#line 96 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
           Write(ViewBag.StudentsNums);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n\r\n");
#nullable restore
#line 99 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
      
        int pageNumber = (ViewBag.Paged);
        string hidden_class_prev = (pageNumber == 1) ? ("d-none") : ("");
        string hidden_class_next = (pageNumber == ViewBag.last_page_num) ? ("d-none") : ("");

    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"pagination2\" style=\"padding:10px;\">\r\n        <a");
            BeginWriteAttribute("class", " class=\"", 3114, "\"", 3148, 2);
            WriteAttributeValue("", 3122, "pagins", 3122, 6, true);
#nullable restore
#line 106 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
WriteAttributeValue("  ", 3128, hidden_class_prev, 3130, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" id=\"prev_page_click\">&raquo;</a>\r\n");
#nullable restore
#line 107 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
         for (var i = 1; i <= ViewBag.links_num; i++)
        {

            var activeLink = (pageNumber == i) ? ("active") : ("");


#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 3346, "\"", 3381, 3);
#nullable restore
#line 112 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
WriteAttributeValue("", 3353, ViewBag.CurrentUrl, 3353, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3372, "?paged=", 3372, 7, true);
#nullable restore
#line 112 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
WriteAttributeValue("", 3379, i, 3379, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 3382, "\"", 3408, 2);
            WriteAttributeValue("", 3390, "pagins", 3390, 6, true);
#nullable restore
#line 112 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
WriteAttributeValue(" ", 3396, activeLink, 3397, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 113 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n");
#nullable restore
#line 115 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("class", " class=\"", 3471, "\"", 3504, 2);
            WriteAttributeValue("", 3479, "pagins", 3479, 6, true);
#nullable restore
#line 116 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
WriteAttributeValue(" ", 3485, hidden_class_next, 3486, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" href=\"#\" id=\"next_page_click\">&laquo;</a>\r\n    </div>\r\n\r\n");
#nullable restore
#line 119 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
      
        var paged_next = pageNumber + 1;
        var paged_prev = pageNumber - 1;
        var next_url = ViewBag.CurrentUrl + "?paged=" + paged_next;
        var prev_url = ViewBag.CurrentUrl + "?paged=" + paged_prev;

    

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n        <script>\r\n            var urls_pagin = {\r\n                next_url: \"");
#nullable restore
#line 129 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
                      Write(next_url);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                prev_url: \"");
#nullable restore
#line 130 "D:\ALL-TUTORS\Modern\test\aspnc1\Hamedtt1Api\UI\Views\Students\Index.cshtml"
                      Write(prev_url);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
            }
            $('#next_page_click').click(function () {
                event.preventDefault();
                window.location.href = urls_pagin.next_url;

            })

            $('#prev_page_click').click(function () {
                event.preventDefault();
                window.location.href = urls_pagin.prev_url;

            })
        </script>
    ");
            }
            );
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Entities.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
