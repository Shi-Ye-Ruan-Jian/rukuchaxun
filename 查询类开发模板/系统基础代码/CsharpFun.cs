using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace 查询类开发模板
{
    class CsharpFun
    {
        public static bool IsNumberic(string oText)
        {
            try
            {
                Decimal Number = Convert.ToDecimal(oText);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
