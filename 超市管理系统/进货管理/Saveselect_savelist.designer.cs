namespace 超市管理系统.进货管理
{
    partial class Saveselect_savelist
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
            this.btselectout = new System.Windows.Forms.Button();
            this.btsee = new System.Windows.Forms.Button();
            this.btout = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbsavenum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbshowprice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboname = new System.Windows.Forms.ComboBox();
            this.btfind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btselectout
            // 
            this.btselectout.Location = new System.Drawing.Point(12, 12);
            this.btselectout.Name = "btselectout";
            this.btselectout.Size = new System.Drawing.Size(62, 64);
            this.btselectout.TabIndex = 0;
            this.btselectout.Text = "单据过滤";
            this.btselectout.UseVisualStyleBackColor = true;
            this.btselectout.Click += new System.EventHandler(this.btselectout_Click);
            // 
            // btsee
            // 
            this.btsee.Location = new System.Drawing.Point(80, 12);
            this.btsee.Name = "btsee";
            this.btsee.Size = new System.Drawing.Size(62, 64);
            this.btsee.TabIndex = 0;
            this.btsee.Text = "查看单据";
            this.btsee.UseVisualStyleBackColor = true;
            // 
            // btout
            // 
            this.btout.Location = new System.Drawing.Point(148, 12);
            this.btout.Name = "btout";
            this.btout.Size = new System.Drawing.Size(62, 64);
            this.btout.TabIndex = 0;
            this.btout.Text = "导出";
            this.btout.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(216, 12);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(62, 64);
            this.btexit.TabIndex = 0;
            this.btexit.Text = "退出";
            this.btexit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "商品名称：";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(357, 25);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(41, 12);
            this.lbname.TabIndex = 2;
            this.lbname.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "库存量：";
            // 
            // lbsavenum
            // 
            this.lbsavenum.AutoSize = true;
            this.lbsavenum.Location = new System.Drawing.Point(515, 25);
            this.lbsavenum.Name = "lbsavenum";
            this.lbsavenum.Size = new System.Drawing.Size(41, 12);
            this.lbsavenum.TabIndex = 4;
            this.lbsavenum.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "销售价：";
            // 
            // lbshowprice
            // 
            this.lbshowprice.AutoSize = true;
            this.lbshowprice.Location = new System.Drawing.Point(688, 25);
            this.lbshowprice.Name = "lbshowprice";
            this.lbshowprice.Size = new System.Drawing.Size(41, 12);
            this.lbshowprice.TabIndex = 6;
            this.lbshowprice.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "查询日期：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(357, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 21);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(474, 50);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(91, 21);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "至";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(590, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "所在仓库：";
            // 
            // cboname
            // 
            this.cboname.FormattingEnabled = true;
            this.cboname.Location = new System.Drawing.Point(656, 50);
            this.cboname.Name = "cboname";
            this.cboname.Size = new System.Drawing.Size(106, 20);
            this.cboname.TabIndex = 11;
            // 
            // btfind
            // 
            this.btfind.Location = new System.Drawing.Point(770, 48);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(75, 23);
            this.btfind.TabIndex = 12;
            this.btfind.Text = "查询";
            this.btfind.UseVisualStyleBackColor = true;
            this.btfind.Click += new System.EventHandler(this.btfind_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(4, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(859, 417);
            this.dataGridView1.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "日期";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "单据号";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "说明";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "供货商/客户";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "入库数";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "出库数";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "单价";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "总金额";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "仓库";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "经办人";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "操作员";
            this.Column11.Name = "Column11";
            // 
            // Saveselect_savelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btfind);
            this.Controls.Add(this.cboname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbshowprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbsavenum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btout);
            this.Controls.Add(this.btsee);
            this.Controls.Add(this.btselectout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Saveselect_savelist";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "库存明细表";
            this.Load += new System.EventHandler(this.Saveselect_savelist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btselectout;
        private System.Windows.Forms.Button btsee;
        private System.Windows.Forms.Button btout;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbsavenum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbshowprice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboname;
        private System.Windows.Forms.Button btfind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}