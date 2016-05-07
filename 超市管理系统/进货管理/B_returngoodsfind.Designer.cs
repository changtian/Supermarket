namespace 超市管理系统.进货管理
{
    partial class B_returngoodsfind
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
            this.txtbusniss = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbostartdate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboenddate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbohomename = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbopeople = new System.Windows.Forms.ComboBox();
            this.btsure = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.btfind = new System.Windows.Forms.Button();
            this.plfind = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.btreturnupdate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.delkh = new System.Windows.Forms.DataGridView();
            this.KH_xId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xlianxiren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xDianhua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KH_xDizhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plfind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delkh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "供货商：";
            // 
            // txtbusniss
            // 
            this.txtbusniss.Location = new System.Drawing.Point(107, 20);
            this.txtbusniss.Name = "txtbusniss";
            this.txtbusniss.Size = new System.Drawing.Size(121, 21);
            this.txtbusniss.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "开单日期：";
            // 
            // cbostartdate
            // 
            this.cbostartdate.FormattingEnabled = true;
            this.cbostartdate.Location = new System.Drawing.Point(107, 56);
            this.cbostartdate.Name = "cbostartdate";
            this.cbostartdate.Size = new System.Drawing.Size(121, 20);
            this.cbostartdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "至";
            // 
            // cboenddate
            // 
            this.cboenddate.FormattingEnabled = true;
            this.cboenddate.Location = new System.Drawing.Point(107, 88);
            this.cboenddate.Name = "cboenddate";
            this.cboenddate.Size = new System.Drawing.Size(121, 20);
            this.cboenddate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "仓库名称：";
            // 
            // cbohomename
            // 
            this.cbohomename.FormattingEnabled = true;
            this.cbohomename.Location = new System.Drawing.Point(107, 120);
            this.cbohomename.Name = "cbohomename";
            this.cbohomename.Size = new System.Drawing.Size(121, 20);
            this.cbohomename.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "操作员：";
            // 
            // cbopeople
            // 
            this.cbopeople.FormattingEnabled = true;
            this.cbopeople.Location = new System.Drawing.Point(107, 152);
            this.cbopeople.Name = "cbopeople";
            this.cbopeople.Size = new System.Drawing.Size(121, 20);
            this.cbopeople.TabIndex = 3;
            // 
            // btsure
            // 
            this.btsure.Location = new System.Drawing.Point(28, 203);
            this.btsure.Name = "btsure";
            this.btsure.Size = new System.Drawing.Size(75, 23);
            this.btsure.TabIndex = 4;
            this.btsure.Text = "确定(&F5)";
            this.btsure.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(164, 203);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 5;
            this.btexit.Text = "退出(&F4)";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btfind
            // 
            this.btfind.Location = new System.Drawing.Point(234, 20);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(29, 23);
            this.btfind.TabIndex = 6;
            this.btfind.Text = "button1";
            this.btfind.UseVisualStyleBackColor = true;
            this.btfind.Click += new System.EventHandler(this.btfind_Click);
            // 
            // plfind
            // 
            this.plfind.Controls.Add(this.button1);
            this.plfind.Controls.Add(this.button2);
            this.plfind.Controls.Add(this.button14);
            this.plfind.Controls.Add(this.btreturnupdate);
            this.plfind.Controls.Add(this.textBox1);
            this.plfind.Controls.Add(this.label19);
            this.plfind.Controls.Add(this.delkh);
            this.plfind.Location = new System.Drawing.Point(64, 114);
            this.plfind.Name = "plfind";
            this.plfind.Size = new System.Drawing.Size(571, 250);
            this.plfind.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "退出(&F4)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "确定(&F5)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(239, 213);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 3;
            this.button14.Text = "新增(&F2)";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // btreturnupdate
            // 
            this.btreturnupdate.Location = new System.Drawing.Point(320, 213);
            this.btreturnupdate.Name = "btreturnupdate";
            this.btreturnupdate.Size = new System.Drawing.Size(75, 23);
            this.btreturnupdate.TabIndex = 3;
            this.btreturnupdate.Text = "修改(&F9)";
            this.btreturnupdate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 12);
            this.label19.TabIndex = 1;
            this.label19.Text = "查找供货商(&F2)：";
            // 
            // delkh
            // 
            this.delkh.AllowUserToAddRows = false;
            this.delkh.AllowUserToDeleteRows = false;
            this.delkh.AllowUserToResizeColumns = false;
            this.delkh.AllowUserToResizeRows = false;
            this.delkh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.delkh.BackgroundColor = System.Drawing.Color.White;
            this.delkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delkh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KH_xId,
            this.KH_xMoney,
            this.KH_xName,
            this.KH_xlianxiren,
            this.KH_xDianhua,
            this.KH_xDizhi});
            this.delkh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.delkh.Location = new System.Drawing.Point(4, 4);
            this.delkh.Name = "delkh";
            this.delkh.ReadOnly = true;
            this.delkh.RowHeadersVisible = false;
            this.delkh.RowTemplate.Height = 23;
            this.delkh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.delkh.Size = new System.Drawing.Size(472, 204);
            this.delkh.TabIndex = 0;
            // 
            // KH_xId
            // 
            this.KH_xId.DataPropertyName = "KH_xId";
            this.KH_xId.HeaderText = "编号";
            this.KH_xId.Name = "KH_xId";
            this.KH_xId.ReadOnly = true;
            // 
            // KH_xMoney
            // 
            this.KH_xMoney.DataPropertyName = "KH_xMoney";
            this.KH_xMoney.HeaderText = "应收金额";
            this.KH_xMoney.Name = "KH_xMoney";
            this.KH_xMoney.ReadOnly = true;
            this.KH_xMoney.Visible = false;
            // 
            // KH_xName
            // 
            this.KH_xName.DataPropertyName = "KH_xName";
            this.KH_xName.HeaderText = "供货商名称";
            this.KH_xName.Name = "KH_xName";
            this.KH_xName.ReadOnly = true;
            // 
            // KH_xlianxiren
            // 
            this.KH_xlianxiren.DataPropertyName = "KH_xlianxiren";
            this.KH_xlianxiren.HeaderText = "联系人";
            this.KH_xlianxiren.Name = "KH_xlianxiren";
            this.KH_xlianxiren.ReadOnly = true;
            // 
            // KH_xDianhua
            // 
            this.KH_xDianhua.DataPropertyName = "KH_xDianhua";
            this.KH_xDianhua.HeaderText = "联系电话";
            this.KH_xDianhua.Name = "KH_xDianhua";
            this.KH_xDianhua.ReadOnly = true;
            // 
            // KH_xDizhi
            // 
            this.KH_xDizhi.DataPropertyName = "KH_xDizhi";
            this.KH_xDizhi.HeaderText = "联系地址";
            this.KH_xDizhi.Name = "KH_xDizhi";
            this.KH_xDizhi.ReadOnly = true;
            // 
            // B_returngoodsfind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 253);
            this.Controls.Add(this.plfind);
            this.Controls.Add(this.btfind);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsure);
            this.Controls.Add(this.cbopeople);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbohomename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboenddate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbostartdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbusniss);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "B_returngoodsfind";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "　查找";
            this.Load += new System.EventHandler(this.B_returngoodsfind_Load);
            this.plfind.ResumeLayout(false);
            this.plfind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delkh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbusniss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbostartdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboenddate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbohomename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbopeople;
        private System.Windows.Forms.Button btsure;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btfind;
        private System.Windows.Forms.Panel plfind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button btreturnupdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView delkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xName;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xlianxiren;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xDianhua;
        private System.Windows.Forms.DataGridViewTextBoxColumn KH_xDizhi;
    }
}