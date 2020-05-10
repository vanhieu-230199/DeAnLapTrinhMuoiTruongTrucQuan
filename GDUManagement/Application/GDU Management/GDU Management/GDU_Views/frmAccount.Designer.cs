namespace GDU_Management.GDU_View
{
    partial class frmAccount
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
            this.pnAccount = new System.Windows.Forms.Panel();
            this.tabQuanLyAccount = new System.Windows.Forms.TabControl();
            this.tabgQuanTriVien = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnAccount.SuspendLayout();
            this.tabQuanLyAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAccount
            // 
            this.pnAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnAccount.Controls.Add(this.tabQuanLyAccount);
            this.pnAccount.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnAccount.Location = new System.Drawing.Point(13, 13);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(1104, 548);
            this.pnAccount.TabIndex = 0;
            // 
            // tabQuanLyAccount
            // 
            this.tabQuanLyAccount.Controls.Add(this.tabgQuanTriVien);
            this.tabQuanLyAccount.Controls.Add(this.tabPage2);
            this.tabQuanLyAccount.Controls.Add(this.tabPage1);
            this.tabQuanLyAccount.Location = new System.Drawing.Point(4, 3);
            this.tabQuanLyAccount.Name = "tabQuanLyAccount";
            this.tabQuanLyAccount.SelectedIndex = 0;
            this.tabQuanLyAccount.Size = new System.Drawing.Size(1095, 534);
            this.tabQuanLyAccount.TabIndex = 0;
            // 
            // tabgQuanTriVien
            // 
            this.tabgQuanTriVien.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabgQuanTriVien.Location = new System.Drawing.Point(4, 31);
            this.tabgQuanTriVien.Name = "tabgQuanTriVien";
            this.tabgQuanTriVien.Padding = new System.Windows.Forms.Padding(3);
            this.tabgQuanTriVien.Size = new System.Drawing.Size(1087, 499);
            this.tabgQuanTriVien.TabIndex = 0;
            this.tabgQuanTriVien.Text = "Quản trị Viên";
            this.tabgQuanTriVien.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1087, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1087, 499);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 573);
            this.Controls.Add(this.pnAccount);
            this.Name = "frmAccount";
            this.Text = "Account";
            this.pnAccount.ResumeLayout(false);
            this.tabQuanLyAccount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAccount;
        private System.Windows.Forms.TabControl tabQuanLyAccount;
        private System.Windows.Forms.TabPage tabgQuanTriVien;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
    }
}