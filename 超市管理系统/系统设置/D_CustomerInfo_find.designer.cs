namespace 超市管理系统.系统设置
{
    partial class D_CustomerInfo_find
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpeople = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.btsure = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名称：";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(100, 21);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(173, 21);
            this.txtname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "联系人：";
            // 
            // txtpeople
            // 
            this.txtpeople.Location = new System.Drawing.Point(100, 63);
            this.txtpeople.Name = "txtpeople";
            this.txtpeople.Size = new System.Drawing.Size(173, 21);
            this.txtpeople.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "联系电话：";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(100, 107);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(173, 21);
            this.txtphone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "联系地址：";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(100, 154);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(173, 21);
            this.txtaddress.TabIndex = 1;
            // 
            // btsure
            // 
            this.btsure.Location = new System.Drawing.Point(33, 207);
            this.btsure.Name = "btsure";
            this.btsure.Size = new System.Drawing.Size(75, 23);
            this.btsure.TabIndex = 2;
            this.btsure.Text = "确定";
            this.btsure.UseVisualStyleBackColor = true;
            this.btsure.Click += new System.EventHandler(this.btsure_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(171, 207);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 3;
            this.btexit.Text = "退出";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // D_CustomerInfo_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 264);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsure);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpeople);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "D_CustomerInfo_find";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户查询";
            this.Load += new System.EventHandler(this.D_CustomerInfo_find_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Button btsure;
        private System.Windows.Forms.Button btexit;
    }
}