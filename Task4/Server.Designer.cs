namespace Task4
{
    partial class Server
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
            this.lsvChat = new System.Windows.Forms.ListView();
            this.lbPort = new System.Windows.Forms.Label();
            this.lbIPAddress = new System.Windows.Forms.Label();
            this.txbIPAddress = new System.Windows.Forms.TextBox();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.btnHost = new System.Windows.Forms.Button();
            this.txbSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsvChat
            // 
            this.lsvChat.HideSelection = false;
            this.lsvChat.Location = new System.Drawing.Point(15, 108);
            this.lsvChat.Margin = new System.Windows.Forms.Padding(4);
            this.lsvChat.Name = "lsvChat";
            this.lsvChat.Size = new System.Drawing.Size(931, 406);
            this.lsvChat.TabIndex = 0;
            this.lsvChat.UseCompatibleStateImageBehavior = false;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(11, 55);
            this.lbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(40, 20);
            this.lbPort.TabIndex = 1;
            this.lbPort.Text = "Port";
            // 
            // lbIPAddress
            // 
            this.lbIPAddress.AutoSize = true;
            this.lbIPAddress.Location = new System.Drawing.Point(11, 18);
            this.lbIPAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIPAddress.Name = "lbIPAddress";
            this.lbIPAddress.Size = new System.Drawing.Size(86, 20);
            this.lbIPAddress.TabIndex = 1;
            this.lbIPAddress.Text = "IPAddress";
            // 
            // txbIPAddress
            // 
            this.txbIPAddress.Location = new System.Drawing.Point(132, 15);
            this.txbIPAddress.Name = "txbIPAddress";
            this.txbIPAddress.Size = new System.Drawing.Size(306, 26);
            this.txbIPAddress.TabIndex = 2;
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(132, 52);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(210, 26);
            this.txbPort.TabIndex = 3;
            // 
            // btnHost
            // 
            this.btnHost.Location = new System.Drawing.Point(756, 18);
            this.btnHost.Name = "btnHost";
            this.btnHost.Size = new System.Drawing.Size(190, 60);
            this.btnHost.TabIndex = 4;
            this.btnHost.Text = "Host";
            this.btnHost.UseVisualStyleBackColor = true;
            this.btnHost.Click += new System.EventHandler(this.btnHost_Click);
            // 
            // txbSend
            // 
            this.txbSend.Location = new System.Drawing.Point(15, 521);
            this.txbSend.Multiline = true;
            this.txbSend.Name = "txbSend";
            this.txbSend.Size = new System.Drawing.Size(718, 73);
            this.txbSend.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(786, 521);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(160, 73);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 606);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbSend);
            this.Controls.Add(this.btnHost);
            this.Controls.Add(this.txbPort);
            this.Controls.Add(this.txbIPAddress);
            this.Controls.Add(this.lbIPAddress);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lsvChat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Server";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvChat;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label lbIPAddress;
        private System.Windows.Forms.TextBox txbIPAddress;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.Button btnHost;
        private System.Windows.Forms.TextBox txbSend;
        private System.Windows.Forms.Button btnSend;
    }
}

