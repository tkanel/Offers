<<<<<<< HEAD
#pragma checksum "C:\Users\AKHS\source\Git\Offers\Views\Years\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f945d4b6e8dd9a4cf116a99884f785a27bcb03"
=======
#pragma checksum "C:\Users\Thodoris\source\Git\Offers\Views\Years\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f945d4b6e8dd9a4cf116a99884f785a27bcb03"
>>>>>>> 62c7fc1ab53e7efd34a9f3b181a7139f5876fffa
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Years_Index), @"mvc.1.0.view", @"/Views/Years/Index.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\AKHS\source\Git\Offers\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\Thodoris\source\Git\Offers\Views\_ViewImports.cshtml"
>>>>>>> 62c7fc1ab53e7efd34a9f3b181a7139f5876fffa
using Offers;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\AKHS\source\Git\Offers\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\Thodoris\source\Git\Offers\Views\_ViewImports.cshtml"
>>>>>>> 62c7fc1ab53e7efd34a9f3b181a7139f5876fffa
using Offers.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f945d4b6e8dd9a4cf116a99884f785a27bcb03", @"/Views/Years/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc30b3e02989b20acd431333ce87f355a276188a", @"/Views/_ViewImports.cshtml")]
    public class Views_Years_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Offers.Models.Year>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_tableButtons", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 3 "C:\Users\AKHS\source\Git\Offers\Views\Years\Index.cshtml"
=======
#line 3 "C:\Users\Thodoris\source\Git\Offers\Views\Years\Index.cshtml"
>>>>>>> 62c7fc1ab53e7efd34a9f3b181a7139f5876fffa
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3f945d4b6e8dd9a4cf116a99884f785a27bcb033996", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3f945d4b6e8dd9a4cf116a99884f785a27bcb034012", async() => {
>>>>>>> 62c7fc1ab53e7efd34a9f3b181a7139f5876fffa
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 16 "C:\Users\AKHS\source\Git\Offers\Views\Years\Index.cshtml"
=======
#line 16 "C:\Users\Thodoris\source\Git\Offers\Views\Years\Index.cshtml"
>>>>>>> 62c7fc1ab53e7efd34a9f3b181a7139f5876fffa
           Write(Html.DisplayNameFor(model => model.YearSelected));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
<<<<<<< HEAD
#line 22 "C:\Users\AKHS\source\Git\Offers\Views\Years\Index.cshtml"
=======
#line 22 "C:\Users\Thodoris\source\Git\Offers\Views\Years\Index.cshtml"
>>>>>>> 62c7fc1ab53e7efd34a9f3b181a7139f5876fffa
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
<<<<<<< HEAD
#line 25 "C:\Users\AKHS\source\Git\Offers\Views\Years\Index.cshtml"
=======
#line 25 "C:\Users\Thodoris\source\Git\Offers\Views\Years\Index.cshtml"
>>>>>>> 62c7fc1ab53e7efd34a9f3b181a7139f5876fffa
           Write(Html.DisplayFor(modelItem => item.YearSelected));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3f945d4b6e8dd9a4cf116a99884f785a27bcb036144", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e3f945d4b6e8dd9a4cf116a99884f785a27bcb036172", async() => {
>>>>>>> 62c7fc1ab53e7efd34a9f3b181a7139f5876fffa
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
<<<<<<< HEAD
#line 28 "C:\Users\AKHS\source\Git\Offers\Views\Years\Index.cshtml"
=======
#line 28 "C:\Users\Thodoris\source\Git\Offers\Views\Years\Index.cshtml"
>>>>>>> 62c7fc1ab53e7efd34a9f3b181a7139f5876fffa
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
<<<<<<< HEAD
#line 31 "C:\Users\AKHS\source\Git\Offers\Views\Years\Index.cshtml"
=======
#line 31 "C:\Users\Thodoris\source\Git\Offers\Views\Years\Index.cshtml"
>>>>>>> 62c7fc1ab53e7efd34a9f3b181a7139f5876fffa
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Offers.Models.Year>> Html { get; private set; }
    }
}
#pragma warning restore 1591
