namespace 超市管理系统.系统设置
{
    partial class H_SM_adminUpdate
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
            this.cbolevel = new System.Windows.Forms.ComboBox();
            this.dtpbirth = new System.Windows.Forms.DateTimePicker();
            this.dtpjoindate = new System.Windows.Forms.DateTimePicker();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbstartnumber = new System.Windows.Forms.CheckBox();
            this.cbremove = new System.Windows.Forms.CheckBox();
            this.cbendday = new System.Windows.Forms.CheckBox();
            this.txtaginpassword = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtintegral = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(269, 349);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 5;
            this.btexit.Text = "退出";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(113, 349);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(75, 23);
            this.btsave.TabIndex = 4;
            this.btsave.Text = "确定";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbolevel);
            this.groupBox1.Controls.Add(this.dtpbirth);
            this.groupBox1.Controls.Add(this.dtpjoindate);
            this.groupBox1.Controls.Add(this.dtpenddate);
            this.groupBox1.Controls.Add(this.txtremark);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbstartnumber);
            this.groupBox1.Controls.Add(this.cbremove);
            this.groupBox1.Controls.Add(this.cbendday);
            this.groupBox1.Controls.Add(this.txtaginpassword);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtintegral);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 309);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会员信息";
            // 
            // cbolevel
            // 
            this.cbolevel.FormattingEnabled = true;
            this.cbolevel.Items.AddRange(new object[] {
            "高级会员",
            "中级会员",
            "普通会员"});
            this.cbolevel.Location = new System.Drawing.Point(288, 18);
            this.cbolevel.Name = "cbolevel";
            this.cbolevel.Size = new System.Drawing.Size(100, 20);
            this.cbolevel.TabIndex = 10;
            // 
            // dtpbirth
            // 
            this.dtpbirth.Location = new System.Drawing.Point(89, 93);
            this.dtpbirth.Name = "dtpbirth";
            this.dtpbirth.Size = new System.Drawing.Size(100, 21);
            this.dtpbirth.TabIndex = 9;
            // 
            // dtpjoindate
            // 
            this.dtpjoindate.Location = new System.Drawing.Point(89, 161);
            this.dtpjoindate.Name = "dtpjoindate";
            this.dtpjoindate.Size = new System.Drawing.Size(100, 21);
            this.dtpjoindate.TabIndex = 9;
            // 
            // dtpenddate
            // 
            this.dtpenddate.Location = new System.Drawing.Point(288, 161);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(100, 21);
            this.dtpenddate.TabIndex = 9;
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(67, 267);
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(321, 21);
            this.txtremark.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "备注：";
            // 
            // cbstartnumber
            // 
            this.cbstartnumber.AutoSize = true;
            this.cbstartnumber.Location = new System.Drawing.Point(223, 198);
            this.cbstartnumber.Name = "cbstartnumber";
            this.cbstartnumber.Size = new System.Drawing.Size(96, 16);
            this.cbstartnumber.TabIndex = 6;
            this.cbstartnumber.Text = "启用该会员卡";
            this.cbstartnumber.UseVisualStyleBackColor = true;
            // 
            // cbremove
            // 
            this.cbremove.AutoSize = true;
            this.cbremove.Location = new System.Drawing.Point(33, 232);
            this.cbremove.Name = "cbremove";
            this.cbremove.Size = new System.Drawing.Size(156, 16);
            this.cbremove.TabIndex = 5;
            this.cbremove.Text = "该会员卡按积分自动升级";
            this.cbremove.UseVisualStyleBackColor = true;
            // 
            // cbendday
            // 
            this.cbendday.AutoSize = true;
            this.cbendday.Location = new System.Drawing.Point(33, 198);
            this.cbendday.Name = "cbendday";
            this.cbendday.Size = new System.Drawing.Size(132, 16);
            this.cbendday.TabIndex = 4;
            this.cbendday.Text = "该会员卡有截止日期";
            this.cbendday.UseVisualStyleBackColor = true;
            // 
            // txtaginpassword
            // 
            this.txtaginpassword.Location = new System.Drawing.Point(288, 89);
            this.txtaginpassword.Name = "txtaginpassword";
            this.txtaginpassword.Size = new System.Drawing.Size(100, 21);
            this.txtaginpassword.TabIndex = 3;
            this.txtaginpassword.UseSystemPasswordChar = true;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(288, 125);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 21);
            this.txtphone.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(288, 53);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 21);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "截止日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "确认密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "联系电话：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "会员密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "会员级别：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "加入日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "会员生日：";
            // 
            // txtintegral
            // 
            this.txtintegral.Location = new System.Drawing.Point(90, 126);
            this.txtintegral.Name = "txtintegral";
            this.txtintegral.Size = new System.Drawing.Size(100, 21);
            this.txtintegral.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "会员积分：";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(90, 54);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "会员名称：";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(90, 18);
            this.txtnum.Name = "txtnum";
            this.txtnum.ReadOnly = true;
            this.txtnum.Size = new System.Drawing.Size(100, 21);
            this.txtnum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "会员编号：";
            // 
            // H_SM_adminUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 395);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "H_SM_adminUpdate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改会员信息";
            this.Load += new System.EventHandler(this.H_SM_adminUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbstartnumber;
        private System.Windows.Forms.CheckBox cbremove;
        private System.Windows.Forms.CheckBox cbendday;
        private System.Windows.Forms.TextBox txtaginpassword;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtintegral;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbolevel;
        private System.Windows.Forms.DateTimePicker dtpbirth;
        private System.Windows.Forms.DateTimePicker dtpjoindate;
        private System.Windows.Forms.DateTimePicker dtpenddate;
    }
}