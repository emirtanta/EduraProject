#pragma checksum "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7535613a5552f1000e3c556d02112e8c17535370"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Details.cshtml", typeof(AspNetCore.Views_Product_Details))]
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
#line 1 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI;

#line default
#line hidden
#line 2 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI.Models;

#line default
#line hidden
#line 3 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\_ViewImports.cshtml"
using Edura.WebUI.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7535613a5552f1000e3c556d02112e8c17535370", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45b720489fc60aed7a9195e5dd64a8224e931360", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(71, 304, true);
            WriteLiteral(@"
<section id=""content"">
    <!-- shop section start -->
    <section id=""shop"" class=""container"">
        <!-- row start -->
        <div class=""row"">
            <!-- sidebar start -->
            <div id=""sidebar"" class=""col-md-3"">
                <!-- search widget start -->
                ");
            EndContext();
            BeginContext(376, 43, false);
#line 14 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
           Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(419, 112, true);
            WriteLiteral("\r\n                <!-- search widget end -->\r\n                <!-- categories widget start -->\r\n                ");
            EndContext();
            BeginContext(532, 47, false);
#line 17 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
           Write(await Component.InvokeAsync("FeaturedProducts"));

#line default
#line hidden
            EndContext();
            BeginContext(579, 4233, true);
            WriteLiteral(@"
                <!-- categories widget end -->
                <!-- featured products widget start -->
                <div class=""widget"">
                    <h4>FEATURED</h4>
                    <div class=""products-list"">
                        <div class=""media"">
                            <a class=""media-left"" href=""#"">
                                <img alt="""" class=""img-responsive product-thumb"" src=""images/products/product1_thumb.jpg"">
                            </a>
                            <div class=""media-body"">
                                <a href=""#"" class=""product-title"">Photo Camera</a>
                                <p class=""product-price"">$153</p>
                            </div>
                        </div>
                        <div class=""media"">
                            <a class=""media-left"" href=""#"">
                                <img alt="""" class=""img-responsive product-thumb"" src=""images/products/product2_thumb.jpg"">
                        ");
            WriteLiteral(@"    </a>
                            <div class=""media-body"">
                                <a href=""#"" class=""product-title"">Wood Chair</a>
                                <p class=""product-price"">$99</p>
                            </div>
                        </div>
                        <div class=""media"">
                            <a class=""media-left"" href=""#"">
                                <img alt="""" class=""img-responsive product-thumb"" src=""images/products/product3_thumb.jpg"">
                            </a>
                            <div class=""media-body"">
                                <a href=""#"" class=""product-title"">Comfortable Sofa</a>
                                <p class=""product-price"">$526</p>
                            </div>
                        </div>
                        <div class=""media"">
                            <a class=""media-left"" href=""#"">
                                <img alt="""" class=""img-responsive product-thumb"" src=""images/prod");
            WriteLiteral(@"ucts/product4_thumb.jpg"">
                            </a>
                            <div class=""media-body"">
                                <a href=""#"" class=""product-title"">Hand Bag</a>
                                <p class=""product-price"">$125</p>
                            </div>
                        </div>
                        <div class=""media"">
                            <a class=""media-left"" href=""#"">
                                <img alt="""" class=""img-responsive product-thumb"" src=""images/products/product1_thumb.jpg"">
                            </a>
                            <div class=""media-body"">
                                <a href=""#"" class=""product-title"">Photo Camera</a>
                                <p class=""product-price"">$29</p>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- featured products widget end -->
            </div>
            <!-- sidebar end --");
            WriteLiteral(@">
            <!-- main column start -->
            <div class=""col-md-9"">
                <div class=""row"">

                    <!-- product page top info start -->
                    <div class=""col-md-12 product"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div id=""product-gallery"" class=""owl-carousel owl-theme"">
                                    <div class=""owl-wrapper-outer"">
                                        <div>
                                            <img alt="""" class=""img-responsive"" src=""images/products/product1.jpg"">
                                        </div>
                                        <div>
                                            <img alt="""" class=""img-responsive"" src=""images/products/product3.jpg"">
                                        </div>
                                        <div>
                                            <img alt="""" class=""img-respon");
            WriteLiteral("sive\" src=\"images/products/product4.jpg\">\r\n                                        </div>\r\n                                    </div>\r\n\r\n");
            EndContext();
#line 94 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                     foreach (var img in Model.ProductImages)
                                    {

#line default
#line hidden
            BeginContext(4930, 104, true);
            WriteLiteral("                                        <div class=\"item\">\r\n                                            ");
            EndContext();
            BeginContext(5034, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ef7182bc27247caa37414811f3de982", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5044, "~/images/products/", 5044, 18, true);
#line 97 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 5062, img.ImageName, 5062, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5103, 50, true);
            WriteLiteral("\r\n                                        </div>\r\n");
            EndContext();
#line 99 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                    }

#line default
#line hidden
            BeginContext(5192, 258, true);
            WriteLiteral(@"



                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""padding15"">
                                    <h2 class=""product-title""><b>");
            EndContext();
            BeginContext(5451, 25, false);
#line 108 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                                            Write(Model.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(5476, 379, true);
            WriteLiteral(@"</b></h2>
                                    <p>
                                        <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i>
                                        3 Reviews
                                    </p>
                                    <p class=""product-price"">$");
            EndContext();
            BeginContext(5856, 19, false);
#line 113 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                                         Write(Model.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(5875, 81, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                                <p>");
            EndContext();
            BeginContext(5957, 25, false);
#line 115 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                              Write(Model.Product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(5982, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
            BeginContext(6053, 93, true);
            WriteLiteral("                                <div class=\"padding15\">\r\n                                    ");
            EndContext();
            BeginContext(6146, 876, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6cd55be4110c49ff98e2abc7d1f69546", async() => {
                BeginContext(6231, 81, true);
                WriteLiteral("\r\n\r\n                                        <input type=\"hidden\" name=\"ProductId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6312, "\"", 6344, 1);
#line 121 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
WriteAttributeValue("", 6320, Model.Product.ProductId, 6320, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6345, 670, true);
                WriteLiteral(@" />

                                        <div class=""form-group qty"">
                                            <div class=""input-group"">
                                                <span class=""input-group-addon"">Qty</span>
                                                <input type=""number"" name=""quantity"" size=""4"" class=""form-control"" value=""1"" min=""1"" step=""1"">
                                            </div>
                                        </div>

                                        <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-cart-plus fa-fw""></i> Sepete ekle</button>

                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7022, 133, true);
            WriteLiteral("\r\n                                </div>\r\n                                <p>\r\n                                    <b>Category:</b>\r\n");
            EndContext();
#line 136 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                     foreach (var item in Model.Categories)
                                    {

#line default
#line hidden
            BeginContext(7271, 52, true);
            WriteLiteral("                                        <a href=\"#\">");
            EndContext();
            BeginContext(7324, 17, false);
#line 138 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                               Write(item.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(7341, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 139 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                    }

#line default
#line hidden
            BeginContext(7386, 911, true);
            WriteLiteral(@"                                </p>
                            </div>
                        </div>
                    </div>
                    <!-- product page top info end -->
                    <!-- product page middle info start -->
                    <div class=""col-md-12 padding25"">

                        <ul class=""nav nav-tabs"">
                            <li class=""active""><a data-toggle=""tab"" href=""#description"">Description</a></li>
                            <li><a data-toggle=""tab"" href=""#spec"">Specifications</a></li>
                            <li><a data-toggle=""tab"" href=""#reviews"">Reviews (3)</a></li>
                        </ul>

                        <div class=""tab-content"">
                            <!-- description tab start -->
                            <div id=""description"" class=""tab-pane fade in active"">
                                ");
            EndContext();
            BeginContext(8298, 35, false);
#line 157 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                           Write(Html.Raw(Model.Product.HtmlContent));

#line default
#line hidden
            EndContext();
            BeginContext(8333, 375, true);
            WriteLiteral(@"
                            </div>
                            <!-- description tab end -->
                            <!-- Specifications tab start -->
                            <div id=""spec"" class=""tab-pane fade"">
                                <div class=""table-responsive"">
                                    <table class=""table table-striped table-hover"">
");
            EndContext();
#line 164 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                         foreach (var item in Model.ProductAttributes)
                                        {

#line default
#line hidden
            BeginContext(8839, 105, true);
            WriteLiteral("                                            <tr>\r\n                                                <td><b>");
            EndContext();
            BeginContext(8945, 14, false);
#line 167 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                                  Write(item.Attribute);

#line default
#line hidden
            EndContext();
            BeginContext(8959, 63, true);
            WriteLiteral("</b></td>\r\n                                                <td>");
            EndContext();
            BeginContext(9023, 10, false);
#line 168 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                               Write(item.Value);

#line default
#line hidden
            EndContext();
            BeginContext(9033, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 170 "C:\Users\emirt\source\repos\Edura\Edura.WebUI\Views\Product\Details.cshtml"
                                        }

#line default
#line hidden
            BeginContext(9134, 3814, true);
            WriteLiteral(@"
                                    </table>
                                </div>
                            </div>
                            <!-- Specifications tab end -->
                            <!-- reviews tab start -->
                            <div id=""reviews"" class=""tab-pane fade"">
                                <div class=""reviews-list"">
                                    <div class=""media"">
                                        <a class=""media-left"" href=""#"">
                                            <img alt="""" class=""img-circle avatar"" src=""images/team/thumb8_40.jpg"">
                                        </a>
                                        <div class=""media-body"">
                                            <p class=""pull-right""><small><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i></small></p>
                                            <h4 class=""media-heading"">John Doe");
            WriteLiteral(@" <small>2 days ago</small></h4>
                                            At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga.
                                        </div>
                                    </div>
                                    <div class=""media"">
                                        <a class=""media-left"" href=""#"">
                                            <img alt="""" class=""img-circle avatar"" src=""images/team/thumb5_40.jpg"">
                                        </a>
                                        <div class=""media-body"">
                                            <p class=""pull-right""><small><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""><");
            WriteLiteral(@"/i></small></p>
                                            <h4 class=""media-heading"">Sarah Smith<small>4 days ago</small></h4>
                                            Nunc risus ex, tempus quis purus ac, tempor consequat ex. Vivamus sem magna, maximus at est id, maximus aliquet nunc. Suspendisse lacinia velit a eros porttitor, in interdum ante faucibus.
                                        </div>
                                    </div>
                                    <div class=""media"">
                                        <a class=""media-left"" href=""#"">
                                            <img alt="""" class=""img-circle avatar"" src=""images/team/thumb3_40.jpg"">
                                        </a>
                                        <div class=""media-body"">
                                            <p class=""pull-right""><small><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i></small");
            WriteLiteral(@"></p>
                                            <h4 class=""media-heading"">Jane Doe<small>5 days ago</small></h4>
                                            Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae.
                                        </div>
                                    </div>
                                </div>
                                <div class=""page-header"">
                                    <h4>ADD A <b>REVIEW</b></h4>
                                </div>
                                <p class=""text-muted"">You must be logged in to add a review.</p>
                                ");
            EndContext();
            BeginContext(12948, 1177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48d4d8a75cde4800a7f0a53b1a054ba2", async() => {
                BeginContext(12954, 1164, true);
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""form-group col-xs-6"">
                                            <input type=""text"" class=""form-control input-lg"" placeholder=""Name*"" required>
                                        </div>
                                        <div class=""form-group col-xs-6"">
                                            <input type=""email"" class=""form-control input-lg"" placeholder=""Email*"" required>
                                        </div>
                                        <div class=""form-group col-xs-12"">
                                            <textarea class=""form-control"" rows=""6"" placeholder=""Review*"" required></textarea>
                                        </div>
                                        <div class=""form-group col-xs-12 text-right"">
                                            <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-check fa-fw""></i> SUBMIT R");
                WriteLiteral("EVIEW</button>\r\n                                        </div>\r\n                                    </div>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(14125, 556, true);
            WriteLiteral(@"
                            </div>
                            <!-- reviews tab end -->
                        </div>
                    </div>
                    <!-- product page middle info end -->
                    <!-- related products start -->
                    
                    <!-- related products end -->
                </div>
                <!-- row end -->
            </div>
            <!-- main column end -->
        </div>
        <!-- row end -->
    </section>
    <!-- shop section end -->
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
