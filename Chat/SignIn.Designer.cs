namespace Chat
{
    partial class SignIn
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
            this.lblDesc3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDesc3
            // 
            this.lblDesc3.AutoSize = true;
            this.lblDesc3.Location = new System.Drawing.Point(12, 56);
            this.lblDesc3.Name = "lblDesc3";
            this.lblDesc3.Size = new System.Drawing.Size(1081, 17);
            this.lblDesc3.TabIndex = 0;
            this.lblDesc3.Text = "- Sign In форма: Username, password и копче Sign In и Back. Aко е точно продолжув" +
    "а инаку печатиме „Wrong username or pasword\" (единствена форма на screen)";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 282);
            this.Controls.Add(this.lblDesc3);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc3;
    }
}