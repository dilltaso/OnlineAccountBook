using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineAccountBook.ExtensionMethods
{
    public static class TextHtmlHelper
    {
        public static MvcHtmlString DoColorLabel(this HtmlHelper helper, string value)
        {
            return new MvcHtmlString((value == "1" ? "<font color=\"Blue\">收入</font>" : "<font color=\"Red\">支出</font>"));
        }
    }
}