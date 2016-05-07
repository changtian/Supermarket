namespace 超市管理系统.系统设置
{
    partial class H_SM_adminlevelSetup
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
            this.btexit = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.btfind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MHY_Jibei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMLEVEL_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMLEVEL_DISCOUNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMLEVEL_LOWSCORE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEMLEVEL_HIGHSCORE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(12, 12);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(56, 56);
            this.btadd.TabIndex = 0;
            this.btadd.Text = "增加";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(105, 12);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(56, 56);
            this.btupdate.TabIndex = 0;
            this.btupdate.Text = "修改";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(291, 12);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(56, 56);
            this.btexit.TabIndex = 0;
            this.btexit.Text = "退出";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(198, 12);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(56, 56);
            this.btdelete.TabIndex = 0;
            this.btdelete.Text = "删除";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "级别信息：";
            // 
            // txtinfo
            // 
            this.txtinfo.Location = new System.Drawing.Point(411, 80);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(100, 21);
            this.txtinfo.TabIndex = 2;
            // 
            // btfind
            // 
            this.btfind.Location = new System.Drawing.Point(522, 80);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(75, 23);
            this.btfind.TabIndex = 3;
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
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MHY_Jibei,
            this.MEMLEVEL_NAME,
            this.MEMLEVEL_DISCOUNT,
            this.MEMLEVEL_LOWSCORE,
            this.MEMLEVEL_HIGHSCORE});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(5, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(624, 253);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // MHY_Jibei
            // 
            this.MHY_Jibei.DataPropertyName = "MHY_Jibei";
            this.MHY_Jibei.HeaderText = "级别编号";
            this.MHY_Jibei.Name = "MHY_Jibei";
            // 
            // MEMLEVEL_NAME
            // 
            this.MEMLEVEL_NAME.DataPropertyName = "MEMLEVEL_NAME";
            this.MEMLEVEL_NAME.HeaderText = "级别名称";
            this.MEMLEVEL_NAME.Name = "MEMLEVEL_NAME";
            // 
            // MEMLEVEL_DISCOUNT
            // 
            this.MEMLEVEL_DISCOUNT.DataPropertyName = "MEMLEVEL_DISCOUNT";
            this.MEMLEVEL_DISCOUNT.HeaderText = "级别折扣";
            this.MEMLEVEL_DISCOUNT.Name = "MEMLEVEL_DISCOUNT";
            // 
            // MEMLEVEL_LOWSCORE
            // 
            this.MEMLEVEL_LOWSCORE.DataPropertyName = "MEMLEVEL_LOWSCORE";
            this.MEMLEVEL_LOWSCORE.HeaderText = "积分下限";
            this.MEMLEVEL_LOWSCORE.Name = "MEMLEVEL_LOWSCORE";
            // 
            // MEMLEVEL_HIGHSCORE
            // 
            this.MEMLEVEL_HIGHSCORE.DataPropertyName = "MEMLEVEL_HIGHSCORE";
            this.MEMLEVEL_HIGHSCORE.HeaderText = "积分上限";
            this.MEMLEVEL_HIGHSCORE.Name = "MEMLEVEL_HIGHSCORE";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(0, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(633, 1);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // H_SM_adminlevelSetup
            // 
            this.ClientSize = new System.Drawing.Size(632, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btfind);
            this.Controls.Add(this.txtinfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btadd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "H_SM_adminlevelSetup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "会员级别设置";
            this.Load += new System.EventHandler(this.H_SM_adminlevelSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.Button btfind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MHY_Jibei;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMLEVEL_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMLEVEL_DISCOUNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMLEVEL_LOWSCORE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEMLEVEL_HIGHSCORE;
    }
}