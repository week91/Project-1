#pragma checksum "C:\repohome\Project-1\HappyNews\Views\RoleControllers\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "116192b88d9bf99854e39dcf3d619d1d1cd15ba0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoleControllers_Edit), @"mvc.1.0.view", @"/Views/RoleControllers/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RoleControllers/Edit.cshtml", typeof(AspNetCore.Views_RoleControllers_Edit))]
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
#line 1 "C:\repohome\Project-1\HappyNews\Views\_ViewImports.cshtml"
using HappyNews;

#line default
#line hidden
#line 1 "C:\repohome\Project-1\HappyNews\Views\RoleControllers\Edit.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"116192b88d9bf99854e39dcf3d619d1d1cd15ba0", @"/Views/RoleControllers/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0b6ddb1e005df4c77c8613fde376bb86756545", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleControllers_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HappyNews.ViewsModel.ChangeRoleVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 39, true);
            WriteLiteral(" \n<h2>Изменение ролей для пользователя ");
            EndContext();
            BeginContext(118, 15, false);
#line 4 "C:\repohome\Project-1\HappyNews\Views\RoleControllers\Edit.cshtml"
                                Write(Model.UserEmail);

#line default
#line hidden
            EndContext();
            BeginContext(133, 8, true);
            WriteLiteral("</h2>\n \n");
            EndContext();
            BeginContext(141, 468, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "116192b88d9bf99854e39dcf3d619d1d1cd15ba04342", async() => {
                BeginContext(179, 39, true);
                WriteLiteral("\n    <input type=\"hidden\" name=\"userId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 218, "\"", 239, 1);
#line 7 "C:\repohome\Project-1\HappyNews\Views\RoleControllers\Edit.cshtml"
WriteAttributeValue("", 226, Model.UserId, 226, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(240, 33, true);
                WriteLiteral(" />\n    <div class=\"form-group\">\n");
                EndContext();
#line 9 "C:\repohome\Project-1\HappyNews\Views\RoleControllers\Edit.cshtml"
         foreach (IdentityRole role in Model.AllRoles)
        {

#line default
#line hidden
                BeginContext(338, 47, true);
                WriteLiteral("            <input type=\"checkbox\" name=\"roles\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 385, "\"", 403, 1);
#line 11 "C:\repohome\Project-1\HappyNews\Views\RoleControllers\Edit.cshtml"
WriteAttributeValue("", 393, role.Name, 393, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(404, 20, true);
                WriteLiteral("\n                   ");
                EndContext();
                BeginContext(426, 64, false);
#line 12 "C:\repohome\Project-1\HappyNews\Views\RoleControllers\Edit.cshtml"
               Write(Model.UserRoles.Contains(role.Name) ? "checked=\"checked\"" : "");

#line default
#line hidden
                EndContext();
                BeginContext(491, 3, true);
                WriteLiteral(" />");
                EndContext();
                BeginContext(495, 9, false);
#line 12 "C:\repohome\Project-1\HappyNews\Views\RoleControllers\Edit.cshtml"
                                                                                    Write(role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(504, 8, true);
                WriteLiteral(" <br />\n");
                EndContext();
#line 13 "C:\repohome\Project-1\HappyNews\Views\RoleControllers\Edit.cshtml"
        }

#line default
#line hidden
                BeginContext(522, 80, true);
                WriteLiteral("    </div>\n    <button type=\"submit\" class=\"btn btn-primary\">Сохранить</button>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HappyNews.ViewsModel.ChangeRoleVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
