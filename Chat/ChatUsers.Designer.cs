namespace Chat
{
    partial class ChatUsers
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
            this.lblDesc5 = new System.Windows.Forms.Label();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.lstChat = new System.Windows.Forms.ListBox();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.gbUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDesc5
            // 
            this.lblDesc5.AutoSize = true;
            this.lblDesc5.Location = new System.Drawing.Point(90, 119);
            this.lblDesc5.Name = "lblDesc5";
            this.lblDesc5.Size = new System.Drawing.Size(372, 17);
            this.lblDesc5.TabIndex = 0;
            this.lblDesc5.Text = "- Форма 3: Листа достапни корисници за чет и пораки";
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 16;
            this.lstUsers.Location = new System.Drawing.Point(7, 40);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(248, 452);
            this.lstUsers.TabIndex = 7;
            // 
            // lstChat
            // 
            this.lstChat.FormattingEnabled = true;
            this.lstChat.ItemHeight = 16;
            this.lstChat.Location = new System.Drawing.Point(358, 244);
            this.lstChat.Name = "lstChat";
            this.lstChat.Size = new System.Drawing.Size(196, 260);
            this.lstChat.TabIndex = 8;
            this.lstChat.Visible = false;
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.lstUsers);
            this.gbUsers.Location = new System.Drawing.Point(609, 12);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(261, 498);
            this.gbUsers.TabIndex = 6;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Users";
            // 
            // ChatUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 540);
            this.Controls.Add(this.lstChat);
            this.Controls.Add(this.gbUsers);
            this.Controls.Add(this.lblDesc5);
            this.Name = "ChatUsers";
            this.Text = "ChatUsers";
            this.gbUsers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc5;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.ListBox lstChat;
        private System.Windows.Forms.GroupBox gbUsers;
    }
}