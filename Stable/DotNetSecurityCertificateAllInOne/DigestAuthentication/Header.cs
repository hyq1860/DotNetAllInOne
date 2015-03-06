using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DigestAuthentication
{
    public class Header
    {
        public Header() { }

        public Header(string header, string method)
        {
            string keyValuePairs = header.Replace("\"", "");

            var kvPairs = keyValuePairs.Split(',');
            foreach (string keyValuePair in kvPairs)
            {
                var trimKevValuePair = keyValuePair.TrimStart(' ');
                int index = trimKevValuePair.IndexOf("=");
                string key = trimKevValuePair.Substring(0, index);
                string value = trimKevValuePair.Substring(index + 1);

                switch (key)
                {
                    case "username": this.UserName = value; break;
                    case "realm": this.Realm = value; break;
                    case "nonce": this.Nonce = value; break;
                    case "uri": this.Uri = value; break;
                    case "nc": this.NounceCounter = value; break;
                    case "cnonce": this.Cnonce = value; break;
                    case "response": this.Response = value; break;
                    case "method": this.Method = value; break;
                }
            }

            if (String.IsNullOrEmpty(this.Method))
                this.Method = method;
        }

        //随机数计数器(cnonce) 每一次请求 要比前一次的大
        public string Cnonce { get; private set; }
        public string Nonce { get; private set; }
        public string Realm { get; private set; }
        public string UserName { get; private set; }
        public string Uri { get; private set; }
        public string Response { get; private set; }
        public string Method { get; private set; }
        public string NounceCounter { get; private set; }

        // This property is used by the handler to generate a
        // nonce and get it ready to be packaged in the
        // WWW-Authenticate header, as part of 401 response
        public static Header UnauthorizedResponseHeader
        {
            get
            {
                return new Header()
                {
                    Realm = "RealmOfBadri",
                    //服务器密码随机数(nonce)
                    Nonce = DigestAuthentication.Nonce.Generate()
                };
            }
        }

        public override string ToString()
        {
            StringBuilder header = new StringBuilder();
            header.AppendFormat("realm=\"{0}\"", Realm);
            header.AppendFormat(",nonce=\"{0}\"", Nonce);
            header.AppendFormat(",qop=\"{0}\"", "auth");
            return header.ToString();
        }
    }

}