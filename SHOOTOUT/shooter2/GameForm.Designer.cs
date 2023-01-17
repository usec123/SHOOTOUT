namespace shooter2
{
    partial class gf
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.limit = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.target = new System.Windows.Forms.PictureBox();
            this.island = new System.Windows.Forms.PictureBox();
            this.crosshair = new System.Windows.Forms.PictureBox();
            this.proj = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.island)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crosshair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proj)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 35;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Gray;
            this.trackBar1.Location = new System.Drawing.Point(118, 585);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(153, 45);
            this.trackBar1.TabIndex = 4;
            // 
            // limit
            // 
            this.limit.AutoSize = true;
            this.limit.BackColor = System.Drawing.Color.Transparent;
            this.limit.Location = new System.Drawing.Point(518, 9);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(0, 13);
            this.limit.TabIndex = 5;
            // 
            // scorelbl
            // 
            this.scorelbl.BackColor = System.Drawing.Color.Red;
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.Location = new System.Drawing.Point(12, 9);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(63, 46);
            this.scorelbl.TabIndex = 7;
            this.scorelbl.Text = "0";
            // 
            // target
            // 
            this.target.BackColor = System.Drawing.Color.Transparent;
            this.target.BackgroundImage = global::shooter2.Properties.Resources.stickman;
            this.target.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.target.Location = new System.Drawing.Point(66, 175);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(46, 90);
            this.target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.target.TabIndex = 6;
            this.target.TabStop = false;
            // 
            // island
            // 
            this.island.BackColor = System.Drawing.Color.Transparent;
            this.island.BackgroundImage = global::shooter2.Properties.Resources.ostrov4ee4;
            this.island.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.island.Location = new System.Drawing.Point(40, 240);
            this.island.Name = "island";
            this.island.Size = new System.Drawing.Size(100, 78);
            this.island.TabIndex = 8;
            this.island.TabStop = false;
            // 
            // crosshair
            // 
            this.crosshair.BackColor = System.Drawing.Color.Transparent;
            this.crosshair.BackgroundImage = global::shooter2.Properties.Resources.crosshair;
            this.crosshair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crosshair.Location = new System.Drawing.Point(40, 338);
            this.crosshair.Name = "crosshair";
            this.crosshair.Size = new System.Drawing.Size(100, 100);
            this.crosshair.TabIndex = 2;
            this.crosshair.TabStop = false;
            // 
            // proj
            // 
            this.proj.BackColor = System.Drawing.Color.Transparent;
            this.proj.BackgroundImage = global::shooter2.Properties.Resources.arrowup;
            this.proj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.proj.Location = new System.Drawing.Point(12, 530);
            this.proj.Name = "proj";
            this.proj.Size = new System.Drawing.Size(100, 100);
            this.proj.TabIndex = 1;
            this.proj.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(277, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Low Graphics (WinForms broken :D)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::shooter2.Properties.Resources.backgroundGame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.target);
            this.Controls.Add(this.island);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.crosshair);
            this.Controls.Add(this.proj);
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.Name = "gf";
            this.Text = "GameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.island)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crosshair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox proj;
        private System.Windows.Forms.PictureBox crosshair;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label limit;
        private System.Windows.Forms.PictureBox target;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.PictureBox island;
        private System.Windows.Forms.Button button1;
    }
}