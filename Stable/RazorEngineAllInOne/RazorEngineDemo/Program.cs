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
        static string template02 = File.ReadAllText(Path.Combine(TemplateFolderPath, "template02.cshtml"));
        static void Main(string[] args)
        {
            
            try
            {
                var html = RazorEngineHelper.RazorEngine.RunCompile(template02, "test", typeof(ReportModel),
                    new ReportModel()
                    {
                        ReportId = "报告编号",
                        Name = "hahahha",
                        Title = "11",
                        Photos = new List<string>() { "111111", "222222" },
                        Count = 13
                    });

                return;
                TaoBaoAutoReportConvert taoBaoAutoReportConvert=new TaoBaoAutoReportConvert();
                taoBaoAutoReportConvert.GetTaoBaoCheckItems();

                taoBaoAutoReportConvert.GeTaoBaoCheckItemRules();
                taoBaoAutoReportConvert.AutoCodeGenerate();

                

                
                return;
                RazorEngineDemo razorEngineDemo=new RazorEngineDemo();

                //razorEngineDemo.RunCompile01();

                //razorEngineDemo.EncodingValues();

                razorEngineDemo.Test(TemplateFolderPath);
            }
            catch(Exception exception)
            {
                
            }

            
        }
    }
}
