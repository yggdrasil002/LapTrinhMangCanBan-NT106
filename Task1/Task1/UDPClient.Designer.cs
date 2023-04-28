namespace Task1
{
    partial class UDPClient
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
            this.txbIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Remote Host";
            // 
            // txbIP
            // 
            this.txbIP.Location = new System.Drawing.Point(36, 62);
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(262, 26);
            this.txbIP.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(442, 62);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(167, 26);
            this.txbPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Messages";
            // 
            // txbSend
            // 
            this.txbSend.Location = new System.Drawing.Point(36, 184);
            this.txbSend.Multiline = true;
            this.txbSend.Name = "txbSend";
            this.txbSend.Size = new System.Drawing.Size(573, 129);
            this.txbSend.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(36, 341);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(109, 44);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // UDPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 412);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UDPClient";
            this.Text = "UDPClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSend;
        private System.Windows.Forms.Button btnSend;
    }
}