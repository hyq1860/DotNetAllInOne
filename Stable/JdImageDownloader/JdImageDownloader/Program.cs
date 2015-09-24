using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace JdImageDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var skus = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory + "/sku.txt");
            var client = new System.Net.WebClient();
            client.Encoding = Encoding.UTF8;
            foreach (var sku in skus)
            {
                var url = "http://item.m.jd.com/product/"+ sku + ".html";
                
                var html = client.DownloadString(url);

                if (!string.IsNullOrEmpty(html))
                {
                    var startIndex = html.IndexOf("<input type=\"hidden\" value=");
                    var endIndex = html.IndexOf("id=\"imgs\"/>");
                    var length = "<input type=\"hidden\" value=".Length + 1;
                    var temp = html.Substring(startIndex + length, endIndex - startIndex- length-3);
                    var imageUrls = temp.Split(',').ToList();
                    var i = 1;
                    if(!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + sku))
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + sku);
                    }

                    foreach (var imageUrl in imageUrls)
                    {
                        if(!string.IsNullOrEmpty(imageUrl))
                        {
                            client.DownloadFile(imageUrl, AppDomain.CurrentDomain.BaseDirectory + sku + "//" + i + ".jpg");
                            i++;
                        }
                    }
                }
                Console.WriteLine(sku +"下载完毕");
                Console.ReadKey();
            }
           
        }
    }
}
