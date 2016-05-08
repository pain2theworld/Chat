namespace Chat
{
    partial class Game
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
            this.lblDesc6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDesc6
            // 
            this.lblDesc6.AutoSize = true;
            this.lblDesc6.Location = new System.Drawing.Point(45, 93);
            this.lblDesc6.Name = "lblDesc6";
            this.lblDesc6.Size = new System.Drawing.Size(92, 17);
            this.lblDesc6.TabIndex = 0;
            this.lblDesc6.Text = "Good luck <3";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 357);
            this.Controls.Add(this.lblDesc6);
            this.Name = "Game";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc6;
    }
}