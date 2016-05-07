namespace 超市管理系统
{
    partial class ForDengl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForDengl1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboname = new System.Windows.Forms.ComboBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.btndenglu = new System.Windows.Forms.Button();
            this.btnquxiao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 255);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cboname
            // 
            this.cboname.FormattingEnabled = true;
            this.cboname.Location = new System.Drawing.Point(296, 93);
            this.cboname.Name = "cboname";
            this.cboname.Size = new System.Drawing.Size(150, 20);
            this.cboname.TabIndex = 1;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(296, 149);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(150, 21);
            this.txtpwd.TabIndex = 2;
            // 
            // btndenglu
            // 
            this.btndenglu.Location = new System.Drawing.Point(194, 214);
            this.btndenglu.Name = "btndenglu";
            this.btndenglu.Size = new System.Drawing.Size(75, 23);
            this.btndenglu.TabIndex = 3;
            this.btndenglu.Text = "登录";
            this.btndenglu.UseVisualStyleBackColor = true;
            this.btndenglu.Click += new System.EventHandler(this.btndenglu_Click);
            // 
            // btnquxiao
            // 
            this.btnquxiao.Location = new System.Drawing.Point(340, 214);
            this.btnquxiao.Name = "btnquxiao";
            this.btnquxiao.Size = new System.Drawing.Size(75, 23);
            this.btnquxiao.TabIndex = 3;
            this.btnquxiao.Text = "退出";
            this.btnquxiao.UseVisualStyleBackColor = true;
            this.btnquxiao.Click += new System.EventHandler(this.btnquxiao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "用户名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "用户密码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(218, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "超市管理系统";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // ForDengl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 255);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnquxiao);
            this.Controls.Add(this.btndenglu);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.cboname);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForDengl1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超市--用户登录";
            this.Load += new System.EventHandler(this.ForDengl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboname;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button btndenglu;
        private System.Windows.Forms.Button btnquxiao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}