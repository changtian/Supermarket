namespace 超市管理系统.销售管理
{
    partial class FrmaddSP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnqx = new System.Windows.Forms.Button();
            this.btnqd = new System.Windows.Forms.Button();
            this.btnsc = new System.Windows.Forms.Button();
            this.btnxg = new System.Windows.Forms.Button();
            this.dgvsplb = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bianhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvqd = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsplb)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvqd)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 506);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询商品列表";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "加入所选商品";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(178, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 21);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "输入商品编号或名称查询商品:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入商品编号或名称查询商品,查询到商品后添加到右边所选的商品";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnqx);
            this.groupBox2.Controls.Add(this.btnqd);
            this.groupBox2.Controls.Add(this.btnsc);
            this.groupBox2.Controls.Add(this.btnxg);
            this.groupBox2.Controls.Add(this.dgvsplb);
            this.groupBox2.Location = new System.Drawing.Point(431, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 505);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "所选商品列表";
            // 
            // btnqx
            // 
            this.btnqx.Location = new System.Drawing.Point(282, 472);
            this.btnqx.Name = "btnqx";
            this.btnqx.Size = new System.Drawing.Size(75, 23);
            this.btnqx.TabIndex = 2;
            this.btnqx.Text = "取消";
            this.btnqx.UseVisualStyleBackColor = true;
            this.btnqx.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnqd
            // 
            this.btnqd.Location = new System.Drawing.Point(201, 472);
            this.btnqd.Name = "btnqd";
            this.btnqd.Size = new System.Drawing.Size(75, 23);
            this.btnqd.TabIndex = 2;
            this.btnqd.Text = "确定";
            this.btnqd.UseVisualStyleBackColor = true;
            this.btnqd.Click += new System.EventHandler(this.btnqd_Click);
            // 
            // btnsc
            // 
            this.btnsc.Location = new System.Drawing.Point(120, 472);
            this.btnsc.Name = "btnsc";
            this.btnsc.Size = new System.Drawing.Size(75, 23);
            this.btnsc.TabIndex = 2;
            this.btnsc.Text = "删除";
            this.btnsc.UseVisualStyleBackColor = true;
            this.btnsc.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnxg
            // 
            this.btnxg.Location = new System.Drawing.Point(39, 472);
            this.btnxg.Name = "btnxg";
            this.btnxg.Size = new System.Drawing.Size(75, 23);
            this.btnxg.TabIndex = 2;
            this.btnxg.Text = "修改";
            this.btnxg.UseVisualStyleBackColor = true;
            this.btnxg.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvsplb
            // 
            this.dgvsplb.AllowUserToAddRows = false;
            this.dgvsplb.AllowUserToDeleteRows = false;
            this.dgvsplb.BackgroundColor = System.Drawing.Color.White;
            this.dgvsplb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsplb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.bianhao,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvsplb.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvsplb.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvsplb.Location = new System.Drawing.Point(3, 17);
            this.dgvsplb.Name = "dgvsplb";
            this.dgvsplb.ReadOnly = true;
            this.dgvsplb.RowHeadersVisible = false;
            this.dgvsplb.RowTemplate.Height = 23;
            this.dgvsplb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsplb.Size = new System.Drawing.Size(394, 436);
            this.dgvsplb.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // bianhao
            // 
            this.bianhao.DataPropertyName = "spbianhao";
            this.bianhao.HeaderText = "bianhao";
            this.bianhao.Name = "bianhao";
            this.bianhao.ReadOnly = true;
            this.bianhao.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "spname";
            this.dataGridViewTextBoxColumn9.HeaderText = "商品名称";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 76;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SPdanwei";
            this.dataGridViewTextBoxColumn10.HeaderText = "单位";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 52;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "danjia";
            this.Column8.HeaderText = "单价";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 52;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "dazhel";
            this.Column9.HeaderText = "打折率";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 65;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "zhj";
            this.Column10.HeaderText = "折后价";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 65;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "shuliang";
            this.Column11.HeaderText = "数量";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 52;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "zje";
            this.Column12.HeaderText = "总金额";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 65;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvqd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(406, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "商品清单";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvqd
            // 
            this.dgvqd.AllowUserToAddRows = false;
            this.dgvqd.AllowUserToDeleteRows = false;
            this.dgvqd.BackgroundColor = System.Drawing.Color.White;
            this.dgvqd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvqd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvqd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvqd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvqd.Location = new System.Drawing.Point(3, 3);
            this.dgvqd.Name = "dgvqd";
            this.dgvqd.ReadOnly = true;
            this.dgvqd.RowHeadersVisible = false;
            this.dgvqd.RowTemplate.Height = 23;
            this.dgvqd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvqd.Size = new System.Drawing.Size(400, 394);
            this.dgvqd.TabIndex = 0;
            this.dgvqd.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvqd_CellContentDoubleClick);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SP_gKucuen";
            this.Column7.HeaderText = "库存量";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 65;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SP_gXijie";
            this.Column6.HeaderText = "预设售价";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 76;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Y_Name";
            this.Column5.HeaderText = "颜色";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 52;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SP_gXinghao";
            this.Column4.HeaderText = "规格";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 52;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SP_gDanweiid";
            this.Column3.HeaderText = "单位";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 52;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SP_gName";
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 76;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SP_gTiaoma";
            this.Column1.HeaderText = "商品编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 76;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(3, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(414, 426);
            this.tabControl1.TabIndex = 4;
            // 
            // FrmaddSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmaddSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加商品(商品销售)";
            this.Load += new System.EventHandler(this.FrmaddSP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsplb)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvqd)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dgvsplb;
        private System.Windows.Forms.Button btnqx;
        private System.Windows.Forms.Button btnqd;
        private System.Windows.Forms.Button btnsc;
        private System.Windows.Forms.Button btnxg;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bianhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvqd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}