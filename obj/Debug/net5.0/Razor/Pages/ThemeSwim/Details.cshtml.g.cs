#pragma checksum "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d974d0bdb2032bc30681e5781dd98590c45120cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WEB315_Assignments_ThemeSwim.Pages.ThemeSwim.Pages_ThemeSwim_Details), @"mvc.1.0.razor-page", @"/Pages/ThemeSwim/Details.cshtml")]
namespace WEB315_Assignments_ThemeSwim.Pages.ThemeSwim
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
#line 1 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\_ViewImports.cshtml"
using WEB315_Assignments_ThemeSwim;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d974d0bdb2032bc30681e5781dd98590c45120cc", @"/Pages/ThemeSwim/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3780a58e82c20632d22348dad8e8a0cadd3c1dce", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ThemeSwim_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>ThemeSwim</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ThemeSwim.EventName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayFor(model => model.ThemeSwim.EventName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ThemeSwim.BookingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayFor(model => model.ThemeSwim.BookingDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ThemeSwim.Competition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayFor(model => model.ThemeSwim.Competition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ThemeSwim.PoolName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayFor(model => model.ThemeSwim.PoolName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ThemeSwim.EntryPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayFor(model => model.ThemeSwim.EntryPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayFor(model => model.ThemeSwim.NoOfPool));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayFor(model => model.ThemeSwim.NoOfPool));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayFor(model => model.ThemeSwim.AlottedPool));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
       Write(Html.DisplayFor(model => model.ThemeSwim.AlottedPool));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        \r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d974d0bdb2032bc30681e5781dd98590c45120cc8950", async() => {
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
#line 60 "C:\Users\samee\OneDrive\Documents\GitHub\WEB315_Assignments_ThemeSwim\Pages\ThemeSwim\Details.cshtml"
                           WriteLiteral(Model.ThemeSwim.ID);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d974d0bdb2032bc30681e5781dd98590c45120cc11121", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WEB315_Assignments_ThemeSwim.Pages_ThemeSwim.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WEB315_Assignments_ThemeSwim.Pages_ThemeSwim.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WEB315_Assignments_ThemeSwim.Pages_ThemeSwim.DetailsModel>)PageContext?.ViewData;
        public WEB315_Assignments_ThemeSwim.Pages_ThemeSwim.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
