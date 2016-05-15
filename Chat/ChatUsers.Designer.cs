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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Online", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Offline", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatUsers));
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.lstUsers = new System.Windows.Forms.ListView();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstMessages = new System.Windows.Forms.ListView();
            this.llblName = new System.Windows.Forms.LinkLabel();
            this.btnSend = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUsers
            // 
            this.gbUsers.BackColor = System.Drawing.Color.Transparent;
            this.gbUsers.Controls.Add(this.lstUsers);
            this.gbUsers.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsers.ForeColor = System.Drawing.Color.Aquamarine;
            this.gbUsers.Location = new System.Drawing.Point(457, 11);
            this.gbUsers.Margin = new System.Windows.Forms.Padding(2);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Padding = new System.Windows.Forms.Padding(2);
            this.gbUsers.Size = new System.Drawing.Size(196, 404);
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
            this.lstUsers.Location = new System.Drawing.Point(2, 18);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(2);
            this.lstUsers.MultiSelect = false;
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(192, 384);
            this.lstUsers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstUsers.TabIndex = 11;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.List;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(20, 359);
            this.txtChat.Margin = new System.Windows.Forms.Padding(2);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(343, 51);
            this.txtChat.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Chat.Properties.Resources.logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(20, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lstMessages
            // 
            this.lstMessages.Location = new System.Drawing.Point(20, 162);
            this.lstMessages.Margin = new System.Windows.Forms.Padding(2);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(406, 181);
            this.lstMessages.TabIndex = 12;
            this.lstMessages.UseCompatibleStateImageBehavior = false;
            this.lstMessages.View = System.Windows.Forms.View.List;
            // 
            // llblName
            // 
            this.llblName.ActiveLinkColor = System.Drawing.Color.Aquamarine;
            this.llblName.AutoSize = true;
            this.llblName.BackColor = System.Drawing.Color.Transparent;
            this.llblName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblName.LinkColor = System.Drawing.Color.Aquamarine;
            this.llblName.Location = new System.Drawing.Point(16, 141);
            this.llblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblName.Name = "llblName";
            this.llblName.Size = new System.Drawing.Size(0, 18);
            this.llblName.TabIndex = 15;
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = global::Chat.Properties.Resources.send;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(369, 359);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 5, 3, 50);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(57, 54);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Send";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // exit
            // 
            this.exit.Image = global::Chat.Properties.Resources.exit;
            this.exit.Location = new System.Drawing.Point(395, 19);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(57, 67);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 17;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ChatUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chat.Properties.Resources.BG_DarkCyan;
            this.ClientSize = new System.Drawing.Size(678, 439);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.llblName);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.gbUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChatUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatUsers";
            this.Load += new System.EventHandler(this.ChatUsers_Load);
            this.gbUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lstMessages;
        private System.Windows.Forms.LinkLabel llblName;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}