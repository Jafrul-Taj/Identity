#pragma checksum "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "308abadbc497e2af222cd5fc2c38d40bd1c09679"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_ListUsers), @"mvc.1.0.view", @"/Views/Administration/ListUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration/ListUsers.cshtml", typeof(AspNetCore.Views_Administration_ListUsers))]
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
#line 1 "H:\work\Identity\Identity\Identity\Views\_ViewImports.cshtml"
using Identity;

#line default
#line hidden
#line 2 "H:\work\Identity\Identity\Identity\Views\_ViewImports.cshtml"
using Identity.Models;

#line default
#line hidden
#line 3 "H:\work\Identity\Identity\Identity\Views\_ViewImports.cshtml"
using Identity.ViewModels;

#line default
#line hidden
#line 4 "H:\work\Identity\Identity\Identity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308abadbc497e2af222cd5fc2c38d40bd1c09679", @"/Views/Administration/ListUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e2003c5e83a5417e628f103fb6f55002d8a3ef8", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_ListUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
  
    ViewData["Title"] = "All Users";

#line default
#line hidden
            BeginContext(176, 22, true);
            WriteLiteral("\r\n<h1>All Users</h1>\r\n");
            EndContext();
#line 9 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(220, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(224, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "308abadbc497e2af222cd5fc2c38d40bd1c096797756", async() => {
                BeginContext(322, 28, true);
                WriteLiteral("\r\n        Add new User\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(354, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
    foreach (var user in Model)
    {

#line default
#line hidden
            BeginContext(396, 109, true);
            WriteLiteral("        <div class=\"card mb-3\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(506, 13, false);
#line 18 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
                                  Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(519, 103, true);
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n               \r\n                    ");
            EndContext();
            BeginContext(622, 561, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "308abadbc497e2af222cd5fc2c38d40bd1c0967910358", async() => {
                BeginContext(690, 31, true);
                WriteLiteral("\r\n                        <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 721, "\"", 745, 2);
                WriteAttributeValue("", 726, "deleteSpan_", 726, 11, true);
#line 23 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
WriteAttributeValue("", 737, user.Id, 737, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(746, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 24 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
                             if ((await authorizationService.AuthorizeAsync(User, "DeleteRolePolicy")).Succeeded)
                            {

#line default
#line hidden
                BeginContext(895, 66, true);
                WriteLiteral("                                <a href=\"#\" class=\"btn btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", "\r\n                                   onclick=\"", 961, "\"", 1078, 12);
                WriteAttributeValue("", 1007, "return", 1007, 6, true);
                WriteAttributeValue(" ", 1013, "confirm(\'Are", 1014, 13, true);
                WriteAttributeValue(" ", 1026, "you", 1027, 4, true);
                WriteAttributeValue(" ", 1030, "sure", 1031, 5, true);
                WriteAttributeValue(" ", 1035, "you", 1036, 4, true);
                WriteAttributeValue(" ", 1039, "want", 1040, 5, true);
                WriteAttributeValue(" ", 1044, "to", 1045, 3, true);
                WriteAttributeValue(" ", 1047, "delete", 1048, 7, true);
                WriteAttributeValue(" ", 1054, "user", 1055, 5, true);
                WriteAttributeValue(" ", 1059, ":", 1060, 2, true);
#line 27 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
WriteAttributeValue(" ", 1061, user.UserName, 1062, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 1076, "\')", 1076, 2, true);
                EndWriteAttribute();
                BeginContext(1079, 13, true);
                WriteLiteral(">Delete</a>\r\n");
                EndContext();
#line 28 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
                            }

#line default
#line hidden
                BeginContext(1123, 53, true);
                WriteLiteral("                        </span>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
                                                    WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1183, 21, true);
            WriteLiteral("\r\n                 \r\n");
            EndContext();
#line 32 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
                  if ((await authorizationService.AuthorizeAsync(User, "EditRolePolicy")).Succeeded)
                  {

#line default
#line hidden
            BeginContext(1327, 21, true);
            WriteLiteral("                     ");
            EndContext();
            BeginContext(1348, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "308abadbc497e2af222cd5fc2c38d40bd1c0967916074", async() => {
                BeginContext(1453, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
                                                                                WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1461, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"

                  }

                        

#line default
#line hidden
            BeginContext(1897, 87, true);
            WriteLiteral("                       \r\n                    \r\n                </div>\r\n        </div>\r\n");
            EndContext();
#line 49 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
    }
}
else
{

#line default
#line hidden
            BeginContext(2003, 291, true);
            WriteLiteral(@"    <div class=""card"">
        <div class=""card-header"">
            No Users Created yet
        </div>
        <div class=""card-body"">
            Use the button below to create a user
        </div>
        <a class=""btn btn-primary"" style=""width:auto "">Add Users</a>
    </div>
");
            EndContext();
#line 62 "H:\work\Identity\Identity\Identity\Views\Administration\ListUsers.cshtml"
}

#line default
#line hidden
            BeginContext(2297, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SCripts", async() => {
                BeginContext(2316, 7, true);
                WriteLiteral(" \r\n    ");
                EndContext();
                BeginContext(2323, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "308abadbc497e2af222cd5fc2c38d40bd1c0967920029", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2359, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService authorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
