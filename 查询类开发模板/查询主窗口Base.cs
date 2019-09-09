using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SyERP.DAL;
using Microsoft.VisualBasic;
using System.Collections;

namespace 查询类开发模板
{
    class 查询主窗口Base
    {
        public ArrayList Get查询仓库权限(string storagenamespell)
        {
            ArrayList dt = null;
            try
            {
                using (SQLServer db = new SQLServer(SqlStr.ConnStringBuilder.ConnectionString))
                {
                    dt = db.GetArraylistBySQL("select name from ORaiKu where 1=1 and storagenamespell not like '%" + storagenamespell + "%'  ");
                    db.Dispose();
                }
            }
            catch (Exception ex)
            {
            }
            return dt;
        }
        public DataTable Get查询(string Where)
        {
            DataTable dt = null;
            try
            {
                using (SQLServer db = new SQLServer(SqlStr.ConnStringBuilder.ConnectionString))
                {
                    dt = db.GetDataSetBySQL("select code as 货物代码,storagename as 仓库,(select materialname from dangdangpuku where code=a.code) as 货物名称 ,(select specs from dangdangpuku where code=a.code) as 规格描述 ,convert(real, quantity) as 数量,zf1 as 颜色,zf2 as 品牌,(select ZF22 from dangdangpuku where code=a.code) AS 粘度,(select ZF23 from dangdangpuku where code=a.code) AS 板厚,(select ZF25 from dangdangpuku where code=a.code) AS 长度,(select ZF24 from dangdangpuku where code=a.code) AS 宽度,batchnumber as 批号  from dangdangkuQtyby物料 a where 1=1 " + Where, "noname").Tables[0];
                    db.Dispose();
                }
            }
            catch (Exception ex)
            {
            }
            return dt;
        }
        public DataTable Get查询台账(string Where)
        {
            DataTable dt = null;
            try
            {
                using (SQLServer db = new SQLServer(SqlStr.ConnStringBuilder.ConnectionString))
                {
                    dt = db.GetDataSetBySQL("select code as 单号,materialCODE as 货物代码,materialNAME as 货物名称,SPECS as 规格,UNITNAME as 单位,QUANTITY as 数量,definestr1 as 颜色,definestr2,definestr3,definestr4,definestr5,definestr6 as 品牌,batchnumber as 批号 from (select code ,materialCODE,materialNAME,SPECS,UNITNAME,QUANTITY,definestr1,definestr2,definestr3,definestr4,definestr5,definestr6,batchnumber  from RukuKu a union all select code ,materialCODE,materialNAME,SPECS,UNITNAME,-QUANTITY,definestr1,definestr2,definestr3,definestr4,definestr5,definestr6,batchnumber  from cukuKu b union all select code ,materialCODE,materialNAME,SPECS,UNITNAME,-QUANTITY,definestr1,definestr2,definestr3,definestr4,definestr5,definestr6,batchnumber  from CheckStockku  f ) c where 1=1 and  left(code,1)<>'*'" + Where, "noname").Tables[0];
                    db.Dispose();
                }
            }
            catch (Exception ex)
            {
            }
            return dt;
        }
        //生成要显示出来的字段清单  GridVisible='1'
        public string SqlField(string biaopu)
        {
            System.Data.SqlClient.SqlDataReader Dr = null;
            using (SQLServer db = new SQLServer(SqlStr.ConnStringBuilder.ConnectionString))
            {
                Dr = db.GetDataReaderBySQL("select * from qianbuNiangbiao where biaopu='" + biaopu + "'  order by Gridorder");
                string SqlFieldStr = "id ";
                while (Dr.Read())
                {
                    if (Information.IsDBNull(Dr["GridVisible"]))
                        continue;
                    if (Dr["GridVisible"].ToString() == "1")
                    {
                        SqlFieldStr += " , " + Dr["ziduanpu"].ToString() + " as " + Dr["ziduandisplay"].ToString() + " ";
                    }
                }
                return SqlFieldStr;
                db.Dispose();
            }
        }

    }
}
