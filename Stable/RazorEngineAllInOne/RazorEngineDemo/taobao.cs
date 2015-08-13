

#region 事故检查
private TbCheckModule Convert_TBRP001(CarReportModel carReportModel)
{
var tbCheckModule = new TbCheckModule();
tbCheckModule.Name = "事故检查";
#region 左A柱
TbCheckItemDetail tbCheckItemDetail_TBC001 = new TbCheckItemDetail();
tbCheckItemDetail_TBC001.Name="左A柱";
var checkInfoList_TBC001 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C015" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C015" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V014") ||
(s.PartCode.ToUpper() == "C015" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V017") ||
(s.PartCode.ToUpper() == "C015" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V018") ||
(s.PartCode.ToUpper() == "C015" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019")
);
var checkResult_TBC001 = 4;
if (checkInfoList_TBC001.Any())
{
checkResult_TBC001 = checkInfoList_TBC001.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC001 = 1;
}
var tbCheckItemDesc_TBC001 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC001);
if (tbCheckItemDesc_TBC001 != null)
tbCheckItemDetail_TBC001.CheckResult = tbCheckItemDesc_TBC001.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC001);
#endregion

#region 左B柱
TbCheckItemDetail tbCheckItemDetail_TBC002 = new TbCheckItemDetail();
tbCheckItemDetail_TBC002.Name="左B柱";
var checkInfoList_TBC002 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C016" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C016" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V014") ||
(s.PartCode.ToUpper() == "C016" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V017") ||
(s.PartCode.ToUpper() == "C016" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V018") ||
(s.PartCode.ToUpper() == "C016" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019")
);
var checkResult_TBC002 = 4;
if (checkInfoList_TBC002.Any())
{
checkResult_TBC002 = checkInfoList_TBC002.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC002 = 1;
}
var tbCheckItemDesc_TBC002 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC002);
if (tbCheckItemDesc_TBC002 != null)
tbCheckItemDetail_TBC002.CheckResult = tbCheckItemDesc_TBC002.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC002);
#endregion

#region 左C柱
TbCheckItemDetail tbCheckItemDetail_TBC003 = new TbCheckItemDetail();
tbCheckItemDetail_TBC003.Name="左C柱";
var checkInfoList_TBC003 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C017" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C017" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V014") ||
(s.PartCode.ToUpper() == "C017" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V017") ||
(s.PartCode.ToUpper() == "C017" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V018") ||
(s.PartCode.ToUpper() == "C017" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019")
);
var checkResult_TBC003 = 4;
if (checkInfoList_TBC003.Any())
{
checkResult_TBC003 = checkInfoList_TBC003.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC003 = 1;
}
var tbCheckItemDesc_TBC003 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC003);
if (tbCheckItemDesc_TBC003 != null)
tbCheckItemDetail_TBC003.CheckResult = tbCheckItemDesc_TBC003.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC003);
#endregion

#region 右A柱
TbCheckItemDetail tbCheckItemDetail_TBC004 = new TbCheckItemDetail();
tbCheckItemDetail_TBC004.Name="右A柱";
var checkInfoList_TBC004 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C015" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C015" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V014") ||
(s.PartCode.ToUpper() == "C015" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V017") ||
(s.PartCode.ToUpper() == "C015" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V018") ||
(s.PartCode.ToUpper() == "C015" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019")
);
var checkResult_TBC004 = 4;
if (checkInfoList_TBC004.Any())
{
checkResult_TBC004 = checkInfoList_TBC004.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC004 = 1;
}
var tbCheckItemDesc_TBC004 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC004);
if (tbCheckItemDesc_TBC004 != null)
tbCheckItemDetail_TBC004.CheckResult = tbCheckItemDesc_TBC004.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC004);
#endregion

#region 右B柱
TbCheckItemDetail tbCheckItemDetail_TBC005 = new TbCheckItemDetail();
tbCheckItemDetail_TBC005.Name="右B柱";
var checkInfoList_TBC005 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C016" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C016" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V014") ||
(s.PartCode.ToUpper() == "C016" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V017") ||
(s.PartCode.ToUpper() == "C016" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V018") ||
(s.PartCode.ToUpper() == "C016" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019")
);
var checkResult_TBC005 = 4;
if (checkInfoList_TBC005.Any())
{
checkResult_TBC005 = checkInfoList_TBC005.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC005 = 1;
}
var tbCheckItemDesc_TBC005 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC005);
if (tbCheckItemDesc_TBC005 != null)
tbCheckItemDetail_TBC005.CheckResult = tbCheckItemDesc_TBC005.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC005);
#endregion

#region 右C柱
TbCheckItemDetail tbCheckItemDetail_TBC006 = new TbCheckItemDetail();
tbCheckItemDetail_TBC006.Name="右C柱";
var checkInfoList_TBC006 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C017" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C017" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V014") ||
(s.PartCode.ToUpper() == "C017" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V017") ||
(s.PartCode.ToUpper() == "C017" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V018") ||
(s.PartCode.ToUpper() == "C017" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019")
);
var checkResult_TBC006 = 4;
if (checkInfoList_TBC006.Any())
{
checkResult_TBC006 = checkInfoList_TBC006.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC006 = 1;
}
var tbCheckItemDesc_TBC006 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC006);
if (tbCheckItemDesc_TBC006 != null)
tbCheckItemDetail_TBC006.CheckResult = tbCheckItemDesc_TBC006.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC006);
#endregion

#region 左前纵梁
TbCheckItemDetail tbCheckItemDetail_TBC007 = new TbCheckItemDetail();
tbCheckItemDetail_TBC007.Name="左前纵梁";
var checkInfoList_TBC007 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C026" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C026" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V016") ||
(s.PartCode.ToUpper() == "C026" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019") ||
(s.PartCode.ToUpper() == "C026" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V017") ||
(s.PartCode.ToUpper() == "C026" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V037") ||
(s.PartCode.ToUpper() == "C026" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V044")
);
var checkResult_TBC007 = 4;
if (checkInfoList_TBC007.Any())
{
checkResult_TBC007 = checkInfoList_TBC007.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC007 = 1;
}
var tbCheckItemDesc_TBC007 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC007);
if (tbCheckItemDesc_TBC007 != null)
tbCheckItemDetail_TBC007.CheckResult = tbCheckItemDesc_TBC007.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC007);
#endregion

#region 右前纵梁
TbCheckItemDetail tbCheckItemDetail_TBC008 = new TbCheckItemDetail();
tbCheckItemDetail_TBC008.Name="右前纵梁";
var checkInfoList_TBC008 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C026" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C026" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V016") ||
(s.PartCode.ToUpper() == "C026" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019") ||
(s.PartCode.ToUpper() == "C026" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V017") ||
(s.PartCode.ToUpper() == "C026" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V037") ||
(s.PartCode.ToUpper() == "C026" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V044")
);
var checkResult_TBC008 = 4;
if (checkInfoList_TBC008.Any())
{
checkResult_TBC008 = checkInfoList_TBC008.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC008 = 1;
}
var tbCheckItemDesc_TBC008 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC008);
if (tbCheckItemDesc_TBC008 != null)
tbCheckItemDetail_TBC008.CheckResult = tbCheckItemDesc_TBC008.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC008);
#endregion

#region 左前减震器悬挂部位
TbCheckItemDetail tbCheckItemDetail_TBC009 = new TbCheckItemDetail();
tbCheckItemDetail_TBC009.Name="左前减震器悬挂部位";
var checkInfoList_TBC009 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V037") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V016") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V017") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019")
);
var checkResult_TBC009 = 4;
if (checkInfoList_TBC009.Any())
{
checkResult_TBC009 = checkInfoList_TBC009.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC009 = 1;
}
var tbCheckItemDesc_TBC009 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC009);
if (tbCheckItemDesc_TBC009 != null)
tbCheckItemDetail_TBC009.CheckResult = tbCheckItemDesc_TBC009.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC009);
#endregion

#region 右前减震器悬挂部位
TbCheckItemDetail tbCheckItemDetail_TBC010 = new TbCheckItemDetail();
tbCheckItemDetail_TBC010.Name="右前减震器悬挂部位";
var checkInfoList_TBC010 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V037") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V016") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V017") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019")
);
var checkResult_TBC010 = 4;
if (checkInfoList_TBC010.Any())
{
checkResult_TBC010 = checkInfoList_TBC010.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC010 = 1;
}
var tbCheckItemDesc_TBC010 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC010);
if (tbCheckItemDesc_TBC010 != null)
tbCheckItemDetail_TBC010.CheckResult = tbCheckItemDesc_TBC010.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC010);
#endregion

#region 左后减震器悬挂部位
TbCheckItemDetail tbCheckItemDetail_TBC011 = new TbCheckItemDetail();
tbCheckItemDetail_TBC011.Name="左后减震器悬挂部位";
var checkInfoList_TBC011 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V016") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V017") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019")
);
var checkResult_TBC011 = 4;
if (checkInfoList_TBC011.Any())
{
checkResult_TBC011 = checkInfoList_TBC011.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC011 = 1;
}
var tbCheckItemDesc_TBC011 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC011);
if (tbCheckItemDesc_TBC011 != null)
tbCheckItemDetail_TBC011.CheckResult = tbCheckItemDesc_TBC011.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC011);
#endregion

#region 右后减震器悬挂部位
TbCheckItemDetail tbCheckItemDetail_TBC012 = new TbCheckItemDetail();
tbCheckItemDetail_TBC012.Name="右后减震器悬挂部位";
var checkInfoList_TBC012 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V016") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V017") ||
(s.PartCode.ToUpper() == "C024" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019")
);
var checkResult_TBC012 = 4;
if (checkInfoList_TBC012.Any())
{
checkResult_TBC012 = checkInfoList_TBC012.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC012 = 1;
}
var tbCheckItemDesc_TBC012 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC012);
if (tbCheckItemDesc_TBC012 != null)
tbCheckItemDetail_TBC012.CheckResult = tbCheckItemDesc_TBC012.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC012);
#endregion

return tbCheckModule;}
#endregion

#region 外观检查
private TbCheckModule Convert_TBRP002(CarReportModel carReportModel)
{
var tbCheckModule = new TbCheckModule();
tbCheckModule.Name = "外观检查";
#region 发动机舱盖表面
TbCheckItemDetail tbCheckItemDetail_TBC013 = new TbCheckItemDetail();
tbCheckItemDetail_TBC013.Name="发动机舱盖表面";
var checkInfoList_TBC013 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C004" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C004" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V003") ||
(s.PartCode.ToUpper() == "C004" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C004" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C004" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C004" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V065") ||
(s.PartCode.ToUpper() == "C004" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V021") ||
(s.PartCode.ToUpper() == "C004" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V023") ||
(s.PartCode.ToUpper() == "C004" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V022") ||
(s.PartCode.ToUpper() == "C004" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V020") ||
(s.PartCode.ToUpper() == "C004" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC013 = 4;
if (checkInfoList_TBC013.Any())
{
checkResult_TBC013 = checkInfoList_TBC013.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC013 = 1;
}
var tbCheckItemDesc_TBC013 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC013);
if (tbCheckItemDesc_TBC013 != null)
tbCheckItemDetail_TBC013.CheckResult = tbCheckItemDesc_TBC013.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC013);
#endregion

#region 左前翼子板
TbCheckItemDetail tbCheckItemDetail_TBC014 = new TbCheckItemDetail();
tbCheckItemDetail_TBC014.Name="左前翼子板";
var checkInfoList_TBC014 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V003") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V065") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V020") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V021") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V022") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V023") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC014 = 4;
if (checkInfoList_TBC014.Any())
{
checkResult_TBC014 = checkInfoList_TBC014.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC014 = 1;
}
var tbCheckItemDesc_TBC014 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC014);
if (tbCheckItemDesc_TBC014 != null)
tbCheckItemDetail_TBC014.CheckResult = tbCheckItemDesc_TBC014.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC014);
#endregion

#region 右前翼子板
TbCheckItemDetail tbCheckItemDetail_TBC015 = new TbCheckItemDetail();
tbCheckItemDetail_TBC015.Name="右前翼子板";
var checkInfoList_TBC015 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V003") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V065") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V020") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V021") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V022") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V023") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC015 = 4;
if (checkInfoList_TBC015.Any())
{
checkResult_TBC015 = checkInfoList_TBC015.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC015 = 1;
}
var tbCheckItemDesc_TBC015 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC015);
if (tbCheckItemDesc_TBC015 != null)
tbCheckItemDetail_TBC015.CheckResult = tbCheckItemDesc_TBC015.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC015);
#endregion

#region 左后翼子板
TbCheckItemDetail tbCheckItemDetail_TBC016 = new TbCheckItemDetail();
tbCheckItemDetail_TBC016.Name="左后翼子板";
var checkInfoList_TBC016 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V003") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V020") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V021") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V022") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V023")
);
var checkResult_TBC016 = 4;
if (checkInfoList_TBC016.Any())
{
checkResult_TBC016 = checkInfoList_TBC016.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC016 = 1;
}
var tbCheckItemDesc_TBC016 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC016);
if (tbCheckItemDesc_TBC016 != null)
tbCheckItemDetail_TBC016.CheckResult = tbCheckItemDesc_TBC016.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC016);
#endregion

#region 右后翼子板
TbCheckItemDetail tbCheckItemDetail_TBC017 = new TbCheckItemDetail();
tbCheckItemDetail_TBC017.Name="右后翼子板";
var checkInfoList_TBC017 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V003") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V020") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V021") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V022") ||
(s.PartCode.ToUpper() == "C012" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V023")
);
var checkResult_TBC017 = 4;
if (checkInfoList_TBC017.Any())
{
checkResult_TBC017 = checkInfoList_TBC017.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC017 = 1;
}
var tbCheckItemDesc_TBC017 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC017);
if (tbCheckItemDesc_TBC017 != null)
tbCheckItemDetail_TBC017.CheckResult = tbCheckItemDesc_TBC017.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC017);
#endregion

#region 左前车门
TbCheckItemDetail tbCheckItemDetail_TBC018 = new TbCheckItemDetail();
tbCheckItemDetail_TBC018.Name="左前车门";
var checkInfoList_TBC018 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V003") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V065") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V020") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V021") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V022") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V023") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC018 = 4;
if (checkInfoList_TBC018.Any())
{
checkResult_TBC018 = checkInfoList_TBC018.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC018 = 1;
}
var tbCheckItemDesc_TBC018 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC018);
if (tbCheckItemDesc_TBC018 != null)
tbCheckItemDetail_TBC018.CheckResult = tbCheckItemDesc_TBC018.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC018);
#endregion

#region 右前车门
TbCheckItemDetail tbCheckItemDetail_TBC019 = new TbCheckItemDetail();
tbCheckItemDetail_TBC019.Name="右前车门";
var checkInfoList_TBC019 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V003") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V065") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V020") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V021") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V022") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V023") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC019 = 4;
if (checkInfoList_TBC019.Any())
{
checkResult_TBC019 = checkInfoList_TBC019.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC019 = 1;
}
var tbCheckItemDesc_TBC019 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC019);
if (tbCheckItemDesc_TBC019 != null)
tbCheckItemDetail_TBC019.CheckResult = tbCheckItemDesc_TBC019.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC019);
#endregion

#region 左后车门
TbCheckItemDetail tbCheckItemDetail_TBC020 = new TbCheckItemDetail();
tbCheckItemDetail_TBC020.Name="左后车门";
var checkInfoList_TBC020 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V003") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V065") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V020") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V021") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V022") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V023") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC020 = 4;
if (checkInfoList_TBC020.Any())
{
checkResult_TBC020 = checkInfoList_TBC020.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC020 = 1;
}
var tbCheckItemDesc_TBC020 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC020);
if (tbCheckItemDesc_TBC020 != null)
tbCheckItemDetail_TBC020.CheckResult = tbCheckItemDesc_TBC020.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC020);
#endregion

#region 右后车门
TbCheckItemDetail tbCheckItemDetail_TBC021 = new TbCheckItemDetail();
tbCheckItemDetail_TBC021.Name="右后车门";
var checkInfoList_TBC021 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V003") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V065") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V020") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V021") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V022") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V023") ||
(s.PartCode.ToUpper() == "C033" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC021 = 4;
if (checkInfoList_TBC021.Any())
{
checkResult_TBC021 = checkInfoList_TBC021.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC021 = 1;
}
var tbCheckItemDesc_TBC021 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC021);
if (tbCheckItemDesc_TBC021 != null)
tbCheckItemDetail_TBC021.CheckResult = tbCheckItemDesc_TBC021.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC021);
#endregion

#region 行李箱盖
TbCheckItemDetail tbCheckItemDetail_TBC022 = new TbCheckItemDetail();
tbCheckItemDetail_TBC022.Name="行李箱盖";
var checkInfoList_TBC022 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C007" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C007" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C007" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V003") ||
(s.PartCode.ToUpper() == "C007" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C007" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C007" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V065") ||
(s.PartCode.ToUpper() == "C007" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V020") ||
(s.PartCode.ToUpper() == "C007" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V021") ||
(s.PartCode.ToUpper() == "C007" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V022") ||
(s.PartCode.ToUpper() == "C007" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V023") ||
(s.PartCode.ToUpper() == "C007" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC022 = 4;
if (checkInfoList_TBC022.Any())
{
checkResult_TBC022 = checkInfoList_TBC022.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC022 = 1;
}
var tbCheckItemDesc_TBC022 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC022);
if (tbCheckItemDesc_TBC022 != null)
tbCheckItemDetail_TBC022.CheckResult = tbCheckItemDesc_TBC022.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC022);
#endregion

#region 行李箱内侧
TbCheckItemDetail tbCheckItemDetail_TBC023 = new TbCheckItemDetail();
tbCheckItemDetail_TBC023.Name="行李箱内侧";
var checkInfoList_TBC023 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C060" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T08" && s.DValueCode.ToUpper()=="V039") ||
(s.PartCode.ToUpper() == "C160" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C160" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C160" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V009") ||
(s.PartCode.ToUpper() == "C160" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C160" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C157" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C157" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C157" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V009") ||
(s.PartCode.ToUpper() == "C157" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C157" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C022" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C022" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C022" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V009") ||
(s.PartCode.ToUpper() == "C022" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T09" && s.DValueCode.ToUpper()=="V041") ||
(s.PartCode.ToUpper() == "C009" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C009" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C009" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C023" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C023" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C023" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C022" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T08" && s.DValueCode.ToUpper()=="V038") ||
(s.PartCode.ToUpper() == "C022" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T08" && s.DValueCode.ToUpper()=="V039") ||
(s.PartCode.ToUpper() == "P224" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T08" && s.DValueCode.ToUpper()=="V038") ||
(s.PartCode.ToUpper() == "P224" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T08" && s.DValueCode.ToUpper()=="V039")
);
var checkResult_TBC023 = 4;
if (checkInfoList_TBC023.Any())
{
checkResult_TBC023 = checkInfoList_TBC023.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC023 = 1;
}
var tbCheckItemDesc_TBC023 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC023);
if (tbCheckItemDesc_TBC023 != null)
tbCheckItemDetail_TBC023.CheckResult = tbCheckItemDesc_TBC023.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC023);
#endregion

#region 车顶
TbCheckItemDetail tbCheckItemDetail_TBC024 = new TbCheckItemDetail();
tbCheckItemDetail_TBC024.Name="车顶";
var checkInfoList_TBC024 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C018" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C018" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C018" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V003") ||
(s.PartCode.ToUpper() == "C018" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C018" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C018" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V020") ||
(s.PartCode.ToUpper() == "C018" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V021") ||
(s.PartCode.ToUpper() == "C018" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V022") ||
(s.PartCode.ToUpper() == "C018" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T03" && s.DValueCode.ToUpper()=="V023")
);
var checkResult_TBC024 = 4;
if (checkInfoList_TBC024.Any())
{
checkResult_TBC024 = checkInfoList_TBC024.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC024 = 1;
}
var tbCheckItemDesc_TBC024 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC024);
if (tbCheckItemDesc_TBC024 != null)
tbCheckItemDetail_TBC024.CheckResult = tbCheckItemDesc_TBC024.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC024);
#endregion

#region 前保险杠
TbCheckItemDetail tbCheckItemDetail_TBC025 = new TbCheckItemDetail();
tbCheckItemDetail_TBC025.Name="前保险杠";
var checkInfoList_TBC025 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C028" && s.PlaceCode.ToUpper() == "P03" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C028" && s.PlaceCode.ToUpper() == "P03" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C028" && s.PlaceCode.ToUpper() == "P03" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C028" && s.PlaceCode.ToUpper() == "P03" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC025 = 4;
if (checkInfoList_TBC025.Any())
{
checkResult_TBC025 = checkInfoList_TBC025.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC025 = 1;
}
var tbCheckItemDesc_TBC025 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC025);
if (tbCheckItemDesc_TBC025 != null)
tbCheckItemDetail_TBC025.CheckResult = tbCheckItemDesc_TBC025.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC025);
#endregion

#region 后保险杠
TbCheckItemDetail tbCheckItemDetail_TBC026 = new TbCheckItemDetail();
tbCheckItemDetail_TBC026.Name="后保险杠";
var checkInfoList_TBC026 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C028" && s.PlaceCode.ToUpper() == "P04" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C028" && s.PlaceCode.ToUpper() == "P04" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C028" && s.PlaceCode.ToUpper() == "P04" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C028" && s.PlaceCode.ToUpper() == "P04" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC026 = 4;
if (checkInfoList_TBC026.Any())
{
checkResult_TBC026 = checkInfoList_TBC026.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC026 = 1;
}
var tbCheckItemDesc_TBC026 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC026);
if (tbCheckItemDesc_TBC026 != null)
tbCheckItemDetail_TBC026.CheckResult = tbCheckItemDesc_TBC026.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC026);
#endregion

#region 左前轮毂
TbCheckItemDetail tbCheckItemDetail_TBC027 = new TbCheckItemDetail();
tbCheckItemDetail_TBC027.Name="左前轮毂";
var checkInfoList_TBC027 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C220" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C220" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C220" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C220" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C220" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C220" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C220" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C220" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "S03" && s.DValueCode.ToUpper()=="SV035") ||
(s.PartCode.ToUpper() == "C061" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "S03" && s.DValueCode.ToUpper()=="SV036")
);
var checkResult_TBC027 = 4;
if (checkInfoList_TBC027.Any())
{
checkResult_TBC027 = checkInfoList_TBC027.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC027 = 1;
}
var tbCheckItemDesc_TBC027 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC027);
if (tbCheckItemDesc_TBC027 != null)
tbCheckItemDetail_TBC027.CheckResult = tbCheckItemDesc_TBC027.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC027);
#endregion

#region 左后轮毂
TbCheckItemDetail tbCheckItemDetail_TBC028 = new TbCheckItemDetail();
tbCheckItemDetail_TBC028.Name="左后轮毂";
tbCheckItemDetail_TBC028.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC028);
#endregion

#region 右前轮毂
TbCheckItemDetail tbCheckItemDetail_TBC029 = new TbCheckItemDetail();
tbCheckItemDetail_TBC029.Name="右前轮毂";
tbCheckItemDetail_TBC029.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC029);
#endregion

#region 右后轮毂
TbCheckItemDetail tbCheckItemDetail_TBC030 = new TbCheckItemDetail();
tbCheckItemDetail_TBC030.Name="右后轮毂";
tbCheckItemDetail_TBC030.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC030);
#endregion

#region 前大灯
TbCheckItemDetail tbCheckItemDetail_TBC031 = new TbCheckItemDetail();
tbCheckItemDetail_TBC031.Name="前大灯";
var checkInfoList_TBC031 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V067") ||
(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V067") ||
(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C081" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC031 = 4;
if (checkInfoList_TBC031.Any())
{
checkResult_TBC031 = checkInfoList_TBC031.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC031 = 1;
}
var tbCheckItemDesc_TBC031 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC031);
if (tbCheckItemDesc_TBC031 != null)
tbCheckItemDetail_TBC031.CheckResult = tbCheckItemDesc_TBC031.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC031);
#endregion

#region 后尾灯
TbCheckItemDetail tbCheckItemDetail_TBC032 = new TbCheckItemDetail();
tbCheckItemDetail_TBC032.Name="后尾灯";
var checkInfoList_TBC032 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C080" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C080" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C080" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C080" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C080" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V067") ||
(s.PartCode.ToUpper() == "C080" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C080" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C080" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C080" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C080" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C080" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V067") ||
(s.PartCode.ToUpper() == "C080" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC032 = 4;
if (checkInfoList_TBC032.Any())
{
checkResult_TBC032 = checkInfoList_TBC032.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC032 = 1;
}
var tbCheckItemDesc_TBC032 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC032);
if (tbCheckItemDesc_TBC032 != null)
tbCheckItemDetail_TBC032.CheckResult = tbCheckItemDesc_TBC032.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC032);
#endregion

#region 前挡风玻璃
TbCheckItemDetail tbCheckItemDetail_TBC033 = new TbCheckItemDetail();
tbCheckItemDetail_TBC033.Name="前挡风玻璃";
var checkInfoList_TBC033 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C044" && s.PlaceCode.ToUpper() == "P03" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C044" && s.PlaceCode.ToUpper() == "P03" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C044" && s.PlaceCode.ToUpper() == "P03" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V066") ||
(s.PartCode.ToUpper() == "C044" && s.PlaceCode.ToUpper() == "P03" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC033 = 4;
if (checkInfoList_TBC033.Any())
{
checkResult_TBC033 = checkInfoList_TBC033.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC033 = 1;
}
var tbCheckItemDesc_TBC033 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC033);
if (tbCheckItemDesc_TBC033 != null)
tbCheckItemDetail_TBC033.CheckResult = tbCheckItemDesc_TBC033.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC033);
#endregion

#region 后挡风玻璃
TbCheckItemDetail tbCheckItemDetail_TBC034 = new TbCheckItemDetail();
tbCheckItemDetail_TBC034.Name="后挡风玻璃";
var checkInfoList_TBC034 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C044" && s.PlaceCode.ToUpper() == "P04" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C044" && s.PlaceCode.ToUpper() == "P04" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C044" && s.PlaceCode.ToUpper() == "P04" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V066") ||
(s.PartCode.ToUpper() == "C044" && s.PlaceCode.ToUpper() == "P04" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC034 = 4;
if (checkInfoList_TBC034.Any())
{
checkResult_TBC034 = checkInfoList_TBC034.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC034 = 1;
}
var tbCheckItemDesc_TBC034 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC034);
if (tbCheckItemDesc_TBC034 != null)
tbCheckItemDetail_TBC034.CheckResult = tbCheckItemDesc_TBC034.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC034);
#endregion

#region 四门风窗玻璃
TbCheckItemDetail tbCheckItemDetail_TBC035 = new TbCheckItemDetail();
tbCheckItemDetail_TBC035.Name="四门风窗玻璃";
var checkInfoList_TBC035 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006")
);
var checkResult_TBC035 = 4;
if (checkInfoList_TBC035.Any())
{
checkResult_TBC035 = checkInfoList_TBC035.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC035 = 1;
}
var tbCheckItemDesc_TBC035 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC035);
if (tbCheckItemDesc_TBC035 != null)
tbCheckItemDetail_TBC035.CheckResult = tbCheckItemDesc_TBC035.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC035);
#endregion

#region 左后视镜
TbCheckItemDetail tbCheckItemDetail_TBC036 = new TbCheckItemDetail();
tbCheckItemDetail_TBC036.Name="左后视镜";
var checkInfoList_TBC036 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C043" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C043" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V003") ||
(s.PartCode.ToUpper() == "C043" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006")
);
var checkResult_TBC036 = 4;
if (checkInfoList_TBC036.Any())
{
checkResult_TBC036 = checkInfoList_TBC036.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC036 = 1;
}
var tbCheckItemDesc_TBC036 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC036);
if (tbCheckItemDesc_TBC036 != null)
tbCheckItemDetail_TBC036.CheckResult = tbCheckItemDesc_TBC036.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC036);
#endregion

#region 右后视镜
TbCheckItemDetail tbCheckItemDetail_TBC037 = new TbCheckItemDetail();
tbCheckItemDetail_TBC037.Name="右后视镜";
var checkInfoList_TBC037 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C043" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V002") ||
(s.PartCode.ToUpper() == "C043" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V003") ||
(s.PartCode.ToUpper() == "C043" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006")
);
var checkResult_TBC037 = 4;
if (checkInfoList_TBC037.Any())
{
checkResult_TBC037 = checkInfoList_TBC037.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC037 = 1;
}
var tbCheckItemDesc_TBC037 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC037);
if (tbCheckItemDesc_TBC037 != null)
tbCheckItemDetail_TBC037.CheckResult = tbCheckItemDesc_TBC037.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC037);
#endregion

#region 轮胎
TbCheckItemDetail tbCheckItemDetail_TBC038 = new TbCheckItemDetail();
tbCheckItemDetail_TBC038.Name="轮胎";
var checkInfoList_TBC038 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C062" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C062" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C062" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V008") ||
(s.PartCode.ToUpper() == "C062" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C062" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C062" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V008") ||
(s.PartCode.ToUpper() == "C062" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C062" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C062" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V008") ||
(s.PartCode.ToUpper() == "C062" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C062" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C062" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V008")
);
var checkResult_TBC038 = 4;
if (checkInfoList_TBC038.Any())
{
checkResult_TBC038 = checkInfoList_TBC038.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC038 = 1;
}
var tbCheckItemDesc_TBC038 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC038);
if (tbCheckItemDesc_TBC038 != null)
tbCheckItemDetail_TBC038.CheckResult = tbCheckItemDesc_TBC038.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC038);
#endregion

return tbCheckModule;}
#endregion

#region 发动机舱检查
private TbCheckModule Convert_TBRP003(CarReportModel carReportModel)
{
var tbCheckModule = new TbCheckModule();
tbCheckModule.Name = "发动机舱检查";
#region 机油有无冷却液混入
TbCheckItemDetail tbCheckItemDetail_TBC039 = new TbCheckItemDetail();
tbCheckItemDetail_TBC039.Name="机油有无冷却液混入";
var checkInfoList_TBC039 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C067" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T07" && s.DValueCode.ToUpper()=="V036")
);
var checkResult_TBC039 = 4;
if (checkInfoList_TBC039.Any())
{
checkResult_TBC039 = checkInfoList_TBC039.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC039 = 1;
}
var tbCheckItemDesc_TBC039 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC039);
if (tbCheckItemDesc_TBC039 != null)
tbCheckItemDetail_TBC039.CheckResult = tbCheckItemDesc_TBC039.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC039);
#endregion

#region 蓄电池电解液有无渗漏、缺少
TbCheckItemDetail tbCheckItemDetail_TBC040 = new TbCheckItemDetail();
tbCheckItemDetail_TBC040.Name="蓄电池电解液有无渗漏、缺少";
tbCheckItemDetail_TBC040.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC040);
#endregion

#region 缸盖外是否有机油渗漏
TbCheckItemDetail tbCheckItemDetail_TBC041 = new TbCheckItemDetail();
tbCheckItemDetail_TBC041.Name="缸盖外是否有机油渗漏";
var checkInfoList_TBC041 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C065" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V028")
);
var checkResult_TBC041 = 4;
if (checkInfoList_TBC041.Any())
{
checkResult_TBC041 = checkInfoList_TBC041.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC041 = 1;
}
var tbCheckItemDesc_TBC041 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC041);
if (tbCheckItemDesc_TBC041 != null)
tbCheckItemDetail_TBC041.CheckResult = tbCheckItemDesc_TBC041.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC041);
#endregion

#region 发动机皮带有无老化
TbCheckItemDetail tbCheckItemDetail_TBC042 = new TbCheckItemDetail();
tbCheckItemDetail_TBC042.Name="发动机皮带有无老化";
var checkInfoList_TBC042 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C137" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007")
);
var checkResult_TBC042 = 4;
if (checkInfoList_TBC042.Any())
{
checkResult_TBC042 = checkInfoList_TBC042.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC042 = 1;
}
var tbCheckItemDesc_TBC042 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC042);
if (tbCheckItemDesc_TBC042 != null)
tbCheckItemDetail_TBC042.CheckResult = tbCheckItemDesc_TBC042.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC042);
#endregion

#region 前翼子板内缘、水箱框架、横拉梁有无凹凸或修复痕迹
TbCheckItemDetail tbCheckItemDetail_TBC043 = new TbCheckItemDetail();
tbCheckItemDetail_TBC043.Name="前翼子板内缘、水箱框架、横拉梁有无凹凸或修复痕迹";
var checkInfoList_TBC043 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C048" && s.PlaceCode.ToUpper() == "P19" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019") ||
(s.PartCode.ToUpper() == "C047" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C047" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019") ||
(s.PartCode.ToUpper() == "C047" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V037") ||
(s.PartCode.ToUpper() == "C047" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V044") ||
(s.PartCode.ToUpper() == "C049" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C049" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019") ||
(s.PartCode.ToUpper() == "C049" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V037") ||
(s.PartCode.ToUpper() == "C049" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V044") ||
(s.PartCode.ToUpper() == "C014" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C014" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C014" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019") ||
(s.PartCode.ToUpper() == "C014" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V037") ||
(s.PartCode.ToUpper() == "C014" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V044") ||
(s.PartCode.ToUpper() == "C014" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C014" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C014" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019") ||
(s.PartCode.ToUpper() == "C014" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V037") ||
(s.PartCode.ToUpper() == "C014" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V044") ||
(s.PartCode.ToUpper() == "C048" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V013") ||
(s.PartCode.ToUpper() == "C048" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V019") ||
(s.PartCode.ToUpper() == "C048" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V037") ||
(s.PartCode.ToUpper() == "C048" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T02" && s.DValueCode.ToUpper()=="V044")
);
var checkResult_TBC043 = 4;
if (checkInfoList_TBC043.Any())
{
checkResult_TBC043 = checkInfoList_TBC043.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC043 = 1;
}
var tbCheckItemDesc_TBC043 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC043);
if (tbCheckItemDesc_TBC043 != null)
tbCheckItemDetail_TBC043.CheckResult = tbCheckItemDesc_TBC043.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC043);
#endregion

#region 油管、水管有无老化裂痕
TbCheckItemDetail tbCheckItemDetail_TBC044 = new TbCheckItemDetail();
tbCheckItemDetail_TBC044.Name="油管、水管有无老化裂痕";
var checkInfoList_TBC044 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C063" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007")
);
var checkResult_TBC044 = 4;
if (checkInfoList_TBC044.Any())
{
checkResult_TBC044 = checkInfoList_TBC044.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC044 = 1;
}
var tbCheckItemDesc_TBC044 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC044);
if (tbCheckItemDesc_TBC044 != null)
tbCheckItemDetail_TBC044.CheckResult = tbCheckItemDesc_TBC044.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC044);
#endregion

#region 散热器格栅有无破损
TbCheckItemDetail tbCheckItemDetail_TBC045 = new TbCheckItemDetail();
tbCheckItemDetail_TBC045.Name="散热器格栅有无破损";
var checkInfoList_TBC045 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C088" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006")
);
var checkResult_TBC045 = 4;
if (checkInfoList_TBC045.Any())
{
checkResult_TBC045 = checkInfoList_TBC045.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC045 = 1;
}
var tbCheckItemDesc_TBC045 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC045);
if (tbCheckItemDesc_TBC045 != null)
tbCheckItemDetail_TBC045.CheckResult = tbCheckItemDesc_TBC045.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC045);
#endregion

#region 线束有无老化、破损
TbCheckItemDetail tbCheckItemDetail_TBC046 = new TbCheckItemDetail();
tbCheckItemDetail_TBC046.Name="线束有无老化、破损";
var checkInfoList_TBC046 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C030" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007")
);
var checkResult_TBC046 = 4;
if (checkInfoList_TBC046.Any())
{
checkResult_TBC046 = checkInfoList_TBC046.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC046 = 1;
}
var tbCheckItemDesc_TBC046 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC046);
if (tbCheckItemDesc_TBC046 != null)
tbCheckItemDetail_TBC046.CheckResult = tbCheckItemDesc_TBC046.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC046);
#endregion

#region 蓄电池电极柱有无腐蚀
TbCheckItemDetail tbCheckItemDetail_TBC047 = new TbCheckItemDetail();
tbCheckItemDetail_TBC047.Name="蓄电池电极柱有无腐蚀";
tbCheckItemDetail_TBC047.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC047);
#endregion

return tbCheckModule;}
#endregion

#region 驾驶舱检查
private TbCheckModule Convert_TBRP004(CarReportModel carReportModel)
{
var tbCheckModule = new TbCheckModule();
tbCheckModule.Name = "驾驶舱检查";
#region 左、右后视镜折叠装置工作是否正常
TbCheckItemDetail tbCheckItemDetail_TBC048 = new TbCheckItemDetail();
tbCheckItemDetail_TBC048.Name="左、右后视镜折叠装置工作是否正常";
var checkInfoList_TBC048 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C043" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C043" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024")
);
var checkResult_TBC048 = 4;
if (checkInfoList_TBC048.Any())
{
checkResult_TBC048 = checkInfoList_TBC048.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC048 = 1;
}
var tbCheckItemDesc_TBC048 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC048);
if (tbCheckItemDesc_TBC048 != null)
tbCheckItemDetail_TBC048.CheckResult = tbCheckItemDesc_TBC048.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC048);
#endregion

#region 车内后视镜、座椅是否否完整、无破损、功能正常
TbCheckItemDetail tbCheckItemDetail_TBC049 = new TbCheckItemDetail();
tbCheckItemDetail_TBC049.Name="车内后视镜、座椅是否否完整、无破损、功能正常";
var checkInfoList_TBC049 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P02" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P02" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P02" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P02" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V008") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P02" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P02" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P02" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V008") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V008") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C042" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C042" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C042" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P01" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P01" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P01" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P01" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V008") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P01" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P01" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C077" && s.PlaceCode.ToUpper() == "P01" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034")
);
var checkResult_TBC049 = 4;
if (checkInfoList_TBC049.Any())
{
checkResult_TBC049 = checkInfoList_TBC049.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC049 = 1;
}
var tbCheckItemDesc_TBC049 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC049);
if (tbCheckItemDesc_TBC049 != null)
tbCheckItemDetail_TBC049.CheckResult = tbCheckItemDesc_TBC049.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC049);
#endregion

#region 方向盘自由行程转角是否小于20度
TbCheckItemDetail tbCheckItemDetail_TBC050 = new TbCheckItemDetail();
tbCheckItemDetail_TBC050.Name="方向盘自由行程转角是否小于20度";
tbCheckItemDetail_TBC050.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC050);
#endregion

#region 车顶及周边内饰是否无破损、松动及裂缝和污迹
TbCheckItemDetail tbCheckItemDetail_TBC051 = new TbCheckItemDetail();
tbCheckItemDetail_TBC051.Name="车顶及周边内饰是否无破损、松动及裂缝和污迹";
var checkInfoList_TBC051 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C082" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C082" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C082" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C082" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C082" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C082" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C082" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C082" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C082" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C082" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C083" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C083" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C083" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C083" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C083" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C083" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C083" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C083" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C083" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C083" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C084" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C084" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C084" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C084" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C084" && s.PlaceCode.ToUpper() == "P05" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C084" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C084" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C084" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C084" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C084" && s.PlaceCode.ToUpper() == "P06" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C019" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C019" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006")
);
var checkResult_TBC051 = 4;
if (checkInfoList_TBC051.Any())
{
checkResult_TBC051 = checkInfoList_TBC051.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC051 = 1;
}
var tbCheckItemDesc_TBC051 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC051);
if (tbCheckItemDesc_TBC051 != null)
tbCheckItemDetail_TBC051.CheckResult = tbCheckItemDesc_TBC051.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC051);
#endregion

#region 仪表台是否无划痕、配件是否无缺失
TbCheckItemDetail tbCheckItemDetail_TBC052 = new TbCheckItemDetail();
tbCheckItemDetail_TBC052.Name="仪表台是否无划痕、配件是否无缺失";
var checkInfoList_TBC052 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C087" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V004") ||
(s.PartCode.ToUpper() == "C087" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C087" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC052 = 4;
if (checkInfoList_TBC052.Any())
{
checkResult_TBC052 = checkInfoList_TBC052.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC052 = 1;
}
var tbCheckItemDesc_TBC052 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC052);
if (tbCheckItemDesc_TBC052 != null)
tbCheckItemDetail_TBC052.CheckResult = tbCheckItemDesc_TBC052.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC052);
#endregion

#region 天窗是否移动灵活、关闭正常
TbCheckItemDetail tbCheckItemDetail_TBC053 = new TbCheckItemDetail();
tbCheckItemDetail_TBC053.Name="天窗是否移动灵活、关闭正常";
var checkInfoList_TBC053 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C090" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C090" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V025") ||
(s.PartCode.ToUpper() == "C090" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V026")
);
var checkResult_TBC053 = 4;
if (checkInfoList_TBC053.Any())
{
checkResult_TBC053 = checkInfoList_TBC053.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC053 = 1;
}
var tbCheckItemDesc_TBC053 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC053);
if (tbCheckItemDesc_TBC053 != null)
tbCheckItemDetail_TBC053.CheckResult = tbCheckItemDesc_TBC053.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC053);
#endregion

#region 门窗密封条是否良好、无老化
TbCheckItemDetail tbCheckItemDetail_TBC054 = new TbCheckItemDetail();
tbCheckItemDetail_TBC054.Name="门窗密封条是否良好、无老化";
var checkInfoList_TBC054 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C032" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C032" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C032" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C032" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C032" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C032" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C032" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C032" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C032" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C032" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C032" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V007") ||
(s.PartCode.ToUpper() == "C032" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C037" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C037" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C037" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C037" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C037" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C037" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C037" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C037" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034") ||
(s.PartCode.ToUpper() == "C159" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C159" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034")
);
var checkResult_TBC054 = 4;
if (checkInfoList_TBC054.Any())
{
checkResult_TBC054 = checkInfoList_TBC054.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC054 = 1;
}
var tbCheckItemDesc_TBC054 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC054);
if (tbCheckItemDesc_TBC054 != null)
tbCheckItemDetail_TBC054.CheckResult = tbCheckItemDesc_TBC054.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC054);
#endregion

#region 安全带结构是否完整、功能是否正常
TbCheckItemDetail tbCheckItemDetail_TBC055 = new TbCheckItemDetail();
tbCheckItemDetail_TBC055.Name="安全带结构是否完整、功能是否正常";
var checkInfoList_TBC055 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C027" && s.PlaceCode.ToUpper() == "P02" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C027" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C027" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C195" && s.PlaceCode.ToUpper() == "P02" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C195" && s.PlaceCode.ToUpper() == "P01" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C195" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C195" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C027" && s.PlaceCode.ToUpper() == "P01" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006")
);
var checkResult_TBC055 = 4;
if (checkInfoList_TBC055.Any())
{
checkResult_TBC055 = checkInfoList_TBC055.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC055 = 1;
}
var tbCheckItemDesc_TBC055 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC055);
if (tbCheckItemDesc_TBC055 != null)
tbCheckItemDetail_TBC055.CheckResult = tbCheckItemDesc_TBC055.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC055);
#endregion

#region 驻车制动系统是否灵活有效
TbCheckItemDetail tbCheckItemDetail_TBC056 = new TbCheckItemDetail();
tbCheckItemDetail_TBC056.Name="驻车制动系统是否灵活有效";
var checkInfoList_TBC056 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C057" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024")
);
var checkResult_TBC056 = 4;
if (checkInfoList_TBC056.Any())
{
checkResult_TBC056 = checkInfoList_TBC056.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC056 = 1;
}
var tbCheckItemDesc_TBC056 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC056);
if (tbCheckItemDesc_TBC056 != null)
tbCheckItemDetail_TBC056.CheckResult = tbCheckItemDesc_TBC056.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC056);
#endregion

#region 玻璃窗升降器、门窗工作是否正常
TbCheckItemDetail tbCheckItemDetail_TBC057 = new TbCheckItemDetail();
tbCheckItemDetail_TBC057.Name="玻璃窗升降器、门窗工作是否正常";
var checkInfoList_TBC057 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V025") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V026") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V025") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V026") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V025") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V026") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V025") ||
(s.PartCode.ToUpper() == "C031" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V026")
);
var checkResult_TBC057 = 4;
if (checkInfoList_TBC057.Any())
{
checkResult_TBC057 = checkInfoList_TBC057.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC057 = 1;
}
var tbCheckItemDesc_TBC057 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC057);
if (tbCheckItemDesc_TBC057 != null)
tbCheckItemDetail_TBC057.CheckResult = tbCheckItemDesc_TBC057.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC057);
#endregion

return tbCheckModule;}
#endregion

#region 启动检查
private TbCheckModule Convert_TBRP005(CarReportModel carReportModel)
{
var tbCheckModule = new TbCheckModule();
tbCheckModule.Name = "启动检查";
#region 车辆启动是否顺畅（时间小于5秒，或一次启动）
TbCheckItemDetail tbCheckItemDetail_TBC058 = new TbCheckItemDetail();
tbCheckItemDetail_TBC058.Name="车辆启动是否顺畅（时间小于5秒，或一次启动）";
var checkInfoList_TBC058 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C136" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024")
);
var checkResult_TBC058 = 4;
if (checkInfoList_TBC058.Any())
{
checkResult_TBC058 = checkInfoList_TBC058.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC058 = 1;
}
var tbCheckItemDesc_TBC058 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC058);
if (tbCheckItemDesc_TBC058 != null)
tbCheckItemDetail_TBC058.CheckResult = tbCheckItemDesc_TBC058.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC058);
#endregion

#region 仪表板指示灯显示是否正常，无故障报警
TbCheckItemDetail tbCheckItemDetail_TBC059 = new TbCheckItemDetail();
tbCheckItemDetail_TBC059.Name="仪表板指示灯显示是否正常，无故障报警";
var checkInfoList_TBC059 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C214" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C215" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C216" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C217" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C207" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024")
);
var checkResult_TBC059 = 4;
if (checkInfoList_TBC059.Any())
{
checkResult_TBC059 = checkInfoList_TBC059.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC059 = 1;
}
var tbCheckItemDesc_TBC059 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC059);
if (tbCheckItemDesc_TBC059 != null)
tbCheckItemDetail_TBC059.CheckResult = tbCheckItemDesc_TBC059.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC059);
#endregion

#region 各类灯光和调节功能是否正常
TbCheckItemDetail tbCheckItemDetail_TBC060 = new TbCheckItemDetail();
tbCheckItemDetail_TBC060.Name="各类灯光和调节功能是否正常";
var checkInfoList_TBC060 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C078" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024")
);
var checkResult_TBC060 = 4;
if (checkInfoList_TBC060.Any())
{
checkResult_TBC060 = checkInfoList_TBC060.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC060 = 1;
}
var tbCheckItemDesc_TBC060 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC060);
if (tbCheckItemDesc_TBC060 != null)
tbCheckItemDetail_TBC060.CheckResult = tbCheckItemDesc_TBC060.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC060);
#endregion

#region 泊车辅助系统工作是否正常
TbCheckItemDetail tbCheckItemDetail_TBC061 = new TbCheckItemDetail();
tbCheckItemDetail_TBC061.Name="泊车辅助系统工作是否正常";
var checkInfoList_TBC061 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C051" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C052" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024")
);
var checkResult_TBC061 = 4;
if (checkInfoList_TBC061.Any())
{
checkResult_TBC061 = checkInfoList_TBC061.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC061 = 1;
}
var tbCheckItemDesc_TBC061 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC061);
if (tbCheckItemDesc_TBC061 != null)
tbCheckItemDetail_TBC061.CheckResult = tbCheckItemDesc_TBC061.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC061);
#endregion

#region 制动防抱死系统（ABS）工作是否正常
TbCheckItemDetail tbCheckItemDetail_TBC062 = new TbCheckItemDetail();
tbCheckItemDetail_TBC062.Name="制动防抱死系统（ABS）工作是否正常";
var checkInfoList_TBC062 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C218" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024")
);
var checkResult_TBC062 = 4;
if (checkInfoList_TBC062.Any())
{
checkResult_TBC062 = checkInfoList_TBC062.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC062 = 1;
}
var tbCheckItemDesc_TBC062 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC062);
if (tbCheckItemDesc_TBC062 != null)
tbCheckItemDetail_TBC062.CheckResult = tbCheckItemDesc_TBC062.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC062);
#endregion

#region 空调系统风量、方向调节、分区控制、自动控制、制冷工作是否正常
TbCheckItemDetail tbCheckItemDetail_TBC063 = new TbCheckItemDetail();
tbCheckItemDetail_TBC063.Name="空调系统风量、方向调节、分区控制、自动控制、制冷工作是否正常";
var checkInfoList_TBC063 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C180" && s.PlaceCode.ToUpper() == "P11" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C180" && s.PlaceCode.ToUpper() == "P18" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C075" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C148" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C148" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V026") ||
(s.PartCode.ToUpper() == "C148" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V028") ||
(s.PartCode.ToUpper() == "C149" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C149" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V026")
);
var checkResult_TBC063 = 4;
if (checkInfoList_TBC063.Any())
{
checkResult_TBC063 = checkInfoList_TBC063.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC063 = 1;
}
var tbCheckItemDesc_TBC063 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC063);
if (tbCheckItemDesc_TBC063 != null)
tbCheckItemDetail_TBC063.CheckResult = tbCheckItemDesc_TBC063.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC063);
#endregion

#region 发动机在冷、热车状态条件下怠速运转是否稳定
TbCheckItemDetail tbCheckItemDetail_TBC064 = new TbCheckItemDetail();
tbCheckItemDetail_TBC064.Name="发动机在冷、热车状态条件下怠速运转是否稳定";
var checkInfoList_TBC064 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "P226" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V029")
);
var checkResult_TBC064 = 4;
if (checkInfoList_TBC064.Any())
{
checkResult_TBC064 = checkInfoList_TBC064.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC064 = 1;
}
var tbCheckItemDesc_TBC064 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC064);
if (tbCheckItemDesc_TBC064 != null)
tbCheckItemDetail_TBC064.CheckResult = tbCheckItemDesc_TBC064.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC064);
#endregion

#region 怠速运转时发动机是否无异响，空挡状态下逐渐增加发动机转速，发动机声音过度是否无异响
TbCheckItemDetail tbCheckItemDetail_TBC065 = new TbCheckItemDetail();
tbCheckItemDetail_TBC065.Name="怠速运转时发动机是否无异响，空挡状态下逐渐增加发动机转速，发动机声音过度是否无异响";
var checkInfoList_TBC065 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C065" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V026")
);
var checkResult_TBC065 = 4;
if (checkInfoList_TBC065.Any())
{
checkResult_TBC065 = checkInfoList_TBC065.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC065 = 1;
}
var tbCheckItemDesc_TBC065 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC065);
if (tbCheckItemDesc_TBC065 != null)
tbCheckItemDetail_TBC065.CheckResult = tbCheckItemDesc_TBC065.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC065);
#endregion

#region 车辆排气是否无异常
TbCheckItemDetail tbCheckItemDetail_TBC066 = new TbCheckItemDetail();
tbCheckItemDetail_TBC066.Name="车辆排气是否无异常";
var checkInfoList_TBC066 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C065" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T05" && s.DValueCode.ToUpper()=="V030") ||
(s.PartCode.ToUpper() == "C065" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T05" && s.DValueCode.ToUpper()=="V031") ||
(s.PartCode.ToUpper() == "C065" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T05" && s.DValueCode.ToUpper()=="V032")
);
var checkResult_TBC066 = 4;
if (checkInfoList_TBC066.Any())
{
checkResult_TBC066 = checkInfoList_TBC066.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC066 = 1;
}
var tbCheckItemDesc_TBC066 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC066);
if (tbCheckItemDesc_TBC066 != null)
tbCheckItemDetail_TBC066.CheckResult = tbCheckItemDesc_TBC066.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC066);
#endregion

return tbCheckModule;}
#endregion

#region 底盘检查
private TbCheckModule Convert_TBRP006(CarReportModel carReportModel)
{
var tbCheckModule = new TbCheckModule();
tbCheckModule.Name = "底盘检查";
#region 发动机油底壳是否无渗漏
TbCheckItemDetail tbCheckItemDetail_TBC067 = new TbCheckItemDetail();
tbCheckItemDetail_TBC067.Name="发动机油底壳是否无渗漏";
var checkInfoList_TBC067 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C065" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V009")
);
var checkResult_TBC067 = 4;
if (checkInfoList_TBC067.Any())
{
checkResult_TBC067 = checkInfoList_TBC067.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC067 = 1;
}
var tbCheckItemDesc_TBC067 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC067);
if (tbCheckItemDesc_TBC067 != null)
tbCheckItemDetail_TBC067.CheckResult = tbCheckItemDesc_TBC067.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC067);
#endregion

#region 变速箱体是否无渗漏
TbCheckItemDetail tbCheckItemDetail_TBC068 = new TbCheckItemDetail();
tbCheckItemDetail_TBC068.Name="变速箱体是否无渗漏";
var checkInfoList_TBC068 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C070" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V028") ||
(s.PartCode.ToUpper() == "C069" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V028")
);
var checkResult_TBC068 = 4;
if (checkInfoList_TBC068.Any())
{
checkResult_TBC068 = checkInfoList_TBC068.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC068 = 1;
}
var tbCheckItemDesc_TBC068 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC068);
if (tbCheckItemDesc_TBC068 != null)
tbCheckItemDetail_TBC068.CheckResult = tbCheckItemDesc_TBC068.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC068);
#endregion

#region 转向节臂球销是否无松动
TbCheckItemDetail tbCheckItemDetail_TBC069 = new TbCheckItemDetail();
tbCheckItemDetail_TBC069.Name="转向节臂球销是否无松动";
tbCheckItemDetail_TBC069.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC069);
#endregion

#region 三角臂球销是否无松动
TbCheckItemDetail tbCheckItemDetail_TBC070 = new TbCheckItemDetail();
tbCheckItemDetail_TBC070.Name="三角臂球销是否无松动";
tbCheckItemDetail_TBC070.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC070);
#endregion

#region 传动轴十字轴是否无松动
TbCheckItemDetail tbCheckItemDetail_TBC071 = new TbCheckItemDetail();
tbCheckItemDetail_TBC071.Name="传动轴十字轴是否无松动";
tbCheckItemDetail_TBC071.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC071);
#endregion

#region 减震器是否无渗漏
TbCheckItemDetail tbCheckItemDetail_TBC072 = new TbCheckItemDetail();
tbCheckItemDetail_TBC072.Name="减震器是否无渗漏";
tbCheckItemDetail_TBC072.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC072);
#endregion

#region 减震弹簧是否无损坏
TbCheckItemDetail tbCheckItemDetail_TBC073 = new TbCheckItemDetail();
tbCheckItemDetail_TBC073.Name="减震弹簧是否无损坏";
tbCheckItemDetail_TBC073.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC073);
#endregion

#region 发动机运转、加速是否正常
TbCheckItemDetail tbCheckItemDetail_TBC074 = new TbCheckItemDetail();
tbCheckItemDetail_TBC074.Name="发动机运转、加速是否正常";
tbCheckItemDetail_TBC074.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC074);
#endregion

#region 车辆启动前踩下制动踏板、保持5-10秒钟，踏板无向下移动的现象
TbCheckItemDetail tbCheckItemDetail_TBC075 = new TbCheckItemDetail();
tbCheckItemDetail_TBC075.Name="车辆启动前踩下制动踏板、保持5-10秒钟，踏板无向下移动的现象";
tbCheckItemDetail_TBC075.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC075);
#endregion

#region 踩住制动踏板启动发动机，踏板是否向下移动
TbCheckItemDetail tbCheckItemDetail_TBC076 = new TbCheckItemDetail();
tbCheckItemDetail_TBC076.Name="踩住制动踏板启动发动机，踏板是否向下移动";
tbCheckItemDetail_TBC076.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC076);
#endregion

return tbCheckModule;}
#endregion

#region 路试检查
private TbCheckModule Convert_TBRP007(CarReportModel carReportModel)
{
var tbCheckModule = new TbCheckModule();
tbCheckModule.Name = "路试检查";
#region 行车制动最大制动效能在踏板全行程的4/5以内达到
TbCheckItemDetail tbCheckItemDetail_TBC077 = new TbCheckItemDetail();
tbCheckItemDetail_TBC077.Name="行车制动最大制动效能在踏板全行程的4/5以内达到";
tbCheckItemDetail_TBC077.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC077);
#endregion

#region 形式是否无跑偏
TbCheckItemDetail tbCheckItemDetail_TBC078 = new TbCheckItemDetail();
tbCheckItemDetail_TBC078.Name="形式是否无跑偏";
tbCheckItemDetail_TBC078.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC078);
#endregion

#region 制动系统工作是否正常有效、制动不跑偏
TbCheckItemDetail tbCheckItemDetail_TBC079 = new TbCheckItemDetail();
tbCheckItemDetail_TBC079.Name="制动系统工作是否正常有效、制动不跑偏";
tbCheckItemDetail_TBC079.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC079);
#endregion

#region 变速箱工作是否正常、无异响
TbCheckItemDetail tbCheckItemDetail_TBC080 = new TbCheckItemDetail();
tbCheckItemDetail_TBC080.Name="变速箱工作是否正常、无异响";
var checkInfoList_TBC080 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C070" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V026") ||
(s.PartCode.ToUpper() == "C069" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V026")
);
var checkResult_TBC080 = 4;
if (checkInfoList_TBC080.Any())
{
checkResult_TBC080 = checkInfoList_TBC080.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC080 = 1;
}
var tbCheckItemDesc_TBC080 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC080);
if (tbCheckItemDesc_TBC080 != null)
tbCheckItemDetail_TBC080.CheckResult = tbCheckItemDesc_TBC080.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC080);
#endregion

#region 行驶过程中车辆底盘部位是否无异响
TbCheckItemDetail tbCheckItemDetail_TBC081 = new TbCheckItemDetail();
tbCheckItemDetail_TBC081.Name="行驶过程中车辆底盘部位是否无异响";
var checkInfoList_TBC081 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "P229" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V026")
);
var checkResult_TBC081 = 4;
if (checkInfoList_TBC081.Any())
{
checkResult_TBC081 = checkInfoList_TBC081.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC081 = 1;
}
var tbCheckItemDesc_TBC081 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC081);
if (tbCheckItemDesc_TBC081 != null)
tbCheckItemDetail_TBC081.CheckResult = tbCheckItemDesc_TBC081.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC081);
#endregion

#region 行驶过程中车辆转向部位是否无异响
TbCheckItemDetail tbCheckItemDetail_TBC082 = new TbCheckItemDetail();
tbCheckItemDetail_TBC082.Name="行驶过程中车辆转向部位是否无异响";
var checkInfoList_TBC082 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C053" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V026")
);
var checkResult_TBC082 = 4;
if (checkInfoList_TBC082.Any())
{
checkResult_TBC082 = checkInfoList_TBC082.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC082 = 1;
}
var tbCheckItemDesc_TBC082 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC082);
if (tbCheckItemDesc_TBC082 != null)
tbCheckItemDetail_TBC082.CheckResult = tbCheckItemDesc_TBC082.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC082);
#endregion

return tbCheckModule;}
#endregion

#region 功能性零部件
private TbCheckModule Convert_TBRP008(CarReportModel carReportModel)
{
var tbCheckModule = new TbCheckModule();
tbCheckModule.Name = "功能性零部件";
#region 发动机舱盖锁止
TbCheckItemDetail tbCheckItemDetail_TBC083 = new TbCheckItemDetail();
tbCheckItemDetail_TBC083.Name="发动机舱盖锁止";
var checkInfoList_TBC083 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C170" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024")
);
var checkResult_TBC083 = 4;
if (checkInfoList_TBC083.Any())
{
checkResult_TBC083 = checkInfoList_TBC083.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC083 = 1;
}
var tbCheckItemDesc_TBC083 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC083);
if (tbCheckItemDesc_TBC083 != null)
tbCheckItemDetail_TBC083.CheckResult = tbCheckItemDesc_TBC083.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC083);
#endregion

#region 发动机舱盖液压撑杆
TbCheckItemDetail tbCheckItemDetail_TBC084 = new TbCheckItemDetail();
tbCheckItemDetail_TBC084.Name="发动机舱盖液压撑杆";
var checkInfoList_TBC084 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C169" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C169" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V028") ||
(s.PartCode.ToUpper() == "C169" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034")
);
var checkResult_TBC084 = 4;
if (checkInfoList_TBC084.Any())
{
checkResult_TBC084 = checkInfoList_TBC084.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC084 = 1;
}
var tbCheckItemDesc_TBC084 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC084);
if (tbCheckItemDesc_TBC084 != null)
tbCheckItemDetail_TBC084.CheckResult = tbCheckItemDesc_TBC084.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC084);
#endregion

#region 后门\后备箱液压支撑杆
TbCheckItemDetail tbCheckItemDetail_TBC085 = new TbCheckItemDetail();
tbCheckItemDetail_TBC085.Name="后门\后备箱液压支撑杆";
var checkInfoList_TBC085 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C222" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C222" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V028") ||
(s.PartCode.ToUpper() == "C222" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C222" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034")
);
var checkResult_TBC085 = 4;
if (checkInfoList_TBC085.Any())
{
checkResult_TBC085 = checkInfoList_TBC085.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC085 = 1;
}
var tbCheckItemDesc_TBC085 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC085);
if (tbCheckItemDesc_TBC085 != null)
tbCheckItemDetail_TBC085.CheckResult = tbCheckItemDesc_TBC085.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC085);
#endregion

#region 各车门锁止
TbCheckItemDetail tbCheckItemDetail_TBC086 = new TbCheckItemDetail();
tbCheckItemDetail_TBC086.Name="各车门锁止";
var checkInfoList_TBC086 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C040" && s.PlaceCode.ToUpper() == "P08" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C040" && s.PlaceCode.ToUpper() == "P07" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C040" && s.PlaceCode.ToUpper() == "P09" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C040" && s.PlaceCode.ToUpper() == "P10" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024")
);
var checkResult_TBC086 = 4;
if (checkInfoList_TBC086.Any())
{
checkResult_TBC086 = checkInfoList_TBC086.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC086 = 1;
}
var tbCheckItemDesc_TBC086 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC086);
if (tbCheckItemDesc_TBC086 != null)
tbCheckItemDetail_TBC086.CheckResult = tbCheckItemDesc_TBC086.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC086);
#endregion

#region 前后雨刷器
TbCheckItemDetail tbCheckItemDetail_TBC087 = new TbCheckItemDetail();
tbCheckItemDetail_TBC087.Name="前后雨刷器";
var checkInfoList_TBC087 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C103" && s.PlaceCode.ToUpper() == "P12" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C103" && s.PlaceCode.ToUpper() == "P12" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024") ||
(s.PartCode.ToUpper() == "C103" && s.PlaceCode.ToUpper() == "P14" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C103" && s.PlaceCode.ToUpper() == "P14" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024")
);
var checkResult_TBC087 = 4;
if (checkInfoList_TBC087.Any())
{
checkResult_TBC087 = checkInfoList_TBC087.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC087 = 1;
}
var tbCheckItemDesc_TBC087 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC087);
if (tbCheckItemDesc_TBC087 != null)
tbCheckItemDetail_TBC087.CheckResult = tbCheckItemDesc_TBC087.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC087);
#endregion

#region 立柱密封胶条
TbCheckItemDetail tbCheckItemDetail_TBC088 = new TbCheckItemDetail();
tbCheckItemDetail_TBC088.Name="立柱密封胶条";
tbCheckItemDetail_TBC088.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC088);
#endregion

#region 排气管及消音器
TbCheckItemDetail tbCheckItemDetail_TBC089 = new TbCheckItemDetail();
tbCheckItemDetail_TBC089.Name="排气管及消音器";
var checkInfoList_TBC089 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C141" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C141" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C141" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C141" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033") ||
(s.PartCode.ToUpper() == "C139" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V001") ||
(s.PartCode.ToUpper() == "C139" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V005") ||
(s.PartCode.ToUpper() == "C139" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C139" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V033")
);
var checkResult_TBC089 = 4;
if (checkInfoList_TBC089.Any())
{
checkResult_TBC089 = checkInfoList_TBC089.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC089 = 1;
}
var tbCheckItemDesc_TBC089 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC089);
if (tbCheckItemDesc_TBC089 != null)
tbCheckItemDetail_TBC089.CheckResult = tbCheckItemDesc_TBC089.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC089);
#endregion

#region 车轮车毂
TbCheckItemDetail tbCheckItemDetail_TBC090 = new TbCheckItemDetail();
tbCheckItemDetail_TBC090.Name="车轮车毂";
tbCheckItemDetail_TBC090.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC090);
#endregion

#region 车内后视镜
TbCheckItemDetail tbCheckItemDetail_TBC091 = new TbCheckItemDetail();
tbCheckItemDetail_TBC091.Name="车内后视镜";
tbCheckItemDetail_TBC091.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC091);
#endregion

#region 座椅调节
TbCheckItemDetail tbCheckItemDetail_TBC092 = new TbCheckItemDetail();
tbCheckItemDetail_TBC092.Name="座椅调节";
tbCheckItemDetail_TBC092.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC092);
#endregion

#region 仪表板出风管道
TbCheckItemDetail tbCheckItemDetail_TBC093 = new TbCheckItemDetail();
tbCheckItemDetail_TBC093.Name="仪表板出风管道";
tbCheckItemDetail_TBC093.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC093);
#endregion

#region 中央集控
TbCheckItemDetail tbCheckItemDetail_TBC094 = new TbCheckItemDetail();
tbCheckItemDetail_TBC094.Name="中央集控";
tbCheckItemDetail_TBC094.CheckResult = 4;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC094);
#endregion

#region 备胎
TbCheckItemDetail tbCheckItemDetail_TBC095 = new TbCheckItemDetail();
tbCheckItemDetail_TBC095.Name="备胎";
var checkInfoList_TBC095 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C029" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T01" && s.DValueCode.ToUpper()=="V006") ||
(s.PartCode.ToUpper() == "C029" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034")
);
var checkResult_TBC095 = 4;
if (checkInfoList_TBC095.Any())
{
checkResult_TBC095 = checkInfoList_TBC095.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC095 = 1;
}
var tbCheckItemDesc_TBC095 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC095);
if (tbCheckItemDesc_TBC095 != null)
tbCheckItemDetail_TBC095.CheckResult = tbCheckItemDesc_TBC095.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC095);
#endregion

#region 千斤顶
TbCheckItemDetail tbCheckItemDetail_TBC096 = new TbCheckItemDetail();
tbCheckItemDetail_TBC096.Name="千斤顶";
var checkInfoList_TBC096 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C124" && s.PlaceCode.ToUpper() == "P17" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034")
);
var checkResult_TBC096 = 4;
if (checkInfoList_TBC096.Any())
{
checkResult_TBC096 = checkInfoList_TBC096.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC096 = 1;
}
var tbCheckItemDesc_TBC096 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC096);
if (tbCheckItemDesc_TBC096 != null)
tbCheckItemDetail_TBC096.CheckResult = tbCheckItemDesc_TBC096.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC096);
#endregion

#region 轮胎扳手及随车工具
TbCheckItemDetail tbCheckItemDetail_TBC097 = new TbCheckItemDetail();
tbCheckItemDetail_TBC097.Name="轮胎扳手及随车工具";
var checkInfoList_TBC097 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "P233" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034")
);
var checkResult_TBC097 = 4;
if (checkInfoList_TBC097.Any())
{
checkResult_TBC097 = checkInfoList_TBC097.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC097 = 1;
}
var tbCheckItemDesc_TBC097 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC097);
if (tbCheckItemDesc_TBC097 != null)
tbCheckItemDetail_TBC097.CheckResult = tbCheckItemDesc_TBC097.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC097);
#endregion

#region 三角警示牌
TbCheckItemDetail tbCheckItemDetail_TBC098 = new TbCheckItemDetail();
tbCheckItemDetail_TBC098.Name="三角警示牌";
var checkInfoList_TBC098 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C122" && s.PlaceCode.ToUpper() == "P17" && s.DefectCode.ToUpper() == "T06" && s.DValueCode.ToUpper()=="V034")
);
var checkResult_TBC098 = 4;
if (checkInfoList_TBC098.Any())
{
checkResult_TBC098 = checkInfoList_TBC098.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC098 = 1;
}
var tbCheckItemDesc_TBC098 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC098);
if (tbCheckItemDesc_TBC098 != null)
tbCheckItemDetail_TBC098.CheckResult = tbCheckItemDesc_TBC098.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC098);
#endregion

#region 遥控器及功能
TbCheckItemDetail tbCheckItemDetail_TBC099 = new TbCheckItemDetail();
tbCheckItemDetail_TBC099.Name="遥控器及功能";
var checkInfoList_TBC099 = carReportModel.CheckInfoTotalList.Where(
s =>(s.PartCode.ToUpper() == "C054" && s.PlaceCode.ToUpper() == "P00" && s.DefectCode.ToUpper() == "T04" && s.DValueCode.ToUpper()=="V024")
);
var checkResult_TBC099 = 4;
if (checkInfoList_TBC099.Any())
{
checkResult_TBC099 = checkInfoList_TBC099.Any(s => !string.IsNullOrEmpty(s.ConfValue)) ? 1 : 2;
}
else
{
//没有认为是没问题
 checkResult_TBC099 = 1;
}
var tbCheckItemDesc_TBC099 = tbCheckModule.TbCheckItemDescs.FirstOrDefault(s => s.Key == checkResult_TBC099);
if (tbCheckItemDesc_TBC099 != null)
tbCheckItemDetail_TBC099.CheckResult = tbCheckItemDesc_TBC099.Key;
tbCheckModule.TbCheckItemDetails.Add(tbCheckItemDetail_TBC099);
#endregion

return tbCheckModule;}
#endregion

