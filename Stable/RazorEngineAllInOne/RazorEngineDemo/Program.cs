using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorEngine;
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
                var result02= Engine.Razor.RunCompile(template02, typeof(ReportModel), new ReportModel() { ReportId = "报告编号", Title = "11" });
            }
            catch(Exception exception)
            {
                
            }

            
        }
    }
}
