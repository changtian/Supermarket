namespace 超市管理系统.系统设置
{
    partial class R_StoreSetup
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
            this.btall = new System.Windows.Forms.Button();
            this.btout = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CK_tName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CK_tfuzren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CK_tDianhua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CK_tDizhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CK_tMoren = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CK_tPOS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CK_tBeizhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CK_tID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(13, 13);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(52, 51);
            this.btadd.TabIndex = 0;
            this.btadd.Text = "增加";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(94, 13);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(52, 51);
            this.btupdate.TabIndex = 0;
            this.btupdate.Text = "修改";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(175, 13);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(52, 51);
            this.btdelete.TabIndex = 0;
            this.btdelete.Text = "删除";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btall
            // 
            this.btall.Location = new System.Drawing.Point(256, 13);
            this.btall.Name = "btall";
            this.btall.Size = new System.Drawing.Size(52, 51);
            this.btall.TabIndex = 0;
            this.btall.Text = "全部";
            this.btall.UseVisualStyleBackColor = true;
            this.btall.Click += new System.EventHandler(this.btall_Click);
            // 
            // btout
            // 
            this.btout.Location = new System.Drawing.Point(337, 13);
            this.btout.Name = "btout";
            this.btout.Size = new System.Drawing.Size(52, 51);
            this.btout.TabIndex = 0;
            this.btout.Text = "导出";
            this.btout.UseVisualStyleBackColor = true;
            this.btout.Click += new System.EventHandler(this.btout_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(418, 13);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(52, 51);
            this.btexit.TabIndex = 0;
            this.btexit.Text = "退出";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CK_tName,
            this.CK_tfuzren,
            this.CK_tDianhua,
            this.CK_tDizhi,
            this.CK_tMoren,
            this.CK_tPOS,
            this.CK_tBeizhu,
            this.CK_tID});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(4, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(601, 357);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // CK_tName
            // 
            this.CK_tName.DataPropertyName = "CK_tName";
            this.CK_tName.HeaderText = "仓库名称";
            this.CK_tName.Name = "CK_tName";
            this.CK_tName.ReadOnly = true;
            // 
            // CK_tfuzren
            // 
            this.CK_tfuzren.DataPropertyName = "CK_tfuzren";
            this.CK_tfuzren.HeaderText = "负责人";
            this.CK_tfuzren.Name = "CK_tfuzren";
            this.CK_tfuzren.ReadOnly = true;
            // 
            // CK_tDianhua
            // 
            this.CK_tDianhua.DataPropertyName = "CK_tDianhua";
            this.CK_tDianhua.HeaderText = "联系电话";
            this.CK_tDianhua.Name = "CK_tDianhua";
            this.CK_tDianhua.ReadOnly = true;
            // 
            // CK_tDizhi
            // 
            this.CK_tDizhi.DataPropertyName = "CK_tDizhi";
            this.CK_tDizhi.HeaderText = "仓库地址";
            this.CK_tDizhi.Name = "CK_tDizhi";
            this.CK_tDizhi.ReadOnly = true;
            // 
            // CK_tMoren
            // 
            this.CK_tMoren.DataPropertyName = "CK_tMoren";
            this.CK_tMoren.HeaderText = "默认仓库";
            this.CK_tMoren.Name = "CK_tMoren";
            this.CK_tMoren.ReadOnly = true;
            this.CK_tMoren.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CK_tMoren.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CK_tPOS
            // 
            this.CK_tPOS.DataPropertyName = "CK_tPOS";
            this.CK_tPOS.HeaderText = "POS仓库";
            this.CK_tPOS.Name = "CK_tPOS";
            this.CK_tPOS.ReadOnly = true;
            this.CK_tPOS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CK_tPOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CK_tBeizhu
            // 
            this.CK_tBeizhu.DataPropertyName = "CK_tBeizhu";
            this.CK_tBeizhu.HeaderText = "备注";
            this.CK_tBeizhu.Name = "CK_tBeizhu";
            this.CK_tBeizhu.ReadOnly = true;
            // 
            // CK_tID
            // 
            this.CK_tID.DataPropertyName = "CK_tID";
            this.CK_tID.HeaderText = "CK_tID";
            this.CK_tID.Name = "CK_tID";
            this.CK_tID.ReadOnly = true;
            this.CK_tID.Visible = false;
            // 
            // R_StoreSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 429);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btout);
            this.Controls.Add(this.btall);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btadd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "R_StoreSetup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "仓库设置";
            this.Load += new System.EventHandler(this.R_StoreSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btall;
        private System.Windows.Forms.Button btout;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CK_tName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CK_tfuzren;
        private System.Windows.Forms.DataGridViewTextBoxColumn CK_tDianhua;
        private System.Windows.Forms.DataGridViewTextBoxColumn CK_tDizhi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CK_tMoren;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CK_tPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CK_tBeizhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CK_tID;

    }
}