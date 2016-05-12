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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Online", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Offline", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatUsers));
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.lstUsers = new System.Windows.Forms.ListView();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // lstUsers
            // 
            this.lstUsers.BackColor = System.Drawing.Color.LightCyan;
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "Online";
            listViewGroup1.Name = "Online";
            listViewGroup2.Header = "Offline";
            listViewGroup2.Name = "Offline";
            this.lstUsers.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lstUsers.Location = new System.Drawing.Point(3, 23);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(255, 472);
            this.lstUsers.TabIndex = 11;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.List;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Chat.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(26, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ChatUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chat.Properties.Resources.BG_DarkCyan;
            this.ClientSize = new System.Drawing.Size(904, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.gbUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatUsers";
            this.Load += new System.EventHandler(this.ChatUsers_Load);
            this.gbUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}