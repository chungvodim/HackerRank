using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DownLoadImage
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            using (var rsp = client.GetAsync("http://www.vagarchitects.com/our-work/land-planning/").Result)
            {
                var page = rsp.Content.ReadAsStringAsync().Result;
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(page);
                var ul = doc.DocumentNode.SelectNodes(@"//*[@id=""main-content""]/div[2]/div/div[3]/div/ul/li");
                foreach (var li in ul)
                {
                    var temp = li.Descendants().ToList();
                    var img = temp[1];
                    var src = img.GetAttributeValue("src","");
                    Console.WriteLine(src);
                }
            }
        }
    }
}
