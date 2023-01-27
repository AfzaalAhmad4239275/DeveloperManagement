#pragma checksum "D:\WorkingApp\Practice\Developer\Developer\Views\Developer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15334362cb0da0492c19e301efb855d6ca90ebf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Developer_Index), @"mvc.1.0.view", @"/Views/Developer/Index.cshtml")]
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
#line 1 "D:\WorkingApp\Practice\Developer\Developer\Views\_ViewImports.cshtml"
using Developer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WorkingApp\Practice\Developer\Developer\Views\_ViewImports.cshtml"
using Developer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15334362cb0da0492c19e301efb855d6ca90ebf1", @"/Views/Developer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a105c4bd4b16b9833bb73384c2d5eb08ed2f7c14", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Developer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Developer.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\WorkingApp\Practice\Developer\Developer\Views\Developer\Index.cshtml"
  
    ViewData["Title"] = "Developers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15334362cb0da0492c19e301efb855d6ca90ebf13771", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n   \r\n\r\n");
            }
            );
            WriteLiteral(@"<div class=""text-center"">
    <h1 class=""display-4"">Developers</h1>
</div>


<p>
    <button type=""button"" class=""btn btn-primary"" onclick=""CreateNewModal()"">Create New</button>
</p>


<div class=""col-12 border bg-light"" style=""border-radius:20px; padding:30px;"">
    <table id=""developerListTable"" class=""table table-bordered table-striped"" style=""width:100%"">
        <thead>
            <tr>

                <th>#</th>
                <th>Name</th>
                <th>Age</th>
                <th>Job Title</th>
                <th></th>
                <th></th>


            </tr>
        </thead>
        <tbody></tbody>
    </table>
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""AddDevModal"" aria-hidden=""true"" id=""AddDevModal"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Create New Developer</h5>
                <button type=""button""");
            WriteLiteral(@" class=""close"" data-dismiss=""modal"" aria-label=""Close"" onclick=""clearmodal()"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""DeveloperDivParent"">
                <div class=""row mb-3 child_sub_container"" style=""margin-top:-16px"" id=""duplicater"">
                    <div class=""col-4"">
                        <div class=""form-group child_sub""><p>Name:</p><input type=""text"" class=""form-control "" id=""txt_Name"" required /></div>
                        <div class=""form-group child_sub""><input type=""hidden"" class=""form-control"" id=""txt_Id"" /></div>
                    </div>
                    <div class=""col-4"">
                        <div class=""form-group child_sub""><p>Age:</p><input type=""text"" class=""form-control"" id=""txt_Age"" required /></div>
                    </div>
                    <div class=""col-4"">
                        <div class=""form-group child_sub""><p>Job Title:</p><input type=");
            WriteLiteral(@"""text"" class=""form-control"" id=""txt_JobTitle"" required /></div>
                    </div>

                    <hr />
                </div>

            </div>
            <div class=""modal-footer"">
                <button id=""createmorebutton"" class=""btn btn-primary"" onclick=""CreationNewDiv()"">Add More</button>
                <button type=""submit"" id=""savebutton"" class=""btn btn-primary"" onclick=""save()"">Save</button>
                <button type=""submit"" id=""editbutton"" class=""btn btn-primary d-none"" onclick=""update()"">Edit</button>
                
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" onclick=""clearmodal()"">Close</button>
            </div>
        </div>
    </div>
</div>









");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591