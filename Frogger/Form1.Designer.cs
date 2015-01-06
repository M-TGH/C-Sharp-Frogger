namespace Frogger
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.butHighScores = new System.Windows.Forms.Button();
            this.butStart = new System.Windows.Forms.Button();
            this.pbFrog = new System.Windows.Forms.PictureBox();
            this.pbCar1 = new System.Windows.Forms.PictureBox();
            this.pbCar2 = new System.Windows.Forms.PictureBox();
            this.pbCar3 = new System.Windows.Forms.PictureBox();
            this.pbTruck1 = new System.Windows.Forms.PictureBox();
            this.pbTruck2 = new System.Windows.Forms.PictureBox();
            this.pbCar4 = new System.Windows.Forms.PictureBox();
            this.pbCar5 = new System.Windows.Forms.PictureBox();
            this.pbCar6 = new System.Windows.Forms.PictureBox();
            this.TrafficTimer = new System.Windows.Forms.Timer(this.components);
            this.pbTruck3 = new System.Windows.Forms.PictureBox();
            this.pbTruck4 = new System.Windows.Forms.PictureBox();
            this.pbEndFrog1 = new System.Windows.Forms.PictureBox();
            this.pbEndFrog2 = new System.Windows.Forms.PictureBox();
            this.pbEndFrog3 = new System.Windows.Forms.PictureBox();
            this.pbEndFrog4 = new System.Windows.Forms.PictureBox();
            this.pbEndFrog5 = new System.Windows.Forms.PictureBox();
            this.labScore = new System.Windows.Forms.Label();
            this.scoreTimer = new System.Windows.Forms.Timer(this.components);
            this.pbRiver = new System.Windows.Forms.PictureBox();
            this.pbLogR1 = new System.Windows.Forms.PictureBox();
            this.pbLogR2 = new System.Windows.Forms.PictureBox();
            this.pbLogL1 = new System.Windows.Forms.PictureBox();
            this.pbLogL2 = new System.Windows.Forms.PictureBox();
            this.pbLogR3 = new System.Windows.Forms.PictureBox();
            this.pbLogR4 = new System.Windows.Forms.PictureBox();
            this.groupBoxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEndFrog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEndFrog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEndFrog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEndFrog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEndFrog5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogL1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogL2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogR4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.butHighScores);
            this.groupBoxMenu.Controls.Add(this.butStart);
            this.groupBoxMenu.Location = new System.Drawing.Point(40, 106);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(200, 108);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Main Menu";
            // 
            // butHighScores
            // 
            this.butHighScores.Location = new System.Drawing.Point(68, 48);
            this.butHighScores.Name = "butHighScores";
            this.butHighScores.Size = new System.Drawing.Size(75, 23);
            this.butHighScores.TabIndex = 1;
            this.butHighScores.Text = "HighScores";
            this.butHighScores.UseVisualStyleBackColor = true;
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(68, 19);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(75, 23);
            this.butStart.TabIndex = 0;
            this.butStart.Text = "Start Game";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // pbFrog
            // 
            this.pbFrog.BackColor = System.Drawing.Color.Transparent;
            this.pbFrog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFrog.Image = global::Frogger.Properties.Resources.Frog;
            this.pbFrog.Location = new System.Drawing.Point(140, 290);
            this.pbFrog.Name = "pbFrog";
            this.pbFrog.Size = new System.Drawing.Size(20, 20);
            this.pbFrog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFrog.TabIndex = 1;
            this.pbFrog.TabStop = false;
            // 
            // pbCar1
            // 
            this.pbCar1.BackColor = System.Drawing.Color.Transparent;
            this.pbCar1.Image = global::Frogger.Properties.Resources.Car;
            this.pbCar1.Location = new System.Drawing.Point(15, 260);
            this.pbCar1.Name = "pbCar1";
            this.pbCar1.Size = new System.Drawing.Size(20, 20);
            this.pbCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar1.TabIndex = 2;
            this.pbCar1.TabStop = false;
            // 
            // pbCar2
            // 
            this.pbCar2.BackColor = System.Drawing.Color.Transparent;
            this.pbCar2.Image = global::Frogger.Properties.Resources.Car;
            this.pbCar2.Location = new System.Drawing.Point(55, 260);
            this.pbCar2.Name = "pbCar2";
            this.pbCar2.Size = new System.Drawing.Size(20, 20);
            this.pbCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar2.TabIndex = 3;
            this.pbCar2.TabStop = false;
            // 
            // pbCar3
            // 
            this.pbCar3.BackColor = System.Drawing.Color.Transparent;
            this.pbCar3.Image = global::Frogger.Properties.Resources.Car;
            this.pbCar3.Location = new System.Drawing.Point(95, 260);
            this.pbCar3.Name = "pbCar3";
            this.pbCar3.Size = new System.Drawing.Size(20, 20);
            this.pbCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar3.TabIndex = 4;
            this.pbCar3.TabStop = false;
            // 
            // pbTruck1
            // 
            this.pbTruck1.BackColor = System.Drawing.Color.Transparent;
            this.pbTruck1.Image = global::Frogger.Properties.Resources.Truck;
            this.pbTruck1.Location = new System.Drawing.Point(240, 230);
            this.pbTruck1.Name = "pbTruck1";
            this.pbTruck1.Size = new System.Drawing.Size(40, 20);
            this.pbTruck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTruck1.TabIndex = 5;
            this.pbTruck1.TabStop = false;
            // 
            // pbTruck2
            // 
            this.pbTruck2.BackColor = System.Drawing.Color.Transparent;
            this.pbTruck2.Image = global::Frogger.Properties.Resources.Truck;
            this.pbTruck2.Location = new System.Drawing.Point(160, 230);
            this.pbTruck2.Name = "pbTruck2";
            this.pbTruck2.Size = new System.Drawing.Size(40, 20);
            this.pbTruck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTruck2.TabIndex = 6;
            this.pbTruck2.TabStop = false;
            // 
            // pbCar4
            // 
            this.pbCar4.BackColor = System.Drawing.Color.Transparent;
            this.pbCar4.Image = global::Frogger.Properties.Resources.Car;
            this.pbCar4.Location = new System.Drawing.Point(140, 200);
            this.pbCar4.Name = "pbCar4";
            this.pbCar4.Size = new System.Drawing.Size(20, 20);
            this.pbCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar4.TabIndex = 7;
            this.pbCar4.TabStop = false;
            // 
            // pbCar5
            // 
            this.pbCar5.BackColor = System.Drawing.Color.Transparent;
            this.pbCar5.Image = global::Frogger.Properties.Resources.Car;
            this.pbCar5.Location = new System.Drawing.Point(190, 200);
            this.pbCar5.Name = "pbCar5";
            this.pbCar5.Size = new System.Drawing.Size(20, 20);
            this.pbCar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar5.TabIndex = 8;
            this.pbCar5.TabStop = false;
            // 
            // pbCar6
            // 
            this.pbCar6.BackColor = System.Drawing.Color.Transparent;
            this.pbCar6.Image = global::Frogger.Properties.Resources.Car;
            this.pbCar6.Location = new System.Drawing.Point(240, 200);
            this.pbCar6.Name = "pbCar6";
            this.pbCar6.Size = new System.Drawing.Size(20, 20);
            this.pbCar6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar6.TabIndex = 9;
            this.pbCar6.TabStop = false;
            // 
            // TrafficTimer
            // 
            this.TrafficTimer.Interval = 10;
            this.TrafficTimer.Tick += new System.EventHandler(this.TrafficTimer_Tick);
            // 
            // pbTruck3
            // 
            this.pbTruck3.BackColor = System.Drawing.Color.Transparent;
            this.pbTruck3.Image = global::Frogger.Properties.Resources.Truck;
            this.pbTruck3.Location = new System.Drawing.Point(110, 170);
            this.pbTruck3.Name = "pbTruck3";
            this.pbTruck3.Size = new System.Drawing.Size(40, 20);
            this.pbTruck3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTruck3.TabIndex = 10;
            this.pbTruck3.TabStop = false;
            // 
            // pbTruck4
            // 
            this.pbTruck4.BackColor = System.Drawing.Color.Transparent;
            this.pbTruck4.Image = global::Frogger.Properties.Resources.Truck;
            this.pbTruck4.Location = new System.Drawing.Point(40, 170);
            this.pbTruck4.Name = "pbTruck4";
            this.pbTruck4.Size = new System.Drawing.Size(40, 20);
            this.pbTruck4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTruck4.TabIndex = 11;
            this.pbTruck4.TabStop = false;
            // 
            // pbEndFrog1
            // 
            this.pbEndFrog1.BackColor = System.Drawing.Color.Transparent;
            this.pbEndFrog1.Image = global::Frogger.Properties.Resources.FrogEnd;
            this.pbEndFrog1.Location = new System.Drawing.Point(10, 12);
            this.pbEndFrog1.Name = "pbEndFrog1";
            this.pbEndFrog1.Size = new System.Drawing.Size(23, 20);
            this.pbEndFrog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEndFrog1.TabIndex = 12;
            this.pbEndFrog1.TabStop = false;
            this.pbEndFrog1.Visible = false;
            // 
            // pbEndFrog2
            // 
            this.pbEndFrog2.BackColor = System.Drawing.Color.Transparent;
            this.pbEndFrog2.Image = global::Frogger.Properties.Resources.FrogEnd;
            this.pbEndFrog2.Location = new System.Drawing.Point(73, 12);
            this.pbEndFrog2.Name = "pbEndFrog2";
            this.pbEndFrog2.Size = new System.Drawing.Size(23, 20);
            this.pbEndFrog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEndFrog2.TabIndex = 13;
            this.pbEndFrog2.TabStop = false;
            this.pbEndFrog2.Visible = false;
            // 
            // pbEndFrog3
            // 
            this.pbEndFrog3.BackColor = System.Drawing.Color.Transparent;
            this.pbEndFrog3.Image = global::Frogger.Properties.Resources.FrogEnd;
            this.pbEndFrog3.Location = new System.Drawing.Point(137, 12);
            this.pbEndFrog3.Name = "pbEndFrog3";
            this.pbEndFrog3.Size = new System.Drawing.Size(23, 20);
            this.pbEndFrog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEndFrog3.TabIndex = 14;
            this.pbEndFrog3.TabStop = false;
            this.pbEndFrog3.Visible = false;
            // 
            // pbEndFrog4
            // 
            this.pbEndFrog4.BackColor = System.Drawing.Color.Transparent;
            this.pbEndFrog4.Image = global::Frogger.Properties.Resources.FrogEnd;
            this.pbEndFrog4.Location = new System.Drawing.Point(200, 12);
            this.pbEndFrog4.Name = "pbEndFrog4";
            this.pbEndFrog4.Size = new System.Drawing.Size(23, 20);
            this.pbEndFrog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEndFrog4.TabIndex = 13;
            this.pbEndFrog4.TabStop = false;
            this.pbEndFrog4.Visible = false;
            // 
            // pbEndFrog5
            // 
            this.pbEndFrog5.BackColor = System.Drawing.Color.Transparent;
            this.pbEndFrog5.Image = global::Frogger.Properties.Resources.FrogEnd;
            this.pbEndFrog5.Location = new System.Drawing.Point(261, 12);
            this.pbEndFrog5.Name = "pbEndFrog5";
            this.pbEndFrog5.Size = new System.Drawing.Size(23, 20);
            this.pbEndFrog5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEndFrog5.TabIndex = 13;
            this.pbEndFrog5.TabStop = false;
            this.pbEndFrog5.Visible = false;
            // 
            // labScore
            // 
            this.labScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labScore.AutoEllipsis = true;
            this.labScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labScore.ForeColor = System.Drawing.Color.LimeGreen;
            this.labScore.Location = new System.Drawing.Point(197, 308);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(100, 23);
            this.labScore.TabIndex = 15;
            this.labScore.Text = "Score: 0";
            // 
            // scoreTimer
            // 
            this.scoreTimer.Tick += new System.EventHandler(this.scoreTimer_Tick);
            // 
            // pbRiver
            // 
            this.pbRiver.BackColor = System.Drawing.Color.Transparent;
            this.pbRiver.Location = new System.Drawing.Point(1, 50);
            this.pbRiver.Name = "pbRiver";
            this.pbRiver.Size = new System.Drawing.Size(296, 80);
            this.pbRiver.TabIndex = 16;
            this.pbRiver.TabStop = false;
            // 
            // pbLogR1
            // 
            this.pbLogR1.BackColor = System.Drawing.Color.Transparent;
            this.pbLogR1.Image = global::Frogger.Properties.Resources.Log;
            this.pbLogR1.Location = new System.Drawing.Point(10, 110);
            this.pbLogR1.Name = "pbLogR1";
            this.pbLogR1.Size = new System.Drawing.Size(60, 20);
            this.pbLogR1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogR1.TabIndex = 17;
            this.pbLogR1.TabStop = false;
            // 
            // pbLogR2
            // 
            this.pbLogR2.BackColor = System.Drawing.Color.Transparent;
            this.pbLogR2.Image = global::Frogger.Properties.Resources.Log;
            this.pbLogR2.Location = new System.Drawing.Point(120, 110);
            this.pbLogR2.Name = "pbLogR2";
            this.pbLogR2.Size = new System.Drawing.Size(60, 20);
            this.pbLogR2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogR2.TabIndex = 18;
            this.pbLogR2.TabStop = false;
            // 
            // pbLogL1
            // 
            this.pbLogL1.BackColor = System.Drawing.Color.Transparent;
            this.pbLogL1.Image = global::Frogger.Properties.Resources.Log;
            this.pbLogL1.Location = new System.Drawing.Point(190, 80);
            this.pbLogL1.Name = "pbLogL1";
            this.pbLogL1.Size = new System.Drawing.Size(90, 20);
            this.pbLogL1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogL1.TabIndex = 19;
            this.pbLogL1.TabStop = false;
            // 
            // pbLogL2
            // 
            this.pbLogL2.BackColor = System.Drawing.Color.Transparent;
            this.pbLogL2.Image = global::Frogger.Properties.Resources.Log;
            this.pbLogL2.Location = new System.Drawing.Point(70, 80);
            this.pbLogL2.Name = "pbLogL2";
            this.pbLogL2.Size = new System.Drawing.Size(60, 20);
            this.pbLogL2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogL2.TabIndex = 20;
            this.pbLogL2.TabStop = false;
            // 
            // pbLogR3
            // 
            this.pbLogR3.BackColor = System.Drawing.Color.Transparent;
            this.pbLogR3.Image = global::Frogger.Properties.Resources.Log;
            this.pbLogR3.Location = new System.Drawing.Point(120, 50);
            this.pbLogR3.Name = "pbLogR3";
            this.pbLogR3.Size = new System.Drawing.Size(60, 20);
            this.pbLogR3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogR3.TabIndex = 21;
            this.pbLogR3.TabStop = false;
            // 
            // pbLogR4
            // 
            this.pbLogR4.BackColor = System.Drawing.Color.Black;
            this.pbLogR4.Image = global::Frogger.Properties.Resources.Log;
            this.pbLogR4.Location = new System.Drawing.Point(220, 50);
            this.pbLogR4.Name = "pbLogR4";
            this.pbLogR4.Size = new System.Drawing.Size(60, 20);
            this.pbLogR4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogR4.TabIndex = 22;
            this.pbLogR4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Frogger.Properties.Resources._7911_FroggerBG_large;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(294, 321);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.pbFrog);
            this.Controls.Add(this.pbLogR4);
            this.Controls.Add(this.pbLogR3);
            this.Controls.Add(this.pbLogL2);
            this.Controls.Add(this.pbLogL1);
            this.Controls.Add(this.pbLogR2);
            this.Controls.Add(this.pbLogR1);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.pbEndFrog5);
            this.Controls.Add(this.pbEndFrog4);
            this.Controls.Add(this.pbEndFrog3);
            this.Controls.Add(this.pbEndFrog2);
            this.Controls.Add(this.pbEndFrog1);
            this.Controls.Add(this.pbTruck4);
            this.Controls.Add(this.pbTruck3);
            this.Controls.Add(this.pbCar6);
            this.Controls.Add(this.pbCar5);
            this.Controls.Add(this.pbCar4);
            this.Controls.Add(this.pbTruck2);
            this.Controls.Add(this.pbTruck1);
            this.Controls.Add(this.pbCar3);
            this.Controls.Add(this.pbCar2);
            this.Controls.Add(this.pbCar1);
            this.Controls.Add(this.pbRiver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 360);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 260);
            this.Name = "Form1";
            this.Text = "Frogger";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBoxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFrog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTruck4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEndFrog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEndFrog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEndFrog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEndFrog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEndFrog5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogL1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogL2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogR4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butHighScores;
        private System.Windows.Forms.PictureBox pbFrog;
        private System.Windows.Forms.PictureBox pbCar1;
        private System.Windows.Forms.PictureBox pbCar2;
        private System.Windows.Forms.PictureBox pbCar3;
        private System.Windows.Forms.PictureBox pbTruck1;
        private System.Windows.Forms.PictureBox pbTruck2;
        private System.Windows.Forms.PictureBox pbCar4;
        private System.Windows.Forms.PictureBox pbCar5;
        private System.Windows.Forms.PictureBox pbCar6;
        private System.Windows.Forms.Timer TrafficTimer;
        private System.Windows.Forms.PictureBox pbTruck3;
        private System.Windows.Forms.PictureBox pbTruck4;
        private System.Windows.Forms.PictureBox pbEndFrog1;
        private System.Windows.Forms.PictureBox pbEndFrog2;
        private System.Windows.Forms.PictureBox pbEndFrog3;
        private System.Windows.Forms.PictureBox pbEndFrog4;
        private System.Windows.Forms.PictureBox pbEndFrog5;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Timer scoreTimer;
        private System.Windows.Forms.PictureBox pbRiver;
        private System.Windows.Forms.PictureBox pbLogR1;
        private System.Windows.Forms.PictureBox pbLogR2;
        private System.Windows.Forms.PictureBox pbLogL1;
        private System.Windows.Forms.PictureBox pbLogL2;
        private System.Windows.Forms.PictureBox pbLogR3;
        private System.Windows.Forms.PictureBox pbLogR4;
    }
}

