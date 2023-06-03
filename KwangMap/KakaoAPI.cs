using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace KwangMap
{
    static class KakaoAPI
    {
        internal static List<MyLocale> Search(string qstr)
        {
            string site = "https://dapi.kakao.com/v2/local/search/keyword.json";
            string query = string.Format("{0}?query={1}", site, qstr);

            WebRequest request = WebRequest.Create(query);
            request.Method = "GET";

            string rkey = "d82f4351f02170364674352a263c60d9";
            string header = "KakaoAK " + rkey;
            request.Headers.Add("Authorization", header);

            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            String json = reader.ReadToEnd();

            JavaScriptSerializer js = new JavaScriptSerializer();
            dynamic dob = js.Deserialize<dynamic>(json);
            dynamic docs = dob["documents"];
            object[] buf = docs;
            int length = buf.Length;

            List<MyLocale> mls = new List<MyLocale>();
            for(int i = 0; i < length; i++)
            {
                string Iname = docs[i]["place_name"];
                double x = double.Parse(docs[i]["x"]);
                double y = double.Parse(docs[i]["y"]);
                mls.Add(new MyLocale(Iname, y, x));
            }
            return mls;
        }
    }
}
