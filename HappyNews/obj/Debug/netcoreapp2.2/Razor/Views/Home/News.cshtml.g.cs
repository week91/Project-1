#pragma checksum "C:\repohome\Project-1\HappyNews\Views\Home\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f04c302d20e346533fbbfdfd0ad902b5aa3f3116"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_News), @"mvc.1.0.view", @"/Views/Home/News.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/News.cshtml", typeof(AspNetCore.Views_Home_News))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f04c302d20e346533fbbfdfd0ad902b5aa3f3116", @"/Views/Home/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0b6ddb1e005df4c77c8613fde376bb86756545", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Model1.News>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 16, true);
            WriteLiteral("\n\n<div>\n    <h2>");
            EndContext();
            BeginContext(36, 15, false);
#line 5 "C:\repohome\Project-1\HappyNews\Views\Home\News.cshtml"
   Write(Model.NewsTitle);

#line default
#line hidden
            EndContext();
            BeginContext(51, 27, true);
            WriteLiteral("</h2>\n</div>\n\n<div>\n    <p>");
            EndContext();
            BeginContext(79, 14, false);
#line 9 "C:\repohome\Project-1\HappyNews\Views\Home\News.cshtml"
  Write(Model.BodyNews);

#line default
#line hidden
            EndContext();
            BeginContext(93, 12, true);
            WriteLiteral("</p>\n    <p>");
            EndContext();
            BeginContext(106, 16, false);
#line 10 "C:\repohome\Project-1\HappyNews\Views\Home\News.cshtml"
  Write(Model.DateCreate);

#line default
#line hidden
            EndContext();
            BeginContext(122, 15, true);
            WriteLiteral("</p>\n\n</div>\n\n\n");
            EndContext();
#line 15 "C:\repohome\Project-1\HappyNews\Views\Home\News.cshtml"
 if (@User.Identity.IsAuthenticated)
{

#line default
#line hidden
            BeginContext(176, 110, true);
            WriteLiteral("    <div id=\"commetsarea\">\n        <div class=\"form-group\">\n            <label for=\"comment-name\">Comment for ");
            EndContext();
            BeginContext(287, 18, false);
#line 19 "C:\repohome\Project-1\HappyNews\Views\Home\News.cshtml"
                                             Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(305, 182, true);
            WriteLiteral("</label>\n            <textarea class=\"form-control\" id=\"comment-body\" rows=\"3\" placeholder=\"write comment\"></textarea>\n            <div style=\"display: none\" id=\"my-div\" data-newsid=");
            EndContext();
            BeginContext(488, 8, false);
#line 21 "C:\repohome\Project-1\HappyNews\Views\Home\News.cshtml"
                                                          Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(496, 13, true);
            WriteLiteral(" data-userid=");
            EndContext();
            BeginContext(510, 18, false);
#line 21 "C:\repohome\Project-1\HappyNews\Views\Home\News.cshtml"
                                                                                Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(528, 598, true);
            WriteLiteral(@"> DataForComments</div>
        </div>
        <button type=""submit"" id=""comment_add"" class=""btn btn-primary"">Add comment</button>
    </div>
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.0/umd/popper.min.js"" integrity=""sha384-cs/chFZiN24E4KMATLdqdvsezGxaGsi4hLGOzlXwp5UZB1LY//20VyM2taTB4QvJ"" crossorigin=""anonymous""></script>
    <script type=""text/javascript"" src=""\js\js.js""></script>
");
            EndContext();
            BeginContext(1128, 94, true);
            WriteLiteral("    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery/3.0.0/jquery.min.js\"></script>\n");
            EndContext();
#line 31 "C:\repohome\Project-1\HappyNews\Views\Home\News.cshtml"
}

#line default
#line hidden
            BeginContext(1224, 53, true);
            WriteLiteral("\n<div style=\"display: none\" id=\"my-div1\" data-newsid=");
            EndContext();
            BeginContext(1278, 8, false);
#line 33 "C:\repohome\Project-1\HappyNews\Views\Home\News.cshtml"
                                               Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(1286, 14, true);
            WriteLiteral(" data-usersid=");
            EndContext();
            BeginContext(1301, 18, false);
#line 33 "C:\repohome\Project-1\HappyNews\Views\Home\News.cshtml"
                                                                      Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1319, 285, true);
            WriteLiteral(@">DataForComments</div>
<div id=""commentdiv"">
</div>
<script src=""https://code.jquery.com/jquery-3.4.1.js""
        integrity=""sha256-WpOohJOqMqqyKL9FccASB9O0KwACQJpFTUBLTYOVvVU=""
        crossorigin=""anonymous""></script>
<script type=""text/javascript"" src=""\js\commentAdd.js""></script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Model1.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
