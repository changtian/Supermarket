namespace 超市管理系统.进货管理
{
    partial class Y_stockfindfind
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
            this.btexit = new System.Windows.Forms.Button();
            this.btsure = new System.Windows.Forms.Button();
            this.btreturnupdate = new System.Windows.Forms.Button();
            this.txtbusniss = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.GH_sId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sLianxiren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sDianhua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sDizhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sBeizhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sMoren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(478, 300);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 11;
            this.btexit.Text = "退出(&F4)";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btsure
            // 
            this.btsure.Location = new System.Drawing.Point(393, 300);
            this.btsure.Name = "btsure";
            this.btsure.Size = new System.Drawing.Size(75, 23);
            this.btsure.TabIndex = 10;
            this.btsure.Text = "确定(&F5)";
            this.btsure.UseVisualStyleBackColor = true;
            this.btsure.Click += new System.EventHandler(this.btsure_Click);
            // 
            // btreturnupdate
            // 
            this.btreturnupdate.Location = new System.Drawing.Point(308, 300);
            this.btreturnupdate.Name = "btreturnupdate";
            this.btreturnupdate.Size = new System.Drawing.Size(75, 23);
            this.btreturnupdate.TabIndex = 9;
            this.btreturnupdate.Text = "修改(&F9)";
            this.btreturnupdate.UseVisualStyleBackColor = true;
            this.btreturnupdate.Click += new System.EventHandler(this.btreturnupdate_Click);
            // 
            // txtbusniss
            // 
            this.txtbusniss.Location = new System.Drawing.Point(136, 300);
            this.txtbusniss.Name = "txtbusniss";
            this.txtbusniss.Size = new System.Drawing.Size(100, 21);
            this.txtbusniss.TabIndex = 8;
            this.txtbusniss.TextChanged += new System.EventHandler(this.txtbusniss_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 305);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 12);
            this.label19.TabIndex = 7;
            this.label19.Text = "查找供货商编号(&F2)：";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GH_sId,
            this.GH_sName,
            this.GH_sLianxiren,
            this.GH_sDianhua,
            this.GH_sDizhi,
            this.GH_sBeizhu,
            this.GH_sMoney,
            this.GH_sMoren});
            this.dataGridView3.Location = new System.Drawing.Point(2, 2);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(564, 280);
            this.dataGridView3.TabIndex = 6;
            this.dataGridView3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView3_MouseDoubleClick);
            // 
            // GH_sId
            // 
            this.GH_sId.DataPropertyName = "GH_sId";
            this.GH_sId.HeaderText = "编号";
            this.GH_sId.Name = "GH_sId";
            // 
            // GH_sName
            // 
            this.GH_sName.DataPropertyName = "GH_sName";
            this.GH_sName.HeaderText = "供货商名称";
            this.GH_sName.Name = "GH_sName";
            // 
            // GH_sLianxiren
            // 
            this.GH_sLianxiren.DataPropertyName = "GH_sLianxiren";
            this.GH_sLianxiren.HeaderText = "联系人";
            this.GH_sLianxiren.Name = "GH_sLianxiren";
            // 
            // GH_sDianhua
            // 
            this.GH_sDianhua.DataPropertyName = "GH_sDianhua";
            this.GH_sDianhua.HeaderText = "联系电话";
            this.GH_sDianhua.Name = "GH_sDianhua";
            // 
            // GH_sDizhi
            // 
            this.GH_sDizhi.DataPropertyName = "GH_sDizhi";
            this.GH_sDizhi.HeaderText = "联系地址";
            this.GH_sDizhi.Name = "GH_sDizhi";
            // 
            // GH_sBeizhu
            // 
            this.GH_sBeizhu.DataPropertyName = "GH_sBeizhu";
            this.GH_sBeizhu.HeaderText = "GH_sBeizhu";
            this.GH_sBeizhu.Name = "GH_sBeizhu";
            this.GH_sBeizhu.Visible = false;
            // 
            // GH_sMoney
            // 
            this.GH_sMoney.DataPropertyName = "GH_sMoney";
            this.GH_sMoney.HeaderText = "GH_sMoney";
            this.GH_sMoney.Name = "GH_sMoney";
            this.GH_sMoney.Visible = false;
            // 
            // GH_sMoren
            // 
            this.GH_sMoren.DataPropertyName = "GH_sMoren";
            this.GH_sMoren.HeaderText = "GH_sMoren";
            this.GH_sMoren.Name = "GH_sMoren";
            this.GH_sMoren.Visible = false;
            // 
            // Y_stockfindfind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 353);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsure);
            this.Controls.Add(this.btreturnupdate);
            this.Controls.Add(this.txtbusniss);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.dataGridView3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Y_stockfindfind";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询供货商";
            this.Load += new System.EventHandler(this.Y_stockfindfind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btsure;
        private System.Windows.Forms.Button btreturnupdate;
        private System.Windows.Forms.TextBox txtbusniss;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sLianxiren;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sDianhua;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sDizhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sBeizhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sMoren;
    }
}