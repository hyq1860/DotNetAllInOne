using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using RazorEngine.Text;

namespace RazorEngineDemo
{
    /// <summary>
    /// RazorEngine助手
    /// </summary>
    public class RazorEngineHelper
    {
        static IRazorEngineService Service { get; set; }
        static TemplateServiceConfiguration Configuration { get; set; }

        static RazorEngineHelper()
        {
            Configuration = new TemplateServiceConfiguration
            {
                BaseTemplateType = typeof(HtmlTemplateBase<>),
                Language = Language.CSharp,
                Debug = false,
                EncodedStringFactory = new RawStringFactory(),
                DisableTempFileLocking = true,// loads the files in-memory (gives the templates full-trust permissions)
                CachingProvider = new DefaultCachingProvider(t => { })//disables the warnings
            };

            // Use the config
            Engine.Razor = RazorEngineService.Create(Configuration); // new API
        }

        public static IRazorEngineService RazorEngine
        {
            get { return Engine.Razor; }
        }

        //public static void Reset()
        //{
        //    Configuration.CachingProvider = new DefaultCachingProvider(t => { }); //disables the warnings
        //}
    }

    [RequireNamespaces("System.Web.Mvc.Html")]
    public class HtmlTemplateBase<T> : TemplateBase<T>, IViewDataContainer
    {
        private HtmlHelper<T> helper = null;
        private ViewDataDictionary viewdata = null;

        public HtmlHelper<T> Html
        {
            get
            {
                if (helper == null)
                {
                    var writer = this.CurrentWriter; //TemplateBase.CurrentWriter
                    var vcontext = new ViewContext() { Writer = writer, ViewData = this.ViewData };

                    helper = new HtmlHelper<T>(vcontext, this);
                }
                return helper;
            }
        }

        public ViewDataDictionary ViewData
        {
            get
            {
                if (viewdata == null)
                {
                    viewdata = new ViewDataDictionary();
                    viewdata.TemplateInfo = new TemplateInfo() { HtmlFieldPrefix = string.Empty };

                    if (this.Model != null)
                    {
                        viewdata.Model = Model;
                    }
                }
                return viewdata;
            }
            set
            {
                viewdata = value;
            }
        }

        public override void WriteTo(TextWriter writer, object value)
        {
            if (writer == null)
                throw new ArgumentNullException("writer");

            if (value == null) return;

            //try to cast to RazorEngine IEncodedString
            var encodedString = value as IEncodedString;
            if (encodedString != null)
            {
                writer.Write(encodedString);
            }
            else
            {
                //try to cast to IHtmlString (Could be returned by Mvc Html helper methods)
                var htmlString = value as IHtmlString;
                if (htmlString != null) writer.Write(htmlString.ToHtmlString());
                else
                {
                    //default implementation is to convert to RazorEngine encoded string
                    encodedString = TemplateService.EncodedStringFactory.CreateEncodedString(value);
                    writer.Write(encodedString);
                }

            }
        }
    }
}
