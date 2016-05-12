namespace Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.llblRegister = new System.Windows.Forms.LinkLabel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSignIn.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSignIn.Location = new System.Drawing.Point(129, 346);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(224, 52);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Georgia", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblWelcome.Location = new System.Drawing.Point(84, 151);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(315, 69);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(170, 37);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(142, 92);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 7;
            this.Logo.TabStop = false;
            // 
            // llblRegister
            // 
            this.llblRegister.ActiveLinkColor = System.Drawing.Color.Aquamarine;
            this.llblRegister.AutoSize = true;
            this.llblRegister.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblRegister.LinkColor = System.Drawing.Color.DarkCyan;
            this.llblRegister.Location = new System.Drawing.Point(199, 420);
            this.llblRegister.Name = "llblRegister";
            this.llblRegister.Size = new System.Drawing.Size(84, 24);
            this.llblRegister.TabIndex = 0;
            this.llblRegister.TabStop = true;
            this.llblRegister.Text = "Register";
            this.llblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegister_LinkClicked);
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtUsername.Location = new System.Drawing.Point(129, 242);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(224, 30);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUsername_MouseClick);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtPassword.Location = new System.Drawing.Point(129, 294);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(224, 30);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 470);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.llblRegister);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSignIn);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.LinkLabel llblRegister;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

