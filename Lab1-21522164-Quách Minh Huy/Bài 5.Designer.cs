namespace Lab1_21522164_Quách_Minh_Huy
{
    partial class FrmBai5
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
            this.txtNhapB = new System.Windows.Forms.TextBox();
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.grbKQ = new System.Windows.Forms.GroupBox();
            this.lbAGiaiThua = new System.Windows.Forms.Label();
            this.lbBGiaiThua = new System.Windows.Forms.Label();
            this.lbTongS1 = new System.Windows.Forms.Label();
            this.lbTongS2 = new System.Windows.Forms.Label();
            this.lbTongS3 = new System.Windows.Forms.Label();
            this.grbKQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B";
            // 
            // txtNhapB
            // 
            this.txtNhapB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapB.Location = new System.Drawing.Point(495, 40);
            this.txtNhapB.Name = "txtNhapB";
            this.txtNhapB.Size = new System.Drawing.Size(240, 30);
            this.txtNhapB.TabIndex = 2;
            // 
            // txtNhapA
            // 
            this.txtNhapA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapA.Location = new System.Drawing.Point(146, 40);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(240, 30);
            this.txtNhapA.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(635, 127);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 70);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(495, 127);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 70);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(67, 127);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(373, 70);
            this.btnTinh.TabIndex = 6;
            this.btnTinh.Text = "Tính các giá trị";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // grbKQ
            // 
            this.grbKQ.Controls.Add(this.lbTongS3);
            this.grbKQ.Controls.Add(this.lbTongS2);
            this.grbKQ.Controls.Add(this.lbTongS1);
            this.grbKQ.Controls.Add(this.lbBGiaiThua);
            this.grbKQ.Controls.Add(this.lbAGiaiThua);
            this.grbKQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbKQ.Location = new System.Drawing.Point(67, 238);
            this.grbKQ.Name = "grbKQ";
            this.grbKQ.Size = new System.Drawing.Size(668, 237);
            this.grbKQ.TabIndex = 7;
            this.grbKQ.TabStop = false;
            this.grbKQ.Text = "Kết Quả";
            // 
            // lbAGiaiThua
            // 
            this.lbAGiaiThua.AutoSize = true;
            this.lbAGiaiThua.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbAGiaiThua.Location = new System.Drawing.Point(25, 40);
            this.lbAGiaiThua.Name = "lbAGiaiThua";
            this.lbAGiaiThua.Size = new System.Drawing.Size(0, 23);
            this.lbAGiaiThua.TabIndex = 0;
            // 
            // lbBGiaiThua
            // 
            this.lbBGiaiThua.AutoSize = true;
            this.lbBGiaiThua.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbBGiaiThua.Location = new System.Drawing.Point(346, 40);
            this.lbBGiaiThua.Name = "lbBGiaiThua";
            this.lbBGiaiThua.Size = new System.Drawing.Size(0, 23);
            this.lbBGiaiThua.TabIndex = 1;
            // 
            // lbTongS1
            // 
            this.lbTongS1.AutoSize = true;
            this.lbTongS1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbTongS1.Location = new System.Drawing.Point(25, 90);
            this.lbTongS1.Name = "lbTongS1";
            this.lbTongS1.Size = new System.Drawing.Size(0, 23);
            this.lbTongS1.TabIndex = 2;
            // 
            // lbTongS2
            // 
            this.lbTongS2.AutoSize = true;
            this.lbTongS2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbTongS2.Location = new System.Drawing.Point(25, 140);
            this.lbTongS2.Name = "lbTongS2";
            this.lbTongS2.Size = new System.Drawing.Size(0, 23);
            this.lbTongS2.TabIndex = 3;
            // 
            // lbTongS3
            // 
            this.lbTongS3.AutoSize = true;
            this.lbTongS3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbTongS3.Location = new System.Drawing.Point(25, 190);
            this.lbTongS3.Name = "lbTongS3";
            this.lbTongS3.Size = new System.Drawing.Size(0, 23);
            this.lbTongS3.TabIndex = 4;
            // 
            // FrmBai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 499);
            this.Controls.Add(this.grbKQ);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtNhapA);
            this.Controls.Add(this.txtNhapB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBai5";
            this.Text = "Bài_5";
            this.grbKQ.ResumeLayout(false);
            this.grbKQ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapB;
        private System.Windows.Forms.TextBox txtNhapA;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.GroupBox grbKQ;
        private System.Windows.Forms.Label lbTongS3;
        private System.Windows.Forms.Label lbTongS2;
        private System.Windows.Forms.Label lbTongS1;
        private System.Windows.Forms.Label lbBGiaiThua;
        private System.Windows.Forms.Label lbAGiaiThua;
    }
}