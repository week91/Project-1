#pragma checksum "C:\repohome\Project-1\HappyNews\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30c34d9849c0332f38e30b960b36a1bbd249e51d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 2 "C:\repohome\Project-1\HappyNews\Views\_ViewImports.cshtml"
using HappyNews.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30c34d9849c0332f38e30b960b36a1bbd249e51d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0624f5ebe9783f3c2e7b2977e1ed39ad4a303009", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\repohome\Project-1\HappyNews\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(64, 611, true);
            WriteLiteral(@"


    <div class=""jumbotron"">
    <div class=""p-3 mb-2 bg-info text-white""> <div class=""container"">
        
        <h1 class=""display-3""><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Welcome!</font></font></h1>
        <h3><p><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">Fresh news. </font><font style=""vertical-align: inherit;"">Happy news of world!!!!! </font><font style=""vertical-align: inherit;"">Only happy ,only smile!!!</font></font></p></h3>
        </div>
    </div>

    <div class=""container"">
        <div class=""row"">
");
            EndContext();
#line 18 "C:\repohome\Project-1\HappyNews\Views\Home\Index.cshtml"
             foreach (var news in Model)
            {

#line default
#line hidden
            BeginContext(732, 143, true);
            WriteLiteral("                 <div class=\"col-md-4\">\r\n                    <h2><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">");
            EndContext();
            BeginContext(876, 14, false);
#line 21 "C:\repohome\Project-1\HappyNews\Views\Home\Index.cshtml"
                                                                                                 Write(news.NewsTitle);

#line default
#line hidden
            EndContext();
            BeginContext(890, 126, true);
            WriteLiteral("</font></font></h2>\r\n                    <p><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\"><h4>");
            EndContext();
            BeginContext(1017, 13, false);
#line 22 "C:\repohome\Project-1\HappyNews\Views\Home\Index.cshtml"
                                                                                                    Write(news.BodyNews);

#line default
#line hidden
            EndContext();
            BeginContext(1030, 80, true);
            WriteLiteral("</h4>\r\n                        <p></font><font style=\"vertical-align: inherit;\">");
            EndContext();
            BeginContext(1111, 15, false);
#line 23 "C:\repohome\Project-1\HappyNews\Views\Home\Index.cshtml"
                                                                    Write(news.DateCreate);

#line default
#line hidden
            EndContext();
            BeginContext(1126, 47, true);
            WriteLiteral(" </font><font style=\"vertical-align: inherit;\">");
            EndContext();
            BeginContext(1174, 11, false);
#line 23 "C:\repohome\Project-1\HappyNews\Views\Home\Index.cshtml"
                                                                                                                                   Write(news.Source);

#line default
#line hidden
            EndContext();
            BeginContext(1185, 244, true);
            WriteLiteral(" \"R\"</font></font></p>\r\n                    <p><a class=\"btn btn-secondary\" href=\"#\" role=\"button\"><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">Посмотреть детали \"</font></font></a></p>\r\n                </div>\r\n");
            EndContext();
#line 26 "C:\repohome\Project-1\HappyNews\Views\Home\Index.cshtml"
             }  

#line default
#line hidden
            BeginContext(1447, 40, true);
            WriteLiteral("        </div>\r\n    </div></div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
