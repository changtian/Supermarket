namespace 超市管理系统.进货管理
{
    partial class B_IntoAllGoods
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsure = new System.Windows.Forms.Button();
            this.gbgoodsinfo = new System.Windows.Forms.GroupBox();
            this.dgvjl = new System.Windows.Forms.DataGridView();
            this.XS_tTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DH_tDanhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DH_tdanjia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DH_tZongjine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbgoods = new System.Windows.Forms.GroupBox();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.remark = new System.Windows.Forms.Label();
            this.lbreserve = new System.Windows.Forms.Label();
            this.lbcolor = new System.Windows.Forms.Label();
            this.lbfactory = new System.Windows.Forms.Label();
            this.lbcell = new System.Windows.Forms.Label();
            this.lbtype = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbnum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbgoodsinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvjl)).BeginInit();
            this.gbgoods.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(274, 187);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "退出(&F4)";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnsure
            // 
            this.btnsure.Location = new System.Drawing.Point(129, 187);
            this.btnsure.Name = "btnsure";
            this.btnsure.Size = new System.Drawing.Size(75, 23);
            this.btnsure.TabIndex = 6;
            this.btnsure.Text = "确定(&F5)";
            this.btnsure.UseVisualStyleBackColor = true;
            this.btnsure.Click += new System.EventHandler(this.btnsure_Click);
            // 
            // gbgoodsinfo
            // 
            this.gbgoodsinfo.Controls.Add(this.dgvjl);
            this.gbgoodsinfo.Location = new System.Drawing.Point(4, 219);
            this.gbgoodsinfo.Name = "gbgoodsinfo";
            this.gbgoodsinfo.Size = new System.Drawing.Size(476, 158);
            this.gbgoodsinfo.TabIndex = 5;
            this.gbgoodsinfo.TabStop = false;
            this.gbgoodsinfo.Text = "普通供货商供货记录";
            // 
            // dgvjl
            // 
            this.dgvjl.AllowUserToAddRows = false;
            this.dgvjl.AllowUserToDeleteRows = false;
            this.dgvjl.AllowUserToResizeColumns = false;
            this.dgvjl.AllowUserToResizeRows = false;
            this.dgvjl.BackgroundColor = System.Drawing.Color.White;
            this.dgvjl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvjl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XS_tTime,
            this.DH_tDanhao,
            this.DH_tdanjia,
            this.Column4,
            this.DH_tZongjine});
            this.dgvjl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvjl.Location = new System.Drawing.Point(6, 17);
            this.dgvjl.Name = "dgvjl";
            this.dgvjl.ReadOnly = true;
            this.dgvjl.RowHeadersVisible = false;
            this.dgvjl.RowTemplate.Height = 23;
            this.dgvjl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvjl.Size = new System.Drawing.Size(470, 135);
            this.dgvjl.TabIndex = 0;
            // 
            // XS_tTime
            // 
            this.XS_tTime.DataPropertyName = "XS_tTime";
            this.XS_tTime.HeaderText = "开单日期";
            this.XS_tTime.Name = "XS_tTime";
            this.XS_tTime.ReadOnly = true;
            // 
            // DH_tDanhao
            // 
            this.DH_tDanhao.DataPropertyName = "DH_tDanhao";
            this.DH_tDanhao.HeaderText = "单据号";
            this.DH_tDanhao.Name = "DH_tDanhao";
            this.DH_tDanhao.ReadOnly = true;
            // 
            // DH_tdanjia
            // 
            this.DH_tdanjia.DataPropertyName = "DH_tdanjia";
            this.DH_tdanjia.HeaderText = "单价";
            this.DH_tdanjia.Name = "DH_tdanjia";
            this.DH_tdanjia.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DH_tShuliang";
            this.Column4.HeaderText = "数量";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // DH_tZongjine
            // 
            this.DH_tZongjine.DataPropertyName = "DH_tZongjine";
            this.DH_tZongjine.HeaderText = "总金额";
            this.DH_tZongjine.Name = "DH_tZongjine";
            this.DH_tZongjine.ReadOnly = true;
            // 
            // gbgoods
            // 
            this.gbgoods.Controls.Add(this.txtmoney);
            this.gbgoods.Controls.Add(this.txtnum);
            this.gbgoods.Controls.Add(this.label11);
            this.gbgoods.Controls.Add(this.label9);
            this.gbgoods.Controls.Add(this.remark);
            this.gbgoods.Controls.Add(this.lbreserve);
            this.gbgoods.Controls.Add(this.lbcolor);
            this.gbgoods.Controls.Add(this.lbfactory);
            this.gbgoods.Controls.Add(this.lbcell);
            this.gbgoods.Controls.Add(this.lbtype);
            this.gbgoods.Controls.Add(this.lbname);
            this.gbgoods.Controls.Add(this.lbnum);
            this.gbgoods.Controls.Add(this.label8);
            this.gbgoods.Controls.Add(this.label7);
            this.gbgoods.Controls.Add(this.label6);
            this.gbgoods.Controls.Add(this.label5);
            this.gbgoods.Controls.Add(this.label4);
            this.gbgoods.Controls.Add(this.label3);
            this.gbgoods.Controls.Add(this.label2);
            this.gbgoods.Controls.Add(this.label1);
            this.gbgoods.Location = new System.Drawing.Point(12, 10);
            this.gbgoods.Name = "gbgoods";
            this.gbgoods.Size = new System.Drawing.Size(455, 165);
            this.gbgoods.TabIndex = 4;
            this.gbgoods.TabStop = false;
            this.gbgoods.Text = "商品信息";
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(88, 135);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(67, 21);
            this.txtmoney.TabIndex = 20;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(320, 136);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(67, 21);
            this.txtnum.TabIndex = 20;
            this.txtnum.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(255, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "数    量：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "退货单价：";
            // 
            // remark
            // 
            this.remark.AutoSize = true;
            this.remark.ForeColor = System.Drawing.Color.Blue;
            this.remark.Location = new System.Drawing.Point(331, 102);
            this.remark.Name = "remark";
            this.remark.Size = new System.Drawing.Size(47, 12);
            this.remark.TabIndex = 15;
            this.remark.Text = "label16";
            // 
            // lbreserve
            // 
            this.lbreserve.AutoSize = true;
            this.lbreserve.ForeColor = System.Drawing.Color.Blue;
            this.lbreserve.Location = new System.Drawing.Point(86, 102);
            this.lbreserve.Name = "lbreserve";
            this.lbreserve.Size = new System.Drawing.Size(47, 12);
            this.lbreserve.TabIndex = 14;
            this.lbreserve.Text = "label15";
            // 
            // lbcolor
            // 
            this.lbcolor.AutoSize = true;
            this.lbcolor.ForeColor = System.Drawing.Color.Blue;
            this.lbcolor.Location = new System.Drawing.Point(331, 74);
            this.lbcolor.Name = "lbcolor";
            this.lbcolor.Size = new System.Drawing.Size(47, 12);
            this.lbcolor.TabIndex = 13;
            this.lbcolor.Text = "label14";
            // 
            // lbfactory
            // 
            this.lbfactory.AutoSize = true;
            this.lbfactory.ForeColor = System.Drawing.Color.Blue;
            this.lbfactory.Location = new System.Drawing.Point(86, 74);
            this.lbfactory.Name = "lbfactory";
            this.lbfactory.Size = new System.Drawing.Size(47, 12);
            this.lbfactory.TabIndex = 12;
            this.lbfactory.Text = "label13";
            // 
            // lbcell
            // 
            this.lbcell.AutoSize = true;
            this.lbcell.ForeColor = System.Drawing.Color.Blue;
            this.lbcell.Location = new System.Drawing.Point(331, 47);
            this.lbcell.Name = "lbcell";
            this.lbcell.Size = new System.Drawing.Size(47, 12);
            this.lbcell.TabIndex = 11;
            this.lbcell.Text = "label12";
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.ForeColor = System.Drawing.Color.Blue;
            this.lbtype.Location = new System.Drawing.Point(86, 48);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(47, 12);
            this.lbtype.TabIndex = 10;
            this.lbtype.Text = "label11";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.ForeColor = System.Drawing.Color.Blue;
            this.lbname.Location = new System.Drawing.Point(331, 20);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(47, 12);
            this.lbname.TabIndex = 9;
            this.lbname.Text = "label10";
            // 
            // lbnum
            // 
            this.lbnum.AutoSize = true;
            this.lbnum.ForeColor = System.Drawing.Color.Red;
            this.lbnum.Location = new System.Drawing.Point(86, 20);
            this.lbnum.Name = "lbnum";
            this.lbnum.Size = new System.Drawing.Size(41, 12);
            this.lbnum.TabIndex = 8;
            this.lbnum.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "备    注：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "当前库存：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "颜    色：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "生产厂商：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "单    位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "规格型号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品编号：";
            // 
            // B_IntoAllGoods
            // 
            this.ClientSize = new System.Drawing.Size(486, 386);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsure);
            this.Controls.Add(this.gbgoodsinfo);
            this.Controls.Add(this.gbgoods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "B_IntoAllGoods";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商品信息(采购退货)";
            this.Load += new System.EventHandler(this.B_IntoAllGoods_Load);
            this.gbgoodsinfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvjl)).EndInit();
            this.gbgoods.ResumeLayout(false);
            this.gbgoods.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnsure;
        private System.Windows.Forms.GroupBox gbgoodsinfo;
        private System.Windows.Forms.DataGridView dgvjl;
        private System.Windows.Forms.GroupBox gbgoods;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label remark;
        private System.Windows.Forms.Label lbreserve;
        private System.Windows.Forms.Label lbcolor;
        private System.Windows.Forms.Label lbfactory;
        private System.Windows.Forms.Label lbcell;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbnum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn XS_tTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DH_tDanhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DH_tdanjia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DH_tZongjine;
    }
}