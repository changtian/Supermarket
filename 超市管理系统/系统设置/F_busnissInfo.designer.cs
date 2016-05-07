namespace 超市管理系统.系统设置
{
    partial class F_busnissInfo
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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.GH_sName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sLianxiren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sDianhua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sDizhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sMoren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sBeizhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GH_sMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btadd = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btfind = new System.Windows.Forms.Button();
            this.btall = new System.Windows.Forms.Button();
            this.btinput = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GH_sName,
            this.GH_sLianxiren,
            this.GH_sDianhua,
            this.GH_sDizhi,
            this.GH_sMoren,
            this.GH_sBeizhu,
            this.GH_sId,
            this.GH_sMoney});
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView3.Location = new System.Drawing.Point(-1, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(608, 297);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView3_MouseDoubleClick);
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
            // GH_sMoren
            // 
            this.GH_sMoren.DataPropertyName = "GH_sMoren";
            this.GH_sMoren.HeaderText = "默认供货商";
            this.GH_sMoren.Name = "GH_sMoren";
            // 
            // GH_sBeizhu
            // 
            this.GH_sBeizhu.DataPropertyName = "GH_sBeizhu";
            this.GH_sBeizhu.HeaderText = "备注";
            this.GH_sBeizhu.Name = "GH_sBeizhu";
            // 
            // GH_sId
            // 
            this.GH_sId.DataPropertyName = "GH_sId";
            this.GH_sId.HeaderText = "GH_sId";
            this.GH_sId.Name = "GH_sId";
            this.GH_sId.Visible = false;
            // 
            // GH_sMoney
            // 
            this.GH_sMoney.DataPropertyName = "GH_sMoney";
            this.GH_sMoney.HeaderText = "GH_sMoney";
            this.GH_sMoney.Name = "GH_sMoney";
            this.GH_sMoney.Visible = false;
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(13, 8);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(48, 46);
            this.btadd.TabIndex = 2;
            this.btadd.Text = "增加";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(80, 8);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(48, 46);
            this.btupdate.TabIndex = 2;
            this.btupdate.Text = "修改";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click_1);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(147, 8);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(48, 46);
            this.btdelete.TabIndex = 2;
            this.btdelete.Text = "删除";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btfind
            // 
            this.btfind.Location = new System.Drawing.Point(214, 8);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(48, 46);
            this.btfind.TabIndex = 2;
            this.btfind.Text = "查找";
            this.btfind.UseVisualStyleBackColor = true;
            this.btfind.Click += new System.EventHandler(this.btfind_Click);
            // 
            // btall
            // 
            this.btall.Location = new System.Drawing.Point(281, 8);
            this.btall.Name = "btall";
            this.btall.Size = new System.Drawing.Size(48, 46);
            this.btall.TabIndex = 2;
            this.btall.Text = "全部";
            this.btall.UseVisualStyleBackColor = true;
            this.btall.Click += new System.EventHandler(this.btall_Click);
            // 
            // btinput
            // 
            this.btinput.Location = new System.Drawing.Point(348, 8);
            this.btinput.Name = "btinput";
            this.btinput.Size = new System.Drawing.Size(48, 46);
            this.btinput.TabIndex = 2;
            this.btinput.Text = "导出";
            this.btinput.UseVisualStyleBackColor = true;
            this.btinput.Click += new System.EventHandler(this.btinput_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(415, 8);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(48, 46);
            this.btexit.TabIndex = 2;
            this.btexit.Text = "退出";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "我方应付金额：正数为我方欠款金额，负数为我方预支金额";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Location = new System.Drawing.Point(2, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 303);
            this.panel1.TabIndex = 4;
            // 
            // F_busnissInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btinput);
            this.Controls.Add(this.btall);
            this.Controls.Add(this.btfind);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btadd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_busnissInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "供货商信息";
            this.Load += new System.EventHandler(this.F_busnissInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btfind;
        private System.Windows.Forms.Button btall;
        private System.Windows.Forms.Button btinput;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sLianxiren;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sDianhua;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sDizhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sMoren;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sBeizhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GH_sMoney;
    }
}