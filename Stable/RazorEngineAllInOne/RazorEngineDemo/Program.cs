using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Configuration.Xml;
using RazorEngine.Templating;
using RazorEngineDemo.ViewModel;

namespace RazorEngineDemo
{
    class Program
    {
        static readonly string TemplateFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views");

        static void Main(string[] args)
        {
            string template = "Hello @Model.Name, welcome to RazorEngine!";
            try
            {
                var result = Engine.Razor.RunCompile(template, "templateKey", null, new { Name = "World" });

                Console.WriteLine(result);

                string template02 = File.ReadAllText(Path.Combine(TemplateFolderPath, "template02.cshtml"));
                //var templateService = new TemplateService();
                //RazorEngineService razorEngineService=new RazorEngineService();

                var config = new TemplateServiceConfiguration();
                // You can use the @inherits directive instead (this is the fallback if no @inherits is found).
                //config.BaseTemplateType = typeof(HtmlSupportTemplateBase<>);
                using (var service = RazorEngineService.Create(config))
                {
                    var result02=service.RunCompile(template02, typeof (ReportModel),
                        new ReportModel() {ReportId = "报告编号", Title = "11"});
                }

                //var result02 = Engine.Razor.RunCompile(template02, typeof(ReportModel), new ReportModel() { ReportId = "报告编号", Title = "11" });
            }
            catch(Exception exception)
            {
                
            }

            
        }
    }
}
