namespace 超市管理系统.系统设置
{
    partial class S_IntoNewGoodsSellPriceUpdate
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
            this.txtsellname = new System.Windows.Forms.TextBox();
            this.txtsellprice = new System.Windows.Forms.TextBox();
            this.btsave = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "售价名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "售价价格：";
            // 
            // txtsellname
            // 
            this.txtsellname.Location = new System.Drawing.Point(105, 15);
            this.txtsellname.Name = "txtsellname";
            this.txtsellname.Size = new System.Drawing.Size(121, 21);
            this.txtsellname.TabIndex = 2;
            // 
            // txtsellprice
            // 
            this.txtsellprice.Location = new System.Drawing.Point(105, 52);
            this.txtsellprice.Name = "txtsellprice";
            this.txtsellprice.Size = new System.Drawing.Size(121, 21);
            this.txtsellprice.TabIndex = 3;
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(44, 94);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(75, 23);
            this.btsave.TabIndex = 4;
            this.btsave.Text = "保存(&F5)";
            this.btsave.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(144, 94);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 5;
            this.btexit.Text = "退出(&F4)";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // S_IntoNewGoodsSellPriceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 131);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.txtsellprice);
            this.Controls.Add(this.txtsellname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "S_IntoNewGoodsSellPriceUpdate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  修改售价";
            this.Load += new System.EventHandler(this.S_IntoNewGoodsSellPriceUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsellname;
        private System.Windows.Forms.TextBox txtsellprice;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btexit;
    }
}