using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 查询类开发模板
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //通用块.初始化数据库连接，本配置文件中获得连接串(以下共3行代码),以下代码请不要随意修改；梁晓东
            SyERP.DAL.SqlStr tt = new SyERP.DAL.SqlStr();
                tt.ReadSqlServerPath();
                SyERP.DAL.SqlStr.TestMaiConn();
                SyERP.DAL.SqlStr.TestChuConn();
                //连接主应用连接(以下共3行代码)
                SyERP20.接口程序说明Base t2 = new SyERP20.接口程序说明Base();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                t2.IniSales();
               Bus_DataBus.SystemIniFromDB();
                //验证用户名(以下共18行代码)
                string[] Argr = Environment.GetCommandLineArgs();
                if (Argr.Length >= 2)
                {
                    Bus_DataBus.Bus_CurrentUser_Username = Argr[1];
                }
                else
                {
                    Bus_DataBus.Bus_CurrentUser_Username = "admin";
                }
                Bus_DataBus.Bus_CurrentUser_Fullname = Bus_FunctionKu.getBus_CurrentUser_Fullname();
                Bus_DataBus.Bus_CurrentUser_Code = Bus_FunctionKu.getBus_CurrentUser_Code();
                Bus_DataBus.Bus_CurrentUser_GroupName = Bus_FunctionKu.getBus_CurrentUser_deptName();
               if (string.IsNullOrEmpty(Bus_DataBus.Bus_CurrentUser_Fullname))
                {
                    SyERP20.ErrorForm err = new SyERP20.ErrorForm("没有用户验证！无法直接启动程序！", null);
                    err.ShowDialog();
                    System.Environment.Exit(0);
                }
                t2.setuser(Bus_DataBus.Bus_CurrentUser_Code, Bus_DataBus.Bus_CurrentUser_Username, Bus_DataBus.Bus_CurrentUser_Fullname, Bus_DataBus.Bus_CurrentUser_GroupName);
            //结束通用块,以上代码请不要随意修改；梁晓东
                Application.Run(new 查询主窗口 ());
        }
    }
}