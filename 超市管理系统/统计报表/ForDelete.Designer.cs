namespace 超市管理系统.统计报表
{
    partial class ForDelete
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
            this.lbid = new System.Windows.Forms.Label();
            this.lbshifu = new System.Windows.Forms.Label();
            this.lbyingfu = new System.Windows.Forms.Label();
            this.lbghs = new System.Windows.Forms.Label();
            this.txtwhy = new System.Windows.Forms.TextBox();
            this.btnshanchu = new System.Windows.Forms.Button();
            this.btnquxiao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "即将删除采购进货单:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "供货商名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "应付金额:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "实付金额:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "请在下面输入删除原因(原因将记录进日志)";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.ForeColor = System.Drawing.Color.Red;
            this.lbid.Location = new System.Drawing.Point(156, 18);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(29, 12);
            this.lbid.TabIndex = 1;
            this.lbid.Text = "单号";
            // 
            // lbshifu
            // 
            this.lbshifu.AutoSize = true;
            this.lbshifu.ForeColor = System.Drawing.Color.Red;
            this.lbshifu.Location = new System.Drawing.Point(96, 90);
            this.lbshifu.Name = "lbshifu";
            this.lbshifu.Size = new System.Drawing.Size(35, 12);
            this.lbshifu.TabIndex = 1;
            this.lbshifu.Text = "money";
            // 
            // lbyingfu
            // 
            this.lbyingfu.AutoSize = true;
            this.lbyingfu.ForeColor = System.Drawing.Color.Red;
            this.lbyingfu.Location = new System.Drawing.Point(96, 66);
            this.lbyingfu.Name = "lbyingfu";
            this.lbyingfu.Size = new System.Drawing.Size(35, 12);
            this.lbyingfu.TabIndex = 1;
            this.lbyingfu.Text = "money";
            // 
            // lbghs
            // 
            this.lbghs.AutoSize = true;
            this.lbghs.ForeColor = System.Drawing.Color.Red;
            this.lbghs.Location = new System.Drawing.Point(109, 42);
            this.lbghs.Name = "lbghs";
            this.lbghs.Size = new System.Drawing.Size(41, 12);
            this.lbghs.TabIndex = 1;
            this.lbghs.Text = "供货商";
            // 
            // txtwhy
            // 
            this.txtwhy.Location = new System.Drawing.Point(32, 136);
            this.txtwhy.Multiline = true;
            this.txtwhy.Name = "txtwhy";
            this.txtwhy.Size = new System.Drawing.Size(293, 64);
            this.txtwhy.TabIndex = 2;
            // 
            // btnshanchu
            // 
            this.btnshanchu.Location = new System.Drawing.Point(56, 211);
            this.btnshanchu.Name = "btnshanchu";
            this.btnshanchu.Size = new System.Drawing.Size(75, 23);
            this.btnshanchu.TabIndex = 3;
            this.btnshanchu.Text = " 确定";
            this.btnshanchu.UseVisualStyleBackColor = true;
            this.btnshanchu.Click += new System.EventHandler(this.btnshanchu_Click);
            // 
            // btnquxiao
            // 
            this.btnquxiao.Location = new System.Drawing.Point(239, 211);
            this.btnquxiao.Name = "btnquxiao";
            this.btnquxiao.Size = new System.Drawing.Size(75, 23);
            this.btnquxiao.TabIndex = 3;
            this.btnquxiao.Text = "退出";
            this.btnquxiao.UseVisualStyleBackColor = true;
            this.btnquxiao.Click += new System.EventHandler(this.btnquxiao_Click);
            // 
            // ForDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 246);
            this.Controls.Add(this.btnquxiao);
            this.Controls.Add(this.btnshanchu);
            this.Controls.Add(this.txtwhy);
            this.Controls.Add(this.lbghs);
            this.Controls.Add(this.lbyingfu);
            this.Controls.Add(this.lbshifu);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除原因";
            this.Load += new System.EventHandler(this.ForDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbshifu;
        private System.Windows.Forms.Label lbyingfu;
        private System.Windows.Forms.Label lbghs;
        private System.Windows.Forms.TextBox txtwhy;
        private System.Windows.Forms.Button btnshanchu;
        private System.Windows.Forms.Button btnquxiao;
    }
}