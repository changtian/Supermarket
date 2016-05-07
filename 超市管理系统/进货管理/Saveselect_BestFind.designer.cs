namespace 超市管理系统.进货管理
{
    partial class Saveselect_BestFind
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
            this.txtbusiness = new System.Windows.Forms.TextBox();
            this.txtsavenum = new System.Windows.Forms.TextBox();
            this.cbosaveaddress = new System.Windows.Forms.ComboBox();
            this.btfind = new System.Windows.Forms.Button();
            this.btsure = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btexit2 = new System.Windows.Forms.Button();
            this.btsure2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SP_gTiaoma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SP_gName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询商品库存情况：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "库存量大于：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "所在仓库：";
            // 
            // txtbusiness
            // 
            this.txtbusiness.Location = new System.Drawing.Point(96, 46);
            this.txtbusiness.Name = "txtbusiness";
            this.txtbusiness.Size = new System.Drawing.Size(100, 21);
            this.txtbusiness.TabIndex = 4;
            // 
            // txtsavenum
            // 
            this.txtsavenum.Location = new System.Drawing.Point(122, 107);
            this.txtsavenum.Name = "txtsavenum";
            this.txtsavenum.Size = new System.Drawing.Size(100, 21);
            this.txtsavenum.TabIndex = 5;
            // 
            // cbosaveaddress
            // 
            this.cbosaveaddress.FormattingEnabled = true;
            this.cbosaveaddress.Location = new System.Drawing.Point(96, 166);
            this.cbosaveaddress.Name = "cbosaveaddress";
            this.cbosaveaddress.Size = new System.Drawing.Size(99, 20);
            this.cbosaveaddress.TabIndex = 6;
            // 
            // btfind
            // 
            this.btfind.Location = new System.Drawing.Point(205, 44);
            this.btfind.Name = "btfind";
            this.btfind.Size = new System.Drawing.Size(30, 23);
            this.btfind.TabIndex = 7;
            this.btfind.Text = "找";
            this.btfind.UseVisualStyleBackColor = true;
            this.btfind.Click += new System.EventHandler(this.btfind_Click);
            // 
            // btsure
            // 
            this.btsure.Location = new System.Drawing.Point(37, 216);
            this.btsure.Name = "btsure";
            this.btsure.Size = new System.Drawing.Size(75, 23);
            this.btsure.TabIndex = 8;
            this.btsure.Text = "确定";
            this.btsure.UseVisualStyleBackColor = true;
            //this.btsure.Click += new System.EventHandler(this.btsure_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(160, 216);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 9;
            this.btexit.Text = "退出";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btexit2);
            this.panel1.Controls.Add(this.btsure2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(22, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 188);
            this.panel1.TabIndex = 10;
            // 
            // btexit2
            // 
            this.btexit2.Location = new System.Drawing.Point(151, 155);
            this.btexit2.Name = "btexit2";
            this.btexit2.Size = new System.Drawing.Size(75, 23);
            this.btexit2.TabIndex = 2;
            this.btexit2.Text = "取消";
            this.btexit2.UseVisualStyleBackColor = true;
            this.btexit2.Click += new System.EventHandler(this.btexit2_Click);
            // 
            // btsure2
            // 
            this.btsure2.Location = new System.Drawing.Point(20, 155);
            this.btsure2.Name = "btsure2";
            this.btsure2.Size = new System.Drawing.Size(75, 23);
            this.btsure2.TabIndex = 1;
            this.btsure2.Text = "确定";
            this.btsure2.UseVisualStyleBackColor = true;
            this.btsure2.Click += new System.EventHandler(this.btsure2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SP_gTiaoma,
            this.SP_gName});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(251, 145);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // SP_gTiaoma
            // 
            this.SP_gTiaoma.DataPropertyName = "SP_gTiaoma";
            this.SP_gTiaoma.HeaderText = "商品编号";
            this.SP_gTiaoma.Name = "SP_gTiaoma";
            // 
            // SP_gName
            // 
            this.SP_gName.DataPropertyName = "SP_gName";
            this.SP_gName.HeaderText = "商品名称";
            this.SP_gName.Name = "SP_gName";
            // 
            // Saveselect_BestFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btsure);
            this.Controls.Add(this.btfind);
            this.Controls.Add(this.cbosaveaddress);
            this.Controls.Add(this.txtsavenum);
            this.Controls.Add(this.txtbusiness);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Saveselect_BestFind";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找";
            this.Load += new System.EventHandler(this.Saveselect_BestFind_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbusiness;
        private System.Windows.Forms.TextBox txtsavenum;
        private System.Windows.Forms.ComboBox cbosaveaddress;
        private System.Windows.Forms.Button btfind;
        private System.Windows.Forms.Button btsure;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btexit2;
        private System.Windows.Forms.Button btsure2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SP_gTiaoma;
        private System.Windows.Forms.DataGridViewTextBoxColumn SP_gName;
    }
}