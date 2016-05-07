namespace 超市管理系统.统计报表
{
    partial class Forshoukuan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnquxiao = new System.Windows.Forms.Button();
            this.btnqueding = new System.Windows.Forms.Button();
            this.txtshuom = new System.Windows.Forms.TextBox();
            this.cobname = new System.Windows.Forms.ComboBox();
            this.cobmtype = new System.Windows.Forms.ComboBox();
            this.datime = new System.Windows.Forms.DateTimePicker();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbqmoney = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(131, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名称:";
            // 
            // btnquxiao
            // 
            this.btnquxiao.Location = new System.Drawing.Point(276, 198);
            this.btnquxiao.Name = "btnquxiao";
            this.btnquxiao.Size = new System.Drawing.Size(75, 23);
            this.btnquxiao.TabIndex = 21;
            this.btnquxiao.Text = "退出";
            this.btnquxiao.UseVisualStyleBackColor = true;
            this.btnquxiao.Click += new System.EventHandler(this.btnquxiao_Click);
            // 
            // btnqueding
            // 
            this.btnqueding.Location = new System.Drawing.Point(82, 198);
            this.btnqueding.Name = "btnqueding";
            this.btnqueding.Size = new System.Drawing.Size(75, 23);
            this.btnqueding.TabIndex = 22;
            this.btnqueding.Text = "确定";
            this.btnqueding.UseVisualStyleBackColor = true;
            this.btnqueding.Click += new System.EventHandler(this.btnqueding_Click);
            // 
            // txtshuom
            // 
            this.txtshuom.Location = new System.Drawing.Point(86, 156);
            this.txtshuom.Name = "txtshuom";
            this.txtshuom.Size = new System.Drawing.Size(293, 21);
            this.txtshuom.TabIndex = 20;
            // 
            // cobname
            // 
            this.cobname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobname.FormattingEnabled = true;
            this.cobname.Location = new System.Drawing.Point(277, 129);
            this.cobname.Name = "cobname";
            this.cobname.Size = new System.Drawing.Size(100, 20);
            this.cobname.TabIndex = 19;
            // 
            // cobmtype
            // 
            this.cobmtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobmtype.FormattingEnabled = true;
            this.cobmtype.Items.AddRange(new object[] {
            "现金",
            "银行转账",
            "其他"});
            this.cobmtype.Location = new System.Drawing.Point(86, 129);
            this.cobmtype.Name = "cobmtype";
            this.cobmtype.Size = new System.Drawing.Size(100, 20);
            this.cobmtype.TabIndex = 18;
            // 
            // datime
            // 
            this.datime.Location = new System.Drawing.Point(277, 104);
            this.datime.Name = "datime";
            this.datime.Size = new System.Drawing.Size(100, 21);
            this.datime.TabIndex = 17;
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(86, 104);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(100, 21);
            this.txtmoney.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "附加说明:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "付款日期:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "经办人:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "付款金额:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "单    号:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "付款方式:";
            // 
            // lbqmoney
            // 
            this.lbqmoney.AutoSize = true;
            this.lbqmoney.ForeColor = System.Drawing.Color.Red;
            this.lbqmoney.Location = new System.Drawing.Point(84, 84);
            this.lbqmoney.Name = "lbqmoney";
            this.lbqmoney.Size = new System.Drawing.Size(41, 12);
            this.lbqmoney.TabIndex = 12;
            this.lbqmoney.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "欠款金额:";
            // 
            // Forshoukuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 253);
            this.Controls.Add(this.btnquxiao);
            this.Controls.Add(this.btnqueding);
            this.Controls.Add(this.txtshuom);
            this.Controls.Add(this.cobname);
            this.Controls.Add(this.cobmtype);
            this.Controls.Add(this.datime);
            this.Controls.Add(this.txtmoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbqmoney);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Forshoukuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收款单(客户)";
            this.Load += new System.EventHandler(this.Forshoukuan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnquxiao;
        private System.Windows.Forms.Button btnqueding;
        private System.Windows.Forms.TextBox txtshuom;
        private System.Windows.Forms.ComboBox cobname;
        private System.Windows.Forms.ComboBox cobmtype;
        private System.Windows.Forms.DateTimePicker datime;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbqmoney;
        private System.Windows.Forms.Label label9;
    }
}