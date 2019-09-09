namespace 查询类开发模板vb.net版
{
    partial class 批次报表查询
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(批次报表查询));
            this.Panel8 = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbl_标题 = new System.Windows.Forms.Label();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.but_导出EXCEL = new System.Windows.Forms.ToolStripButton();
            this.DataGridView1 = new RowMergeView();
            this.but_查询 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.Panel8.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.ToolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel8
            // 
            this.Panel8.BackColor = System.Drawing.Color.SlateGray;
            this.Panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel8.BackgroundImage")));
            this.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel8.Controls.Add(this.Panel1);
            this.Panel8.Controls.Add(this.lbl_标题);
            this.Panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel8.Location = new System.Drawing.Point(0, 0);
            this.Panel8.Margin = new System.Windows.Forms.Padding(4);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(1368, 60);
            this.Panel8.TabIndex = 60;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel1.Location = new System.Drawing.Point(925, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(443, 60);
            this.Panel1.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(4, 19);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(410, 24);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "视野软件—电气行业管理软件供应商";
            // 
            // lbl_标题
            // 
            this.lbl_标题.AutoSize = true;
            this.lbl_标题.BackColor = System.Drawing.Color.Transparent;
            this.lbl_标题.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_标题.ForeColor = System.Drawing.Color.White;
            this.lbl_标题.Location = new System.Drawing.Point(16, 19);
            this.lbl_标题.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_标题.Name = "lbl_标题";
            this.lbl_标题.Size = new System.Drawing.Size(160, 24);
            this.lbl_标题.TabIndex = 1;
            this.lbl_标题.Text = "批次报表查询";
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.but_导出EXCEL});
            this.ToolStrip2.Location = new System.Drawing.Point(0, 60);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip2.Size = new System.Drawing.Size(1368, 27);
            this.ToolStrip2.TabIndex = 61;
            this.ToolStrip2.Text = "ToolStrip2";
            // 
            // but_导出EXCEL
            // 
            this.but_导出EXCEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.but_导出EXCEL.Name = "but_导出EXCEL";
            this.but_导出EXCEL.Size = new System.Drawing.Size(80, 24);
            this.but_导出EXCEL.Text = "导出Excel";
            this.but_导出EXCEL.Click += new System.EventHandler(this.But_导出EXCEL_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 136);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.DataGridView1.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("DataGridView1.MergeColumnNames")));
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.Size = new System.Drawing.Size(1368, 659);
            this.DataGridView1.TabIndex = 63;
            this.DataGridView1.当前用户名 = null;
            this.DataGridView1.管理列的对应表名称 = "dangdangkuQtyby物料";
            this.DataGridView1.管理列的控件库名称 = "dangdangkuQtyby历史报表";
            // 
            // but_查询
            // 
            this.but_查询.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_查询.Location = new System.Drawing.Point(875, 9);
            this.but_查询.Margin = new System.Windows.Forms.Padding(4);
            this.but_查询.Name = "but_查询";
            this.but_查询.Size = new System.Drawing.Size(85, 31);
            this.but_查询.TabIndex = 56;
            this.but_查询.Text = "查询(C)";
            this.but_查询.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_查询.UseVisualStyleBackColor = true;
            this.but_查询.Click += new System.EventHandler(this.But_查询_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(106, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker1.TabIndex = 75;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(411, 11);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 25);
            this.dateTimePicker2.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 77;
            this.label5.Text = "开始时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(322, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 78;
            this.label8.Text = "结束时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(635, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 79;
            this.label7.Text = "仓库：";
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(695, 13);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(155, 23);
            this.ComboBox1.TabIndex = 80;
            // 
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.Color.Lavender;
            this.Panel9.Controls.Add(this.ComboBox1);
            this.Panel9.Controls.Add(this.label7);
            this.Panel9.Controls.Add(this.label8);
            this.Panel9.Controls.Add(this.label5);
            this.Panel9.Controls.Add(this.dateTimePicker2);
            this.Panel9.Controls.Add(this.dateTimePicker1);
            this.Panel9.Controls.Add(this.but_查询);
            this.Panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel9.Location = new System.Drawing.Point(0, 87);
            this.Panel9.Margin = new System.Windows.Forms.Padding(4);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(1368, 49);
            this.Panel9.TabIndex = 62;
            // 
            // 批次报表查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 795);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Panel9);
            this.Controls.Add(this.ToolStrip2);
            this.Controls.Add(this.Panel8);
            this.Name = "批次报表查询";
            this.Text = "批次报表查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.批次报表查询_Load);
            this.Panel8.ResumeLayout(false);
            this.Panel8.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel9.ResumeLayout(false);
            this.Panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel8;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lbl_标题;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
        internal System.Windows.Forms.ToolStripButton but_导出EXCEL;
        private RowMergeView DataGridView1;
        internal System.Windows.Forms.Button but_查询;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Panel Panel9;
    }
}