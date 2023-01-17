namespace shooter2
{
    partial class MainForm
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
            this.playButton = new System.Windows.Forms.Button();
            this.showScoreboard = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.resetScoreboard = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::shooter2.Properties.Resources.play;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.Location = new System.Drawing.Point(270, 140);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(240, 98);
            this.playButton.TabIndex = 0;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // showScoreboard
            // 
            this.showScoreboard.BackgroundImage = global::shooter2.Properties.Resources.showScoreboard;
            this.showScoreboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showScoreboard.FlatAppearance.BorderSize = 0;
            this.showScoreboard.Location = new System.Drawing.Point(270, 244);
            this.showScoreboard.Name = "showScoreboard";
            this.showScoreboard.Size = new System.Drawing.Size(240, 98);
            this.showScoreboard.TabIndex = 1;
            this.showScoreboard.UseVisualStyleBackColor = true;
            this.showScoreboard.Click += new System.EventHandler(this.showScoreboard_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Silver;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(580, 249);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 186);
            this.listBox1.TabIndex = 2;
            // 
            // resetScoreboard
            // 
            this.resetScoreboard.BackgroundImage = global::shooter2.Properties.Resources.resetScoreboard;
            this.resetScoreboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resetScoreboard.FlatAppearance.BorderSize = 0;
            this.resetScoreboard.Location = new System.Drawing.Point(270, 348);
            this.resetScoreboard.Name = "resetScoreboard";
            this.resetScoreboard.Size = new System.Drawing.Size(240, 98);
            this.resetScoreboard.TabIndex = 3;
            this.resetScoreboard.UseVisualStyleBackColor = true;
            this.resetScoreboard.Click += new System.EventHandler(this.resetScoreboard_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(328, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::shooter2.Properties.Resources.backgroundMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.resetScoreboard);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.showScoreboard);
            this.Controls.Add(this.playButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button showScoreboard;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button resetScoreboard;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

