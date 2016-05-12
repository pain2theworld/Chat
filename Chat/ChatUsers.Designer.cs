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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatUsers));
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.gbUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUsers
            // 
            this.lstUsers.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 20;
            this.lstUsers.Location = new System.Drawing.Point(7, 40);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(248, 444);
            this.lstUsers.TabIndex = 7;
            // 
            // gbUsers
            // 
            this.gbUsers.BackColor = System.Drawing.Color.Transparent;
            this.gbUsers.Controls.Add(this.lstUsers);
            this.gbUsers.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsers.ForeColor = System.Drawing.Color.Aquamarine;
            this.gbUsers.Location = new System.Drawing.Point(609, 12);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(261, 498);
            this.gbUsers.TabIndex = 6;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Users";
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(26, 173);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(540, 331);
            this.txtChat.TabIndex = 9;
            this.txtChat.Visible = false;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::Chat.Properties.Resources.logo_transparent;
            this.Logo.Location = new System.Drawing.Point(26, 23);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(265, 123);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            // 
            // ChatUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chat.Properties.Resources.BG_DarkCyan;
            this.ClientSize = new System.Drawing.Size(904, 540);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.gbUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatUsers";
            this.Load += new System.EventHandler(this.ChatUsers_Load);
            this.gbUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.PictureBox Logo;
    }
}