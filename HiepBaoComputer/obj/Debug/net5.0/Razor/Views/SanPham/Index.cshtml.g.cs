#pragma checksum "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0fbe494610130ae39cf4a05d84d477fe19ef4cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPham_Index), @"mvc.1.0.view", @"/Views/SanPham/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0fbe494610130ae39cf4a05d84d477fe19ef4cd", @"/Views/SanPham/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2cbe42aa48917402bb034e9df4f91a3906ae90a", @"/Views/_ViewImports.cshtml")]
    public class Views_SanPham_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HiepBaoComputer.Models.SanPham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Index.cshtml"
  
    ViewData["Title"] = "Index";
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
              <h1 class=""page-title"">Shop Page</h1>
              <ol class=""breadcrumb"">
                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0fbe494610130ae39cf4a05d84d477fe19ef4cd4747", async() => {
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
                <li class=""active"">Sản Phẩm</li>
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
<div class=""section padding_layout_1 product_list_main"">
  <div class=""container"">
    <div class=""row"">
      <div class=""col-md-9"">
        <div class=""row"">
");
#nullable restore
#line 35 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Index.cshtml"
             foreach (var item in Model)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4 col-sm-6 col-xs-12 margin_bottom_30_all\">\r\n            <div class=\"product_list\">\r\n              <div class=\"product_img\"> <img class=\"img-responsive\"");
            BeginWriteAttribute("src", " src=\"", 1228, "\"", 1245, 1);
#nullable restore
#line 39 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Index.cshtml"
WriteAttributeValue("", 1234, item.AnhSp, 1234, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1246, "\"", 1252, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n              <div class=\"product_detail_btm\">\r\n                <div class=\"center\">\r\n                  <h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0fbe494610130ae39cf4a05d84d477fe19ef4cd7552", async() => {
#nullable restore
#line 42 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Index.cshtml"
                                                                   Write(item.TenSp);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Index.cshtml"
                                                WriteLiteral(item.MaSp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h4>
                </div>
                <div class=""starratin"">
                  <div class=""center""> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star"" aria-hidden=""true""></i> <i class=""fa fa-star-o"" aria-hidden=""true""></i> </div>
                </div>
                <div class=""product_price"">
                  <p><span class=""old_price"">");
#nullable restore
#line 48 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Index.cshtml"
                                        Write(item.GiaSp.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span> – <span class=\"new_price\">");
#nullable restore
#line 48 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Index.cshtml"
                                                                                                           Write(item.GiaSp.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></p>\r\n                </div>\r\n              </div>\r\n            </div>\r\n          </div>\n");
#nullable restore
#line 53 "D:\LAP TRING NET NANG CAO\HiepBaoComputer\HiepBaoComputer\Views\SanPham\Index.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"         

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
                <li><a href=""it_data_recovery.html""><i class=""fa fa-angle-right""></i> Computer</a></li>
                <li><a href=""it_computer_repair.html""><i class=""fa fa-angle-right""></i> Laptop</a></li>
                <li><a href=""it_mobile_service.html""><i class=""fa fa-angle-right""></i> Linh Kiện Máy Tính");
            WriteLiteral(@"</a></li>
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
<!-- end section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HiepBaoComputer.Models.SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
