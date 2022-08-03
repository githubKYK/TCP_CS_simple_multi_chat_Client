namespace ClientClient
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
            this.list_chats = new System.Windows.Forms.ListBox();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_chats
            // 
            this.list_chats.FormattingEnabled = true;
            this.list_chats.ItemHeight = 16;
            this.list_chats.Location = new System.Drawing.Point(0, 0);
            this.list_chats.Name = "list_chats";
            this.list_chats.Size = new System.Drawing.Size(799, 388);
            this.list_chats.TabIndex = 0;
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(139, 394);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(521, 50);
            this.txt_msg.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(666, 394);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(133, 50);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(0, 394);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(133, 50);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "Connect server";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.list_chats);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_chats;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_connect;
    }
}

