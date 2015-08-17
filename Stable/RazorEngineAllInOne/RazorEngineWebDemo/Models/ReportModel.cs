using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorEngineWebDemo.Models
{
    public class ReportModel
    {
        /// <summary>
        /// 报告id
        /// </summary>
        public string ReportId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 报告标题
        /// </summary>
        public string Title { get; set; }

        public List<string> Photos { get; set; }

        public int Count { get; set; }
    }
}