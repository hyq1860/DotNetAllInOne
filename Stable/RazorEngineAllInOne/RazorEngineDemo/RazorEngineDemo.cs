using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using RazorEngine.Text;
using RazorEngineDemo.ViewModel;

namespace RazorEngineDemo
{
    public class RazorEngineDemo
    {
        public void RunCompile01()
        {
            // using RazorEngine.Templating; Dont forget to include this.
            string template = "Hello @Model.Name, welcome to RazorEngine!";
            //Using Anonymous Types
            var result01 = Engine.Razor.RunCompile(template, "templateKey", null, new {Name = "World"});
            Console.WriteLine(result01);

            //判断模板是否有缓存过
            if (Engine.Razor.IsTemplateCached("templateKey", null))
            {
                var result02 = Engine.Razor.Run("templateKey", null, new { Name = "World" });
                Console.WriteLine(result02);
            }

            //Using Dynamic Types
            dynamic model03=new ExpandoObject();
            model03.Name = "刘德华";
            if (Engine.Razor.IsTemplateCached("templateKey", null))
            {
                //注意参数中必须要有object对象的转换
                var result03 = Engine.Razor.Run("templateKey", null, (object)model03);
                Console.WriteLine(result03);
            }

        }

        /// <summary>
        /// 编码的问题
        /// </summary>
        public void EncodingValues()
        {
            string template = "@Raw(Model.Data)";
            var model = new
            {
                Data = "My raw double quotes appears here \"hello!\"",
                Html="<h1>你好</h1>"
            };
            var result = string.Empty;
            if (Engine.Razor.IsTemplateCached("EncodingValues", null))
            {
                result = Engine.Razor.Run("EncodingValues", null, model);
            }
            else
            {
                result = Engine.Razor.RunCompile(template, "EncodingValues", null, model);
            }

            Console.WriteLine(result);
        }

        public void Test(string templateFolderPath)
        {
            string template02 = File.ReadAllText(Path.Combine(templateFolderPath, "template02.cshtml"));
            
            var config = new TemplateServiceConfiguration();
            config.Language=Language.CSharp;
            config.EncodedStringFactory = new RawStringFactory();
            //config.EncodedStringFactory=new HtmlEncodedStringFactory();
            config.Debug = true;

            //config.TemplateManager = new RazorTemplateManager(Environment.CurrentDirectory.Replace("\\bin","") + "\\Views");

            config.TemplateManager= new DelegateTemplateManager(name =>
            {
                string resourcePath = string.Format(templateFolderPath, name);
                var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath);
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            });
            config.CachingProvider=new DefaultCachingProvider();
            
            var service = RazorEngineService.Create(config);

            Engine.Razor = service;
            var result = string.Empty;
            if (service.IsTemplateCached("template02.cshtml", null))
            {
                result = service.Run("template02.cshtml", typeof(ReportModel),
                new ReportModel() { ReportId = "报告编号", Name = "hahahha", Title = "11", Photos = new List<string>() { "111111", "222222" },Count=13 });
            }
            else
            {
                result = service.RunCompile(template02, "template02.cshtml", typeof(ReportModel),
                new ReportModel() { ReportId = "报告编号", Name = "hahahha", Title = "11", Photos = new List<string>() { "111111", "222222" }, Count = 13 });
            }
            

            Console.WriteLine(result);

            // You can use the @inherits directive instead (this is the fallback if no @inherits is found).
            //config.BaseTemplateType = typeof(TemplateBase<ReportModel>);

            //var result02 = service.RunCompile(template02, typeof(ReportModel),new ReportModel() { ReportId = "报告编号", Title = "11" });

            //var result02 = Engine.Razor.RunCompile(template02,"ceshi", typeof (ReportModel),new ReportModel() {ReportId = "报告编号", Title = "11",Photos = new List<string>(){"111111","222222"}});

            //Console.WriteLine(result02);
        }

        public void Test02()
        {
        }
    }
}
