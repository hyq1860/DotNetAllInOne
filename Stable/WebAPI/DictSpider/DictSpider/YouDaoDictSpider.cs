using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DictSpider
{
    public class YouDaoDictSpider
    {

        public void MainSpider()
        {
            var filePath = @"D:\Sync\WebAPI\DictSpider\DictSpider\Data\";
            var firstLevalUrls = new List<string>();
            var firstLevalUrlTemplate = "http://dict.youdao.com/bisheng/api?m=[[\"ls\", {\"id\":\"2-#\",\"page\":1,\"num\":100}]]&t=json";
            var viewUrlTemplate="http://dict.youdao.com/bisheng/api?m=[[\"view\", {\"id\":\"#\"}]]&t=json";
            var client = new HttpClient();
            var webClient = new WebClient();
            HttpResponseMessage response;
            for (int i = 10; i <= 21; i++)
            {
                var url = firstLevalUrlTemplate.Replace("#", i.ToString());

                var task = client.GetAsync(url);
                response = task.Result;
                var result = response.Content.ReadAsStringAsync().Result;
                var directoryName = "2-" + i;
                
                if (!Directory.Exists(filePath + directoryName))
                {
                    //Directory.CreateDirectory(filePath + directoryName);
                    //File.WriteAllText(filePath + directoryName + "\\" + directoryName + ".json", result, Encoding.UTF8);
                }
                var s = "[[{\"code\": 0,\"execTime\": 0},";
                var tempResult = result.Substring(s.Length, result.Length - 2 - s.Length);//result.Replace("[[{\"code\": 0,\"execTime\": 0},", "");
                //tempResult = result.Substring(s.Length, result.Length - 1);
                tempResult = tempResult.TrimEnd(new char[] { ']', ']' });

                //File.WriteAllText(filePath + directoryName + "\\" + directoryName + "_cleaning.json", result, Encoding.UTF8);
                var categoryData = JsonConvert.DeserializeObject<Category>(tempResult);
                Console.WriteLine(directoryName);
                foreach (var pic in categoryData.pic)
                {
                    var viewUrl = viewUrlTemplate.Replace("#", pic.id);
                    //下载图片
                    var tempFilePath = filePath + directoryName + "\\" + pic.id + ".m.jpg";
                    if (!File.Exists(tempFilePath))
                    {
                        webClient.DownloadFile(pic.url, tempFilePath);
                    }
                    
                    task = client.GetAsync(viewUrl);
                    response = task.Result;
                    result = response.Content.ReadAsStringAsync().Result;
                    //File.WriteAllText(filePath + directoryName + "\\" + pic.id + ".json", result, Encoding.UTF8);

                    tempResult = result.Substring(s.Length, result.Length - 2 - s.Length);
                    //tempResult = result.Replace("[[{\"code\": 0,\"execTime\": 0},", "");
                    //tempResult = result.Replace("[[{\"code\": 0,\"execTime\": 1},", "");
                    //tempResult = tempResult.TrimEnd(new char[] { ']', ']' });
                    //File.WriteAllText(filePath + directoryName + "\\" + pic.id + "_cleaning.json", result, Encoding.UTF8);
                    var viewData = JsonConvert.DeserializeObject<View>(tempResult);
                    var viewPicPath = filePath + directoryName + "\\" + viewData.id + ".d.jpg";
                    if (!File.Exists(viewPicPath))
                    {
                        webClient.DownloadFile(viewData.url, viewPicPath);
                    }
                    
                }
            }
            Console.WriteLine("完成了");
        }

        public void Spider()
        {
            var client=new HttpClient();
            var url = "http://dict.youdao.com/bisheng/api?m=[[\"ls\", {\"id\":\"2-10\",\"page\":1,\"num\":15}]]&t=json";
            var task = client.GetAsync(url);
            HttpResponseMessage response = task.Result;

            var result = response.Content.ReadAsStringAsync().Result;
            var tempResult = result.Replace("[[{\"code\": 0,\"execTime\": 0},", "");
            tempResult = tempResult.TrimEnd(new char[] {']',']'});

            //result = result.TrimStart(new char[] { '[', '[' });
            //result = result.TrimEnd(new char[] { ']', ']' });
            //var obj = JObject.Parse(result);
            //var tempResult = "{" + result + "}";

            var model = new Category();


            //var json = JsonConvert.SerializeObject(model);

            //var obj = JsonConvert.DeserializeObject(tempResult);
            var data = JsonConvert.DeserializeObject<Category>(tempResult);
        }

        public void Spider2()
        {
            var url = "http://dict.youdao.com/bisheng/api?m=[[%22view%22,%20{%22id%22:%222-10-1-1%22}]]&t=json";
            var client = new HttpClient();
            var task = client.GetAsync(url);
            HttpResponseMessage response = task.Result;

            var result = response.Content.ReadAsStringAsync().Result;
            var tempResult = result.Replace("[[{\"code\": 0,\"execTime\": 0},", "");
            tempResult = tempResult.TrimEnd(new char[] { ']', ']' });

            var data = JsonConvert.DeserializeObject<View>(tempResult);
        }
    }


    public class Category
    {

        public string id { get; set; }

        public string name { get; set; }

        public string count { get; set; }

        public List<CategoryItem> pic { get; set; }
    }

    public class CategoryItem
    {
        public string id { get; set; }

        public string url { get; set; }

        public string title { get; set; }

        public string engTitle { get; set; }
    }


    public class View
    {
        public string id { get; set; }

        public string title { get; set; }

        public string engTitle { get; set; }

        public string url { get; set; }

        public string next { get; set; }

        public List<ViewItem> label { get; set; }
    }

    public class ViewItem
    {
        public string cn { get; set; }

        public string en { get; set; }

        public string left { get; set; }

        public string top { get; set; }
    }

}
