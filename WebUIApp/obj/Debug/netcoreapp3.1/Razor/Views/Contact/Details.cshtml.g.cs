#pragma checksum "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae69d6827f31bd6e31e0c0f98500fdf0413cbd95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Details), @"mvc.1.0.view", @"/Views/Contact/Details.cshtml")]
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
#line 1 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\_ViewImports.cshtml"
using WebUIApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\_ViewImports.cshtml"
using WebUIApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae69d6827f31bd6e31e0c0f98500fdf0413cbd95", @"/Views/Contact/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e6c5a085a8c5e299635a683d8f2b7e431cb5093", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml"
 if (Model==null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div >\r\n        Not Have enough Contact\r\n    </div>\r\n");
#nullable restore
#line 10 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card text-white bg-dark mb-3\">\r\n    <div class=\"card-header\">");
#nullable restore
#line 14 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml"
                        Write(Model.Contact.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml"
                                                 Write(Model.Contact.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">Contacts</h5>\r\n        <p class=\"card-text\"><strong><small class=\"mr-2\">Mobile Number:</small></strong><small>");
#nullable restore
#line 17 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml"
                                                                                          Write(Model.MobilNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n        <p class=\"card-text\"><strong><small class=\"mr-2\">Home Number:</small></strong><small>");
#nullable restore
#line 18 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml"
                                                                                        Write(Model.HomeNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n        <p class=\"card-text\"><strong><small class=\"mr-2\">Work Number:</small></strong><small>");
#nullable restore
#line 19 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml"
                                                                                        Write(Model.WorkNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n        <p><small class=\"text-muted\">Created Date:  ");
#nullable restore
#line 20 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml"
                                               Write(Model.Contact.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n        <p><small class=\"text-muted\">Last Modified Date:  ");
#nullable restore
#line 21 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml"
                                                     Write(Model.Contact.LastModifiedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae69d6827f31bd6e31e0c0f98500fdf0413cbd956958", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <a class=\"btn btn-sm btn-dark text-white\" data-toggle=\"modal\" data-target=\"#exampleModal\" data-orik=\"");
#nullable restore
#line 24 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml"
                                                                                                    Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</a>\r\n</div>\r\n");
#nullable restore
#line 26 "D:\.Net Core Projects\ContactApp\WebUIApp\Views\Contact\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!-- Button trigger modal -->


<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Warning!!!</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Are you sure for Delete???.............>>>>>>>>>>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
                <button type=""button"" class=""btn btn-primary"" id=""btndelete"">Yes</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
<script type=""text/javascript"">

    $(document).ready(function () {
        $(""#exampleModal"").on(""show.bs.modal"", function (event) {

            let trigerelement = $(event.relatedTarget);
            let id = trigerelement.data(""orik"");

            $(""#btndelete"").click(function () {
                $.ajax({
                    type: ""Post"",
                    url: ""/Contact/Delete"",
                    data: { id: id },
                    //dataType: ""json"",
                    //contentType: ""application/json;charset=utf-8"",
                    success: function (data) {
                        if (data != null && data == true) {
                            window.location = ""/Contact/Index"";
                        }
                 
                    },
                    error: function (error) {
                        alert(error);
                    }
                });
            });
        });

    });

</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
