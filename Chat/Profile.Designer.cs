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
            this.lblDesc4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDesc4
            // 
            this.lblDesc4.AutoSize = true;
            this.lblDesc4.Location = new System.Drawing.Point(52, 78);
            this.lblDesc4.Name = "lblDesc4";
            this.lblDesc4.Size = new System.Drawing.Size(647, 17);
            this.lblDesc4.TabIndex = 0;
            this.lblDesc4.Text = "- Форма 2: Профил - Име и презиме, слика, хороскопски знак, пол, опис... МЕНИ, ко" +
    "пче Log Out";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 318);
            this.Controls.Add(this.lblDesc4);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc4;
    }
}