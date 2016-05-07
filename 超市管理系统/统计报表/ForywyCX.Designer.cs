namespace 超市管理系统.统计报表
{
    partial class ForywyCX
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
            this.lbe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cobck = new System.Windows.Forms.ComboBox();
            this.cobtype = new System.Windows.Forms.ComboBox();
            this.btncha = new System.Windows.Forms.Button();
            this.btnqd = new System.Windows.Forms.Button();
            this.btntc = new System.Windows.Forms.Button();
            this.palkh = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnplqd = new System.Windows.Forms.Button();
            this.btnpltc = new System.Windows.Forms.Button();
            this.palkh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客户名称:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(100, 22);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(109, 21);
            this.txtname.TabIndex = 1;
            // 
            // lbe
            // 
            this.lbe.AutoSize = true;
            this.lbe.Location = new System.Drawing.Point(35, 72);
            this.lbe.Name = "lbe";
            this.lbe.Size = new System.Drawing.Size(59, 12);
            this.lbe.TabIndex = 0;
            this.lbe.Text = "仓库名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "单据类型:";
            // 
            // cobck
            // 
            this.cobck.FormattingEnabled = true;
            this.cobck.Location = new System.Drawing.Point(100, 69);
            this.cobck.Name = "cobck";
            this.cobck.Size = new System.Drawing.Size(109, 20);
            this.cobck.TabIndex = 2;
            // 
            // cobtype
            // 
            this.cobtype.FormattingEnabled = true;
            this.cobtype.Location = new System.Drawing.Point(100, 114);
            this.cobtype.Name = "cobtype";
            this.cobtype.Size = new System.Drawing.Size(109, 20);
            this.cobtype.TabIndex = 2;
            // 
            // btncha
            // 
            this.btncha.Location = new System.Drawing.Point(215, 22);
            this.btncha.Name = "btncha";
            this.btncha.Size = new System.Drawing.Size(30, 23);
            this.btncha.TabIndex = 3;
            this.btncha.Text = "button1";
            this.btncha.UseVisualStyleBackColor = true;
            this.btncha.Click += new System.EventHandler(this.btncha_Click);
            // 
            // btnqd
            // 
            this.btnqd.Location = new System.Drawing.Point(37, 174);
            this.btnqd.Name = "btnqd";
            this.btnqd.Size = new System.Drawing.Size(75, 23);
            this.btnqd.TabIndex = 4;
            this.btnqd.Text = "确定";
            this.btnqd.UseVisualStyleBackColor = true;
            // 
            // btntc
            // 
            this.btntc.Location = new System.Drawing.Point(170, 174);
            this.btntc.Name = "btntc";
            this.btntc.Size = new System.Drawing.Size(75, 23);
            this.btntc.TabIndex = 4;
            this.btntc.Text = "退出";
            this.btntc.UseVisualStyleBackColor = true;
            // 
            // palkh
            // 
            this.palkh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palkh.Controls.Add(this.btnpltc);
            this.palkh.Controls.Add(this.btnplqd);
            this.palkh.Controls.Add(this.dataGridView1);
            this.palkh.Location = new System.Drawing.Point(37, 43);
            this.palkh.Name = "palkh";
            this.palkh.Size = new System.Drawing.Size(227, 185);
            this.palkh.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(225, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "客户名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 143;
            // 
            // btnplqd
            // 
            this.btnplqd.Location = new System.Drawing.Point(15, 156);
            this.btnplqd.Name = "btnplqd";
            this.btnplqd.Size = new System.Drawing.Size(75, 23);
            this.btnplqd.TabIndex = 1;
            this.btnplqd.Text = "确定";
            this.btnplqd.UseVisualStyleBackColor = true;
            // 
            // btnpltc
            // 
            this.btnpltc.Location = new System.Drawing.Point(133, 156);
            this.btnpltc.Name = "btnpltc";
            this.btnpltc.Size = new System.Drawing.Size(75, 23);
            this.btnpltc.TabIndex = 1;
            this.btnpltc.Text = "退出";
            this.btnpltc.UseVisualStyleBackColor = true;
            this.btnpltc.Click += new System.EventHandler(this.btnpltc_Click);
            // 
            // ForywyCX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 252);
            this.Controls.Add(this.palkh);
            this.Controls.Add(this.btntc);
            this.Controls.Add(this.btnqd);
            this.Controls.Add(this.btncha);
            this.Controls.Add(this.cobtype);
            this.Controls.Add(this.cobck);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForywyCX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询";
            this.Load += new System.EventHandler(this.ForywyCX_Load);
            this.palkh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cobck;
        private System.Windows.Forms.ComboBox cobtype;
        private System.Windows.Forms.Button btncha;
        private System.Windows.Forms.Button btnqd;
        private System.Windows.Forms.Button btntc;
        private System.Windows.Forms.Panel palkh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnplqd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnpltc;
    }
}