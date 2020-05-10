namespace GDU_Management
{
    partial class frmDanhSachLop
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
            this.pnDanhSachLop = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnExportDSLop = new System.Windows.Forms.Button();
            this.txtTimKiemLop = new System.Windows.Forms.TextBox();
            this.pnControl = new System.Windows.Forms.Panel();
            this.btnDeleteLop = new System.Windows.Forms.Button();
            this.btnNewLop = new System.Windows.Forms.Button();
            this.btnUpdateLop = new System.Windows.Forms.Button();
            this.btnSaveLop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STTLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDanhSachLop = new System.Windows.Forms.GroupBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDanhSachLop.SuspendLayout();
            this.pnControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbDanhSachLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDanhSachLop
            // 
            this.pnDanhSachLop.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnDanhSachLop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDanhSachLop.Controls.Add(this.lblClose);
            this.pnDanhSachLop.Controls.Add(this.label4);
            this.pnDanhSachLop.Controls.Add(this.label11);
            this.pnDanhSachLop.Controls.Add(this.btnExportDSLop);
            this.pnDanhSachLop.Controls.Add(this.txtTimKiemLop);
            this.pnDanhSachLop.Controls.Add(this.pnControl);
            this.pnDanhSachLop.Controls.Add(this.label3);
            this.pnDanhSachLop.Controls.Add(this.dataGridView1);
            this.pnDanhSachLop.Controls.Add(this.grbDanhSachLop);
            this.pnDanhSachLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDanhSachLop.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pnDanhSachLop.Location = new System.Drawing.Point(12, 12);
            this.pnDanhSachLop.Name = "pnDanhSachLop";
            this.pnDanhSachLop.Size = new System.Drawing.Size(889, 519);
            this.pnDanhSachLop.TabIndex = 1;
            // 
            // lblClose
            // 
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Image = global::GDU_Management.Properties.Resources.icons8_closed_60;
            this.lblClose.Location = new System.Drawing.Point(674, 436);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(178, 73);
            this.lblClose.TabIndex = 24;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label4
            // 
            this.label4.Image = global::GDU_Management.Properties.Resources.logo_03_03;
            this.label4.Location = new System.Drawing.Point(559, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 115);
            this.label4.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Image = global::GDU_Management.Properties.Resources.icon_gdumanagement_ps_13;
            this.label11.Location = new System.Drawing.Point(724, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 114);
            this.label11.TabIndex = 22;
            // 
            // btnExportDSLop
            // 
            this.btnExportDSLop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExportDSLop.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportDSLop.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExportDSLop.Image = global::GDU_Management.Properties.Resources.icons8_print_40;
            this.btnExportDSLop.Location = new System.Drawing.Point(674, 135);
            this.btnExportDSLop.Name = "btnExportDSLop";
            this.btnExportDSLop.Size = new System.Drawing.Size(178, 51);
            this.btnExportDSLop.TabIndex = 15;
            this.btnExportDSLop.UseVisualStyleBackColor = false;
            // 
            // txtTimKiemLop
            // 
            this.txtTimKiemLop.Location = new System.Drawing.Point(145, 145);
            this.txtTimKiemLop.Name = "txtTimKiemLop";
            this.txtTimKiemLop.Size = new System.Drawing.Size(312, 27);
            this.txtTimKiemLop.TabIndex = 9;
            this.txtTimKiemLop.Text = "Nhập Thông Tin Để Tìm Kiếm";
            // 
            // pnControl
            // 
            this.pnControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnControl.Controls.Add(this.btnDeleteLop);
            this.pnControl.Controls.Add(this.btnNewLop);
            this.pnControl.Controls.Add(this.btnUpdateLop);
            this.pnControl.Controls.Add(this.btnSaveLop);
            this.pnControl.Location = new System.Drawing.Point(14, 454);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(579, 55);
            this.pnControl.TabIndex = 7;
            // 
            // btnDeleteLop
            // 
            this.btnDeleteLop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDeleteLop.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteLop.Image = global::GDU_Management.Properties.Resources.icons_delete_3;
            this.btnDeleteLop.Location = new System.Drawing.Point(434, 3);
            this.btnDeleteLop.Name = "btnDeleteLop";
            this.btnDeleteLop.Size = new System.Drawing.Size(140, 45);
            this.btnDeleteLop.TabIndex = 6;
            this.btnDeleteLop.UseVisualStyleBackColor = false;
            // 
            // btnNewLop
            // 
            this.btnNewLop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNewLop.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNewLop.Image = global::GDU_Management.Properties.Resources.icon_lop_2;
            this.btnNewLop.Location = new System.Drawing.Point(3, 3);
            this.btnNewLop.Name = "btnNewLop";
            this.btnNewLop.Size = new System.Drawing.Size(125, 45);
            this.btnNewLop.TabIndex = 3;
            this.btnNewLop.UseVisualStyleBackColor = false;
            // 
            // btnUpdateLop
            // 
            this.btnUpdateLop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUpdateLop.Image = global::GDU_Management.Properties.Resources.icons_update_30;
            this.btnUpdateLop.Location = new System.Drawing.Point(286, 3);
            this.btnUpdateLop.Name = "btnUpdateLop";
            this.btnUpdateLop.Size = new System.Drawing.Size(140, 45);
            this.btnUpdateLop.TabIndex = 5;
            this.btnUpdateLop.UseVisualStyleBackColor = false;
            // 
            // btnSaveLop
            // 
            this.btnSaveLop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSaveLop.Image = global::GDU_Management.Properties.Resources.icons_save_2;
            this.btnSaveLop.Location = new System.Drawing.Point(140, 3);
            this.btnSaveLop.Name = "btnSaveLop";
            this.btnSaveLop.Size = new System.Drawing.Size(140, 45);
            this.btnSaveLop.TabIndex = 4;
            this.btnSaveLop.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tìm Kiếm:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTLop,
            this.MaLop,
            this.TenLop});
            this.dataGridView1.Location = new System.Drawing.Point(14, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(870, 241);
            this.dataGridView1.TabIndex = 1;
            // 
            // STTLop
            // 
            this.STTLop.HeaderText = "STT";
            this.STTLop.MinimumWidth = 6;
            this.STTLop.Name = "STTLop";
            this.STTLop.ReadOnly = true;
            this.STTLop.Width = 125;
            // 
            // MaLop
            // 
            this.MaLop.HeaderText = "MaLop";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            this.MaLop.Width = 125;
            // 
            // TenLop
            // 
            this.TenLop.HeaderText = "Tên Lớp";
            this.TenLop.MinimumWidth = 6;
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            this.TenLop.Width = 125;
            // 
            // grbDanhSachLop
            // 
            this.grbDanhSachLop.Controls.Add(this.txtTenLop);
            this.grbDanhSachLop.Controls.Add(this.txtMaLop);
            this.grbDanhSachLop.Controls.Add(this.label2);
            this.grbDanhSachLop.Controls.Add(this.label1);
            this.grbDanhSachLop.Location = new System.Drawing.Point(14, 4);
            this.grbDanhSachLop.Name = "grbDanhSachLop";
            this.grbDanhSachLop.Size = new System.Drawing.Size(449, 125);
            this.grbDanhSachLop.TabIndex = 0;
            this.grbDanhSachLop.TabStop = false;
            this.grbDanhSachLop.Text = "THÔNG TIN LỚP";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(131, 74);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(312, 27);
            this.txtTenLop.TabIndex = 3;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(131, 36);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(163, 27);
            this.txtMaLop.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp:";
            // 
            // frmDanhSachLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(913, 543);
            this.Controls.Add(this.pnDanhSachLop);
            this.Name = "frmDanhSachLop";
            this.Text = "frmDanhSachLop";
            this.pnDanhSachLop.ResumeLayout(false);
            this.pnDanhSachLop.PerformLayout();
            this.pnControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbDanhSachLop.ResumeLayout(false);
            this.grbDanhSachLop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDanhSachLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnExportDSLop;
        private System.Windows.Forms.TextBox txtTimKiemLop;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Button btnDeleteLop;
        private System.Windows.Forms.Button btnNewLop;
        private System.Windows.Forms.Button btnUpdateLop;
        private System.Windows.Forms.Button btnSaveLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbDanhSachLop;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.Label lblClose;
    }
}