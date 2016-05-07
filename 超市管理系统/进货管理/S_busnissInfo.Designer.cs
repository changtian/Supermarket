namespace 超市管理系统.进货管理
{
    partial class S_busnissInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(S_busnissInfo));
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btadd = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btfind = new System.Windows.Forms.Button();
            this.btall = new System.Windows.Forms.Button();
            this.btinput = new System.Windows.Forms.Button();
            this.btprint = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.Column4,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column2,
            this.Column3});
            this.dataGridView3.Location = new System.Drawing.Point(-1, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(608, 275);
            this.dataGridView3.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "供货商名称";
            this.Column4.Name = "Column4";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "联系人";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "联系电话";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "联系地址";
            this.Column14.Name = "Column14";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "默认供货商";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "备注";
            this.Column3.Name = "Column3";
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
            this.btupdate.Location = new System.Drawing.Point(71, 8);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(48, 46);
            this.btupdate.TabIndex = 2;
            this.btupdate.Text = "修改";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click_1);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(129, 8);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(48, 46);
            this.btdelete.TabIndex = 2;
            this.btdelete.Text = "删除";
            this.btdelete.UseVisualStyleBackColor = true;
            // 
            // btfind
            // 
            this.btfind.Location = new System.Drawing.Point(187, 8);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(48, 46);
            this.btfind.TabIndex = 2;
            this.btfind.Text = "查找";
            this.btfind.UseVisualStyleBackColor = true;
            this.btfind.Click += new System.EventHandler(this.btfind_Click);
            // 
            // btall
            // 
            this.btall.Location = new System.Drawing.Point(245, 8);
            this.btall.Name = "btall";
            this.btall.Size = new System.Drawing.Size(48, 46);
            this.btall.TabIndex = 2;
            this.btall.Text = "全部";
            this.btall.UseVisualStyleBackColor = true;
            // 
            // btinput
            // 
            this.btinput.Location = new System.Drawing.Point(303, 8);
            this.btinput.Name = "btinput";
            this.btinput.Size = new System.Drawing.Size(48, 46);
            this.btinput.TabIndex = 2;
            this.btinput.Text = "导出";
            this.btinput.UseVisualStyleBackColor = true;
            // 
            // btprint
            // 
            this.btprint.Location = new System.Drawing.Point(361, 8);
            this.btprint.Name = "btprint";
            this.btprint.Size = new System.Drawing.Size(48, 46);
            this.btprint.TabIndex = 2;
            this.btprint.Text = "打印";
            this.btprint.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(419, 8);
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
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Location = new System.Drawing.Point(2, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 303);
            this.panel1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSplitButton1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 281);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(607, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // S_busnissInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 378);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btprint);
            this.Controls.Add(this.btinput);
            this.Controls.Add(this.btall);
            this.Controls.Add(this.btfind);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btadd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "S_busnissInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "供货商信息";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btprint;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}