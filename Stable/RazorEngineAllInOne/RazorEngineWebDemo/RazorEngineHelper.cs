using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using RazorEngine.Text;

namespace RazorEngineWebDemo
{
    public class RazorEngineHelper
    {
        static RazorEngineHelper()
        {
            var config = new TemplateServiceConfiguration
            {
                Language = Language.CSharp,
                EncodedStringFactory = new RawStringFactory(),
                DisableTempFileLocking = true,// loads the files in-memory (gives the templates full-trust permissions)
                CachingProvider = new DefaultCachingProvider(t => { })//disables the warnings
            };

            // Use the config
            Engine.Razor = RazorEngineService.Create(config); // new API
        }

        public static IRazorEngineService RazorEngine
        {
            get { return Engine.Razor; }
        }
    }
}