namespace 超市管理系统.系统设置
{
    partial class E_EmployeeInfo
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btall = new System.Windows.Forms.Button();
            this.btout = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.YG_xId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YG_xName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YG_xZhiwu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YG_xDianhua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YG_xDizhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YG_xBeizhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YG_xCaigou = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.YG_xXiaoshou = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.YG_xkucuen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(13, 13);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(57, 56);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "增加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(101, 13);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(57, 56);
            this.btupdate.TabIndex = 0;
            this.btupdate.Text = "修改";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(189, 13);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(57, 56);
            this.btdelete.TabIndex = 0;
            this.btdelete.Text = "删除";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btall
            // 
            this.btall.Location = new System.Drawing.Point(277, 13);
            this.btall.Name = "btall";
            this.btall.Size = new System.Drawing.Size(57, 56);
            this.btall.TabIndex = 0;
            this.btall.Text = "全部";
            this.btall.UseVisualStyleBackColor = true;
            this.btall.Click += new System.EventHandler(this.btall_Click);
            // 
            // btout
            // 
            this.btout.Location = new System.Drawing.Point(365, 13);
            this.btout.Name = "btout";
            this.btout.Size = new System.Drawing.Size(57, 56);
            this.btout.TabIndex = 0;
            this.btout.Text = "导出";
            this.btout.UseVisualStyleBackColor = true;
            this.btout.Click += new System.EventHandler(this.btout_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(453, 13);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(57, 56);
            this.btexit.TabIndex = 0;
            this.btexit.Text = "退出";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.YG_xId,
            this.YG_xName,
            this.YG_xZhiwu,
            this.YG_xDianhua,
            this.YG_xDizhi,
            this.YG_xBeizhu,
            this.YG_xCaigou,
            this.YG_xXiaoshou,
            this.YG_xkucuen});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(4, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 343);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // YG_xId
            // 
            this.YG_xId.DataPropertyName = "YG_xId";
            this.YG_xId.HeaderText = "员工编号";
            this.YG_xId.Name = "YG_xId";
            this.YG_xId.ReadOnly = true;
            this.YG_xId.Visible = false;
            // 
            // YG_xName
            // 
            this.YG_xName.DataPropertyName = "YG_xName";
            this.YG_xName.HeaderText = "员工姓名";
            this.YG_xName.Name = "YG_xName";
            this.YG_xName.ReadOnly = true;
            // 
            // YG_xZhiwu
            // 
            this.YG_xZhiwu.DataPropertyName = "YG_xZhiwu";
            this.YG_xZhiwu.HeaderText = "职务";
            this.YG_xZhiwu.Name = "YG_xZhiwu";
            this.YG_xZhiwu.ReadOnly = true;
            // 
            // YG_xDianhua
            // 
            this.YG_xDianhua.DataPropertyName = "YG_xDianhua";
            this.YG_xDianhua.HeaderText = "联系电话";
            this.YG_xDianhua.Name = "YG_xDianhua";
            this.YG_xDianhua.ReadOnly = true;
            // 
            // YG_xDizhi
            // 
            this.YG_xDizhi.DataPropertyName = "YG_xDizhi";
            this.YG_xDizhi.HeaderText = "联系地址";
            this.YG_xDizhi.Name = "YG_xDizhi";
            this.YG_xDizhi.ReadOnly = true;
            // 
            // YG_xBeizhu
            // 
            this.YG_xBeizhu.DataPropertyName = "YG_xBeizhu";
            this.YG_xBeizhu.HeaderText = "备注";
            this.YG_xBeizhu.Name = "YG_xBeizhu";
            this.YG_xBeizhu.ReadOnly = true;
            // 
            // YG_xCaigou
            // 
            this.YG_xCaigou.DataPropertyName = "YG_xCaigou";
            this.YG_xCaigou.HeaderText = "采购管理";
            this.YG_xCaigou.Name = "YG_xCaigou";
            this.YG_xCaigou.ReadOnly = true;
            this.YG_xCaigou.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.YG_xCaigou.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.YG_xCaigou.Visible = false;
            // 
            // YG_xXiaoshou
            // 
            this.YG_xXiaoshou.DataPropertyName = "YG_xXiaoshou";
            this.YG_xXiaoshou.HeaderText = "销售管理";
            this.YG_xXiaoshou.Name = "YG_xXiaoshou";
            this.YG_xXiaoshou.ReadOnly = true;
            this.YG_xXiaoshou.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.YG_xXiaoshou.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.YG_xXiaoshou.Visible = false;
            // 
            // YG_xkucuen
            // 
            this.YG_xkucuen.DataPropertyName = "YG_xkucuen";
            this.YG_xkucuen.HeaderText = "库存管理";
            this.YG_xkucuen.Name = "YG_xkucuen";
            this.YG_xkucuen.ReadOnly = true;
            this.YG_xkucuen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.YG_xkucuen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.YG_xkucuen.Visible = false;
            // 
            // E_EmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 430);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btout);
            this.Controls.Add(this.btall);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btAdd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "E_EmployeeInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息";
            this.Load += new System.EventHandler(this.E_EmployeeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btall;
        private System.Windows.Forms.Button btout;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn YG_xId;
        private System.Windows.Forms.DataGridViewTextBoxColumn YG_xName;
        private System.Windows.Forms.DataGridViewTextBoxColumn YG_xZhiwu;
        private System.Windows.Forms.DataGridViewTextBoxColumn YG_xDianhua;
        private System.Windows.Forms.DataGridViewTextBoxColumn YG_xDizhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YG_xBeizhu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YG_xCaigou;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YG_xXiaoshou;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YG_xkucuen;
    }
}