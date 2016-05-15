namespace Chat
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.gbContactInfo = new System.Windows.Forms.GroupBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.imgMail = new System.Windows.Forms.PictureBox();
            this.gbBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.imgGender = new System.Windows.Forms.PictureBox();
            this.lblG = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.gbAstro = new System.Windows.Forms.GroupBox();
            this.imgZodiacSign = new System.Windows.Forms.PictureBox();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.edit = new System.Windows.Forms.Button();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.btnCamera = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbMenu.SuspendLayout();
            this.gbContactInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMail)).BeginInit();
            this.gbBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGender)).BeginInit();
            this.gbAstro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgZodiacSign)).BeginInit();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnSignOut);
            this.gbMenu.Controls.Add(this.btnFriends);
            this.gbMenu.Controls.Add(this.btnGame);
            this.gbMenu.Font = new System.Drawing.Font("Georgia", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbMenu.Location = new System.Drawing.Point(339, 2);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(183, 80);
            this.gbMenu.TabIndex = 3;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menu";
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignOut.BackgroundImage")));
            this.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnSignOut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnSignOut.Location = new System.Drawing.Point(122, 19);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(52, 48);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.TabStop = false;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.BackgroundImage = global::Chat.Properties.Resources.friends;
            this.btnFriends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFriends.FlatAppearance.BorderSize = 0;
            this.btnFriends.Location = new System.Drawing.Point(6, 19);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(52, 48);
            this.btnFriends.TabIndex = 2;
            this.btnFriends.TabStop = false;
            this.btnFriends.UseVisualStyleBackColor = true;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // btnGame
            // 
            this.btnGame.BackgroundImage = global::Chat.Properties.Resources.game;
            this.btnGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGame.FlatAppearance.BorderSize = 0;
            this.btnGame.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnGame.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnGame.Location = new System.Drawing.Point(64, 19);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(52, 48);
            this.btnGame.TabIndex = 1;
            this.btnGame.TabStop = false;
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(167, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(22, 25);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "*";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Georgia", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSurname.Location = new System.Drawing.Point(166, 44);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(22, 25);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "*";
            // 
            // gbContactInfo
            // 
            this.gbContactInfo.Controls.Add(this.lblMail);
            this.gbContactInfo.Controls.Add(this.imgMail);
            this.gbContactInfo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbContactInfo.Location = new System.Drawing.Point(12, 144);
            this.gbContactInfo.Name = "gbContactInfo";
            this.gbContactInfo.Size = new System.Drawing.Size(308, 50);
            this.gbContactInfo.TabIndex = 9;
            this.gbContactInfo.TabStop = false;
            this.gbContactInfo.Text = "Contact Information";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMail.Location = new System.Drawing.Point(35, 25);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(267, 15);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "email@gmail.com                                              .";
            // 
            // imgMail
            // 
            this.imgMail.Image = global::Chat.Properties.Resources.mail;
            this.imgMail.Location = new System.Drawing.Point(7, 21);
            this.imgMail.Name = "imgMail";
            this.imgMail.Size = new System.Drawing.Size(24, 22);
            this.imgMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgMail.TabIndex = 0;
            this.imgMail.TabStop = false;
            // 
            // gbBasicInfo
            // 
            this.gbBasicInfo.Controls.Add(this.lblBD);
            this.gbBasicInfo.Controls.Add(this.lblDateBirth);
            this.gbBasicInfo.Controls.Add(this.imgGender);
            this.gbBasicInfo.Controls.Add(this.lblG);
            this.gbBasicInfo.Controls.Add(this.lblAge);
            this.gbBasicInfo.Controls.Add(this.lblA);
            this.gbBasicInfo.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbBasicInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbBasicInfo.Location = new System.Drawing.Point(13, 201);
            this.gbBasicInfo.Name = "gbBasicInfo";
            this.gbBasicInfo.Size = new System.Drawing.Size(145, 151);
            this.gbBasicInfo.TabIndex = 10;
            this.gbBasicInfo.TabStop = false;
            this.gbBasicInfo.Text = "Basic Information";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblBD.Location = new System.Drawing.Point(3, 17);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(80, 16);
            this.lblBD.TabIndex = 5;
            this.lblBD.Text = "Birth date";
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDateBirth.Location = new System.Drawing.Point(6, 34);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(66, 15);
            this.lblDateBirth.TabIndex = 4;
            this.lblDateBirth.Text = "27 Januari";
            // 
            // imgGender
            // 
            this.imgGender.Image = global::Chat.Properties.Resources.female;
            this.imgGender.Location = new System.Drawing.Point(59, 75);
            this.imgGender.Name = "imgGender";
            this.imgGender.Size = new System.Drawing.Size(20, 28);
            this.imgGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGender.TabIndex = 3;
            this.imgGender.TabStop = false;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblG.Location = new System.Drawing.Point(3, 85);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(55, 15);
            this.lblG.TabIndex = 2;
            this.lblG.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAge.Location = new System.Drawing.Point(7, 69);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(25, 16);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "20";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblA.Location = new System.Drawing.Point(6, 52);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(35, 16);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Age";
            // 
            // gbAstro
            // 
            this.gbAstro.Controls.Add(this.imgZodiacSign);
            this.gbAstro.Font = new System.Drawing.Font("Georgia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAstro.ForeColor = System.Drawing.Color.Teal;
            this.gbAstro.Location = new System.Drawing.Point(171, 203);
            this.gbAstro.Name = "gbAstro";
            this.gbAstro.Size = new System.Drawing.Size(99, 107);
            this.gbAstro.TabIndex = 11;
            this.gbAstro.TabStop = false;
            this.gbAstro.Text = "Astro";
            // 
            // imgZodiacSign
            // 
            this.imgZodiacSign.Image = global::Chat.Properties.Resources.strelec;
            this.imgZodiacSign.Location = new System.Drawing.Point(14, 23);
            this.imgZodiacSign.Name = "imgZodiacSign";
            this.imgZodiacSign.Size = new System.Drawing.Size(70, 72);
            this.imgZodiacSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgZodiacSign.TabIndex = 5;
            this.imgZodiacSign.TabStop = false;
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.btnSave);
            this.gbAbout.Controls.Add(this.about);
            this.gbAbout.Font = new System.Drawing.Font("Georgia", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbAbout.Location = new System.Drawing.Point(326, 144);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.Size = new System.Drawing.Size(187, 208);
            this.gbAbout.TabIndex = 12;
            this.gbAbout.TabStop = false;
            this.gbAbout.Text = "About";
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Maroon;
            this.btnSave.Location = new System.Drawing.Point(105, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(12, 21);
            this.about.Multiline = true;
            this.about.Name = "about";
            this.about.ReadOnly = true;
            this.about.Size = new System.Drawing.Size(168, 69);
            this.about.TabIndex = 0;
            this.about.TextChanged += new System.EventHandler(this.about_TextChanged);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.White;
            this.edit.BackgroundImage = global::Chat.Properties.Resources.edit;
            this.edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit.FlatAppearance.BorderSize = 0;
            this.edit.Location = new System.Drawing.Point(490, 75);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(32, 32);
            this.edit.TabIndex = 1;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // imgAvatar
            // 
            this.imgAvatar.Image = global::Chat.Properties.Resources.f_4;
            this.imgAvatar.Location = new System.Drawing.Point(12, 2);
            this.imgAvatar.MaximumSize = new System.Drawing.Size(127, 125);
            this.imgAvatar.MinimumSize = new System.Drawing.Size(127, 125);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(127, 125);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAvatar.TabIndex = 0;
            this.imgAvatar.TabStop = false;
            // 
            // btnCamera
            // 
            this.btnCamera.BackColor = System.Drawing.Color.White;
            this.btnCamera.BackgroundImage = global::Chat.Properties.Resources.camera;
            this.btnCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCamera.FlatAppearance.BorderSize = 0;
            this.btnCamera.Location = new System.Drawing.Point(145, 98);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(48, 40);
            this.btnCamera.TabIndex = 13;
            this.btnCamera.UseVisualStyleBackColor = false;
            this.btnCamera.Visible = false;
            this.btnCamera.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(528, 355);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.gbAbout);
            this.Controls.Add(this.gbAstro);
            this.Controls.Add(this.gbBasicInfo);
            this.Controls.Add(this.gbContactInfo);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.imgAvatar);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(544, 393);
            this.MinimumSize = new System.Drawing.Size(544, 393);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.gbMenu.ResumeLayout(false);
            this.gbContactInfo.ResumeLayout(false);
            this.gbContactInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgMail)).EndInit();
            this.gbBasicInfo.ResumeLayout(false);
            this.gbBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGender)).EndInit();
            this.gbAstro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgZodiacSign)).EndInit();
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.PictureBox imgZodiacSign;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.GroupBox gbContactInfo;
        private System.Windows.Forms.PictureBox imgMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.GroupBox gbBasicInfo;
        private System.Windows.Forms.PictureBox imgGender;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.GroupBox gbAstro;
        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox about;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}