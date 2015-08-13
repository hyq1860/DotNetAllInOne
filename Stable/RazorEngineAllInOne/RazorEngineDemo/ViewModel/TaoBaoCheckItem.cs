using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorEngineDemo.ViewModel
{
    public class TaoBaoCheckItem
    {
        /// <summary>
        /// 检测项目
        /// </summary>
        public string CheckItemName { get; set; }

        /// <summary>
        /// 淘宝部件编号
        /// </summary>
        public string TaoBaoPartCode { get; set; }

        /// <summary>
        /// 淘宝报告分类编号
        /// </summary>
        public string TaoBaoReportTCode { get; set; }

        /// <summary>
        /// 淘宝报告分类名称
        /// </summary>
        public string TaoBaoReportTypeName { get; set; }

        /// <summary>
        /// 是否匹配
        /// </summary>
        public string IsMatch { get; set; }
    }

    public class TaoBaoCheckItemRule
    {
        /// <summary>
        /// 部件编码
        /// </summary>
        public string PartCode { get; set; }

        /// <summary>
        /// 部件名称
        /// </summary>
        public string PartName { get; set; }

        /// <summary>
        /// 部位编码
        /// </summary>
        public string PlaceCode { get; set; }

        /// <summary>
        /// 部位名称
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// 缺陷类型编码
        /// </summary>
        public string DefectCode { get; set; }

        /// <summary>
        /// 缺陷类型名称
        /// </summary>
        public string DefectName { get; set; }

        /// <summary>
        /// 缺陷值编码
        /// </summary>
        public string DValueCode { get; set; }

        /// <summary>
        /// 检测类型编码
        /// </summary>
        public string ReportTCode { get; set; }

        /// <summary>
        /// 检测值
        /// </summary>
        public string ConfValue { get; set; }

        /// <summary>
        /// 淘宝部件编号
        /// </summary>
        public string TaoBaoPartCode { get; set; }

        /// <summary>
        /// 淘宝报告分类
        /// </summary>
        public string TaoBaoReportTCode { get; set; }
    }

    public class TaoBaoMapData
    {
        public List<TaoBaoCheckItem> TaoBaoCheckItems { get; set; }

        public List<TaoBaoCheckItemRule> TaoBaoCheckItemRules { get; set; }
    }
}
