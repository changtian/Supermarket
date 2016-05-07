namespace 超市管理系统.进货管理
{
    partial class S_businessfind
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
            this.txtbusnessname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbusnesspeople = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbusnessphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbusnessaddress = new System.Windows.Forms.TextBox();
            this.btsure = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "供货商名称：";
            // 
            // txtbusnessname
            // 
            this.txtbusnessname.Location = new System.Drawing.Point(123, 20);
            this.txtbusnessname.Name = "txtbusnessname";
            this.txtbusnessname.Size = new System.Drawing.Size(144, 21);
            this.txtbusnessname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "联系人：";
            // 
            // txtbusnesspeople
            // 
            this.txtbusnesspeople.Location = new System.Drawing.Point(123, 64);
            this.txtbusnesspeople.Name = "txtbusnesspeople";
            this.txtbusnesspeople.Size = new System.Drawing.Size(144, 21);
            this.txtbusnesspeople.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "联系电话：";
            // 
            // txtbusnessphone
            // 
            this.txtbusnessphone.Location = new System.Drawing.Point(123, 112);
            this.txtbusnessphone.Name = "txtbusnessphone";
            this.txtbusnessphone.Size = new System.Drawing.Size(144, 21);
            this.txtbusnessphone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "联系地址：";
            // 
            // txtbusnessaddress
            // 
            this.txtbusnessaddress.Location = new System.Drawing.Point(123, 158);
            this.txtbusnessaddress.Name = "txtbusnessaddress";
            this.txtbusnessaddress.Size = new System.Drawing.Size(144, 21);
            this.txtbusnessaddress.TabIndex = 1;
            // 
            // btsure
            // 
            this.btsure.Location = new System.Drawing.Point(56, 207);
            this.btsure.Name = "btsure";
            this.btsure.Size = new System.Drawing.Size(75, 23);
            this.btsure.TabIndex = 2;
            this.btsure.Text = "确定(&F5)";
            this.btsure.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(180, 207);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 3;
            this.btexit.Text = "退出(&F4)";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // S_businessfind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 261);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsure);
            this.Controls.Add(this.txtbusnessaddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbusnessphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbusnesspeople);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbusnessname);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "S_businessfind";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "供货商查找";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbusnessname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbusnesspeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbusnessphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbusnessaddress;
        private System.Windows.Forms.Button btsure;
        private System.Windows.Forms.Button btexit;
    }
}