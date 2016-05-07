namespace 超市管理系统.进货管理
{
    partial class Saveselect_inorout
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpin = new System.Windows.Forms.TabPage();
            this.tpexit = new System.Windows.Forms.TabPage();
            this.btadd1 = new System.Windows.Forms.Button();
            this.btupdate1 = new System.Windows.Forms.Button();
            this.btdelete1 = new System.Windows.Forms.Button();
            this.btout1 = new System.Windows.Forms.Button();
            this.btprint1 = new System.Windows.Forms.Button();
            this.btexit1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btexit2 = new System.Windows.Forms.Button();
            this.btprint2 = new System.Windows.Forms.Button();
            this.btout2 = new System.Windows.Forms.Button();
            this.btdelete2 = new System.Windows.Forms.Button();
            this.btupdate2 = new System.Windows.Forms.Button();
            this.btadd2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpin.SuspendLayout();
            this.tpexit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpin);
            this.tabControl1.Controls.Add(this.tpexit);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tpin
            // 
            this.tpin.Controls.Add(this.dataGridView1);
            this.tpin.Controls.Add(this.label1);
            this.tpin.Controls.Add(this.btexit1);
            this.tpin.Controls.Add(this.btprint1);
            this.tpin.Controls.Add(this.btout1);
            this.tpin.Controls.Add(this.btdelete1);
            this.tpin.Controls.Add(this.btupdate1);
            this.tpin.Controls.Add(this.btadd1);
            this.tpin.Location = new System.Drawing.Point(4, 21);
            this.tpin.Name = "tpin";
            this.tpin.Padding = new System.Windows.Forms.Padding(3);
            this.tpin.Size = new System.Drawing.Size(785, 461);
            this.tpin.TabIndex = 0;
            this.tpin.Text = "进货参考";
            this.tpin.UseVisualStyleBackColor = true;
            // 
            // tpexit
            // 
            this.tpexit.Controls.Add(this.dataGridView2);
            this.tpexit.Controls.Add(this.label2);
            this.tpexit.Controls.Add(this.btexit2);
            this.tpexit.Controls.Add(this.btprint2);
            this.tpexit.Controls.Add(this.btout2);
            this.tpexit.Controls.Add(this.btdelete2);
            this.tpexit.Controls.Add(this.btupdate2);
            this.tpexit.Controls.Add(this.btadd2);
            this.tpexit.Location = new System.Drawing.Point(4, 21);
            this.tpexit.Name = "tpexit";
            this.tpexit.Padding = new System.Windows.Forms.Padding(3);
            this.tpexit.Size = new System.Drawing.Size(785, 461);
            this.tpexit.TabIndex = 1;
            this.tpexit.Text = "退货参考";
            this.tpexit.UseVisualStyleBackColor = true;
            // 
            // btadd1
            // 
            this.btadd1.Location = new System.Drawing.Point(16, 11);
            this.btadd1.Name = "btadd1";
            this.btadd1.Size = new System.Drawing.Size(63, 57);
            this.btadd1.TabIndex = 0;
            this.btadd1.Text = "查询添加";
            this.btadd1.UseVisualStyleBackColor = true;
            this.btadd1.Click += new System.EventHandler(this.btadd1_Click);
            // 
            // btupdate1
            // 
            this.btupdate1.Location = new System.Drawing.Point(85, 11);
            this.btupdate1.Name = "btupdate1";
            this.btupdate1.Size = new System.Drawing.Size(63, 57);
            this.btupdate1.TabIndex = 0;
            this.btupdate1.Text = "修改数量";
            this.btupdate1.UseVisualStyleBackColor = true;
            this.btupdate1.Click += new System.EventHandler(this.btupdate1_Click);
            // 
            // btdelete1
            // 
            this.btdelete1.Location = new System.Drawing.Point(154, 11);
            this.btdelete1.Name = "btdelete1";
            this.btdelete1.Size = new System.Drawing.Size(63, 57);
            this.btdelete1.TabIndex = 0;
            this.btdelete1.Text = "删除商品";
            this.btdelete1.UseVisualStyleBackColor = true;
            this.btdelete1.Click += new System.EventHandler(this.btdelete1_Click);
            // 
            // btout1
            // 
            this.btout1.Location = new System.Drawing.Point(223, 11);
            this.btout1.Name = "btout1";
            this.btout1.Size = new System.Drawing.Size(63, 57);
            this.btout1.TabIndex = 0;
            this.btout1.Text = "导出";
            this.btout1.UseVisualStyleBackColor = true;
            this.btout1.Click += new System.EventHandler(this.btout1_Click);
            // 
            // btprint1
            // 
            this.btprint1.Location = new System.Drawing.Point(292, 11);
            this.btprint1.Name = "btprint1";
            this.btprint1.Size = new System.Drawing.Size(63, 57);
            this.btprint1.TabIndex = 0;
            this.btprint1.Text = "打印";
            this.btprint1.UseVisualStyleBackColor = true;
            this.btprint1.Click += new System.EventHandler(this.btprint1_Click);
            // 
            // btexit1
            // 
            this.btexit1.Location = new System.Drawing.Point(361, 11);
            this.btexit1.Name = "btexit1";
            this.btexit1.Size = new System.Drawing.Size(63, 57);
            this.btexit1.TabIndex = 0;
            this.btexit1.Text = "退出";
            this.btexit1.UseVisualStyleBackColor = true;
            this.btexit1.Click += new System.EventHandler(this.btexit1_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(3, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 1);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(781, 379);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品编号";
            this.Column1.Name = "Column1";
            this.Column1.Width = 97;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "商品名称";
            this.Column2.Name = "Column2";
            this.Column2.Width = 98;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "单位";
            this.Column3.Name = "Column3";
            this.Column3.Width = 97;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "规格型号";
            this.Column4.Name = "Column4";
            this.Column4.Width = 97;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "颜色";
            this.Column5.Name = "Column5";
            this.Column5.Width = 97;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "供货商";
            this.Column6.Name = "Column6";
            this.Column6.Width = 98;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "参考进货数量";
            this.Column7.Name = "Column7";
            this.Column7.Width = 97;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "当前库存量";
            this.Column8.Name = "Column8";
            this.Column8.Width = 97;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView2.Location = new System.Drawing.Point(2, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(781, 379);
            this.dataGridView2.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "商品编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 97;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "商品名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 98;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "单位";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 97;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "规格型号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 97;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "颜色";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 97;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "供货商";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 98;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "参考进货数量";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 97;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "当前库存量";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 97;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(786, 1);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // btexit2
            // 
            this.btexit2.Location = new System.Drawing.Point(362, 12);
            this.btexit2.Name = "btexit2";
            this.btexit2.Size = new System.Drawing.Size(63, 57);
            this.btexit2.TabIndex = 7;
            this.btexit2.Text = "退出";
            this.btexit2.UseVisualStyleBackColor = true;
            this.btexit2.Click += new System.EventHandler(this.btexit2_Click);
            // 
            // btprint2
            // 
            this.btprint2.Location = new System.Drawing.Point(293, 12);
            this.btprint2.Name = "btprint2";
            this.btprint2.Size = new System.Drawing.Size(63, 57);
            this.btprint2.TabIndex = 8;
            this.btprint2.Text = "打印";
            this.btprint2.UseVisualStyleBackColor = true;
            this.btprint2.Click += new System.EventHandler(this.btprint2_Click);
            // 
            // btout2
            // 
            this.btout2.Location = new System.Drawing.Point(220, 12);
            this.btout2.Name = "btout2";
            this.btout2.Size = new System.Drawing.Size(63, 57);
            this.btout2.TabIndex = 4;
            this.btout2.Text = "导出";
            this.btout2.UseVisualStyleBackColor = true;
            this.btout2.Click += new System.EventHandler(this.btout2_Click);
            // 
            // btdelete2
            // 
            this.btdelete2.Location = new System.Drawing.Point(151, 12);
            this.btdelete2.Name = "btdelete2";
            this.btdelete2.Size = new System.Drawing.Size(63, 57);
            this.btdelete2.TabIndex = 3;
            this.btdelete2.Text = "删除商品";
            this.btdelete2.UseVisualStyleBackColor = true;
            this.btdelete2.Click += new System.EventHandler(this.btdelete2_Click);
            // 
            // btupdate2
            // 
            this.btupdate2.Location = new System.Drawing.Point(82, 12);
            this.btupdate2.Name = "btupdate2";
            this.btupdate2.Size = new System.Drawing.Size(63, 57);
            this.btupdate2.TabIndex = 6;
            this.btupdate2.Text = "修改数量";
            this.btupdate2.UseVisualStyleBackColor = true;
            this.btupdate2.Click += new System.EventHandler(this.btupdate2_Click);
            // 
            // btadd2
            // 
            this.btadd2.Location = new System.Drawing.Point(8, 12);
            this.btadd2.Name = "btadd2";
            this.btadd2.Size = new System.Drawing.Size(63, 57);
            this.btadd2.TabIndex = 5;
            this.btadd2.Text = "查询添加";
            this.btadd2.UseVisualStyleBackColor = true;
            this.btadd2.Click += new System.EventHandler(this.btadd2_Click);
            // 
            // Saveselect_inorout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 486);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Saveselect_inorout";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进/退货参考";
            this.Load += new System.EventHandler(this.Saveselect_inorout_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpin.ResumeLayout(false);
            this.tpexit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpin;
        private System.Windows.Forms.Button btprint1;
        private System.Windows.Forms.Button btout1;
        private System.Windows.Forms.Button btdelete1;
        private System.Windows.Forms.Button btupdate1;
        private System.Windows.Forms.Button btadd1;
        private System.Windows.Forms.TabPage tpexit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btexit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btexit2;
        private System.Windows.Forms.Button btprint2;
        private System.Windows.Forms.Button btout2;
        private System.Windows.Forms.Button btdelete2;
        private System.Windows.Forms.Button btupdate2;
        private System.Windows.Forms.Button btadd2;
    }
}