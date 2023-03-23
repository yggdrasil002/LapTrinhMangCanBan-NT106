namespace Lab1_21522164_Quách_Minh_Huy
{
    partial class FrmDoiTien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txtXuat = new System.Windows.Forms.TextBox();
            this.cboTien = new System.Windows.Forms.ComboBox();
            this.lbTyGiaThayDoi = new System.Windows.Forms.Label();
            this.btnChuyenDoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tiền cần đổi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền đã đổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tỷ giá quy đổi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chuyển đổi tiền tệ";
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(181, 77);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(221, 26);
            this.txtNhap.TabIndex = 4;
            // 
            // txtXuat
            // 
            this.txtXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXuat.Location = new System.Drawing.Point(181, 233);
            this.txtXuat.Name = "txtXuat";
            this.txtXuat.Size = new System.Drawing.Size(221, 26);
            this.txtXuat.TabIndex = 5;
            // 
            // cboTien
            // 
            this.cboTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTien.FormattingEnabled = true;
            this.cboTien.Location = new System.Drawing.Point(473, 75);
            this.cboTien.Name = "cboTien";
            this.cboTien.Size = new System.Drawing.Size(199, 28);
            this.cboTien.TabIndex = 6;
            this.cboTien.SelectedValueChanged += new System.EventHandler(this.cboTien_SelectedValueChanged);
            // 
            // lbTyGiaThayDoi
            // 
            this.lbTyGiaThayDoi.AutoSize = true;
            this.lbTyGiaThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTyGiaThayDoi.Location = new System.Drawing.Point(177, 291);
            this.lbTyGiaThayDoi.Name = "lbTyGiaThayDoi";
            this.lbTyGiaThayDoi.Size = new System.Drawing.Size(0, 20);
            this.lbTyGiaThayDoi.TabIndex = 8;
            // 
            // btnChuyenDoi
            // 
            this.btnChuyenDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenDoi.Location = new System.Drawing.Point(40, 148);
            this.btnChuyenDoi.Name = "btnChuyenDoi";
            this.btnChuyenDoi.Size = new System.Drawing.Size(362, 40);
            this.btnChuyenDoi.TabIndex = 9;
            this.btnChuyenDoi.Text = "Chuyển đổi";
            this.btnChuyenDoi.UseVisualStyleBackColor = true;
            this.btnChuyenDoi.Click += new System.EventHandler(this.btnChuyenDoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(571, 179);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 130);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmDoiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 385);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChuyenDoi);
            this.Controls.Add(this.lbTyGiaThayDoi);
            this.Controls.Add(this.cboTien);
            this.Controls.Add(this.txtXuat);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoiTien";
            this.Text = "Bài_4";
            this.Load += new System.EventHandler(this.FrmDoiTien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.TextBox txtXuat;
        private System.Windows.Forms.ComboBox cboTien;
        private System.Windows.Forms.Label lbTyGiaThayDoi;
        private System.Windows.Forms.Button btnChuyenDoi;
        private System.Windows.Forms.Button btnThoat;
    }
}