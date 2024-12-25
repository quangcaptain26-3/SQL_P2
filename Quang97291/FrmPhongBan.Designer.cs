namespace Quang97291
{
    partial class FrmPhongBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.txt_find_pc = new System.Windows.Forms.TextBox();
            this.txt_find_date = new System.Windows.Forms.TextBox();
            this.txt_find_name = new System.Windows.Forms.TextBox();
            this.txt_find_id = new System.Windows.Forms.TextBox();
            this.cb_find_pc = new System.Windows.Forms.CheckBox();
            this.cb_find_date = new System.Windows.Forms.CheckBox();
            this.cb_find_name = new System.Windows.Forms.CheckBox();
            this.cb_find_id = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_pc = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_load_pb = new System.Windows.Forms.DataGridView();
            this.colMaPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayThanhLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erp_loi = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_loi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_find);
            this.groupBox1.Controls.Add(this.txt_find_pc);
            this.groupBox1.Controls.Add(this.txt_find_date);
            this.groupBox1.Controls.Add(this.txt_find_name);
            this.groupBox1.Controls.Add(this.txt_find_id);
            this.groupBox1.Controls.Add(this.cb_find_pc);
            this.groupBox1.Controls.Add(this.cb_find_date);
            this.groupBox1.Controls.Add(this.cb_find_name);
            this.groupBox1.Controls.Add(this.cb_find_id);
            this.groupBox1.Location = new System.Drawing.Point(17, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 784);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tim Kiem";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(28, 481);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(238, 53);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(28, 422);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(238, 53);
            this.btn_reset.TabIndex = 9;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(28, 363);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(238, 53);
            this.btn_find.TabIndex = 8;
            this.btn_find.Text = "Tim Kiem";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // txt_find_pc
            // 
            this.txt_find_pc.Location = new System.Drawing.Point(20, 322);
            this.txt_find_pc.Name = "txt_find_pc";
            this.txt_find_pc.Size = new System.Drawing.Size(288, 24);
            this.txt_find_pc.TabIndex = 7;
            // 
            // txt_find_date
            // 
            this.txt_find_date.Location = new System.Drawing.Point(22, 218);
            this.txt_find_date.Name = "txt_find_date";
            this.txt_find_date.Size = new System.Drawing.Size(288, 24);
            this.txt_find_date.TabIndex = 6;
            // 
            // txt_find_name
            // 
            this.txt_find_name.Location = new System.Drawing.Point(20, 141);
            this.txt_find_name.Name = "txt_find_name";
            this.txt_find_name.Size = new System.Drawing.Size(288, 24);
            this.txt_find_name.TabIndex = 5;
            // 
            // txt_find_id
            // 
            this.txt_find_id.Location = new System.Drawing.Point(20, 62);
            this.txt_find_id.Name = "txt_find_id";
            this.txt_find_id.Size = new System.Drawing.Size(288, 24);
            this.txt_find_id.TabIndex = 4;
            // 
            // cb_find_pc
            // 
            this.cb_find_pc.AutoSize = true;
            this.cb_find_pc.Location = new System.Drawing.Point(22, 294);
            this.cb_find_pc.Name = "cb_find_pc";
            this.cb_find_pc.Size = new System.Drawing.Size(87, 22);
            this.cb_find_pc.TabIndex = 3;
            this.cb_find_pc.Text = "Phu Cap";
            this.cb_find_pc.UseVisualStyleBackColor = true;
            // 
            // cb_find_date
            // 
            this.cb_find_date.AutoSize = true;
            this.cb_find_date.Location = new System.Drawing.Point(22, 190);
            this.cb_find_date.Name = "cb_find_date";
            this.cb_find_date.Size = new System.Drawing.Size(127, 22);
            this.cb_find_date.TabIndex = 2;
            this.cb_find_date.Text = "Ngay thanh lap";
            this.cb_find_date.UseVisualStyleBackColor = true;
            // 
            // cb_find_name
            // 
            this.cb_find_name.AutoSize = true;
            this.cb_find_name.Location = new System.Drawing.Point(22, 113);
            this.cb_find_name.Name = "cb_find_name";
            this.cb_find_name.Size = new System.Drawing.Size(128, 22);
            this.cb_find_name.TabIndex = 1;
            this.cb_find_name.Text = "Ten phong ban";
            this.cb_find_name.UseVisualStyleBackColor = true;
            // 
            // cb_find_id
            // 
            this.cb_find_id.AutoSize = true;
            this.cb_find_id.Location = new System.Drawing.Point(22, 26);
            this.cb_find_id.Name = "cb_find_id";
            this.cb_find_id.Size = new System.Drawing.Size(124, 22);
            this.cb_find_id.TabIndex = 0;
            this.cb_find_id.Text = "Ma phong ban";
            this.cb_find_id.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_pc);
            this.groupBox2.Controls.Add(this.txt_date);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(378, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1011, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thong tin";
            // 
            // txt_pc
            // 
            this.txt_pc.Location = new System.Drawing.Point(134, 136);
            this.txt_pc.Name = "txt_pc";
            this.txt_pc.Size = new System.Drawing.Size(288, 24);
            this.txt_pc.TabIndex = 14;
            this.txt_pc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pc_KeyPress);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(134, 102);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(288, 24);
            this.txt_date.TabIndex = 13;
            this.txt_date.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_date_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(134, 61);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(288, 24);
            this.txt_name.TabIndex = 12;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(134, 23);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(288, 24);
            this.txt_id.TabIndex = 11;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phu cap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngay thanh lap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten phong ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma phong ban";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Controls.Add(this.btn_sua);
            this.groupBox3.Controls.Add(this.btn_them);
            this.groupBox3.Location = new System.Drawing.Point(378, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1011, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chuc nang";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(443, 28);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(197, 98);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xoa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(240, 28);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(197, 98);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sua";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(27, 28);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(197, 98);
            this.btn_them.TabIndex = 11;
            this.btn_them.Text = "Them";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_load_pb);
            this.groupBox4.Location = new System.Drawing.Point(378, 360);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1011, 433);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Du lieu";
            // 
            // dgv_load_pb
            // 
            this.dgv_load_pb.AllowUserToAddRows = false;
            this.dgv_load_pb.AllowUserToDeleteRows = false;
            this.dgv_load_pb.AllowUserToResizeColumns = false;
            this.dgv_load_pb.AllowUserToResizeRows = false;
            this.dgv_load_pb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_load_pb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhongBan,
            this.colTenPhongBan,
            this.colNgayThanhLap,
            this.colPhuCap});
            this.dgv_load_pb.Location = new System.Drawing.Point(14, 20);
            this.dgv_load_pb.Name = "dgv_load_pb";
            this.dgv_load_pb.RowHeadersWidth = 51;
            this.dgv_load_pb.RowTemplate.Height = 24;
            this.dgv_load_pb.Size = new System.Drawing.Size(981, 412);
            this.dgv_load_pb.TabIndex = 0;
            this.dgv_load_pb.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_load_pb_RowEnter);
            // 
            // colMaPhongBan
            // 
            this.colMaPhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaPhongBan.DataPropertyName = "MaPhongBan";
            this.colMaPhongBan.HeaderText = "MaPhongBan";
            this.colMaPhongBan.MinimumWidth = 6;
            this.colMaPhongBan.Name = "colMaPhongBan";
            this.colMaPhongBan.ReadOnly = true;
            // 
            // colTenPhongBan
            // 
            this.colTenPhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenPhongBan.DataPropertyName = "TenPhongBan";
            this.colTenPhongBan.HeaderText = "TenPhongBan";
            this.colTenPhongBan.MinimumWidth = 6;
            this.colTenPhongBan.Name = "colTenPhongBan";
            this.colTenPhongBan.ReadOnly = true;
            // 
            // colNgayThanhLap
            // 
            this.colNgayThanhLap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNgayThanhLap.DataPropertyName = "NgayThanhLap";
            this.colNgayThanhLap.HeaderText = "NgayThanhLap";
            this.colNgayThanhLap.MinimumWidth = 6;
            this.colNgayThanhLap.Name = "colNgayThanhLap";
            this.colNgayThanhLap.ReadOnly = true;
            // 
            // colPhuCap
            // 
            this.colPhuCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhuCap.DataPropertyName = "PhuCap";
            this.colPhuCap.HeaderText = "PhuCap";
            this.colPhuCap.MinimumWidth = 6;
            this.colPhuCap.Name = "colPhuCap";
            this.colPhuCap.ReadOnly = true;
            // 
            // erp_loi
            // 
            this.erp_loi.ContainerControl = this;
            // 
            // FrmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 814);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPhongBan";
            this.Text = "FrmPhongBan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_load_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erp_loi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox txt_find_pc;
        private System.Windows.Forms.TextBox txt_find_date;
        private System.Windows.Forms.TextBox txt_find_name;
        private System.Windows.Forms.TextBox txt_find_id;
        private System.Windows.Forms.CheckBox cb_find_pc;
        private System.Windows.Forms.CheckBox cb_find_date;
        private System.Windows.Forms.CheckBox cb_find_name;
        private System.Windows.Forms.CheckBox cb_find_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pc;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridView dgv_load_pb;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayThanhLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhuCap;
        private System.Windows.Forms.ErrorProvider erp_loi;
    }
}