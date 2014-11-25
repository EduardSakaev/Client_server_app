namespace Chat_Client_APP
{
    partial class Form1
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
            this.Client1 = new System.Windows.Forms.GroupBox();
            this.Client2 = new System.Windows.Forms.GroupBox();
            this.textLocalIP = new System.Windows.Forms.TextBox();
            this.textLocalPort = new System.Windows.Forms.TextBox();
            this.textFriendIP = new System.Windows.Forms.TextBox();
            this.textFriendPort = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.ListMessage = new System.Windows.Forms.ListBox();
            this.StartButon = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Client1.SuspendLayout();
            this.Client2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Client1
            // 
            this.Client1.Controls.Add(this.label2);
            this.Client1.Controls.Add(this.label1);
            this.Client1.Controls.Add(this.textLocalPort);
            this.Client1.Controls.Add(this.textLocalIP);
            this.Client1.Location = new System.Drawing.Point(23, 24);
            this.Client1.Name = "Client1";
            this.Client1.Size = new System.Drawing.Size(230, 100);
            this.Client1.TabIndex = 0;
            this.Client1.TabStop = false;
            this.Client1.Text = "Client1";
            // 
            // Client2
            // 
            this.Client2.Controls.Add(this.label4);
            this.Client2.Controls.Add(this.label3);
            this.Client2.Controls.Add(this.textFriendPort);
            this.Client2.Controls.Add(this.textFriendIP);
            this.Client2.Location = new System.Drawing.Point(317, 24);
            this.Client2.Name = "Client2";
            this.Client2.Size = new System.Drawing.Size(234, 100);
            this.Client2.TabIndex = 1;
            this.Client2.TabStop = false;
            this.Client2.Text = "Client2";
            // 
            // textLocalIP
            // 
            this.textLocalIP.Location = new System.Drawing.Point(64, 19);
            this.textLocalIP.Name = "textLocalIP";
            this.textLocalIP.Size = new System.Drawing.Size(141, 20);
            this.textLocalIP.TabIndex = 0;
            // 
            // textLocalPort
            // 
            this.textLocalPort.Location = new System.Drawing.Point(64, 63);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.Size = new System.Drawing.Size(141, 20);
            this.textLocalPort.TabIndex = 0;
            // 
            // textFriendIP
            // 
            this.textFriendIP.Location = new System.Drawing.Point(63, 18);
            this.textFriendIP.Name = "textFriendIP";
            this.textFriendIP.Size = new System.Drawing.Size(143, 20);
            this.textFriendIP.TabIndex = 0;
            // 
            // textFriendPort
            // 
            this.textFriendPort.Location = new System.Drawing.Point(63, 62);
            this.textFriendPort.Name = "textFriendPort";
            this.textFriendPort.Size = new System.Drawing.Size(143, 20);
            this.textFriendPort.TabIndex = 1;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(23, 357);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(528, 20);
            this.textMessage.TabIndex = 2;
            // 
            // ListMessage
            // 
            this.ListMessage.FormattingEnabled = true;
            this.ListMessage.Location = new System.Drawing.Point(23, 160);
            this.ListMessage.Name = "ListMessage";
            this.ListMessage.Size = new System.Drawing.Size(638, 173);
            this.ListMessage.TabIndex = 3;
            // 
            // StartButon
            // 
            this.StartButon.Location = new System.Drawing.Point(586, 43);
            this.StartButon.Name = "StartButon";
            this.StartButon.Size = new System.Drawing.Size(75, 23);
            this.StartButon.TabIndex = 4;
            this.StartButon.Text = "Start";
            this.StartButon.UseVisualStyleBackColor = true;
            this.StartButon.Click += new System.EventHandler(this.Start_Click);
            // 
            // Send
            // 
            this.Send.Enabled = false;
            this.Send.Location = new System.Drawing.Point(586, 354);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 5;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PORT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 404);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.StartButon);
            this.Controls.Add(this.ListMessage);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.Client2);
            this.Controls.Add(this.Client1);
            this.MaximumSize = new System.Drawing.Size(689, 442);
            this.MinimumSize = new System.Drawing.Size(689, 442);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Client1.ResumeLayout(false);
            this.Client1.PerformLayout();
            this.Client2.ResumeLayout(false);
            this.Client2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Client1;
        private System.Windows.Forms.GroupBox Client2;
        private System.Windows.Forms.TextBox textLocalIP;
        private System.Windows.Forms.TextBox textLocalPort;
        private System.Windows.Forms.TextBox textFriendPort;
        private System.Windows.Forms.TextBox textFriendIP;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.ListBox ListMessage;
        private System.Windows.Forms.Button StartButon;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

