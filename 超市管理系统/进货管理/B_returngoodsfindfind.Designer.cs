namespace 超市管理系统.进货管理
{
    partial class B_returngoodsfindfind
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
            this.button1 = new System.Windows.Forms.Button();
            this.delkh = new System.Windows.Forms.DataGridView();
            this.KH_xId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xlianxiren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xDianhua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xDizhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.delkh)).BeginInit();
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
            this.txtbusniss.Location = new System.Drawing.Point(108, 300);
            this.txtbusniss.Name = "txtbusniss";
            this.txtbusniss.Size = new System.Drawing.Size(100, 21);
            this.txtbusniss.TabIndex = 8;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 305);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 12);
            this.label19.TabIndex = 7;
            this.label19.Text = "查找供货商(&F2)：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "新增(&F8)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // delkh
            // 
            this.delkh.AllowUserToAddRows = false;
            this.delkh.AllowUserToDeleteRows = false;
            this.delkh.AllowUserToResizeColumns = false;
            this.delkh.AllowUserToResizeRows = false;
            this.delkh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.delkh.BackgroundColor = System.Drawing.Color.White;
            this.delkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KH_xId,
            this.KH_xMoney,
            this.KH_xName,
            this.KH_xlianxiren,
            this.KH_xDianhua,
            this.KH_xDizhi});
            this.delkh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.delkh.Location = new System.Drawing.Point(12, 3);
            this.delkh.Name = "delkh";
            this.delkh.ReadOnly = true;
            this.delkh.RowHeadersVisible = false;
            this.delkh.RowTemplate.Height = 23;
            this.delkh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.delkh.Size = new System.Drawing.Size(541, 291);
            this.delkh.TabIndex = 12;
            // 
            // KH_xId
            // 
            this.KH_xId.DataPropertyName = "KH_xId";
            this.KH_xId.HeaderText = "编号";
            this.KH_xId.Name = "KH_xId";
            this.KH_xId.ReadOnly = true;
            // 
            // KH_xMoney
            // 
            this.KH_xMoney.DataPropertyName = "KH_xMoney";
            this.KH_xMoney.HeaderText = "应收金额";
            this.KH_xMoney.Name = "KH_xMoney";
            this.KH_xMoney.ReadOnly = true;
            this.KH_xMoney.Visible = false;
            // 
            // KH_xName
            // 
            this.KH_xName.DataPropertyName = "KH_xName";
            this.KH_xName.HeaderText = "供货商名称";
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
            // KH_xDizhi
            // 
            this.KH_xDizhi.DataPropertyName = "KH_xDizhi";
            this.KH_xDizhi.HeaderText = "联系地址";
            this.KH_xDizhi.Name = "KH_xDizhi";
            this.KH_xDizhi.ReadOnly = true;
            // 
            // B_returngoodsfindfind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 353);
            this.Controls.Add(this.delkh);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsure);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btreturnupdate);
            this.Controls.Add(this.txtbusniss);
            this.Controls.Add(this.label19);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "B_returngoodsfindfind";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询供货商";
            ((System.ComponentModel.ISupportInitialize)(this.delkh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btsure;
        private System.Windows.Forms.Button btreturnupdate;
        private System.Windows.Forms.TextBox txtbusniss;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView delkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xName;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xlianxiren;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xDianhua;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xDizhi;
    }
}