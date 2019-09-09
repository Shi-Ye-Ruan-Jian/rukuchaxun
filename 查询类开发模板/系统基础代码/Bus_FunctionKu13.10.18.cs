using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using SyERP.DAL;
namespace 查询类开发模板
{

static class Bus_FunctionKu
{
 #region "与数据库没有关连的函数库"
 //***************************************************
 //功能：用于导出到EXCEL文件中 梁晓东
    //***************************************************
 #endregion

   

 #region "【数据库有关】用户及权限类的函数库"
 //***************************************************
 //功能：用于获得Bus_CurrentUser_Code
 //***************************************************
 public static string getBus_CurrentUser_Code()
 {
  string t = "";
  using (SQLServer db = new SQLServer(SqlStr.ConnStringBuilder.ConnectionString)) {
   t = db.GetStrBySQL("select code from puku where userpu='" + Bus_DataBus.Bus_CurrentUser_Username + "'");
  }
  return t;
 }
 //***************************************************
 //功能：用于获得Bus_CurrentUser_GroupCode
 //***************************************************
 public static string getBus_CurrentUser_GroupCode()
 {
  string t = "";
  using (SQLServer db = new SQLServer(SqlStr.ConnStringBuilder.ConnectionString)) {
   t = db.GetStrBySQL("select code from puku where userpu='" + Bus_DataBus.Bus_CurrentUser_Username + "'");
  }
  return t;
 }
 //***************************************************
 //功能：用于获得Bus_DataBus.Bus_CurrentUser_Fullname
 //***************************************************
 public static string getBus_CurrentUser_Fullname()
 {
  string t = "";
  using (SQLServer db = new SQLServer(SqlStr.ConnStringBuilder.ConnectionString)) {
   t = db.GetStrBySQL("select turename from puku where userpu='" + Bus_DataBus.Bus_CurrentUser_Username + "'");
  }
  return t;
 }
 //***************************************************
 //功能：用于获得Bus_CurrentUser_deptName
 //***************************************************
 public static string getBus_CurrentUser_deptName()
 {
  string t = "";
  using (SQLServer db = new SQLServer(SqlStr.ConnStringBuilder.ConnectionString)) {
   t = db.GetStrBySQL("select dept from puku where userpu='" + Bus_DataBus.Bus_CurrentUser_Username + "'");
  }
  return t;
 }
 #endregion
}

}
