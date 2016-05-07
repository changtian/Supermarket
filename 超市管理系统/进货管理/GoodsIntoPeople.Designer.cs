namespace 超市管理系统.进货管理
{
    partial class GoodsIntoPeople
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtinputinfo = new System.Windows.Forms.TextBox();
            this.btfind = new System.Windows.Forms.Button();
            this.btsure = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(575, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入员工信息(&Q):";
            // 
            // txtinputinfo
            // 
            this.txtinputinfo.Location = new System.Drawing.Point(117, 230);
            this.txtinputinfo.Name = "txtinputinfo";
            this.txtinputinfo.Size = new System.Drawing.Size(88, 21);
            this.txtinputinfo.TabIndex = 2;
            // 
            // btfind
            // 
            this.btfind.Location = new System.Drawing.Point(207, 230);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(29, 23);
            this.btfind.TabIndex = 3;
            this.btfind.Text = "button1";
            this.btfind.UseVisualStyleBackColor = true;
            this.btfind.Click += new System.EventHandler(this.btfind_Click);
            // 
            // btsure
            // 
            this.btsure.Location = new System.Drawing.Point(248, 230);
            this.btsure.Name = "btsure";
            this.btsure.Size = new System.Drawing.Size(75, 23);
            this.btsure.TabIndex = 4;
            this.btsure.Text = "确定(&F5)";
            this.btsure.UseVisualStyleBackColor = true;
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(332, 230);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(75, 23);
            this.btadd.TabIndex = 5;
            this.btadd.Text = "增加(&F4)";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(416, 229);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 6;
            this.btupdate.Text = "修改(&F9)";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(500, 229);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 7;
            this.btexit.Text = "关闭(&esc)";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "姓名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "年龄";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "联系电话";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "地址";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "备注";
            this.Column5.Name = "Column5";
            // 
            // GoodsIntoPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 261);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.btsure);
            this.Controls.Add(this.btfind);
            this.Controls.Add(this.txtinputinfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoodsIntoPeople";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择经济人";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtinputinfo;
        private System.Windows.Forms.Button btfind;
        private System.Windows.Forms.Button btsure;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}