using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using RazorEngine.Text;
using RazorEngineDemo.ViewModel;
using Encoding = System.Text.Encoding;

namespace RazorEngineDemo
{
    public class TaoBaoAutoReportConvert
    {
        private string basePath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin","");
        public List<TaoBaoCheckItem> GetTaoBaoCheckItems()
        {
            FileStream fs=new FileStream(basePath+"淘宝检测项.xlsx",FileMode.Open);
            IWorkbook workbook = new XSSFWorkbook(fs);
            ISheet sheet1 = workbook.GetSheetAt(0);
            var result=new List<TaoBaoCheckItem>();
            for (int i = sheet1.FirstRowNum+1; i <= sheet1.LastRowNum; i++)
            {
                var row = sheet1.GetRow(i);
                TaoBaoCheckItem taoBaoCheckItem=new TaoBaoCheckItem();

                taoBaoCheckItem.CheckItemName = row.GetCell(0).StringCellValue;
                taoBaoCheckItem.TaoBaoPartCode = row.GetCell(1).StringCellValue;
                taoBaoCheckItem.TaoBaoReportTypeName = row.GetCell(2).StringCellValue;
                taoBaoCheckItem.TaoBaoReportTCode = row.GetCell(3).StringCellValue;
                taoBaoCheckItem.IsMatch = row.GetCell(4).StringCellValue;

                //for (int j = row.FirstCellNum; j < row.LastCellNum; j++)
                //{
                    
                //}
                
                

                

                result.Add(taoBaoCheckItem);
            }
            
            return result;
        }

        public List<TaoBaoCheckItemRule> GeTaoBaoCheckItemRules()
        {
            FileStream fs = new FileStream(basePath + "268v全部数据.xlsx", FileMode.Open);
            IWorkbook workbook = new XSSFWorkbook(fs);
            ISheet sheet1 = workbook.GetSheetAt(0);
            var result=new List<TaoBaoCheckItemRule>();
            var errorIndexs=new List<int>();
            for (int i = sheet1.FirstRowNum + 1; i <= sheet1.LastRowNum; i++)
            {
                try
                {
                    var row = sheet1.GetRow(i);
                    TaoBaoCheckItemRule taoBaoCheckItemRule=new TaoBaoCheckItemRule();
                    var cell0 = row.GetCell(0);
                    if (cell0 != null)
                    {
                        taoBaoCheckItemRule.PartCode = cell0.StringCellValue;
                    }

                    taoBaoCheckItemRule.PartName = CellValueConvert(row.GetCell(1));
                    taoBaoCheckItemRule.PlaceCode = CellValueConvert(row.GetCell(2));
                    taoBaoCheckItemRule.PlaceName = CellValueConvert(row.GetCell(3));
                    taoBaoCheckItemRule.DefectCode = CellValueConvert(row.GetCell(4));
                    taoBaoCheckItemRule.DefectName = CellValueConvert(row.GetCell(5));

                    taoBaoCheckItemRule.DValueCode = CellValueConvert(row.GetCell(6));
                    taoBaoCheckItemRule.ConfValue = CellValueConvert(row.GetCell(7));
                    string error = "";
                
                    var cell15 = row.GetCell(15);
                    if (cell15 != null && !string.IsNullOrEmpty(cell15.StringCellValue) &&
                        cell15.StringCellValue != "NULL")
                    {
                        taoBaoCheckItemRule.TaoBaoPartCode = cell15.StringCellValue;
                    }

                    var cell16 = row.GetCell(16);
                    if (cell16 != null && !string.IsNullOrEmpty(cell16.StringCellValue))
                    {
                        taoBaoCheckItemRule.TaoBaoReportTCode = cell16.StringCellValue;
                    }

                    if (!string.IsNullOrEmpty(taoBaoCheckItemRule.TaoBaoPartCode)
                        && taoBaoCheckItemRule.TaoBaoPartCode.ToUpper() != "NULL"
                        )
                    {
                        result.Add(taoBaoCheckItemRule);
                    }
                }
                catch (Exception ex)
                {
                    errorIndexs.Add(i);
                }
                finally
                {
                    
                }
                
            }

            return result.OrderBy(s => s.TaoBaoPartCode).ToList();
        }

        public void AutoCodeGenerate()
        {
            var templateFolderPath = AppDomain.CurrentDomain.BaseDirectory.Replace("bin", "");
            string template02 = File.ReadAllText(Path.Combine(templateFolderPath, "Views\\taobaomap.cshtml"));

            var config = new TemplateServiceConfiguration();
            config.Language = Language.CSharp;
            config.EncodedStringFactory = new RawStringFactory();
            //config.EncodedStringFactory=new HtmlEncodedStringFactory();
            config.Debug = true;

            //config.TemplateManager = new RazorTemplateManager(Environment.CurrentDirectory.Replace("\\bin","") + "\\Views");

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

            Engine.Razor = service;
            var result = string.Empty;
            var taoBaoMapData=new TaoBaoMapData();
            taoBaoMapData.TaoBaoCheckItems = GetTaoBaoCheckItems();
            taoBaoMapData.TaoBaoCheckItemRules = GeTaoBaoCheckItemRules();
            if (service.IsTemplateCached("taobaomap.cshtml", null))
            {
                result = service.Run("taobaomap.cshtml", null, taoBaoMapData);
            }
            else
            {
                result = service.RunCompile(template02, "taobaomap.cshtml", null, taoBaoMapData);
            }

            File.WriteAllText(templateFolderPath + "\\taobao.cs", result, Encoding.UTF8);
        }

        private string CellValueConvert(ICell cell)
        {
            var result = string.Empty;
            if (cell != null)
            {
                switch (cell.CellType)
                {
                     case CellType.String:
                        result = cell.StringCellValue;
                        break;
                     case CellType.Numeric:
                        result = cell.NumericCellValue.ToString();
                        break;
                }
            }
            return result;
        }
    }
}
