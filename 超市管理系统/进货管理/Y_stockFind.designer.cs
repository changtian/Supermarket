namespace 超市管理系统.进货管理
{
    partial class Y_stockFind
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbusiness = new System.Windows.Forms.TextBox();
            this.btsave = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.dtpendtime = new System.Windows.Forms.DateTimePicker();
            this.ddtpstartime = new System.Windows.Forms.DateTimePicker();
            this.cbsavename = new System.Windows.Forms.ComboBox();
            this.cbemployee = new System.Windows.Forms.ComboBox();
            this.txtfind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "供货商：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "开单日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "至";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "仓库名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "操作员：";
            // 
            // txtbusiness
            // 
            this.txtbusiness.Location = new System.Drawing.Point(90, 23);
            this.txtbusiness.Name = "txtbusiness";
            this.txtbusiness.Size = new System.Drawing.Size(135, 21);
            this.txtbusiness.TabIndex = 5;
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(27, 225);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(75, 23);
            this.btsave.TabIndex = 6;
            this.btsave.Text = "确定";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(165, 225);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 7;
            this.btexit.Text = "退出";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // dtpendtime
            // 
            this.dtpendtime.Location = new System.Drawing.Point(90, 102);
            this.dtpendtime.Name = "dtpendtime";
            this.dtpendtime.Size = new System.Drawing.Size(135, 21);
            this.dtpendtime.TabIndex = 8;
            // 
            // ddtpstartime
            // 
            this.ddtpstartime.Location = new System.Drawing.Point(90, 62);
            this.ddtpstartime.Name = "ddtpstartime";
            this.ddtpstartime.Size = new System.Drawing.Size(135, 21);
            this.ddtpstartime.TabIndex = 8;
            // 
            // cbsavename
            // 
            this.cbsavename.FormattingEnabled = true;
            this.cbsavename.Items.AddRange(new object[] {
            "所有仓库"});
            this.cbsavename.Location = new System.Drawing.Point(90, 143);
            this.cbsavename.Name = "cbsavename";
            this.cbsavename.Size = new System.Drawing.Size(135, 20);
            this.cbsavename.TabIndex = 9;
            // 
            // cbemployee
            // 
            this.cbemployee.FormattingEnabled = true;
            this.cbemployee.Items.AddRange(new object[] {
            "所有操作员"});
            this.cbemployee.Location = new System.Drawing.Point(90, 183);
            this.cbemployee.Name = "cbemployee";
            this.cbemployee.Size = new System.Drawing.Size(135, 20);
            this.cbemployee.TabIndex = 9;
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(241, 23);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(25, 23);
            this.txtfind.TabIndex = 10;
            this.txtfind.Text = "找";
            this.txtfind.UseVisualStyleBackColor = true;
            this.txtfind.Click += new System.EventHandler(this.txtfind_Click);
            // 
            // Y_stockFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.cbemployee);
            this.Controls.Add(this.cbsavename);
            this.Controls.Add(this.ddtpstartime);
            this.Controls.Add(this.dtpendtime);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.txtbusiness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Y_stockFind";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找";
            this.Load += new System.EventHandler(this.Y_stockFind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbusiness;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.DateTimePicker dtpendtime;
        private System.Windows.Forms.DateTimePicker ddtpstartime;
        private System.Windows.Forms.ComboBox cbsavename;
        private System.Windows.Forms.ComboBox cbemployee;
        private System.Windows.Forms.Button txtfind;
    }
}