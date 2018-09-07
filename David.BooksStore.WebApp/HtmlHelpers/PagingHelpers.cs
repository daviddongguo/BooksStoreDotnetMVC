﻿using David.BooksStore.WebApp.Models;
using System;
using System.Text;
using System.Web.Mvc;

namespace David.BooksStore.WebApp.HtmlHelpers
{
    public static class PagingHelpers
    {
        /// <summary>
        /// Create html tag like 
        /// <a class="btn btn-default" href="/?page=2">2</a>
        /// <a class="btn btn-default btn-primary selected" href="/?page=3">3</a>
        /// </summary>
        /// <param name="html"></param>
        /// <param name="pagingInfo"></param>
        /// <param name="pageUrl"></param>
        /// <returns></returns>
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= pagingInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}