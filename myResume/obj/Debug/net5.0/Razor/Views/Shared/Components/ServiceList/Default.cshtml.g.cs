#pragma checksum "C:\Users\Melih\OneDrive\Masaüstü\MyResume\MyResume\myResume\App\Web\myResume\myResume\Views\Shared\Components\ServiceList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7f72eee8352a751a1be4d0fee2fa693a1f67d78ee5a55d3d68b24707bb12d100"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ServiceList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Melih\OneDrive\Masaüstü\MyResume\MyResume\myResume\App\Web\myResume\myResume\Views\_ViewImports.cshtml"
using myResume;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Melih\OneDrive\Masaüstü\MyResume\MyResume\myResume\App\Web\myResume\myResume\Views\_ViewImports.cshtml"
using myResume.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Melih\OneDrive\Masaüstü\MyResume\MyResume\myResume\App\Web\myResume\myResume\Views\Shared\Components\ServiceList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7f72eee8352a751a1be4d0fee2fa693a1f67d78ee5a55d3d68b24707bb12d100", @"/Views/Shared/Components/ServiceList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cc432a68e0462145738ea9f93733b7b179adf3c639e5a56dd141130c68c928e0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ServiceList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""section px-3 px-lg-4 pt-5"" id=""services"">
	<div class=""container-narrow"">
		<div class=""text-center mb-5"">
			<h2 class=""marker marker-center"">Hizmetlerim</h2>
		</div>
		<div class=""text-center"">
			<p class=""mx-auto mb-3"" style=""max-width:600px"">Her web sitesi veya uygulamaya uygun hizmetler sunuyorum. Gerçek zamanlı şemalar için zamanında teslimatları hızlı bir şekilde en üst düzeye çıkarabilirim.</p>
		</div>
		<div class=""row py-3"">
");
#nullable restore
#line 12 "C:\Users\Melih\OneDrive\Masaüstü\MyResume\MyResume\myResume\App\Web\myResume\myResume\Views\Shared\Components\ServiceList\Default.cshtml"
             foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col-md-3 text-center\" data-aos=\"fade-up\" data-aos-delay=\"100\">\r\n\t\t\t\t\t<img class=\"mb-2\"");
            BeginWriteAttribute("src", " src=\"", 655, "\"", 675, 1);
#nullable restore
#line 15 "C:\Users\Melih\OneDrive\Masaüstü\MyResume\MyResume\myResume\App\Web\myResume\myResume\Views\Shared\Components\ServiceList\Default.cshtml"
WriteAttributeValue("", 661, item.ImageUrl, 661, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"96\" height=\"96\" alt=\"web design\" />\r\n\t\t\t\t\t<div class=\"h5\">");
#nullable restore
#line 16 "C:\Users\Melih\OneDrive\Masaüstü\MyResume\MyResume\myResume\App\Web\myResume\myResume\Views\Shared\Components\ServiceList\Default.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t</div>\t\r\n");
#nullable restore
#line 18 "C:\Users\Melih\OneDrive\Masaüstü\MyResume\MyResume\myResume\App\Web\myResume\myResume\Views\Shared\Components\ServiceList\Default.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
