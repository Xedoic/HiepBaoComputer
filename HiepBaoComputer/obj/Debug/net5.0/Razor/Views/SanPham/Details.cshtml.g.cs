#pragma checksum "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c175cce240eb74f98627777fb684afe51e5e9d27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_Details), @"mvc.1.0.view", @"/Views/SanPham/Details.cshtml")]
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
#line 1 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\_ViewImports.cshtml"
using HiepBaoComputer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\_ViewImports.cshtml"
using HiepBaoComputer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c175cce240eb74f98627777fb684afe51e5e9d27", @"/Views/SanPham/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2cbe42aa48917402bb034e9df4f91a3906ae90a", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HiepBaoComputer.Models.SanPham>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("UTF-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- inner page banner -->
<div id=""inner_banner"" class=""section inner_banner_section"">
  <div class=""container"">
    <div class=""row"">
      <div class=""col-md-12"">
        <div class=""full"">
          <div class=""title-holder"">
            <div class=""title-holder-cell text-left"">
              <h1 class=""page-title"">Chi Tiết Sản Phẩm</h1>
              <ol class=""breadcrumb"">
                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c175cce240eb74f98627777fb684afe51e5e9d276424", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                <li class=""active"">Chi Tiết Sản Phẩm</li>
              </ol>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>
<!-- end inner page banner -->
<!-- section -->
<div class=""section padding_layout_1 product_detail"">
  <div class=""container"">
    <div class=""row"">
      <div class=""col-md-9"">
        <div class=""row"">
          <div class=""col-xl-6 col-lg-12 col-md-12"">
            <div class=""product_detail_feature_img hizoom hi2"">
              <div class='hizoom hi2'> <img");
            BeginWriteAttribute("src", " src=\"", 1158, "\"", 1176, 1);
#nullable restore
#line 38 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Details.cshtml"
WriteAttributeValue("", 1164, Model.AnhSp, 1164, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"#\" style=\"width:400px;\" /> </div>\r\n            </div>\r\n          </div>\r\n          <div class=\"col-xl-6 col-lg-12 col-md-12 product_detail_side detail_style1\">\r\n            <div class=\"product-heading\">\r\n              <h2>");
#nullable restore
#line 43 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Details.cshtml"
             Write(Model.TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </div>\r\n            <div class=\"product-detail-side\"> <span><del>");
#nullable restore
#line 45 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Details.cshtml"
                                                    Write(Model.GiaSp.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</del></span><span class=\"new-price\">");
#nullable restore
#line 45 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Details.cshtml"
                                                                                                                           Write(Model.GiaSp.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ</span> <span class=""rating""> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star-o"" aria-hidden=""true""></i> </span> <span class=""review"">(5 customer review)</span> </div>
            <div class=""detail-contant"">
              <p>");
#nullable restore
#line 47 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Details.cshtml"
            Write(Model.MotaSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                <span class=\"stock\">2 in stock</span> </p>\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c175cce240eb74f98627777fb684afe51e5e9d2710721", async() => {
                WriteLiteral(@"
                <div class=""quantity"">
                  <input step=""1"" min=""1"" max=""5"" name=""quantity"" value=""1"" title=""Qty"" class=""input-text qty text"" size=""4"" type=""number"">
                </div>
                <button type=""submit"" class=""btn sqaure_bt"">Mua Ngay</button>
              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            WriteLiteral(@"
            </div>
            <div class=""share-post""> <a href=""#"" class=""share-text"">Share</a>
              <ul class=""social_icons"">
                <li><a href=""#""><i class=""fa fa-facebook"" aria-hidden=""true""></i></a></li>
                <li><a href=""#""><i class=""fa fa-twitter"" aria-hidden=""true""></i></a></li>
                <li><a href=""#""><i class=""fa fa-google-plus"" aria-hidden=""true""></i></a></li>
                <li><a href=""#""><i class=""fa fa-instagram"" aria-hidden=""true""></i></a></li>
                <li><a href=""#""><i class=""fa fa-linkedin"" aria-hidden=""true""></i></a></li>
              </ul>
            </div>
          </div>
        </div>
        <div class=""row"">
          <div class=""col-md-12"">
            <div class=""full"">
              <div class=""tab_bar_section"">
                <ul class=""nav nav-tabs"" role=""tablist"">
                  <li class=""nav-item""> <a class=""nav-link active"" data-toggle=""tab"" href=""#description"">Chi Tiết</a> </li>
                </ul>");
            WriteLiteral(@"
                <!-- Tab panes -->
                <div class=""tab-content"">
                  <div id=""description"" class=""tab-pane active"">
                    <div class=""product_desc"">
                      <p>HP Victus 16 CHÍNH HÃNG RẺ NHẤT THỊ TRƯỜNG
Laptop gaming duy nhất tầm giá có RTX 3050Ti 
Chiến game, làm đồ họa cực mượt mà
Màn lớn 16 inch 144Hz cực sắc nét - Pin trâu
 

Nếu bạn đang cần 1 chiếc laptop gaming thực sự mạnh mẽ có thể cân mọi tựa game nặng, làm đồ họa mượt mà, cấu hình cao nhất trong khoảng giá 19 triệu thì đừng nên bỏ lỡ ""siêu phẩm"" HP Victus 16 - Một ""chiến binh gaming"" đẳng cấp đến từ thương hiệu nổi tiếng laptop HP. Đây cũng là chiếc laptop/máy tính xách tay duy nhất được trang bị card rời RTX 3050Ti siêu mạnh mẽ trong tầm giá 19 triệu, kết hợp cùng những ưu điểm cực nổi trội như: màn lớn 16 inch 144Hz, pin trâu, ""body"" ngon nghẻ, thanh lịch, hiện đại,... có thể đem đến cho bạn một trải nghiệm tuyệt nhất tầm giá. Cùng đánh giá chi tiết hơn về chiếc HP Victus 16 qua nội");
            WriteLiteral(@" dung bài viết nhé!
</p>
                    </div>
                  </div>
                  <div id=""reviews"" class=""tab-pane fade"">
                    <div class=""product_review"">
                      <h3>Reviews (2)</h3>
                      <div class=""commant-text row"">
                        <div class=""col-lg-2 col-md-2 col-sm-4"">
                          <div class=""profile""> <img class=""img-responsive"" src=""images/it_service/client1.png"" alt=""#""> </div>
                        </div>
                        <div class=""col-lg-10 col-md-10 col-sm-8"">
                          <h5>David</h5>
                          <p><span class=""c_date"">March 2, 2018</span> | <span><a rel=""nofollow"" class=""comment-reply-link"" href=""#"">Reply</a></span></p>
                          <span class=""rating""> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""f");
            WriteLiteral(@"a fa-star-o"" aria-hidden=""true""></i> </span>
                          <p class=""msg"">ThisThis book is a treatise on the theory of ethics, very popular during the Renaissance. 
                            The first line of Lorem Ipsum, “Lorem ipsum dolor sit amet.. </p>
                        </div>
                      </div>
                      <div class=""commant-text row"">
                        <div class=""col-lg-2 col-md-2 col-sm-4"">
                          <div class=""profile""> <img class=""img-responsive"" src=""images/it_service/client2.png"" alt=""#""> </div>
                        </div>
                        <div class=""col-lg-10 col-md-10 col-sm-8"">
                          <h5>Jack</h5>
                          <p><span class=""c_date"">March 2, 2018</span> | <span><a rel=""nofollow"" class=""comment-reply-link"" href=""#"">Reply</a></span></p>
                          <span class=""rating""> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star"" aria-hidden=""true""></i> <i ");
            WriteLiteral(@"class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star-o"" aria-hidden=""true""></i> </span>
                          <p class=""msg"">Nunc augue purus, posuere in accumsan sodales ac, euismod at est. Nunc faccumsan ermentum consectetur metus placerat mattis. Praesent mollis justo felis, accumsan faucibus mi maximus et. Nam hendrerit mauris id scelerisque placerat. Nam vitae imperdiet turpis</p>
                        </div>
                      </div>
                      <div class=""row"">
                        <div class=""col-sm-12"">
                          <div class=""full review_bt_section"">
                            <div class=""float-right""> <a class=""btn sqaure_bt"" data-toggle=""collapse"" href=""#collapseExample"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"">Leave a Review</a> </div>
                          </div>
                          <div class=""full"">
                            <div id=""collapseExample"" c");
            WriteLiteral("lass=\"full collapse commant_box\">\r\n                              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c175cce240eb74f98627777fb684afe51e5e9d2718179", async() => {
                WriteLiteral("\r\n                                <input id=\"ratings-hidden\" name=\"rating\" type=\"hidden\">\r\n                                <textarea class=\"form-control animated\" cols=\"50\" id=\"new-review\" name=\"comment\" placeholder=\"Enter your review here...\"");
                BeginWriteAttribute("required", " required=\"", 7926, "\"", 7937, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n                                <div class=\"full_bt center\">\r\n                                  <button class=\"btn sqaure_bt\" type=\"submit\">Save</button>\r\n                                </div>\r\n                              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>

       <div class=""col-md-3"">
        <div class=""side_bar"">
          <div class=""side_bar_blog"">
            <h4>TÌM KIẾM</h4>
            <div class=""side_bar_search"">
              <div class=""input-group stylish-input-group"">
                <input class=""form-control"" placeholder=""Search"" type=""text"">
                <span class=""input-group-addon"">
                <button type=""submit""><i class=""fa fa-search"" aria-hidden=""true""></i></button>
                </span> </div>
            </div>
          </div>
          <div class=""side_bar_blog"">
            <h4>DANH MỤC SẢN PHẨM</h4>
            <div class=""categary"">
              <ul>
                <li><a href=""it_data_recovery.html""><");
            WriteLiteral(@"i class=""fa fa-angle-right""></i> Computer</a></li>
                <li><a href=""it_computer_repair.html""><i class=""fa fa-angle-right""></i> Laptop</a></li>
                <li><a href=""it_mobile_service.html""><i class=""fa fa-angle-right""></i> Linh Kiện Máy Tính</a></li>
                <li><a href=""it_network_solution.html""><i class=""fa fa-angle-right""></i> Dịch Vụ Mạng</a></li>
                <li><a href=""it_techn_support.html""><i class=""fa fa-angle-right""></i> Công Nghệ</a></li>
              </ul>
            </div>
          </div>
        </div>
      </div>

    </div>
  </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HiepBaoComputer.Models.SanPham> Html { get; private set; }
    }
}
#pragma warning restore 1591
