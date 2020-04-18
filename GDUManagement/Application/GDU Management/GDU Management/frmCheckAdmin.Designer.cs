namespace GDU_Management
{
    partial class frmCheckAdmin
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
            this.pnCheckAdmin = new System.Windows.Forms.Panel();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.pnCheckAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCheckAdmin
            // 
            this.pnCheckAdmin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnCheckAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCheckAdmin.Controls.Add(this.btnTroLai);
            this.pnCheckAdmin.Controls.Add(this.btnTiepTuc);
            this.pnCheckAdmin.Controls.Add(this.txtKetQua);
            this.pnCheckAdmin.Controls.Add(this.label3);
            this.pnCheckAdmin.Controls.Add(this.label2);
            this.pnCheckAdmin.Controls.Add(this.label1);
            this.pnCheckAdmin.Location = new System.Drawing.Point(13, 13);
            this.pnCheckAdmin.Name = "pnCheckAdmin";
            this.pnCheckAdmin.Size = new System.Drawing.Size(839, 341);
            this.pnCheckAdmin.TabIndex = 0;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTiepTuc.Location = new System.Drawing.Point(555, 256);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(126, 30);
            this.btnTiepTuc.TabIndex = 4;
            this.btnTiepTuc.Text = "Tiếp Tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(395, 256);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(154, 30);
            this.txtKetQua.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập Đáp án để tiếp tục:";
            // 
            // label2
            // 
            this.label2.Image = global::GDU_Management.Properties.Resources.img_check_admin;
            this.label2.Location = new System.Drawing.Point(45, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 178);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn Có Phải Robot Không...???";
            // 
            // btnTroLai
            // 
            this.btnTroLai.Location = new System.Drawing.Point(696, 255);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(103, 33);
            this.btnTroLai.TabIndex = 11;
            this.btnTroLai.Text = "Trở Lại";
            this.btnTroLai.UseVisualStyleBackColor = true;
            this.btnTroLai.Click += new System.EventHandler(this.btnTroLai_Click);
            // 
            // frmCheckAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(864, 366);
            this.Controls.Add(this.pnCheckAdmin);
            this.Name = "frmCheckAdmin";
            this.pnCheckAdmin.ResumeLayout(false);
            this.pnCheckAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCheckAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTroLai;
    }
}