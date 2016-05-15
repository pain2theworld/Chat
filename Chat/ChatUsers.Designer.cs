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
            this.lstMessages = new System.Windows.Forms.ListView();
            this.llblName = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblActiveUser = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.gbUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUsers
            // 
            this.gbUsers.BackColor = System.Drawing.Color.Transparent;
            this.gbUsers.Controls.Add(this.lstUsers);
            this.gbUsers.Font = new System.Drawing.Font("Georgia", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsers.ForeColor = System.Drawing.Color.Aquamarine;
            this.gbUsers.Location = new System.Drawing.Point(609, 14);
            this.gbUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUsers.Size = new System.Drawing.Size(261, 497);
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
            this.lstUsers.Location = new System.Drawing.Point(3, 22);
            this.lstUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstUsers.MultiSelect = false;
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(255, 473);
            this.lstUsers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstUsers.TabIndex = 11;
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.List;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(27, 442);
            this.txtChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(456, 69);
            this.txtChat.TabIndex = 9;
            this.txtChat.Visible = false;
            this.txtChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChat_KeyDown);
            // 
            // lstMessages
            // 
            this.lstMessages.Location = new System.Drawing.Point(27, 199);
            this.lstMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(540, 222);
            this.lstMessages.TabIndex = 12;
            this.lstMessages.UseCompatibleStateImageBehavior = false;
            this.lstMessages.View = System.Windows.Forms.View.List;
            this.lstMessages.Visible = false;
            this.lstMessages.SelectedIndexChanged += new System.EventHandler(this.lstMessages_SelectedIndexChanged);
            // 
            // llblName
            // 
            this.llblName.ActiveLinkColor = System.Drawing.Color.Aquamarine;
            this.llblName.AutoSize = true;
            this.llblName.BackColor = System.Drawing.Color.Transparent;
            this.llblName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblName.LinkColor = System.Drawing.Color.Aquamarine;
            this.llblName.Location = new System.Drawing.Point(21, 174);
            this.llblName.Name = "llblName";
            this.llblName.Size = new System.Drawing.Size(0, 24);
            this.llblName.TabIndex = 15;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::Chat.Properties.Resources.logo_transparent;
            this.Logo.Location = new System.Drawing.Point(27, 14);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(265, 123);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 18;
            this.Logo.TabStop = false;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackgroundImage = global::Chat.Properties.Resources.send;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.CausesValidation = false;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnSend.FlatAppearance.BorderSize = 2;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Georgia", 10F);
            this.btnSend.ForeColor = System.Drawing.Color.MintCream;
            this.btnSend.Location = new System.Drawing.Point(490, 442);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(77, 69);
            this.btnSend.TabIndex = 19;
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Chat.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.CausesValidation = false;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Aquamarine;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Georgia", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.MintCream;
            this.btnBack.Location = new System.Drawing.Point(490, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 69);
            this.btnBack.TabIndex = 20;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblActiveUser
            // 
            this.lblActiveUser.AutoSize = true;
            this.lblActiveUser.BackColor = System.Drawing.Color.Transparent;
            this.lblActiveUser.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActiveUser.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblActiveUser.Location = new System.Drawing.Point(299, 137);
            this.lblActiveUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActiveUser.Name = "lblActiveUser";
            this.lblActiveUser.Size = new System.Drawing.Size(23, 27);
            this.lblActiveUser.TabIndex = 21;
            this.lblActiveUser.Text = "*";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.BackColor = System.Drawing.Color.Transparent;
            this.lblActive.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblActive.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblActive.Location = new System.Drawing.Point(299, 110);
            this.lblActive.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(110, 23);
            this.lblActive.TabIndex = 22;
            this.lblActive.Text = "Active user:";
            // 
            // ChatUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Chat.Properties.Resources.BG_DarkCyan;
            this.ClientSize = new System.Drawing.Size(904, 540);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.lblActiveUser);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.llblName);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.gbUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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

        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.ListView lstMessages;
        private System.Windows.Forms.LinkLabel llblName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblActiveUser;
        private System.Windows.Forms.Label lblActive;
    }
}