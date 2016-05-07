namespace 超市管理系统.系统设置
{
    partial class T_peopleAdd
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
            this.btsave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpassword2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpassword1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbowork = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(132, 285);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 7;
            this.btexit.Text = "退出(&F4)";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(26, 285);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(75, 23);
            this.btsave.TabIndex = 6;
            this.btsave.Text = "确定(&F5)";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbowork);
            this.groupBox1.Controls.Add(this.txtpassword2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtpassword1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtnum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 269);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作员信息";
            // 
            // txtpassword2
            // 
            this.txtpassword2.Location = new System.Drawing.Point(82, 220);
            this.txtpassword2.Name = "txtpassword2";
            this.txtpassword2.Size = new System.Drawing.Size(133, 21);
            this.txtpassword2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "验证密码：";
            // 
            // txtpassword1
            // 
            this.txtpassword1.Location = new System.Drawing.Point(82, 170);
            this.txtpassword1.Name = "txtpassword1";
            this.txtpassword1.Size = new System.Drawing.Size(133, 21);
            this.txtpassword1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "用户密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "所任职务：";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(82, 75);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(133, 21);
            this.txtname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名称：";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(82, 31);
            this.txtnum.Name = "txtnum";
            this.txtnum.ReadOnly = true;
            this.txtnum.Size = new System.Drawing.Size(133, 21);
            this.txtnum.TabIndex = 1;
            this.txtnum.Text = "自动生成";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户编号：";
            // 
            // cbowork
            // 
            this.cbowork.FormattingEnabled = true;
            this.cbowork.Location = new System.Drawing.Point(82, 122);
            this.cbowork.Name = "cbowork";
            this.cbowork.Size = new System.Drawing.Size(133, 20);
            this.cbowork.TabIndex = 2;
            // 
            // T_peopleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 315);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "T_peopleAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "增加操作员";
            this.Load += new System.EventHandler(this.T_peopleAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpassword2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpassword1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbowork;
    }
}