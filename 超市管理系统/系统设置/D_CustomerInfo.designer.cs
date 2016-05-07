namespace 超市管理系统.系统设置
{
    partial class D_CustomerInfo
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
            this.btadd = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btshowAll = new System.Windows.Forms.Button();
            this.btout = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KH_xName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xlianxiren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xDianhua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xDizhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xBeizhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xMoren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(13, 13);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(67, 64);
            this.btadd.TabIndex = 0;
            this.btadd.Text = "增加";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(106, 13);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(67, 64);
            this.btupdate.TabIndex = 0;
            this.btupdate.Text = "修改";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(199, 13);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(67, 64);
            this.btdelete.TabIndex = 0;
            this.btdelete.Text = "删除";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btshowAll
            // 
            this.btshowAll.Location = new System.Drawing.Point(292, 13);
            this.btshowAll.Name = "btshowAll";
            this.btshowAll.Size = new System.Drawing.Size(67, 64);
            this.btshowAll.TabIndex = 0;
            this.btshowAll.Text = "全部";
            this.btshowAll.UseVisualStyleBackColor = true;
            this.btshowAll.Click += new System.EventHandler(this.btshowAll_Click);
            // 
            // btout
            // 
            this.btout.Location = new System.Drawing.Point(385, 13);
            this.btout.Name = "btout";
            this.btout.Size = new System.Drawing.Size(67, 64);
            this.btout.TabIndex = 0;
            this.btout.Text = "导出";
            this.btout.UseVisualStyleBackColor = true;
            this.btout.Click += new System.EventHandler(this.btout_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(478, 13);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(67, 64);
            this.btexit.TabIndex = 0;
            this.btexit.Text = "退出";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KH_xName,
            this.KH_xlianxiren,
            this.KH_xDianhua,
            this.KH_xMoney,
            this.KH_xDizhi,
            this.KH_xBeizhu,
            this.KH_xId,
            this.KH_xMoren});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(1, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(633, 355);
            this.dataGridView1.TabIndex = 1;
            // 
            // KH_xName
            // 
            this.KH_xName.DataPropertyName = "KH_xName";
            this.KH_xName.HeaderText = "客户姓名";
            this.KH_xName.Name = "KH_xName";
            this.KH_xName.ReadOnly = true;
            // 
            // KH_xlianxiren
            // 
            this.KH_xlianxiren.DataPropertyName = "KH_xlianxiren";
            this.KH_xlianxiren.HeaderText = "联系人";
            this.KH_xlianxiren.Name = "KH_xlianxiren";
            this.KH_xlianxiren.ReadOnly = true;
            // 
            // KH_xDianhua
            // 
            this.KH_xDianhua.DataPropertyName = "KH_xDianhua";
            this.KH_xDianhua.HeaderText = "联系电话";
            this.KH_xDianhua.Name = "KH_xDianhua";
            this.KH_xDianhua.ReadOnly = true;
            // 
            // KH_xMoney
            // 
            this.KH_xMoney.DataPropertyName = "KH_xMoney";
            this.KH_xMoney.HeaderText = "我方收金额";
            this.KH_xMoney.Name = "KH_xMoney";
            this.KH_xMoney.ReadOnly = true;
            // 
            // KH_xDizhi
            // 
            this.KH_xDizhi.DataPropertyName = "KH_xDizhi";
            this.KH_xDizhi.HeaderText = "联系地址";
            this.KH_xDizhi.Name = "KH_xDizhi";
            this.KH_xDizhi.ReadOnly = true;
            // 
            // KH_xBeizhu
            // 
            this.KH_xBeizhu.DataPropertyName = "KH_xBeizhu";
            this.KH_xBeizhu.HeaderText = "KH_xBeizhu";
            this.KH_xBeizhu.Name = "KH_xBeizhu";
            this.KH_xBeizhu.ReadOnly = true;
            this.KH_xBeizhu.Visible = false;
            // 
            // KH_xId
            // 
            this.KH_xId.DataPropertyName = "KH_xId";
            this.KH_xId.HeaderText = "KH_xId";
            this.KH_xId.Name = "KH_xId";
            this.KH_xId.ReadOnly = true;
            this.KH_xId.Visible = false;
            // 
            // KH_xMoren
            // 
            this.KH_xMoren.DataPropertyName = "KH_xMoren";
            this.KH_xMoren.HeaderText = "KH_xMoren";
            this.KH_xMoren.Name = "KH_xMoren";
            this.KH_xMoren.ReadOnly = true;
            this.KH_xMoren.Visible = false;
            // 
            // D_CustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btout);
            this.Controls.Add(this.btshowAll);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btadd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "D_CustomerInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户信息";
            this.Load += new System.EventHandler(this.D_CustomerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btshowAll;
        private System.Windows.Forms.Button btout;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xName;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xlianxiren;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xDianhua;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xDizhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xBeizhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xMoren;
    }
}