namespace 超市管理系统.系统设置
{
    partial class T_people
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CZ_yId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CZ_yName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CZ_yZhiwei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CZ_yPOS = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CZ_yPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSure = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 56);
            this.button2.TabIndex = 0;
            this.button2.Text = "修改";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(181, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 56);
            this.button3.TabIndex = 0;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(266, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 56);
            this.button4.TabIndex = 0;
            this.button4.Text = "退出";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.rName,
            this.CZ_yId,
            this.CZ_yName,
            this.CZ_yZhiwei,
            this.CZ_yPOS,
            this.CZ_yPassword,
            this.rid,
            this.Column3});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(-3, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(329, 319);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // rName
            // 
            this.rName.DataPropertyName = "rName";
            this.rName.HeaderText = "角色名称";
            this.rName.Name = "rName";
            this.rName.ReadOnly = true;
            // 
            // CZ_yId
            // 
            this.CZ_yId.DataPropertyName = "CZ_yId";
            this.CZ_yId.HeaderText = "编号";
            this.CZ_yId.Name = "CZ_yId";
            this.CZ_yId.ReadOnly = true;
            this.CZ_yId.Visible = false;
            // 
            // CZ_yName
            // 
            this.CZ_yName.DataPropertyName = "CZ_yName";
            this.CZ_yName.HeaderText = "用户名称";
            this.CZ_yName.Name = "CZ_yName";
            this.CZ_yName.ReadOnly = true;
            // 
            // CZ_yZhiwei
            // 
            this.CZ_yZhiwei.DataPropertyName = "CZ_yZhiwei";
            this.CZ_yZhiwei.HeaderText = "所任职务";
            this.CZ_yZhiwei.Name = "CZ_yZhiwei";
            this.CZ_yZhiwei.ReadOnly = true;
            this.CZ_yZhiwei.Visible = false;
            // 
            // CZ_yPOS
            // 
            this.CZ_yPOS.DataPropertyName = "CZ_yPOS";
            this.CZ_yPOS.HeaderText = "POS操作员";
            this.CZ_yPOS.Name = "CZ_yPOS";
            this.CZ_yPOS.ReadOnly = true;
            this.CZ_yPOS.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CZ_yPOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CZ_yPOS.Visible = false;
            // 
            // CZ_yPassword
            // 
            this.CZ_yPassword.DataPropertyName = "CZ_yPassword";
            this.CZ_yPassword.HeaderText = "密码";
            this.CZ_yPassword.Name = "CZ_yPassword";
            this.CZ_yPassword.ReadOnly = true;
            this.CZ_yPassword.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // rid
            // 
            this.rid.DataPropertyName = "rid";
            this.rid.HeaderText = "rid";
            this.rid.Name = "rid";
            this.rid.ReadOnly = true;
            this.rid.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(4, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(315, 327);
            this.treeView1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 354);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(62, 354);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 3;
            this.btnSure.Text = "保存";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSure);
            this.groupBox1.Location = new System.Drawing.Point(332, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 386);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "权限";
            // 
            // T_people
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "T_people";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "操作员设置";
            this.Load += new System.EventHandler(this.T_people_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.DataGridViewTextBoxColumn rName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CZ_yId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CZ_yName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CZ_yZhiwei;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CZ_yPOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CZ_yPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn rid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}