using System;
using System.Text;
using System.Web.Mvc;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks( this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
    }
}