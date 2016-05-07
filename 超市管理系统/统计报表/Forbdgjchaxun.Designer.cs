namespace 超市管理系统.统计报表
{
    partial class Forbdgjchaxun
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
            this.txtghs = new System.Windows.Forms.TextBox();
            this.btncha = new System.Windows.Forms.Button();
            this.cobdeng = new System.Windows.Forms.ComboBox();
            this.txtshu = new System.Windows.Forms.TextBox();
            this.cobcangku = new System.Windows.Forms.ComboBox();
            this.btnqueding = new System.Windows.Forms.Button();
            this.btnquxiao = new System.Windows.Forms.Button();
            this.palcha = new System.Windows.Forms.Panel();
            this.btnpalqu = new System.Windows.Forms.Button();
            this.btnpalque = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询次供货商的库存情况:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "供货商:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "库存量:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "所在仓库:";
            // 
            // txtghs
            // 
            this.txtghs.Location = new System.Drawing.Point(104, 56);
            this.txtghs.Name = "txtghs";
            this.txtghs.Size = new System.Drawing.Size(121, 21);
            this.txtghs.TabIndex = 1;
            // 
            // btncha
            // 
            this.btncha.Location = new System.Drawing.Point(231, 54);
            this.btncha.Name = "btncha";
            this.btncha.Size = new System.Drawing.Size(28, 23);
            this.btncha.TabIndex = 2;
            this.btncha.Text = "button1";
            this.btncha.UseVisualStyleBackColor = true;
            this.btncha.Click += new System.EventHandler(this.btncha_Click);
            // 
            // cobdeng
            // 
            this.cobdeng.FormattingEnabled = true;
            this.cobdeng.Items.AddRange(new object[] {
            "=",
            ">=",
            "<=",
            "<>"});
            this.cobdeng.Location = new System.Drawing.Point(104, 94);
            this.cobdeng.Name = "cobdeng";
            this.cobdeng.Size = new System.Drawing.Size(39, 20);
            this.cobdeng.TabIndex = 3;
            // 
            // txtshu
            // 
            this.txtshu.Location = new System.Drawing.Point(149, 94);
            this.txtshu.Name = "txtshu";
            this.txtshu.Size = new System.Drawing.Size(110, 21);
            this.txtshu.TabIndex = 4;
            this.txtshu.Text = "0";
            // 
            // cobcangku
            // 
            this.cobcangku.FormattingEnabled = true;
            this.cobcangku.Location = new System.Drawing.Point(104, 132);
            this.cobcangku.Name = "cobcangku";
            this.cobcangku.Size = new System.Drawing.Size(155, 20);
            this.cobcangku.TabIndex = 5;
            // 
            // btnqueding
            // 
            this.btnqueding.Location = new System.Drawing.Point(41, 171);
            this.btnqueding.Name = "btnqueding";
            this.btnqueding.Size = new System.Drawing.Size(75, 23);
            this.btnqueding.TabIndex = 6;
            this.btnqueding.Text = "确定";
            this.btnqueding.UseVisualStyleBackColor = true;
            // 
            // btnquxiao
            // 
            this.btnquxiao.Location = new System.Drawing.Point(184, 171);
            this.btnquxiao.Name = "btnquxiao";
            this.btnquxiao.Size = new System.Drawing.Size(75, 23);
            this.btnquxiao.TabIndex = 6;
            this.btnquxiao.Text = "退出";
            this.btnquxiao.UseVisualStyleBackColor = true;
            this.btnquxiao.Click += new System.EventHandler(this.btnquxiao_Click_1);
            // 
            // palcha
            // 
            this.palcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palcha.Controls.Add(this.btnpalqu);
            this.palcha.Controls.Add(this.btnpalque);
            this.palcha.Controls.Add(this.dataGridView1);
            this.palcha.Location = new System.Drawing.Point(103, 80);
            this.palcha.Name = "palcha";
            this.palcha.Size = new System.Drawing.Size(201, 124);
            this.palcha.TabIndex = 7;
            // 
            // btnpalqu
            // 
            this.btnpalqu.Location = new System.Drawing.Point(115, 97);
            this.btnpalqu.Name = "btnpalqu";
            this.btnpalqu.Size = new System.Drawing.Size(56, 23);
            this.btnpalqu.TabIndex = 1;
            this.btnpalqu.Text = "取消";
            this.btnpalqu.UseVisualStyleBackColor = true;
            this.btnpalqu.Click += new System.EventHandler(this.btnpalqu_Click);
            // 
            // btnpalque
            // 
            this.btnpalque.Location = new System.Drawing.Point(21, 97);
            this.btnpalque.Name = "btnpalque";
            this.btnpalque.Size = new System.Drawing.Size(56, 23);
            this.btnpalque.TabIndex = 1;
            this.btnpalque.Text = "确定";
            this.btnpalque.UseVisualStyleBackColor = true;
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
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(199, 95);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "供货商编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 95;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "供货商名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Forbdgjchaxun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 219);
            this.Controls.Add(this.palcha);
            this.Controls.Add(this.btnquxiao);
            this.Controls.Add(this.btnqueding);
            this.Controls.Add(this.cobcangku);
            this.Controls.Add(this.txtshu);
            this.Controls.Add(this.cobdeng);
            this.Controls.Add(this.btncha);
            this.Controls.Add(this.txtghs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Forbdgjchaxun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找";
            this.Load += new System.EventHandler(this.Forbdgjchaxun_Load);
            this.palcha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtghs;
        private System.Windows.Forms.Button btncha;
        private System.Windows.Forms.ComboBox cobdeng;
        private System.Windows.Forms.TextBox txtshu;
        private System.Windows.Forms.ComboBox cobcangku;
        private System.Windows.Forms.Button btnqueding;
        private System.Windows.Forms.Button btnquxiao;
        private System.Windows.Forms.Panel palcha;
        private System.Windows.Forms.Button btnpalqu;
        private System.Windows.Forms.Button btnpalque;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}