namespace Chat
{
    partial class LettersGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LettersGame));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labela = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.result = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.friends = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labela});
            this.statusStrip1.Location = new System.Drawing.Point(0, 357);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(773, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // labela
            // 
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.result);
            this.groupBox1.Controls.Add(this.play);
            this.groupBox1.Controls.Add(this.pause);
            this.groupBox1.Controls.Add(this.stop);
            this.groupBox1.Controls.Add(this.friends);
            this.groupBox1.Controls.Add(this.profile);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(613, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 321);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Georgia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.result.Location = new System.Drawing.Point(11, 86);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(55, 18);
            this.result.TabIndex = 5;
            this.result.Text = "label2";
            this.result.Visible = false;
            // 
            // play
            // 
            this.play.BackgroundImage = global::Chat.Properties.Resources.play;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.Location = new System.Drawing.Point(45, 146);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(52, 52);
            this.play.TabIndex = 4;
            this.play.TabStop = false;
            this.play.UseMnemonic = false;
            this.play.UseVisualStyleBackColor = true;
            this.play.UseWaitCursor = true;
            this.play.Click += new System.EventHandler(this.button5_Click);
            // 
            // pause
            // 
            this.pause.BackgroundImage = global::Chat.Properties.Resources.pause;
            this.pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pause.FlatAppearance.BorderSize = 0;
            this.pause.Location = new System.Drawing.Point(80, 204);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(52, 51);
            this.pause.TabIndex = 3;
            this.pause.TabStop = false;
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.button4_Click);
            // 
            // stop
            // 
            this.stop.BackgroundImage = global::Chat.Properties.Resources.stop;
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stop.FlatAppearance.BorderSize = 0;
            this.stop.Location = new System.Drawing.Point(14, 204);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(53, 51);
            this.stop.TabIndex = 2;
            this.stop.TabStop = false;
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button3_Click);
            // 
            // friends
            // 
            this.friends.BackgroundImage = global::Chat.Properties.Resources.friends;
            this.friends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.friends.FlatAppearance.BorderSize = 0;
            this.friends.Location = new System.Drawing.Point(80, 35);
            this.friends.Name = "friends";
            this.friends.Size = new System.Drawing.Size(52, 48);
            this.friends.TabIndex = 1;
            this.friends.TabStop = false;
            this.friends.UseVisualStyleBackColor = true;
            this.friends.Click += new System.EventHandler(this.button2_Click);
            // 
            // profile
            // 
            this.profile.BackgroundImage = global::Chat.Properties.Resources.profile;
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile.FlatAppearance.BorderSize = 0;
            this.profile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.profile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.profile.Location = new System.Drawing.Point(14, 35);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(52, 48);
            this.profile.TabIndex = 0;
            this.profile.TabStop = false;
            this.profile.UseVisualStyleBackColor = true;
            this.profile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(-29, -8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 20);
            this.label3.TabIndex = 5;
            this.label3.Tag = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(778, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LettersGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(789, 417);
            this.MinimumSize = new System.Drawing.Size(789, 417);
            this.Name = "LettersGame";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LettersGame";
            this.Load += new System.EventHandler(this.LettersGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LettersGame_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LettersGame_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel labela;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button friends;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}