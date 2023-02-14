namespace App2
{
    partial class App2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtAlarm = new System.Windows.Forms.TextBox();
            this.btnSendAlarm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 123);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(519, 160);
            this.listBox1.TabIndex = 5;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(390, 35);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(137, 23);
            this.btnSendMessage.TabIndex = 4;
            this.btnSendMessage.Text = "Send Mesage";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(8, 11);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(519, 20);
            this.txtMessage.TabIndex = 3;
            // 
            // txtAlarm
            // 
            this.txtAlarm.Location = new System.Drawing.Point(11, 62);
            this.txtAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlarm.Name = "txtAlarm";
            this.txtAlarm.Size = new System.Drawing.Size(519, 20);
            this.txtAlarm.TabIndex = 3;
            // 
            // btnSendAlarm
            // 
            this.btnSendAlarm.Location = new System.Drawing.Point(393, 86);
            this.btnSendAlarm.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendAlarm.Name = "btnSendAlarm";
            this.btnSendAlarm.Size = new System.Drawing.Size(137, 23);
            this.btnSendAlarm.TabIndex = 4;
            this.btnSendAlarm.Text = "Send Alarm";
            this.btnSendAlarm.UseVisualStyleBackColor = true;
            this.btnSendAlarm.Click += new System.EventHandler(this.btnSendAlarm_Click);
            // 
            // App2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSendAlarm);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtAlarm);
            this.Controls.Add(this.txtMessage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "App2";
            this.Text = "App 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtAlarm;
        private System.Windows.Forms.Button btnSendAlarm;
    }
}

