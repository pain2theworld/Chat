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
            this.lblDesc5.Location = new System.Drawing.Point(68, 97);
            this.lblDesc5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc5.Name = "lblDesc5";
            this.lblDesc5.Size = new System.Drawing.Size(285, 13);
            this.lblDesc5.TabIndex = 0;
            this.lblDesc5.Text = "- Форма 3: Листа достапни корисници за чет и пораки";
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(5, 32);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(187, 368);
            this.lstUsers.TabIndex = 7;
            // 
            // lstChat
            // 
            this.lstChat.FormattingEnabled = true;
            this.lstChat.Location = new System.Drawing.Point(268, 198);
            this.lstChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstChat.Name = "lstChat";
            this.lstChat.Size = new System.Drawing.Size(148, 212);
            this.lstChat.TabIndex = 8;
            this.lstChat.Visible = false;
            // 
            // gbUsers
            // 
            this.gbUsers.Controls.Add(this.lstUsers);
            this.gbUsers.Location = new System.Drawing.Point(457, 10);
            this.gbUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbUsers.Size = new System.Drawing.Size(196, 405);
            this.gbUsers.TabIndex = 6;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Users";
            // 
            // ChatUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 439);
            this.Controls.Add(this.lstChat);
            this.Controls.Add(this.gbUsers);
            this.Controls.Add(this.lblDesc5);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChatUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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