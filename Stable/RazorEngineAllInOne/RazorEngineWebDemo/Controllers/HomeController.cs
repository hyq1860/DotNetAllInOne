using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using RazorEngine;
using RazorEngine.Compilation.ReferenceResolver;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using RazorEngine.Text;
using RazorEngineWebDemo.Models;

namespace RazorEngineWebDemo.Controllers
{
    //public static class RazorHelper
    //{
    //    private static IRazorEngineService razorEngineService;
    //    static RazorHelper()
    //    {
    //        var config = new TemplateServiceConfiguration();
    //        config.Language = Language.CSharp;
    //        config.EncodedStringFactory = new RawStringFactory();
    //        //config.EncodedStringFactory=new HtmlEncodedStringFactory();
    //        //两个属性互斥
    //        //config.Debug = true;
    //        config.DisableTempFileLocking = true;
    //        //config.BaseTemplateType=

    //        //config.TemplateManager = new RazorTemplateManager(Environment.CurrentDirectory.Replace("\\bin","") + "\\Views");

    //        config.TemplateManager = new DelegateTemplateManager(name =>
    //        {
    //            string resourcePath = string.Format(templateFolderPath, name);
    //            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath);
    //            using (StreamReader reader = new StreamReader(stream))
    //            {
    //                return reader.ReadToEnd();
    //            }
    //        });
    //        config.CachingProvider = new DefaultCachingProvider();

    //        razorEngineService = RazorEngineService.Create(config);
    //        RazorEngineServiceExtensions.Compile(razorEngineService,);
            
    //    }

    //}

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //http://blogs.msdn.com/b/hongyes/archive/2012/03/12/using-razor-template-engine-in-web-api-self-host-application.aspx
        //http://stackoverflow.com/questions/10520821/how-are-templates-in-razorengine-cached
        public ActionResult Razor()
        {
            var templateFolderPath=Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views");
            string template02 = System.IO.File.ReadAllText(Path.Combine(templateFolderPath, "template02.cshtml"));

            /*
            var config = new TemplateServiceConfiguration();
            config.Language = Language.CSharp;
            config.EncodedStringFactory = new RawStringFactory();
            //config.EncodedStringFactory=new HtmlEncodedStringFactory();
            //两个属性互斥
            //config.Debug = true;
            config.DisableTempFileLocking = true;
            //config.BaseTemplateType=

            //config.TemplateManager = new RazorTemplateManager(Environment.CurrentDirectory.Replace("\\bin","") + "\\Views");
            config.ReferenceResolver = new CustomReferenceResolver();//new UseCurrentAssembliesReferenceResolver();
            config.TemplateManager = new DelegateTemplateManager(name =>
            {
                string resourcePath = string.Format(templateFolderPath, name);
                var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourcePath);
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            });
            config.CachingProvider = new DefaultCachingProvider();

            var service = RazorEngineService.Create(config);
            //RazorEngineServiceExtensions.Compile(service,);
            Engine.Razor = service;
             * */
            var result = string.Empty;

            if (RazorEngineHelper.RazorEngine.IsTemplateCached("template02.cshtml", typeof(ReportModel)))
            {
                result = RazorEngineHelper.RazorEngine.Run("template02.cshtml", typeof(ReportModel),
                new ReportModel() { ReportId = "报告编号", Name = "hahahha", Title = "11", Photos = new List<string>() { "111111", "222222" }, Count = 13 });
            }
            else
            {
                result = RazorEngineHelper.RazorEngine.RunCompile(template02, "template02.cshtml", typeof(ReportModel),
                new ReportModel() { ReportId = "报告编号", Name = "hahahha", Title = "11", Photos = new List<string>() { "111111", "222222" }, Count = 13 });
            }
            return View();
        }
    }
}