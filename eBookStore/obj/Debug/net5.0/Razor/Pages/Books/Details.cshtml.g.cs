#pragma checksum "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c237616bb7a008a007e9c457a113becda0f4567f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(eBookStore.Pages.Books.Pages_Books_Details), @"mvc.1.0.razor-page", @"/Pages/Books/Details.cshtml")]
namespace eBookStore.Pages.Books
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
#line 1 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\_ViewImports.cshtml"
using eBookStore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c237616bb7a008a007e9c457a113becda0f4567f", @"/Pages/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a5252e915daa470ea878a9c98803eb3311ad1c6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Books_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Book</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Advance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Advance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Royalty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Royalty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.YtdSale));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.YtdSale));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.PublishedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Book.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
       Write(Html.DisplayFor(model => model.Book.Publisher.PubId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c237616bb7a008a007e9c457a113becda0f4567f10351", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "D:\01_Docs\FPT_University\CN8\PRN231\Assignments\assignment2-prn231-quan\eBookStore\Pages\Books\Details.cshtml"
                           WriteLiteral(Model.Book.BookId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c237616bb7a008a007e9c457a113becda0f4567f12532", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetailsModel>)PageContext?.ViewData;
        public DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591