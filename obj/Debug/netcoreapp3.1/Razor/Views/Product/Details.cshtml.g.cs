<<<<<<< HEAD
#pragma checksum "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de4ff5051dd0fc9bfbdd7dd747ce89451396750c"
=======
#pragma checksum "C:\Users\Mahes\Documents\DealNepal2\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de4ff5051dd0fc9bfbdd7dd747ce89451396750c"
>>>>>>> ed0f8b3848a63e709a438e2d462bb4c729307ee9
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\_ViewImports.cshtml"
using UserManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\_ViewImports.cshtml"
using UserManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de4ff5051dd0fc9bfbdd7dd747ce89451396750c", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49da211b1c35ec911bb8f94c53c5e3c8e53492f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserManagement.Models.Products>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid z-depth-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <!--Section: Block Content-->
    <section class=""mb-5"">
        <div class=""row"">
            <div class=""col-md-6 mb-4 mb-md-0"">
                <div id=""mdb-lightbox-ui""></div>
                <div class=""mdb-lightbox"">
                  <div class=""row product-gallery mx-1"">
                        <div class=""col-12 mb-0"">
                            <figure class=""view overlay rounded z-depth-1 main-img"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 501, "\"", 548, 1);
#nullable restore
#line 11 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml"
WriteAttributeValue("", 508, Url.Content("~/image/"+Model.ImageName), 508, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" \r\n                                   data-size=\"710x823\">\r\n                                    ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de4ff5051dd0fc9bfbdd7dd747ce89451396750c4429", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de4ff5051dd0fc9bfbdd7dd747ce89451396750c4369", async() => {
>>>>>>> ed0f8b3848a63e709a438e2d462bb4c729307ee9
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml"
                                  WriteLiteral(Url.Content("~/image/"+Model.ImageName));

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 13 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </a>
                            </figure>
                           
                        </div>
                        <div class=""col-12"">
                            <div class=""row"">
                                <div class=""col-3"">
                                    <div class=""view overlay rounded z-depth-1 gallery-item"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 1220, "\"", 1266, 1);
#nullable restore
#line 23 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml"
WriteAttributeValue("", 1226, Url.Content("~/image/"+Model.ImageName), 1226, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                             class=""img-fluid"">
                                        <div class=""mask rgba-white-slight""></div>
                                    </div>
                                </div>
                                <div class=""col-3"">
                                    <div class=""view overlay rounded z-depth-1 gallery-item"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 1694, "\"", 1740, 1);
#nullable restore
#line 30 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml"
WriteAttributeValue("", 1700, Url.Content("~/image/"+Model.ImageName), 1700, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                             class=""img-fluid"">
                                        <div class=""mask rgba-white-slight""></div>
                                    </div>
                                </div>
                                <div class=""col-3"">
                                    <div class=""view overlay rounded z-depth-1 gallery-item"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 2168, "\"", 2214, 1);
#nullable restore
#line 37 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml"
WriteAttributeValue("", 2174, Url.Content("~/image/"+Model.ImageName), 2174, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                             class=""img-fluid"">
                                        <div class=""mask rgba-white-slight""></div>
                                    </div>
                                </div>
                                <div class=""col-3"">
                                    <div class=""view overlay rounded z-depth-1 gallery-item"">
                                        <img");
            BeginWriteAttribute("src", " src=\"", 2642, "\"", 2688, 1);
#nullable restore
#line 44 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml"
WriteAttributeValue("", 2648, Url.Content("~/image/"+Model.ImageName), 2648, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                                             class=""img-fluid"">
                                        <div class=""mask rgba-white-slight""></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
            <div class=""col-md-6"">
                <h5>");
#nullable restore
#line 57 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(model => model.ImageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"mb-2 text-muted text-uppercase small\">");
#nullable restore
#line 58 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml"
                                                           Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                 
                <div class=""rating"">
                    <span class=""fas fa-star""></span>
                    <span class=""fas fa-star""></span>
                    <span class=""fa fa-star""></span>
                    <span class=""fa fa-star""></span>
                </div>
                <br />
                <p><span class=""mr-1"">
                       <strong>NRS. ");
#nullable restore
#line 68 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml"
                               Write(Html.DisplayFor(model => model.MinPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - NRS.");
#nullable restore
#line 68 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml"
                                                                               Write(Html.DisplayFor(model => model.MaxPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                           </strong></span></p>\r\n                <p class=\"pt-1\">\r\n                    ");
#nullable restore
#line 71 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
                <div class=""table-responsive"">
                    <table class=""table table-sm table-borderless mb-0"">
                        <tbody>
                            <tr>
                                <th class=""pl-0 w-25"" scope=""row""><strong>Ends in</strong></th>
                                <td>");
#nullable restore
#line 78 "C:\Users\mahes\OneDrive\Documents\DealNepal-master\Views\Product\Details.cshtml"
                               Write(Html.DisplayFor(model => model.EndTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" hrs</td>
                            </tr>
                            <tr>
                                <th class=""pl-0 w-25"" scope=""row""><strong>Bids</strong></th>
                                <td>x</td>
                            </tr>
                            <tr>
                                <th class=""pl-0 w-25"" scope=""row""><strong>Seller Location</strong></th>
                                <td>z,y</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <hr>
                
                <button type=""button"" class=""btn btn-primary btn-md mr-1 mb-2"">
                
                Bid now</button>
                <button type=""button"" class=""btn btn-light btn-md mr-1 mb-2"">
                    <i class=""fas fa-shopping-cart pr-2""></i>Add to cart
                </button>
            </div>
        </div>

    </section>
    <!--Section: Block Content-->

    <script type=""t");
            WriteLiteral("ext/javascript\">\r\n        $(document).ready(function () {\r\n            // MDB Lightbox Init\r\n            $(function () {\r\n                $(\"#mdb-lightbox-ui\").load(\"mdb-addons/mdb-lightbox-ui.html\");\r\n            });\r\n        });\r\n    </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserManagement.Models.Products> Html { get; private set; }
    }
}
#pragma warning restore 1591
