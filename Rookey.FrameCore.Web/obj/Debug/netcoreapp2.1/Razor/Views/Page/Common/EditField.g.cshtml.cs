#pragma checksum "D:\wdx\平台\RookeyFrameCore\Rookey.FrameCore.Web\Views\Page\Common\EditField.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb6a4da8262064ba7ea06a249a400165918ee2fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Page_Common_EditField), @"mvc.1.0.view", @"/Views/Page/Common/EditField.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Page/Common/EditField.cshtml", typeof(AspNetCore.Views_Page_Common_EditField))]
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
#line 4 "D:\wdx\平台\RookeyFrameCore\Rookey.FrameCore.Web\Views\Page\Common\EditField.cshtml"
using Rookey.Frame.Common;

#line default
#line hidden
#line 5 "D:\wdx\平台\RookeyFrameCore\Rookey.FrameCore.Web\Views\Page\Common\EditField.cshtml"
using Rookey.Frame.UIOperate;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb6a4da8262064ba7ea06a249a400165918ee2fa", @"/Views/Page/Common/EditField.cshtml")]
    public class Views_Page_Common_EditField : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\wdx\平台\RookeyFrameCore\Rookey.FrameCore.Web\Views\Page\Common\EditField.cshtml"
  
    ViewBag.Title = "EditField";

#line default
#line hidden
#line 6 "D:\wdx\平台\RookeyFrameCore\Rookey.FrameCore.Web\Views\Page\Common\EditField.cshtml"
   UIFrameFactory frameFactory = UIFrameFactory.GetInstance(this.Context.Request);
   Guid moduleId = UIOperate.GetModuleIdByRequest(this.Context.Request);
   string fieldName = this.Context.Request.Query["fieldName"].ObjToStr();
   Guid recordId = this.Context.Request.Query["recordId"].ObjToGuid();

#line default
#line hidden
            BeginContext(409, 70, false);
#line 10 "D:\wdx\平台\RookeyFrameCore\Rookey.FrameCore.Web\Views\Page\Common\EditField.cshtml"
Write(Html.Raw(frameFactory.GetEditFieldHTML(moduleId, fieldName, recordId)));

#line default
#line hidden
            EndContext();
            BeginContext(479, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
