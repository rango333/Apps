namespace RockPaperScissorsGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupInstructions = new GroupBox();
            labelInstructions = new Label();
            groupSettings = new GroupBox();
            numMaxPoints = new NumericUpDown();
            labelMaxPoints = new Label();
            numOddBestOf = new NumericUpDown();
            labelBestOf = new Label();
            buttonStart = new Button();
            buttonQuit = new Button();
            groupScores = new GroupBox();
            labelCountdown = new Label();
            labelRound = new Label();
            labelComputerScore = new Label();
            labelPlayerScore = new Label();
            labelRoundResult = new Label();
            roundTimer = new System.Windows.Forms.Timer(components);
            btnReadme = new Button();
            pictureRock = new PictureBox();
            picturePaper = new PictureBox();
            pictureScissors = new PictureBox();
            gifCelebration = new PictureBox();
            groupInstructions.SuspendLayout();
            groupSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOddBestOf).BeginInit();
            groupScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureRock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePaper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureScissors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gifCelebration).BeginInit();
            SuspendLayout();
            // 
            // groupInstructions
            // 
            groupInstructions.BackColor = Color.LightSteelBlue;
            groupInstructions.Controls.Add(labelInstructions);
            groupInstructions.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupInstructions.Location = new Point(20, 20);
            groupInstructions.Name = "groupInstructions";
            groupInstructions.Size = new Size(940, 150);
            groupInstructions.TabIndex = 0;
            groupInstructions.TabStop = false;
            groupInstructions.Text = "How the game works";
            // 
            // labelInstructions
            // 
            labelInstructions.BackColor = SystemColors.ActiveCaption;
            labelInstructions.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelInstructions.Location = new Point(12, 32);
            labelInstructions.Name = "labelInstructions";
            labelInstructions.Size = new Size(920, 115);
            labelInstructions.TabIndex = 0;
            labelInstructions.Text = resources.GetString("labelInstructions.Text");
            // 
            // groupSettings
            // 
            groupSettings.BackColor = Color.LightSteelBlue;
            groupSettings.Controls.Add(numMaxPoints);
            groupSettings.Controls.Add(labelMaxPoints);
            groupSettings.Controls.Add(numOddBestOf);
            groupSettings.Controls.Add(labelBestOf);
            groupSettings.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupSettings.Location = new Point(20, 180);
            groupSettings.Name = "groupSettings";
            groupSettings.Size = new Size(940, 110);
            groupSettings.TabIndex = 1;
            groupSettings.TabStop = false;
            groupSettings.Text = "Game Settings";
            // 
            // numMaxPoints
            // 
            numMaxPoints.Location = new Point(360, 38);
            numMaxPoints.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMaxPoints.Name = "numMaxPoints";
            numMaxPoints.ReadOnly = true;
            numMaxPoints.Size = new Size(80, 37);
            numMaxPoints.TabIndex = 3;
            numMaxPoints.TextAlign = HorizontalAlignment.Center;
            numMaxPoints.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // labelMaxPoints
            // 
            labelMaxPoints.AutoSize = true;
            labelMaxPoints.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMaxPoints.Location = new Point(250, 40);
            labelMaxPoints.Name = "labelMaxPoints";
            labelMaxPoints.Size = new Size(117, 28);
            labelMaxPoints.TabIndex = 2;
            labelMaxPoints.Text = "Max Points:";
            // 
            // numOddBestOf
            // 
            numOddBestOf.Increment = new decimal(new int[] { 2, 0, 0, 0 });
            numOddBestOf.Location = new Point(110, 38);
            numOddBestOf.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numOddBestOf.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numOddBestOf.Name = "numOddBestOf";
            numOddBestOf.ReadOnly = true;
            numOddBestOf.Size = new Size(80, 37);
            numOddBestOf.TabIndex = 1;
            numOddBestOf.TextAlign = HorizontalAlignment.Center;
            numOddBestOf.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // labelBestOf
            // 
            labelBestOf.AutoSize = true;
            labelBestOf.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBestOf.Location = new Point(30, 40);
            labelBestOf.Name = "labelBestOf";
            labelBestOf.Size = new Size(76, 28);
            labelBestOf.TabIndex = 0;
            labelBestOf.Text = "Best of";
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.DarkBlue;
            buttonStart.FlatStyle = FlatStyle.Popup;
            buttonStart.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.ForeColor = Color.White;
            buttonStart.Location = new Point(50, 310);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(160, 45);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Start Match";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonQuit
            // 
            buttonQuit.BackColor = Color.DarkBlue;
            buttonQuit.FlatStyle = FlatStyle.Popup;
            buttonQuit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonQuit.ForeColor = Color.White;
            buttonQuit.Location = new Point(230, 310);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(120, 45);
            buttonQuit.TabIndex = 3;
            buttonQuit.Text = "Quit";
            buttonQuit.UseVisualStyleBackColor = false;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // groupScores
            // 
            groupScores.BackColor = Color.MediumAquamarine;
            groupScores.Controls.Add(labelCountdown);
            groupScores.Controls.Add(labelRound);
            groupScores.Controls.Add(labelComputerScore);
            groupScores.Controls.Add(labelPlayerScore);
            groupScores.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupScores.Location = new Point(20, 440);
            groupScores.Name = "groupScores";
            groupScores.Size = new Size(940, 100);
            groupScores.TabIndex = 7;
            groupScores.TabStop = false;
            groupScores.Text = "Scores: ";
            // 
            // labelCountdown
            // 
            labelCountdown.AutoSize = true;
            labelCountdown.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCountdown.Location = new Point(550, 40);
            labelCountdown.Name = "labelCountdown";
            labelCountdown.Size = new Size(68, 28);
            labelCountdown.TabIndex = 3;
            labelCountdown.Text = "Time: ";
            // 
            // labelRound
            // 
            labelRound.AutoSize = true;
            labelRound.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRound.Location = new Point(400, 40);
            labelRound.Name = "labelRound";
            labelRound.Size = new Size(82, 28);
            labelRound.TabIndex = 2;
            labelRound.Text = "Round: ";
            // 
            // labelComputerScore
            // 
            labelComputerScore.AutoSize = true;
            labelComputerScore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComputerScore.Location = new Point(200, 40);
            labelComputerScore.Name = "labelComputerScore";
            labelComputerScore.Size = new Size(115, 28);
            labelComputerScore.TabIndex = 1;
            labelComputerScore.Text = "Computer: ";
            // 
            // labelPlayerScore
            // 
            labelPlayerScore.AutoSize = true;
            labelPlayerScore.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayerScore.Location = new Point(40, 40);
            labelPlayerScore.Name = "labelPlayerScore";
            labelPlayerScore.Size = new Size(79, 28);
            labelPlayerScore.TabIndex = 0;
            labelPlayerScore.Text = "Player: ";
            // 
            // labelRoundResult
            // 
            labelRoundResult.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRoundResult.ForeColor = Color.DarkGreen;
            labelRoundResult.Location = new Point(50, 560);
            labelRoundResult.Name = "labelRoundResult";
            labelRoundResult.Size = new Size(860, 40);
            labelRoundResult.TabIndex = 8;
            labelRoundResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundTimer
            // 
            roundTimer.Interval = 1000;
            roundTimer.Tick += roundTimer_Tick;
            // 
            // btnReadme
            // 
            btnReadme.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReadme.BackColor = Color.SkyBlue;
            btnReadme.FlatStyle = FlatStyle.Popup;
            btnReadme.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReadme.Location = new Point(32, 603);
            btnReadme.Name = "btnReadme";
            btnReadme.Size = new Size(120, 40);
            btnReadme.TabIndex = 10;
            btnReadme.Text = "README";
            btnReadme.UseVisualStyleBackColor = false;
            btnReadme.Click += btnReadme_Click;
            // 
            // pictureRock
            // 
            pictureRock.Enabled = false;
            pictureRock.Image = Resources.Rock;
            pictureRock.Location = new Point(50, 365);
            pictureRock.Name = "pictureRock";
            pictureRock.Size = new Size(60, 60);
            pictureRock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureRock.TabIndex = 13;
            pictureRock.TabStop = false;
            pictureRock.Click += pictureRock_Click;
            // 
            // picturePaper
            // 
            picturePaper.Enabled = false;
            picturePaper.Image = Resources.Paper;
            picturePaper.Location = new Point(180, 365);
            picturePaper.Name = "picturePaper";
            picturePaper.Size = new Size(60, 60);
            picturePaper.SizeMode = PictureBoxSizeMode.Zoom;
            picturePaper.TabIndex = 12;
            picturePaper.TabStop = false;
            picturePaper.Click += picturePaper_Click;
            // 
            // pictureScissors
            // 
            pictureScissors.Enabled = false;
            pictureScissors.Image = Resources.Scissors;
            pictureScissors.Location = new Point(310, 365);
            pictureScissors.Name = "pictureScissors";
            pictureScissors.Size = new Size(60, 60);
            pictureScissors.SizeMode = PictureBoxSizeMode.Zoom;
            pictureScissors.TabIndex = 11;
            pictureScissors.TabStop = false;
            pictureScissors.Click += pictureScissors_Click;
            // 
            // gifCelebration
            // 
            gifCelebration.BackColor = Color.Transparent;
            gifCelebration.Location = new Point(300, 20);
            gifCelebration.Name = "gifCelebration";
            gifCelebration.Size = new Size(300, 200);
            gifCelebration.SizeMode = PictureBoxSizeMode.StretchImage;
            gifCelebration.TabIndex = 14;
            gifCelebration.TabStop = false;
            gifCelebration.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(980, 700);
            Controls.Add(btnReadme);
            Controls.Add(labelRoundResult);
            Controls.Add(groupScores);
            Controls.Add(pictureScissors);
            Controls.Add(picturePaper);
            Controls.Add(pictureRock);
            Controls.Add(buttonQuit);
            Controls.Add(buttonStart);
            Controls.Add(groupSettings);
            Controls.Add(groupInstructions);
            Controls.Add(gifCelebration);
            Font = new Font("Segoe UI", 10F);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock-Paper-Scissors App";
            groupInstructions.ResumeLayout(false);
            groupSettings.ResumeLayout(false);
            groupSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOddBestOf).EndInit();
            groupScores.ResumeLayout(false);
            groupScores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureRock).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePaper).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureScissors).EndInit();
            ((System.ComponentModel.ISupportInitialize)gifCelebration).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupInstructions;
        private Label labelInstructions;
        private GroupBox groupSettings;
        private Label labelBestOf;
        private NumericUpDown numOddBestOf;
        private Label labelMaxPoints;
        private NumericUpDown numMaxPoints;
        private Button buttonStart;
        private Button buttonQuit;
        private PictureBox pictureRock;
        private PictureBox picturePaper;
        private PictureBox pictureScissors;
        private GroupBox groupScores;
        private Label labelPlayerScore;
        private Label labelComputerScore;
        private Label labelRound;
        private Label labelCountdown;
        private Label labelRoundResult;
        private System.Windows.Forms.Timer roundTimer;
        private PictureBox gifCelebration;
        private System.Windows.Forms.Button btnReadme;
    }
}
