namespace Million_Dollar_Project
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
            this.btnOptionA = new System.Windows.Forms.Button();
            this.btnOptionB = new System.Windows.Forms.Button();
            this.btnOptionC = new System.Windows.Forms.Button();
            this.btnOptionD = new System.Windows.Forms.Button();
            this.tbxQuestion = new System.Windows.Forms.TextBox();
            this.gpbxLevel = new System.Windows.Forms.GroupBox();
            this.lblLevel10 = new System.Windows.Forms.Label();
            this.lblLevel9 = new System.Windows.Forms.Label();
            this.lblLevel8 = new System.Windows.Forms.Label();
            this.lblLevel7 = new System.Windows.Forms.Label();
            this.lblLevel6 = new System.Windows.Forms.Label();
            this.lblLevel5 = new System.Windows.Forms.Label();
            this.lblLevel4 = new System.Windows.Forms.Label();
            this.lblLevel3 = new System.Windows.Forms.Label();
            this.lblLevel2 = new System.Windows.Forms.Label();
            this.lblLevel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFifty = new System.Windows.Forms.Button();
            this.btnCallAFreind = new System.Windows.Forms.Button();
            this.btnAudience = new System.Windows.Forms.Button();
            this.cmbxDifficulty = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginSignupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pgbOptionA = new System.Windows.Forms.ProgressBar();
            this.pgbOptionB = new System.Windows.Forms.ProgressBar();
            this.pgbOptionC = new System.Windows.Forms.ProgressBar();
            this.pgbOptionD = new System.Windows.Forms.ProgressBar();
            this.lblPercentegeOfOptionA = new System.Windows.Forms.Label();
            this.lblPercentegeOfOptionB = new System.Windows.Forms.Label();
            this.lblPercentegeOfOptionC = new System.Windows.Forms.Label();
            this.lblPercentegeOfOptionD = new System.Windows.Forms.Label();
            this.gpbxLevel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOptionA
            // 
            this.btnOptionA.Location = new System.Drawing.Point(72, 299);
            this.btnOptionA.Name = "btnOptionA";
            this.btnOptionA.Size = new System.Drawing.Size(203, 62);
            this.btnOptionA.TabIndex = 0;
            this.btnOptionA.Tag = "A";
            this.btnOptionA.UseVisualStyleBackColor = true;
            this.btnOptionA.Click += new System.EventHandler(this.btnOption_Clicked);
            // 
            // btnOptionB
            // 
            this.btnOptionB.Location = new System.Drawing.Point(477, 299);
            this.btnOptionB.Name = "btnOptionB";
            this.btnOptionB.Size = new System.Drawing.Size(203, 62);
            this.btnOptionB.TabIndex = 1;
            this.btnOptionB.Tag = "B";
            this.btnOptionB.UseVisualStyleBackColor = true;
            this.btnOptionB.Click += new System.EventHandler(this.btnOption_Clicked);
            // 
            // btnOptionC
            // 
            this.btnOptionC.Location = new System.Drawing.Point(72, 426);
            this.btnOptionC.Name = "btnOptionC";
            this.btnOptionC.Size = new System.Drawing.Size(203, 62);
            this.btnOptionC.TabIndex = 2;
            this.btnOptionC.Tag = "C";
            this.btnOptionC.UseVisualStyleBackColor = true;
            this.btnOptionC.Click += new System.EventHandler(this.btnOption_Clicked);
            // 
            // btnOptionD
            // 
            this.btnOptionD.Location = new System.Drawing.Point(477, 426);
            this.btnOptionD.Name = "btnOptionD";
            this.btnOptionD.Size = new System.Drawing.Size(203, 62);
            this.btnOptionD.TabIndex = 3;
            this.btnOptionD.Tag = "D";
            this.btnOptionD.UseVisualStyleBackColor = true;
            this.btnOptionD.Click += new System.EventHandler(this.btnOption_Clicked);
            // 
            // tbxQuestion
            // 
            this.tbxQuestion.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuestion.Location = new System.Drawing.Point(102, 182);
            this.tbxQuestion.Multiline = true;
            this.tbxQuestion.Name = "tbxQuestion";
            this.tbxQuestion.Size = new System.Drawing.Size(558, 96);
            this.tbxQuestion.TabIndex = 4;
            // 
            // gpbxLevel
            // 
            this.gpbxLevel.Controls.Add(this.lblLevel10);
            this.gpbxLevel.Controls.Add(this.lblLevel9);
            this.gpbxLevel.Controls.Add(this.lblLevel8);
            this.gpbxLevel.Controls.Add(this.lblLevel7);
            this.gpbxLevel.Controls.Add(this.lblLevel6);
            this.gpbxLevel.Controls.Add(this.lblLevel5);
            this.gpbxLevel.Controls.Add(this.lblLevel4);
            this.gpbxLevel.Controls.Add(this.lblLevel3);
            this.gpbxLevel.Controls.Add(this.lblLevel2);
            this.gpbxLevel.Controls.Add(this.lblLevel1);
            this.gpbxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbxLevel.Location = new System.Drawing.Point(755, 35);
            this.gpbxLevel.Name = "gpbxLevel";
            this.gpbxLevel.Size = new System.Drawing.Size(146, 453);
            this.gpbxLevel.TabIndex = 5;
            this.gpbxLevel.TabStop = false;
            this.gpbxLevel.Text = "Level";
            // 
            // lblLevel10
            // 
            this.lblLevel10.AutoSize = true;
            this.lblLevel10.Location = new System.Drawing.Point(6, 30);
            this.lblLevel10.Name = "lblLevel10";
            this.lblLevel10.Size = new System.Drawing.Size(135, 20);
            this.lblLevel10.TabIndex = 9;
            this.lblLevel10.Text = "10.      1.000.000$";
            // 
            // lblLevel9
            // 
            this.lblLevel9.AutoSize = true;
            this.lblLevel9.Location = new System.Drawing.Point(6, 72);
            this.lblLevel9.Name = "lblLevel9";
            this.lblLevel9.Size = new System.Drawing.Size(113, 20);
            this.lblLevel9.TabIndex = 8;
            this.lblLevel9.Text = "9.      900.000$";
            // 
            // lblLevel8
            // 
            this.lblLevel8.AutoSize = true;
            this.lblLevel8.Location = new System.Drawing.Point(6, 114);
            this.lblLevel8.Name = "lblLevel8";
            this.lblLevel8.Size = new System.Drawing.Size(113, 20);
            this.lblLevel8.TabIndex = 7;
            this.lblLevel8.Text = "8.      800.000$";
            // 
            // lblLevel7
            // 
            this.lblLevel7.AutoSize = true;
            this.lblLevel7.Location = new System.Drawing.Point(6, 156);
            this.lblLevel7.Name = "lblLevel7";
            this.lblLevel7.Size = new System.Drawing.Size(113, 20);
            this.lblLevel7.TabIndex = 6;
            this.lblLevel7.Text = "7.      700.000$";
            // 
            // lblLevel6
            // 
            this.lblLevel6.AutoSize = true;
            this.lblLevel6.Location = new System.Drawing.Point(6, 198);
            this.lblLevel6.Name = "lblLevel6";
            this.lblLevel6.Size = new System.Drawing.Size(113, 20);
            this.lblLevel6.TabIndex = 5;
            this.lblLevel6.Text = "6.      500.000$";
            // 
            // lblLevel5
            // 
            this.lblLevel5.AutoSize = true;
            this.lblLevel5.Location = new System.Drawing.Point(6, 240);
            this.lblLevel5.Name = "lblLevel5";
            this.lblLevel5.Size = new System.Drawing.Size(113, 20);
            this.lblLevel5.TabIndex = 4;
            this.lblLevel5.Text = "5.      300.000$";
            // 
            // lblLevel4
            // 
            this.lblLevel4.AutoSize = true;
            this.lblLevel4.Location = new System.Drawing.Point(6, 282);
            this.lblLevel4.Name = "lblLevel4";
            this.lblLevel4.Size = new System.Drawing.Size(113, 20);
            this.lblLevel4.TabIndex = 3;
            this.lblLevel4.Text = "4.      100.000$";
            // 
            // lblLevel3
            // 
            this.lblLevel3.AutoSize = true;
            this.lblLevel3.Location = new System.Drawing.Point(6, 324);
            this.lblLevel3.Name = "lblLevel3";
            this.lblLevel3.Size = new System.Drawing.Size(104, 20);
            this.lblLevel3.TabIndex = 2;
            this.lblLevel3.Text = "3.      50.000$";
            // 
            // lblLevel2
            // 
            this.lblLevel2.AutoSize = true;
            this.lblLevel2.Location = new System.Drawing.Point(6, 366);
            this.lblLevel2.Name = "lblLevel2";
            this.lblLevel2.Size = new System.Drawing.Size(112, 20);
            this.lblLevel2.TabIndex = 1;
            this.lblLevel2.Text = "2.        10.000$";
            // 
            // lblLevel1
            // 
            this.lblLevel1.AutoSize = true;
            this.lblLevel1.Location = new System.Drawing.Point(6, 408);
            this.lblLevel1.Name = "lblLevel1";
            this.lblLevel1.Size = new System.Drawing.Size(103, 20);
            this.lblLevel1.TabIndex = 0;
            this.lblLevel1.Text = "1.         1000$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(228, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Who Wants to be a Millionnaire";
            // 
            // btnFifty
            // 
            this.btnFifty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFifty.Enabled = false;
            this.btnFifty.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFifty.Location = new System.Drawing.Point(102, 133);
            this.btnFifty.Name = "btnFifty";
            this.btnFifty.Size = new System.Drawing.Size(131, 41);
            this.btnFifty.TabIndex = 7;
            this.btnFifty.Text = "Fifty-Fifty";
            this.btnFifty.UseVisualStyleBackColor = true;
            this.btnFifty.Click += new System.EventHandler(this.btnFifty_Click);
            // 
            // btnCallAFreind
            // 
            this.btnCallAFreind.Enabled = false;
            this.btnCallAFreind.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallAFreind.Location = new System.Drawing.Point(315, 133);
            this.btnCallAFreind.Name = "btnCallAFreind";
            this.btnCallAFreind.Size = new System.Drawing.Size(131, 41);
            this.btnCallAFreind.TabIndex = 8;
            this.btnCallAFreind.Text = "Call a Freind";
            this.btnCallAFreind.UseVisualStyleBackColor = true;
            this.btnCallAFreind.Click += new System.EventHandler(this.btnCallAFreind_Click);
            // 
            // btnAudience
            // 
            this.btnAudience.Enabled = false;
            this.btnAudience.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudience.Location = new System.Drawing.Point(528, 133);
            this.btnAudience.Name = "btnAudience";
            this.btnAudience.Size = new System.Drawing.Size(131, 41);
            this.btnAudience.TabIndex = 9;
            this.btnAudience.Text = "Audience Help";
            this.btnAudience.UseVisualStyleBackColor = true;
            this.btnAudience.Click += new System.EventHandler(this.btnAudience_Click);
            // 
            // cmbxDifficulty
            // 
            this.cmbxDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxDifficulty.FormattingEnabled = true;
            this.cmbxDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbxDifficulty.Location = new System.Drawing.Point(102, 40);
            this.cmbxDifficulty.Name = "cmbxDifficulty";
            this.cmbxDifficulty.Size = new System.Drawing.Size(102, 28);
            this.cmbxDifficulty.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 21);
            this.label12.TabIndex = 11;
            this.label12.Text = "Difficulty";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginSignupToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loginSignupToolStripMenuItem
            // 
            this.loginSignupToolStripMenuItem.Name = "loginSignupToolStripMenuItem";
            this.loginSignupToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.loginSignupToolStripMenuItem.Text = "Login/Signup";
            this.loginSignupToolStripMenuItem.Click += new System.EventHandler(this.loginSignupToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(236, 90);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 34);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(447, 90);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 34);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(356, 99);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 25);
            this.lblTimer.TabIndex = 15;
            // 
            // pgbOptionA
            // 
            this.pgbOptionA.Location = new System.Drawing.Point(72, 367);
            this.pgbOptionA.Name = "pgbOptionA";
            this.pgbOptionA.Size = new System.Drawing.Size(174, 23);
            this.pgbOptionA.TabIndex = 16;
            this.pgbOptionA.Visible = false;
            // 
            // pgbOptionB
            // 
            this.pgbOptionB.Location = new System.Drawing.Point(477, 367);
            this.pgbOptionB.Name = "pgbOptionB";
            this.pgbOptionB.Size = new System.Drawing.Size(174, 23);
            this.pgbOptionB.TabIndex = 17;
            this.pgbOptionB.Visible = false;
            // 
            // pgbOptionC
            // 
            this.pgbOptionC.Location = new System.Drawing.Point(72, 494);
            this.pgbOptionC.Name = "pgbOptionC";
            this.pgbOptionC.Size = new System.Drawing.Size(174, 23);
            this.pgbOptionC.TabIndex = 18;
            this.pgbOptionC.Visible = false;
            // 
            // pgbOptionD
            // 
            this.pgbOptionD.Location = new System.Drawing.Point(477, 494);
            this.pgbOptionD.Name = "pgbOptionD";
            this.pgbOptionD.Size = new System.Drawing.Size(174, 23);
            this.pgbOptionD.TabIndex = 19;
            this.pgbOptionD.Visible = false;
            // 
            // lblPercentegeOfOptionA
            // 
            this.lblPercentegeOfOptionA.AutoSize = true;
            this.lblPercentegeOfOptionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentegeOfOptionA.Location = new System.Drawing.Point(252, 370);
            this.lblPercentegeOfOptionA.Name = "lblPercentegeOfOptionA";
            this.lblPercentegeOfOptionA.Size = new System.Drawing.Size(0, 20);
            this.lblPercentegeOfOptionA.TabIndex = 20;
            // 
            // lblPercentegeOfOptionB
            // 
            this.lblPercentegeOfOptionB.AutoSize = true;
            this.lblPercentegeOfOptionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentegeOfOptionB.Location = new System.Drawing.Point(660, 370);
            this.lblPercentegeOfOptionB.Name = "lblPercentegeOfOptionB";
            this.lblPercentegeOfOptionB.Size = new System.Drawing.Size(0, 20);
            this.lblPercentegeOfOptionB.TabIndex = 21;
            // 
            // lblPercentegeOfOptionC
            // 
            this.lblPercentegeOfOptionC.AutoSize = true;
            this.lblPercentegeOfOptionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentegeOfOptionC.Location = new System.Drawing.Point(251, 496);
            this.lblPercentegeOfOptionC.Name = "lblPercentegeOfOptionC";
            this.lblPercentegeOfOptionC.Size = new System.Drawing.Size(0, 20);
            this.lblPercentegeOfOptionC.TabIndex = 22;
            this.lblPercentegeOfOptionC.Click += new System.EventHandler(this.label13_Click);
            // 
            // lblPercentegeOfOptionD
            // 
            this.lblPercentegeOfOptionD.AutoSize = true;
            this.lblPercentegeOfOptionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentegeOfOptionD.Location = new System.Drawing.Point(659, 500);
            this.lblPercentegeOfOptionD.Name = "lblPercentegeOfOptionD";
            this.lblPercentegeOfOptionD.Size = new System.Drawing.Size(0, 20);
            this.lblPercentegeOfOptionD.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 529);
            this.Controls.Add(this.lblPercentegeOfOptionD);
            this.Controls.Add(this.lblPercentegeOfOptionC);
            this.Controls.Add(this.lblPercentegeOfOptionB);
            this.Controls.Add(this.lblPercentegeOfOptionA);
            this.Controls.Add(this.pgbOptionD);
            this.Controls.Add(this.pgbOptionC);
            this.Controls.Add(this.pgbOptionB);
            this.Controls.Add(this.pgbOptionA);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbxDifficulty);
            this.Controls.Add(this.btnAudience);
            this.Controls.Add(this.btnCallAFreind);
            this.Controls.Add(this.btnFifty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbxLevel);
            this.Controls.Add(this.tbxQuestion);
            this.Controls.Add(this.btnOptionD);
            this.Controls.Add(this.btnOptionC);
            this.Controls.Add(this.btnOptionB);
            this.Controls.Add(this.btnOptionA);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Who Wants To Be A Millionnaire";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbxLevel.ResumeLayout(false);
            this.gpbxLevel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOptionA;
        private System.Windows.Forms.Button btnOptionB;
        private System.Windows.Forms.Button btnOptionC;
        private System.Windows.Forms.Button btnOptionD;
        private System.Windows.Forms.TextBox tbxQuestion;
        private System.Windows.Forms.GroupBox gpbxLevel;
        private System.Windows.Forms.Label lblLevel10;
        private System.Windows.Forms.Label lblLevel9;
        private System.Windows.Forms.Label lblLevel8;
        private System.Windows.Forms.Label lblLevel7;
        private System.Windows.Forms.Label lblLevel6;
        private System.Windows.Forms.Label lblLevel5;
        private System.Windows.Forms.Label lblLevel4;
        private System.Windows.Forms.Label lblLevel3;
        private System.Windows.Forms.Label lblLevel2;
        private System.Windows.Forms.Label lblLevel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFifty;
        private System.Windows.Forms.Button btnCallAFreind;
        private System.Windows.Forms.Button btnAudience;
        private System.Windows.Forms.ComboBox cmbxDifficulty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginSignupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ProgressBar pgbOptionA;
        private System.Windows.Forms.ProgressBar pgbOptionB;
        private System.Windows.Forms.ProgressBar pgbOptionC;
        private System.Windows.Forms.ProgressBar pgbOptionD;
        private System.Windows.Forms.Label lblPercentegeOfOptionA;
        private System.Windows.Forms.Label lblPercentegeOfOptionB;
        private System.Windows.Forms.Label lblPercentegeOfOptionC;
        private System.Windows.Forms.Label lblPercentegeOfOptionD;
    }
}

