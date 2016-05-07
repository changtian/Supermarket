namespace 超市管理系统.统计报表
{
    partial class Forjintueichax
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paltiaojian = new System.Windows.Forms.Panel();
            this.btntjianadd = new System.Windows.Forms.Button();
            this.btntjiancha = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.palghshang = new System.Windows.Forms.Panel();
            this.btnghsadd = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnghscha = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.palshangp = new System.Windows.Forms.Panel();
            this.btnshangpadd = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnshangpcha = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnghs = new System.Windows.Forms.Button();
            this.btnshangping = new System.Windows.Forms.Button();
            this.btntiaojian = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.paltiaojian.SuspendLayout();
            this.palghshang.SuspendLayout();
            this.palshangp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.paltiaojian);
            this.groupBox1.Controls.Add(this.palghshang);
            this.groupBox1.Controls.Add(this.palshangp);
            this.groupBox1.Controls.Add(this.btnghs);
            this.groupBox1.Controls.Add(this.btnshangping);
            this.groupBox1.Controls.Add(this.btntiaojian);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 查询库存商品";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(585, 292);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "所属类别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "单位";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "规格型号";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "颜色";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "销售数量";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "库存数量";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 80;
            // 
            // paltiaojian
            // 
            this.paltiaojian.Controls.Add(this.btntjianadd);
            this.paltiaojian.Controls.Add(this.btntjiancha);
            this.paltiaojian.Controls.Add(this.textBox2);
            this.paltiaojian.Controls.Add(this.label5);
            this.paltiaojian.Controls.Add(this.label4);
            this.paltiaojian.Controls.Add(this.textBox1);
            this.paltiaojian.Controls.Add(this.label3);
            this.paltiaojian.Controls.Add(this.label2);
            this.paltiaojian.Controls.Add(this.dateTimePicker2);
            this.paltiaojian.Controls.Add(this.dateTimePicker1);
            this.paltiaojian.Controls.Add(this.label1);
            this.paltiaojian.Controls.Add(this.textBox3);
            this.paltiaojian.Location = new System.Drawing.Point(26, 49);
            this.paltiaojian.Name = "paltiaojian";
            this.paltiaojian.Size = new System.Drawing.Size(538, 58);
            this.paltiaojian.TabIndex = 2;
            // 
            // btntjianadd
            // 
            this.btntjianadd.Location = new System.Drawing.Point(411, 31);
            this.btntjianadd.Name = "btntjianadd";
            this.btntjianadd.Size = new System.Drawing.Size(89, 23);
            this.btntjianadd.TabIndex = 10;
            this.btntjianadd.UseVisualStyleBackColor = true;
            this.btntjianadd.Click += new System.EventHandler(this.btntjianadd_Click);
            // 
            // btntjiancha
            // 
            this.btntjiancha.Location = new System.Drawing.Point(348, 32);
            this.btntjiancha.Name = "btntjiancha";
            this.btntjiancha.Size = new System.Drawing.Size(51, 23);
            this.btntjiancha.TabIndex = 9;
            this.btntjiancha.Text = "查询";
            this.btntjiancha.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(68, 21);
            this.textBox2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "且库存量大于";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "销售量小于";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(392, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 21);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "商品类别:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "至";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(243, 6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(82, 21);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(82, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询条件: 起始日期从:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(270, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 21);
            this.textBox3.TabIndex = 6;
            // 
            // palghshang
            // 
            this.palghshang.Controls.Add(this.btnghsadd);
            this.palghshang.Controls.Add(this.textBox5);
            this.palghshang.Controls.Add(this.btnghscha);
            this.palghshang.Controls.Add(this.label7);
            this.palghshang.Location = new System.Drawing.Point(26, 50);
            this.palghshang.Name = "palghshang";
            this.palghshang.Size = new System.Drawing.Size(538, 58);
            this.palghshang.TabIndex = 2;
            // 
            // btnghsadd
            // 
            this.btnghsadd.Location = new System.Drawing.Point(411, 18);
            this.btnghsadd.Name = "btnghsadd";
            this.btnghsadd.Size = new System.Drawing.Size(89, 23);
            this.btnghsadd.TabIndex = 12;
            this.btnghsadd.UseVisualStyleBackColor = true;
            this.btnghsadd.Click += new System.EventHandler(this.btnghsadd_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(218, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(124, 21);
            this.textBox5.TabIndex = 10;
            // 
            // btnghscha
            // 
            this.btnghscha.Location = new System.Drawing.Point(348, 18);
            this.btnghscha.Name = "btnghscha";
            this.btnghscha.Size = new System.Drawing.Size(51, 23);
            this.btnghscha.TabIndex = 11;
            this.btnghscha.Text = "查询";
            this.btnghscha.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "输入供货商名称或简码:";
            // 
            // palshangp
            // 
            this.palshangp.Controls.Add(this.btnshangpadd);
            this.palshangp.Controls.Add(this.textBox4);
            this.palshangp.Controls.Add(this.btnshangpcha);
            this.palshangp.Controls.Add(this.label6);
            this.palshangp.Location = new System.Drawing.Point(28, 49);
            this.palshangp.Name = "palshangp";
            this.palshangp.Size = new System.Drawing.Size(538, 58);
            this.palshangp.TabIndex = 1;
            // 
            // btnshangpadd
            // 
            this.btnshangpadd.Location = new System.Drawing.Point(411, 19);
            this.btnshangpadd.Name = "btnshangpadd";
            this.btnshangpadd.Size = new System.Drawing.Size(89, 23);
            this.btnshangpadd.TabIndex = 8;
            this.btnshangpadd.UseVisualStyleBackColor = true;
            this.btnshangpadd.Click += new System.EventHandler(this.btnshangpadd_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(218, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(124, 21);
            this.textBox4.TabIndex = 1;
            // 
            // btnshangpcha
            // 
            this.btnshangpcha.Location = new System.Drawing.Point(348, 20);
            this.btnshangpcha.Name = "btnshangpcha";
            this.btnshangpcha.Size = new System.Drawing.Size(51, 23);
            this.btnshangpcha.TabIndex = 7;
            this.btnshangpcha.Text = "查询";
            this.btnshangpcha.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "输入商品名称或编号:";
            // 
            // btnghs
            // 
            this.btnghs.Location = new System.Drawing.Point(179, 20);
            this.btnghs.Name = "btnghs";
            this.btnghs.Size = new System.Drawing.Size(75, 23);
            this.btnghs.TabIndex = 0;
            this.btnghs.Text = "按供货商查询";
            this.btnghs.UseVisualStyleBackColor = true;
            this.btnghs.Click += new System.EventHandler(this.btnghs_Click);
            // 
            // btnshangping
            // 
            this.btnshangping.Location = new System.Drawing.Point(98, 20);
            this.btnshangping.Name = "btnshangping";
            this.btnshangping.Size = new System.Drawing.Size(75, 23);
            this.btnshangping.TabIndex = 0;
            this.btnshangping.Text = "按商品查询";
            this.btnshangping.UseVisualStyleBackColor = true;
            this.btnshangping.Click += new System.EventHandler(this.btnshangping_Click);
            // 
            // btntiaojian
            // 
            this.btntiaojian.Location = new System.Drawing.Point(17, 20);
            this.btntiaojian.Name = "btntiaojian";
            this.btntiaojian.Size = new System.Drawing.Size(75, 23);
            this.btntiaojian.TabIndex = 0;
            this.btntiaojian.Text = "按条件查询";
            this.btntiaojian.UseVisualStyleBackColor = true;
            this.btntiaojian.Click += new System.EventHandler(this.btntiaojian_Click);
            // 
            // Forjintueichax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 412);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Forjintueichax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Forjintueichax_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.paltiaojian.ResumeLayout(false);
            this.paltiaojian.PerformLayout();
            this.palghshang.ResumeLayout(false);
            this.palghshang.PerformLayout();
            this.palshangp.ResumeLayout(false);
            this.palshangp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnghs;
        private System.Windows.Forms.Button btnshangping;
        private System.Windows.Forms.Button btntiaojian;
        private System.Windows.Forms.Panel paltiaojian;
        private System.Windows.Forms.Button btnshangpcha;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel palghshang;
        private System.Windows.Forms.Panel palshangp;
        private System.Windows.Forms.Button btnghsadd;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnghscha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnshangpadd;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btntjianadd;
        private System.Windows.Forms.Button btntjiancha;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}