namespace 查询类开发模板
{
    partial class 查询主窗口
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(查询主窗口));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rowMergeView1 = new RowMergeView();
            this.数量 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DataGridView1 = new RowMergeView();
            this.Panel_正在执行 = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.用户全名 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.关键字 = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_查询 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.lbl_标题 = new System.Windows.Forms.Label();
            this.DataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.but_左侧显示 = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.but_导出EXCEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowMergeView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel_正在执行.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.ToolStrip2.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 127);
            this.SplitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Lavender;
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.panel2);
            this.SplitContainer1.Panel2.Controls.Add(this.DataGridView1);
            this.SplitContainer1.Panel2.Controls.Add(this.Panel_正在执行);
            this.SplitContainer1.Size = new System.Drawing.Size(1421, 487);
            this.SplitContainer1.SplitterDistance = 38;
            this.SplitContainer1.SplitterWidth = 5;
            this.SplitContainer1.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rowMergeView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1378, 487);
            this.panel2.TabIndex = 41;
            // 
            // rowMergeView1
            // 
            this.rowMergeView1.AllowUserToAddRows = false;
            this.rowMergeView1.AllowUserToDeleteRows = false;
            this.rowMergeView1.AllowUserToOrderColumns = true;
            this.rowMergeView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.rowMergeView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rowMergeView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.数量});
            this.rowMergeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowMergeView1.Location = new System.Drawing.Point(0, 30);
            this.rowMergeView1.Margin = new System.Windows.Forms.Padding(4);
            this.rowMergeView1.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.rowMergeView1.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("rowMergeView1.MergeColumnNames")));
            this.rowMergeView1.Name = "rowMergeView1";
            this.rowMergeView1.ReadOnly = true;
            this.rowMergeView1.RowTemplate.Height = 23;
            this.rowMergeView1.Size = new System.Drawing.Size(1378, 457);
            this.rowMergeView1.TabIndex = 41;
            this.rowMergeView1.当前用户名 = null;
            this.rowMergeView1.管理列的对应表名称 = "dangdangkuQtyby物料";
            this.rowMergeView1.管理列的控件库名称 = "dangdangkuQtyby历史台账";
            // 
            // 数量
            // 
            this.数量.DataPropertyName = "数量";
            dataGridViewCellStyle1.Format = "0.####";
            this.数量.DefaultCellStyle = dataGridViewCellStyle1;
            this.数量.HeaderText = "数量";
            this.数量.Name = "数量";
            this.数量.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1378, 30);
            this.panel3.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1278, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "关闭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToOrderColumns = true;
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView1.MergeColumnHeaderBackColor = System.Drawing.SystemColors.Control;
            this.DataGridView1.MergeColumnNames = ((System.Collections.Generic.List<string>)(resources.GetObject("DataGridView1.MergeColumnNames")));
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowTemplate.Height = 23;
            this.DataGridView1.Size = new System.Drawing.Size(1378, 487);
            this.DataGridView1.TabIndex = 40;
            this.DataGridView1.当前用户名 = null;
            this.DataGridView1.管理列的对应表名称 = "dangdangkuQtyby物料";
            this.DataGridView1.管理列的控件库名称 = "dangdangkuQtyby物料";
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // Panel_正在执行
            // 
            this.Panel_正在执行.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Panel_正在执行.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_正在执行.Controls.Add(this.Label5);
            this.Panel_正在执行.Location = new System.Drawing.Point(461, 224);
            this.Panel_正在执行.Margin = new System.Windows.Forms.Padding(4);
            this.Panel_正在执行.Name = "Panel_正在执行";
            this.Panel_正在执行.Size = new System.Drawing.Size(231, 59);
            this.Panel_正在执行.TabIndex = 39;
            this.Panel_正在执行.Visible = false;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(17, 22);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(174, 15);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "正在读取数据,请等待...";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户全名});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 614);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(1421, 25);
            this.StatusStrip1.TabIndex = 62;
            this.StatusStrip1.Text = "用户全名：";
            // 
            // 用户全名
            // 
            this.用户全名.Name = "用户全名";
            this.用户全名.Size = new System.Drawing.Size(84, 20);
            this.用户全名.Text = "用户全名：";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel1.Location = new System.Drawing.Point(978, 0);
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
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.Color.Lavender;
            this.Panel9.Controls.Add(this.CheckBox1);
            this.Panel9.Controls.Add(this.ComboBox1);
            this.Panel9.Controls.Add(this.label7);
            this.Panel9.Controls.Add(this.textBox3);
            this.Panel9.Controls.Add(this.label6);
            this.Panel9.Controls.Add(this.textBox2);
            this.Panel9.Controls.Add(this.label4);
            this.Panel9.Controls.Add(this.textBox1);
            this.Panel9.Controls.Add(this.label3);
            this.Panel9.Controls.Add(this.关键字);
            this.Panel9.Controls.Add(this.PictureBox1);
            this.Panel9.Controls.Add(this.but_查询);
            this.Panel9.Controls.Add(this.Label1);
            this.Panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel9.Location = new System.Drawing.Point(0, 87);
            this.Panel9.Margin = new System.Windows.Forms.Padding(4);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(1421, 40);
            this.Panel9.TabIndex = 61;
            this.Panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel9_Paint);
            // 
            // CheckBox1
            // 
            this.CheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(1308, 8);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(97, 19);
            this.CheckBox1.TabIndex = 74;
            this.CheckBox1.Text = "显示0库存";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(967, 8);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(155, 23);
            this.ComboBox1.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(907, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 72;
            this.label7.Text = "仓库：";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(731, 6);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(161, 25);
            this.textBox3.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(687, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 67;
            this.label6.Text = "批次：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(500, 6);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(161, 25);
            this.textBox2.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(456, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 65;
            this.label4.Text = "品牌：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 25);
            this.textBox1.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(235, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 63;
            this.label3.Text = "颜色：";
            // 
            // 关键字
            // 
            this.关键字.Location = new System.Drawing.Point(52, 6);
            this.关键字.Margin = new System.Windows.Forms.Padding(4);
            this.关键字.Name = "关键字";
            this.关键字.Size = new System.Drawing.Size(171, 25);
            this.关键字.TabIndex = 53;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox1.Location = new System.Drawing.Point(1351, 50);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(24, 12);
            this.PictureBox1.TabIndex = 62;
            this.PictureBox1.TabStop = false;
            // 
            // but_查询
            // 
            this.but_查询.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_查询.Location = new System.Drawing.Point(1215, 0);
            this.but_查询.Margin = new System.Windows.Forms.Padding(4);
            this.but_查询.Name = "but_查询";
            this.but_查询.Size = new System.Drawing.Size(85, 31);
            this.but_查询.TabIndex = 56;
            this.but_查询.Text = "查询(C)";
            this.but_查询.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_查询.UseVisualStyleBackColor = true;
            this.but_查询.Click += new System.EventHandler(this.but_查询_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(8, 11);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 15);
            this.Label1.TabIndex = 51;
            this.Label1.Text = "搜索：";
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
            this.lbl_标题.Text = "库存批次查询";
            // 
            // DataGridViewCheckBoxColumn1
            // 
            this.DataGridViewCheckBoxColumn1.HeaderText = "选择";
            this.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            this.DataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // but_左侧显示
            // 
            this.but_左侧显示.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.but_左侧显示.Name = "but_左侧显示";
            this.but_左侧显示.Size = new System.Drawing.Size(73, 24);
            this.but_左侧显示.Text = "左侧显示";
            this.but_左侧显示.Click += new System.EventHandler(this.but_左侧显示_Click);
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.but_左侧显示,
            this.but_导出EXCEL,
            this.toolStripButton1});
            this.ToolStrip2.Location = new System.Drawing.Point(0, 60);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip2.Size = new System.Drawing.Size(1421, 27);
            this.ToolStrip2.TabIndex = 60;
            this.ToolStrip2.Text = "ToolStrip2";
            // 
            // but_导出EXCEL
            // 
            this.but_导出EXCEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.but_导出EXCEL.Name = "but_导出EXCEL";
            this.but_导出EXCEL.Size = new System.Drawing.Size(80, 24);
            this.but_导出EXCEL.Text = "导出Excel";
            this.but_导出EXCEL.Click += new System.EventHandler(this.but_导出EXCEL_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::查询类开发模板vb.net版.Properties.Resources.jihua;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(123, 24);
            this.toolStripButton1.Text = "查看批次报表";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
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
            this.Panel8.Size = new System.Drawing.Size(1421, 60);
            this.Panel8.TabIndex = 59;
            // 
            // 查询主窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 639);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.Panel9);
            this.Controls.Add(this.ToolStrip2);
            this.Controls.Add(this.Panel8);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "查询主窗口";
            this.Text = "库存批次查询";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rowMergeView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel_正在执行.ResumeLayout(false);
            this.Panel_正在执行.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel9.ResumeLayout(false);
            this.Panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            this.Panel8.ResumeLayout(false);
            this.Panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Panel Panel_正在执行;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Panel Panel9;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button but_查询;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lbl_标题;
        internal System.Windows.Forms.DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
        internal System.Windows.Forms.ToolStripButton but_左侧显示;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
        internal System.Windows.Forms.ToolStripButton but_导出EXCEL;
        internal System.Windows.Forms.Panel Panel8;
        private System.Windows.Forms.ToolStripStatusLabel 用户全名;
        private RowMergeView DataGridView1;
        public System.Windows.Forms.TextBox 关键字;
        public System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private RowMergeView rowMergeView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数量;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

