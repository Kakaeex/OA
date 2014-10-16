using System.Collections.Generic;
using System.Text;
using OA.Interface;
using System.Collections.Specialized;

namespace OA.Service
{
    public class WebHelper : IWebHelper
    {
        public string SetQueryString(Dictionary<string, string> _value)
        {
            StringBuilder _querystring = new StringBuilder("?");
            foreach (KeyValuePair<string, string> pair in _value)
            {
                _querystring.AppendFormat("{0}={1}&", pair.Key, pair.Value);
            }
            return _querystring.ToString().TrimEnd('&');
        }

        public Dictionary<string, string> GetQueryString(NameValueCollection queryString)
        {
            Dictionary<string, string> _queryString = new Dictionary<string, string>();
            foreach (string key in queryString.AllKeys)
            {
                _queryString.Add(key, queryString[key].ToString());
            }
            return _queryString;
        }
    }
}
