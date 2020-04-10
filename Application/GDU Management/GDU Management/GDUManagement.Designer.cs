namespace GDU_Management
{
    partial class GDUManagement
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
            this.pnContents = new System.Windows.Forms.Panel();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lvlVersion = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThoatChuongTrinh = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnDiemSinhVien = new System.Windows.Forms.Panel();
            this.lblDSV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnThoiKhoaBieu = new System.Windows.Forms.Panel();
            this.lblTKB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnPhanCongCongViec = new System.Windows.Forms.Panel();
            this.lblPCCV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnStatusTopLeft = new System.Windows.Forms.Panel();
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.grbDay = new System.Windows.Forms.GroupBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblLogoGDU = new System.Windows.Forms.Panel();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.timerHelloAdmin = new System.Windows.Forms.Timer(this.components);
            this.pnQuanLySinhVien = new System.Windows.Forms.Panel();
            this.lblQLSV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnContents.SuspendLayout();
            this.pnTitle.SuspendLayout();
            this.panel10.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnDiemSinhVien.SuspendLayout();
            this.pnThoiKhoaBieu.SuspendLayout();
            this.pnPhanCongCongViec.SuspendLayout();
            this.pnStatusTopLeft.SuspendLayout();
            this.grbTime.SuspendLayout();
            this.grbDay.SuspendLayout();
            this.pnQuanLySinhVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContents
            // 
            this.pnContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnContents.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnContents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnContents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContents.Controls.Add(this.pnTitle);
            this.pnContents.Controls.Add(this.lvlVersion);
            this.pnContents.Controls.Add(this.panel10);
            this.pnContents.Controls.Add(this.pnMenu);
            this.pnContents.Controls.Add(this.pnStatusTopLeft);
            this.pnContents.Controls.Add(this.pnLogo);
            this.pnContents.ForeColor = System.Drawing.Color.Navy;
            this.pnContents.Location = new System.Drawing.Point(13, 13);
            this.pnContents.Name = "pnContents";
            this.pnContents.Size = new System.Drawing.Size(1144, 609);
            this.pnContents.TabIndex = 0;
            this.pnContents.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnTitle
            // 
            this.pnTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Location = new System.Drawing.Point(25, 157);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(477, 28);
            this.pnTitle.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hello Admin...!!!";
            // 
            // lvlVersion
            // 
            this.lvlVersion.AllowDrop = true;
            this.lvlVersion.Font = new System.Drawing.Font("Microsoft Uighur", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlVersion.Location = new System.Drawing.Point(19, 517);
            this.lvlVersion.Name = "lvlVersion";
            this.lvlVersion.Size = new System.Drawing.Size(214, 58);
            this.lvlVersion.TabIndex = 14;
            this.lvlVersion.Text = "Future Pass\r\nGDU Management v1.0\r\n";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.btnDangXuat);
            this.panel10.Controls.Add(this.btnThoatChuongTrinh);
            this.panel10.Location = new System.Drawing.Point(599, 522);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(517, 71);
            this.panel10.TabIndex = 13;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(15, 15);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(215, 43);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThoatChuongTrinh
            // 
            this.btnThoatChuongTrinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatChuongTrinh.Location = new System.Drawing.Point(271, 15);
            this.btnThoatChuongTrinh.Name = "btnThoatChuongTrinh";
            this.btnThoatChuongTrinh.Size = new System.Drawing.Size(215, 43);
            this.btnThoatChuongTrinh.TabIndex = 9;
            this.btnThoatChuongTrinh.Text = "Thoát Chương Trình";
            this.btnThoatChuongTrinh.UseVisualStyleBackColor = true;
            this.btnThoatChuongTrinh.Click += new System.EventHandler(this.btnThoatChuongTrinh_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMenu.Controls.Add(this.pnQuanLySinhVien);
            this.pnMenu.Controls.Add(this.pnDiemSinhVien);
            this.pnMenu.Controls.Add(this.pnThoiKhoaBieu);
            this.pnMenu.Controls.Add(this.pnPhanCongCongViec);
            this.pnMenu.Location = new System.Drawing.Point(599, 6);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(517, 508);
            this.pnMenu.TabIndex = 12;
            // 
            // pnDiemSinhVien
            // 
            this.pnDiemSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDiemSinhVien.Controls.Add(this.lblDSV);
            this.pnDiemSinhVien.Controls.Add(this.label4);
            this.pnDiemSinhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnDiemSinhVien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pnDiemSinhVien.Location = new System.Drawing.Point(25, 166);
            this.pnDiemSinhVien.Name = "pnDiemSinhVien";
            this.pnDiemSinhVien.Size = new System.Drawing.Size(471, 104);
            this.pnDiemSinhVien.TabIndex = 4;
            // 
            // lblDSV
            // 
            this.lblDSV.AutoSize = true;
            this.lblDSV.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSV.Location = new System.Drawing.Point(109, 31);
            this.lblDSV.Name = "lblDSV";
            this.lblDSV.Size = new System.Drawing.Size(240, 36);
            this.lblDSV.TabIndex = 1;
            this.lblDSV.Text = "ĐIỂM SINH VIÊN";
            this.lblDSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDSV.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.Image = global::GDU_Management.Properties.Resources.icon_diem;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 102);
            this.label4.TabIndex = 0;
            // 
            // pnThoiKhoaBieu
            // 
            this.pnThoiKhoaBieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnThoiKhoaBieu.Controls.Add(this.lblTKB);
            this.pnThoiKhoaBieu.Controls.Add(this.label6);
            this.pnThoiKhoaBieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnThoiKhoaBieu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pnThoiKhoaBieu.Location = new System.Drawing.Point(25, 276);
            this.pnThoiKhoaBieu.Name = "pnThoiKhoaBieu";
            this.pnThoiKhoaBieu.Size = new System.Drawing.Size(471, 104);
            this.pnThoiKhoaBieu.TabIndex = 6;
            // 
            // lblTKB
            // 
            this.lblTKB.AutoSize = true;
            this.lblTKB.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTKB.Location = new System.Drawing.Point(109, 31);
            this.lblTKB.Name = "lblTKB";
            this.lblTKB.Size = new System.Drawing.Size(248, 36);
            this.lblTKB.TabIndex = 1;
            this.lblTKB.Text = "THỜI KHÓA BIỂU";
            this.lblTKB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTKB.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.Image = global::GDU_Management.Properties.Resources.icon_thoi_khoa_bieu;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 102);
            this.label6.TabIndex = 0;
            // 
            // pnPhanCongCongViec
            // 
            this.pnPhanCongCongViec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPhanCongCongViec.Controls.Add(this.lblPCCV);
            this.pnPhanCongCongViec.Controls.Add(this.label8);
            this.pnPhanCongCongViec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnPhanCongCongViec.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pnPhanCongCongViec.Location = new System.Drawing.Point(25, 386);
            this.pnPhanCongCongViec.Name = "pnPhanCongCongViec";
            this.pnPhanCongCongViec.Size = new System.Drawing.Size(471, 104);
            this.pnPhanCongCongViec.TabIndex = 7;
            // 
            // lblPCCV
            // 
            this.lblPCCV.AutoSize = true;
            this.lblPCCV.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPCCV.Location = new System.Drawing.Point(109, 31);
            this.lblPCCV.Name = "lblPCCV";
            this.lblPCCV.Size = new System.Drawing.Size(318, 32);
            this.lblPCCV.TabIndex = 1;
            this.lblPCCV.Text = "PHÂN CÔNG CÔNG VIỆC";
            this.lblPCCV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPCCV.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.Image = global::GDU_Management.Properties.Resources.icon_lich_cong_tac;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 102);
            this.label8.TabIndex = 0;
            // 
            // pnStatusTopLeft
            // 
            this.pnStatusTopLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnStatusTopLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnStatusTopLeft.Controls.Add(this.grbTime);
            this.pnStatusTopLeft.Controls.Add(this.grbDay);
            this.pnStatusTopLeft.Controls.Add(this.lblLogoGDU);
            this.pnStatusTopLeft.Location = new System.Drawing.Point(25, 6);
            this.pnStatusTopLeft.Name = "pnStatusTopLeft";
            this.pnStatusTopLeft.Size = new System.Drawing.Size(475, 142);
            this.pnStatusTopLeft.TabIndex = 11;
            // 
            // grbTime
            // 
            this.grbTime.Controls.Add(this.lblTime);
            this.grbTime.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTime.Location = new System.Drawing.Point(33, 3);
            this.grbTime.Name = "grbTime";
            this.grbTime.Size = new System.Drawing.Size(192, 64);
            this.grbTime.TabIndex = 2;
            this.grbTime.TabStop = false;
            this.grbTime.Text = "Time";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(6, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(117, 30);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00.00.00";
            // 
            // grbDay
            // 
            this.grbDay.Controls.Add(this.lblDay);
            this.grbDay.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDay.Location = new System.Drawing.Point(33, 73);
            this.grbDay.Name = "grbDay";
            this.grbDay.Size = new System.Drawing.Size(192, 64);
            this.grbDay.TabIndex = 1;
            this.grbDay.TabStop = false;
            this.grbDay.Text = "Day";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(6, 27);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(129, 30);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "00/00/00";
            // 
            // lblLogoGDU
            // 
            this.lblLogoGDU.BackgroundImage = global::GDU_Management.Properties.Resources.logo_03_03;
            this.lblLogoGDU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lblLogoGDU.Location = new System.Drawing.Point(268, 3);
            this.lblLogoGDU.Name = "lblLogoGDU";
            this.lblLogoGDU.Size = new System.Drawing.Size(208, 138);
            this.lblLogoGDU.TabIndex = 4;
            // 
            // pnLogo
            // 
            this.pnLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLogo.BackgroundImage = global::GDU_Management.Properties.Resources.icon_gdumanagement_ps_40;
            this.pnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnLogo.Location = new System.Drawing.Point(25, 191);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(475, 323);
            this.pnLogo.TabIndex = 10;
            // 
            // timerHelloAdmin
            // 
            this.timerHelloAdmin.Tick += new System.EventHandler(this.timerHelloAdmin_Tick);
            // 
            // pnQuanLySinhVien
            // 
            this.pnQuanLySinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnQuanLySinhVien.Controls.Add(this.lblQLSV);
            this.pnQuanLySinhVien.Controls.Add(this.label2);
            this.pnQuanLySinhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnQuanLySinhVien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pnQuanLySinhVien.Location = new System.Drawing.Point(25, 56);
            this.pnQuanLySinhVien.Name = "pnQuanLySinhVien";
            this.pnQuanLySinhVien.Size = new System.Drawing.Size(471, 104);
            this.pnQuanLySinhVien.TabIndex = 5;
            // 
            // lblQLSV
            // 
            this.lblQLSV.AutoSize = true;
            this.lblQLSV.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLSV.Location = new System.Drawing.Point(109, 31);
            this.lblQLSV.Name = "lblQLSV";
            this.lblQLSV.Size = new System.Drawing.Size(290, 36);
            this.lblQLSV.TabIndex = 1;
            this.lblQLSV.Text = "QUẢN LÝ SINH VIÊN";
            this.lblQLSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQLSV.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Image = global::GDU_Management.Properties.Resources.icon_quan_ly_sinh_vien;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 102);
            this.label2.TabIndex = 0;
            // 
            // GDUManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1169, 634);
            this.Controls.Add(this.pnContents);
            this.Name = "GDUManagement";
            this.Text = " GDU Management";
            this.Load += new System.EventHandler(this.GDUManagement_Load);
            this.pnContents.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnDiemSinhVien.ResumeLayout(false);
            this.pnDiemSinhVien.PerformLayout();
            this.pnThoiKhoaBieu.ResumeLayout(false);
            this.pnThoiKhoaBieu.PerformLayout();
            this.pnPhanCongCongViec.ResumeLayout(false);
            this.pnPhanCongCongViec.PerformLayout();
            this.pnStatusTopLeft.ResumeLayout(false);
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
            this.grbDay.ResumeLayout(false);
            this.grbDay.PerformLayout();
            this.pnQuanLySinhVien.ResumeLayout(false);
            this.pnQuanLySinhVien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContents;
        private System.Windows.Forms.GroupBox grbDay;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Panel lblLogoGDU;
        private System.Windows.Forms.Panel pnPhanCongCongViec;
        private System.Windows.Forms.Label lblPCCV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnThoiKhoaBieu;
        private System.Windows.Forms.Label lblTKB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnDiemSinhVien;
        private System.Windows.Forms.Label lblDSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThoatChuongTrinh;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnStatusTopLeft;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lvlVersion;
        private System.Windows.Forms.GroupBox grbTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timerHelloAdmin;
        private System.Windows.Forms.Panel pnQuanLySinhVien;
        private System.Windows.Forms.Label lblQLSV;
        private System.Windows.Forms.Label label2;
    }
}