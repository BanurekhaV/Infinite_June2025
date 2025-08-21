using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_HelpersPrj.CustomHelpers
{
    public static class CustomExtensionHelpers
    {
        public static IHtmlString RedLabel(this HtmlHelper helperobj,string content)
        {
            string str = String.Format("<label><i><font color=red>{0}</font></i></label>", content);
            return new HtmlString(str);
        }

        public static IHtmlString GreenLabel(this HtmlHelper helperobj, string content)
        {
            string str = String.Format("<label><i><font color=green>{0}</font></i></label>", content);
            return new HtmlString(str);
        }
    }
}