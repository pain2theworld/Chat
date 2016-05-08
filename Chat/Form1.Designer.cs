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
            this.lblDesc1 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDesc1
            // 
            this.lblDesc1.AutoSize = true;
            this.lblDesc1.Location = new System.Drawing.Point(33, 122);
            this.lblDesc1.Name = "lblDesc1";
            this.lblDesc1.Size = new System.Drawing.Size(589, 17);
            this.lblDesc1.TabIndex = 3;
            this.lblDesc1.Text = "Почетна страна за логирање, Welcome screen со копчиња Create New Account и Sign I" +
    "n";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(172, 253);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(149, 35);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Create New Account";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 556);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblDesc1);
            this.Name = "Form1";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc1;
        private System.Windows.Forms.Button btnAddUser;
    }
}

