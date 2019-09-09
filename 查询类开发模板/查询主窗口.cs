using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 查询类开发模板vb.net版;

namespace 查询类开发模板
{
    public partial class 查询主窗口 : Form
    {
         查询主窗口Base  Base1 = new 查询主窗口Base();
        public 查询主窗口()
        {
            InitializeComponent();
            DataGridView1.当前用户名 = Bus_DataBus.Bus_CurrentUser_Fullname;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            用户全名.Text = "当前用户：" + Bus_DataBus.Bus_CurrentUser_Fullname;
            panel2.Visible = false;
            ComboBox1.DataSource = Base1.Get查询仓库权限(SyERP20.DataBus.bus_CurrentUser_dept);
            if (ComboBox1.Items.Count > 0)
            {
                ComboBox1.SelectedIndex = 0;
            }
            doSelect();
        }

        #region "业务链接"
        public void doSelect()
        {
            Panel_正在执行.Visible = true;
            try
            {
                DataTable dt = null;
                string where = "";
                if (关键字.Text!="")
                {
                    where += " and (code like '%" + 关键字 + "%' or code like '%" + 关键字.Text + "%'   or batchnumber like '%" + 关键字.Text + "%')  ";
                }
                if (textBox1.Text!="")
                {
                  
                        where += " and zf1 like '%" + textBox1.Text + "%'  ";
                  
                   
                }
                if (textBox2.Text != "")
                {
                  
                        where += " and zf2 like '%" + textBox2.Text + "%'  ";
                   
                }
                if (textBox3.Text != "")
                {

                    where += " and batchnumber like '%" + textBox3.Text + "%'  ";

                }
                if (ComboBox1.Text != "")
                {

                    where += " and storagename like '%" + ComboBox1.Text + "%'  ";

                }
               if (CheckBox1.Checked != true)
                {

                    where += " and quantity<>0  ";

                }

               
                dt = Base1.Get查询(where );
              
                DataGridView1.DataSource = dt;
                //加入列宽定义
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkCancel, "");
            }
            Panel_正在执行.Visible = false;

        }
        public void doSelect(string 颜色,string 品牌,string 批次,string 编码)
        {
            Panel_正在执行.Visible = true;
            try
            {
                DataTable dt = null;
                string where = "";
                where += " and materialcode ='" + 编码 + "'   and isnull(batchnumber,'')  = '" + 批次 + "'  ";
                    where += " and isnull(definestr1,'') = '" + 颜色 + "'  ";
                    where += " and isnull(definestr6,'') = '" + 品牌 + "'  ";
                    dt = Base1.Get查询台账(where);
                  
                
                DataRow dr = dt.NewRow();
                    dr["货物代码"] = "合计";
                    dr["数量"] = dt.Compute(" sum(数量) ", "");
                    dt.Rows.Add(dr.ItemArray);

                rowMergeView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.OkCancel, "");
            }
            Panel_正在执行.Visible = false;

        }
        #endregion

        #region "Form窗口事件"
        private void but_查询_Click(object sender, EventArgs e)
        {
            doSelect();
        }
        private void but_左侧显示_Click(object sender, EventArgs e)
        {
            SplitContainer1.Panel1Collapsed = !SplitContainer1.Panel1Collapsed;
        }
        private void but_导出EXCEL_Click(object sender, EventArgs e)
        {

            SyERP20.CodeFunciton.导出EXCELByNPOI(DataGridView1, new Label(),"查询窗口",true,false  );
        }
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            SyERP20.SelectForm aaa = new SyERP20.SelectForm(new SyERP20.SelectFormBase(), "kfku", "", "",false);
            aaa.ShowDialog ();
        }

        private void Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                doSelect(DataGridView1.Rows[e.RowIndex].Cells["颜色"].Value.ToString(), DataGridView1.Rows[e.RowIndex].Cells["品牌"].Value.ToString(), DataGridView1.Rows[e.RowIndex].Cells["批号"].Value.ToString(), DataGridView1.Rows[e.RowIndex].Cells["货物代码"].Value.ToString());
                 panel2.Visible = true ;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false ;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            doSelect();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            批次报表查询 fw = new 批次报表查询();
            fw.ShowDialog();
        }
    }
}