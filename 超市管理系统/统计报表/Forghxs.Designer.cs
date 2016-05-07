namespace 超市管理系统.统计报表
{
    partial class Forghxs
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
            this.txtspname = new System.Windows.Forms.TextBox();
            this.lbqtime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbhtime = new System.Windows.Forms.Label();
            this.lbghname = new System.Windows.Forms.Label();
            this.btnqueding = new System.Windows.Forms.Button();
            this.btntueichu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "以下是你所选的查询条件:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "查询时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "供货商名称:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "请在下面输入你要查询的商品信息:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "商品信息:";
            // 
            // txtspname
            // 
            this.txtspname.Location = new System.Drawing.Point(97, 116);
            this.txtspname.Name = "txtspname";
            this.txtspname.Size = new System.Drawing.Size(100, 21);
            this.txtspname.TabIndex = 1;
            // 
            // lbqtime
            // 
            this.lbqtime.AutoSize = true;
            this.lbqtime.Location = new System.Drawing.Point(99, 45);
            this.lbqtime.Name = "lbqtime";
            this.lbqtime.Size = new System.Drawing.Size(41, 12);
            this.lbqtime.TabIndex = 2;
            this.lbqtime.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "至";
            // 
            // lbhtime
            // 
            this.lbhtime.AutoSize = true;
            this.lbhtime.Location = new System.Drawing.Point(193, 45);
            this.lbhtime.Name = "lbhtime";
            this.lbhtime.Size = new System.Drawing.Size(41, 12);
            this.lbhtime.TabIndex = 2;
            this.lbhtime.Text = "label6";
            // 
            // lbghname
            // 
            this.lbghname.AutoSize = true;
            this.lbghname.Location = new System.Drawing.Point(110, 70);
            this.lbghname.Name = "lbghname";
            this.lbghname.Size = new System.Drawing.Size(41, 12);
            this.lbghname.TabIndex = 3;
            this.lbghname.Text = "label6";
            // 
            // btnqueding
            // 
            this.btnqueding.Location = new System.Drawing.Point(45, 159);
            this.btnqueding.Name = "btnqueding";
            this.btnqueding.Size = new System.Drawing.Size(75, 23);
            this.btnqueding.TabIndex = 4;
            this.btnqueding.Text = "确定";
            this.btnqueding.UseVisualStyleBackColor = true;
            // 
            // btntueichu
            // 
            this.btntueichu.Location = new System.Drawing.Point(171, 159);
            this.btntueichu.Name = "btntueichu";
            this.btntueichu.Size = new System.Drawing.Size(75, 23);
            this.btntueichu.TabIndex = 4;
            this.btntueichu.Text = "退出";
            this.btntueichu.UseVisualStyleBackColor = true;
            this.btntueichu.Click += new System.EventHandler(this.btntueichu_Click);
            // 
            // Forghxs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 212);
            this.Controls.Add(this.btntueichu);
            this.Controls.Add(this.btnqueding);
            this.Controls.Add(this.lbghname);
            this.Controls.Add(this.lbhtime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbqtime);
            this.Controls.Add(this.txtspname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Forghxs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Forghxs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtspname;
        private System.Windows.Forms.Label lbqtime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbhtime;
        private System.Windows.Forms.Label lbghname;
        private System.Windows.Forms.Button btnqueding;
        private System.Windows.Forms.Button btntueichu;
    }
}