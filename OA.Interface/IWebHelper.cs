using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace OA.Interface
{
    public interface IWebHelper
    {
        string SetQueryString(Dictionary<string, string> _value);

        Dictionary<string, string> GetQueryString(NameValueCollection QueryString);
    }
}
