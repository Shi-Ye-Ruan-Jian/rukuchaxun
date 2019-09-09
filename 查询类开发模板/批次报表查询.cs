using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 查询类开发模板;

namespace 查询类开发模板vb.net版
{
    public partial class 批次报表查询 : Form
    {
        批次报表查询Base Base1 = new 批次报表查询Base();
        public 批次报表查询()
        {
            InitializeComponent();
        }

        private void 批次报表查询_Load(object sender, EventArgs e)
        {
            DataGridView1.当前用户名  = Bus_DataBus.Bus_CurrentUser_Fullname;
            ComboBox1.DataSource = Base1.Get查询仓库权限(SyERP20.DataBus.bus_CurrentUser_dept);
            if (ComboBox1.Items.Count > 0)
            {
                ComboBox1.SelectedIndex = 0;
            }
            doSelect();
        }

        private void But_导出EXCEL_Click(object sender, EventArgs e)
        {

            SyERP20.CodeFunciton.导出EXCELByNPOI(DataGridView1, new Label(), "查询窗口", true, false);
        }

        private void But_查询_Click(object sender, EventArgs e)
        {
            doSelect();
        }
        public void doSelect()
        {
            try
            {
                DataTable dt = null;
                string where = "";
                if (ComboBox1.Text != "")
                {

                    where = ComboBox1.Text ;

                }
                dt = Base1.Get查询(where, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"));
                DataGridView1.DataSource = dt;
                DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
                //加入列宽定义
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkCancel, "");
            }

        }
    }
}
