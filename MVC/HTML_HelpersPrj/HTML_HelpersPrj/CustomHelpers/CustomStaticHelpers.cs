using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTML_HelpersPrj.CustomHelpers
{
    public class CustomStaticHelpers
    {
        public static IHtmlString LabelWithMark(string content)
        {
            string htmlstr = String.Format("<label><b><mark><i><del>{0}</del></i></mark></b></label>", content);
            return new HtmlString(htmlstr);
        }
    }
}