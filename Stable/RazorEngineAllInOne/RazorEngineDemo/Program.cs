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
            
            try
            {
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
