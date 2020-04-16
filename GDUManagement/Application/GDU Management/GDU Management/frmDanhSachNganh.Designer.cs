namespace GDU_Management
{
    partial class frmDanhSachNganh
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
            this.btnClose = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbDanhSachLop = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.txtTenNganh = new System.Windows.Forms.TextBox();
            this.btnExportDSNganh = new System.Windows.Forms.Button();
            this.dgvDSNganh = new System.Windows.Forms.DataGridView();
            this.pnControl = new System.Windows.Forms.Panel();
            this.btnSaveNganh = new System.Windows.Forms.Button();
            this.btnUpdateNganh = new System.Windows.Forms.Button();
            this.btnNewNganh = new System.Windows.Forms.Button();
            this.btnDeleteNganh = new System.Windows.Forms.Button();
            this.pnDanhSachNganh = new System.Windows.Forms.Panel();
            this.txtTimKiemNganh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.STTNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDanhSachLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNganh)).BeginInit();
            this.pnControl.SuspendLayout();
            this.pnDanhSachNganh.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(635, 467);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(216, 55);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.UseWaitCursor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label11
            // 
            this.label11.Image = global::GDU_Management.Properties.Resources.icon_gdumanagement_ps_13;
            this.label11.Location = new System.Drawing.Point(723, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 114);
            this.label11.TabIndex = 22;
            this.label11.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.Image = global::GDU_Management.Properties.Resources.logo_03_03;
            this.label4.Location = new System.Drawing.Point(558, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 115);
            this.label4.TabIndex = 23;
            this.label4.UseWaitCursor = true;
            // 
            // grbDanhSachLop
            // 
            this.grbDanhSachLop.Controls.Add(this.txtTenNganh);
            this.grbDanhSachLop.Controls.Add(this.txtMaNganh);
            this.grbDanhSachLop.Controls.Add(this.label2);
            this.grbDanhSachLop.Controls.Add(this.label1);
            this.grbDanhSachLop.Location = new System.Drawing.Point(13, 17);
            this.grbDanhSachLop.Name = "grbDanhSachLop";
            this.grbDanhSachLop.Size = new System.Drawing.Size(449, 125);
            this.grbDanhSachLop.TabIndex = 24;
            this.grbDanhSachLop.TabStop = false;
            this.grbDanhSachLop.Text = "THÔNG TIN LỚP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Ngành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Ngành:";
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Location = new System.Drawing.Point(131, 36);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(163, 22);
            this.txtMaNganh.TabIndex = 2;
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Location = new System.Drawing.Point(131, 74);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Size = new System.Drawing.Size(312, 22);
            this.txtTenNganh.TabIndex = 3;
            // 
            // btnExportDSNganh
            // 
            this.btnExportDSNganh.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportDSNganh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExportDSNganh.Location = new System.Drawing.Point(635, 158);
            this.btnExportDSNganh.Name = "btnExportDSNganh";
            this.btnExportDSNganh.Size = new System.Drawing.Size(216, 42);
            this.btnExportDSNganh.TabIndex = 16;
            this.btnExportDSNganh.Text = "EXPORT ";
            this.btnExportDSNganh.UseVisualStyleBackColor = true;
            // 
            // dgvDSNganh
            // 
            this.dgvDSNganh.AllowUserToAddRows = false;
            this.dgvDSNganh.AllowUserToDeleteRows = false;
            this.dgvDSNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTNganh,
            this.MaNganh,
            this.TenNganh});
            this.dgvDSNganh.Location = new System.Drawing.Point(3, 206);
            this.dgvDSNganh.Name = "dgvDSNganh";
            this.dgvDSNganh.ReadOnly = true;
            this.dgvDSNganh.RowHeadersWidth = 51;
            this.dgvDSNganh.RowTemplate.Height = 24;
            this.dgvDSNganh.Size = new System.Drawing.Size(870, 241);
            this.dgvDSNganh.TabIndex = 25;
            // 
            // pnControl
            // 
            this.pnControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnControl.Controls.Add(this.btnDeleteNganh);
            this.pnControl.Controls.Add(this.btnNewNganh);
            this.pnControl.Controls.Add(this.btnUpdateNganh);
            this.pnControl.Controls.Add(this.btnSaveNganh);
            this.pnControl.Location = new System.Drawing.Point(3, 468);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(579, 55);
            this.pnControl.TabIndex = 26;
            // 
            // btnSaveNganh
            // 
            this.btnSaveNganh.Location = new System.Drawing.Point(154, 13);
            this.btnSaveNganh.Name = "btnSaveNganh";
            this.btnSaveNganh.Size = new System.Drawing.Size(84, 30);
            this.btnSaveNganh.TabIndex = 4;
            this.btnSaveNganh.Text = "SAVE";
            this.btnSaveNganh.UseVisualStyleBackColor = true;
            // 
            // btnUpdateNganh
            // 
            this.btnUpdateNganh.Location = new System.Drawing.Point(300, 13);
            this.btnUpdateNganh.Name = "btnUpdateNganh";
            this.btnUpdateNganh.Size = new System.Drawing.Size(97, 30);
            this.btnUpdateNganh.TabIndex = 5;
            this.btnUpdateNganh.Text = "UPDATE";
            this.btnUpdateNganh.UseVisualStyleBackColor = true;
            // 
            // btnNewNganh
            // 
            this.btnNewNganh.Location = new System.Drawing.Point(15, 13);
            this.btnNewNganh.Name = "btnNewNganh";
            this.btnNewNganh.Size = new System.Drawing.Size(84, 30);
            this.btnNewNganh.TabIndex = 3;
            this.btnNewNganh.Text = "NEW";
            this.btnNewNganh.UseVisualStyleBackColor = true;
            // 
            // btnDeleteNganh
            // 
            this.btnDeleteNganh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDeleteNganh.Location = new System.Drawing.Point(432, 13);
            this.btnDeleteNganh.Name = "btnDeleteNganh";
            this.btnDeleteNganh.Size = new System.Drawing.Size(121, 30);
            this.btnDeleteNganh.TabIndex = 6;
            this.btnDeleteNganh.Text = "DELETE";
            this.btnDeleteNganh.UseVisualStyleBackColor = true;
            // 
            // pnDanhSachNganh
            // 
            this.pnDanhSachNganh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnDanhSachNganh.Controls.Add(this.txtTimKiemNganh);
            this.pnDanhSachNganh.Controls.Add(this.pnControl);
            this.pnDanhSachNganh.Controls.Add(this.label3);
            this.pnDanhSachNganh.Controls.Add(this.dgvDSNganh);
            this.pnDanhSachNganh.Controls.Add(this.btnExportDSNganh);
            this.pnDanhSachNganh.Controls.Add(this.grbDanhSachLop);
            this.pnDanhSachNganh.Controls.Add(this.label4);
            this.pnDanhSachNganh.Controls.Add(this.label11);
            this.pnDanhSachNganh.Controls.Add(this.btnClose);
            this.pnDanhSachNganh.Location = new System.Drawing.Point(13, 13);
            this.pnDanhSachNganh.Name = "pnDanhSachNganh";
            this.pnDanhSachNganh.Size = new System.Drawing.Size(892, 530);
            this.pnDanhSachNganh.TabIndex = 24;
            this.pnDanhSachNganh.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDanhSachNganh_Paint);
            // 
            // txtTimKiemNganh
            // 
            this.txtTimKiemNganh.Location = new System.Drawing.Point(137, 158);
            this.txtTimKiemNganh.Name = "txtTimKiemNganh";
            this.txtTimKiemNganh.Size = new System.Drawing.Size(319, 22);
            this.txtTimKiemNganh.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tìm Kiếm:";
            // 
            // STTNganh
            // 
            this.STTNganh.HeaderText = "STT";
            this.STTNganh.MinimumWidth = 6;
            this.STTNganh.Name = "STTNganh";
            this.STTNganh.ReadOnly = true;
            this.STTNganh.Width = 125;
            // 
            // MaNganh
            // 
            this.MaNganh.HeaderText = "Mã Ngành";
            this.MaNganh.MinimumWidth = 6;
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.ReadOnly = true;
            this.MaNganh.Width = 125;
            // 
            // TenNganh
            // 
            this.TenNganh.HeaderText = "Tên Ngành";
            this.TenNganh.MinimumWidth = 6;
            this.TenNganh.Name = "TenNganh";
            this.TenNganh.ReadOnly = true;
            this.TenNganh.Width = 125;
            // 
            // frmDanhSachNganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(916, 555);
            this.Controls.Add(this.pnDanhSachNganh);
            this.Name = "frmDanhSachNganh";
            this.Text = "frmDanhSachNganh";
            this.grbDanhSachLop.ResumeLayout(false);
            this.grbDanhSachLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNganh)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.pnDanhSachNganh.ResumeLayout(false);
            this.pnDanhSachNganh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbDanhSachLop;
        private System.Windows.Forms.TextBox txtTenNganh;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportDSNganh;
        private System.Windows.Forms.DataGridView dgvDSNganh;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Button btnDeleteNganh;
        private System.Windows.Forms.Button btnNewNganh;
        private System.Windows.Forms.Button btnUpdateNganh;
        private System.Windows.Forms.Button btnSaveNganh;
        private System.Windows.Forms.Panel pnDanhSachNganh;
        private System.Windows.Forms.TextBox txtTimKiemNganh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNganh;
    }
}