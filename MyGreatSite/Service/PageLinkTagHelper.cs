using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using MyGreatSite.Models;

namespace MyGreatSite.Service
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder result = new TagBuilder("div");
            TagBuilder ul = new TagBuilder("ul");
            ul.AddCssClass("pagination");
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder li = new TagBuilder("li");
                TagBuilder tag = new TagBuilder("a");
                if (PageModel.CurrentPage == i) tag.AddCssClass("page active");
                tag.AddCssClass("page");
                tag.Attributes["href"] = urlHelper.Action(PageAction, new { page = i });
                tag.InnerHtml.Append(i.ToString());
                li.InnerHtml.AppendHtml(tag);
                ul.InnerHtml.AppendHtml(li);
            }
            result.InnerHtml.AppendHtml(ul);
            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}
