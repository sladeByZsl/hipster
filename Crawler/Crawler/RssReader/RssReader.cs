using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RssReader
{
    public class RssReader
    {
        public static string run()
        {
            string startIndex = "http://articles.csdn.net/api/rss.php?tid=1008";

            string content = "";
            Uri url = new Uri(startIndex);
            HttpWebRequest requestPage = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = requestPage.GetResponse();
            Stream stream = response.GetResponseStream();//获取页面流
            if (stream != null)
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);//读取获得内容流
                content = reader.ReadToEnd();//将内容流转换为文本并存入变量BoardStream，即为所需要的数据流
            }
            return content;
        }
        

    }
}
