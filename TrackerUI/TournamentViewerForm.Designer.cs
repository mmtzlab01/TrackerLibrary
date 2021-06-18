
namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TournamentLabel = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropdown = new System.Windows.Forms.ComboBox();
            this.UnplayedOnly = new System.Windows.Forms.CheckBox();
            this.MatchupListbox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreBox = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreBox = new System.Windows.Forms.TextBox();
            this.ScoreLabel2 = new System.Windows.Forms.Label();
            this.TeamTwoName = new System.Windows.Forms.Label();
            this.VSLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(214, 50);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament:";
            this.HeaderLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TournamentLabel
            // 
            this.TournamentLabel.AutoSize = true;
            this.TournamentLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TournamentLabel.Location = new System.Drawing.Point(232, 9);
            this.TournamentLabel.Name = "TournamentLabel";
            this.TournamentLabel.Size = new System.Drawing.Size(156, 50);
            this.TournamentLabel.TabIndex = 1;
            this.TournamentLabel.Text = "<None>";
            this.TournamentLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RoundLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RoundLabel.Location = new System.Drawing.Point(14, 72);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(117, 37);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // RoundDropdown
            // 
            this.RoundDropdown.FormattingEnabled = true;
            this.RoundDropdown.Location = new System.Drawing.Point(137, 72);
            this.RoundDropdown.Name = "RoundDropdown";
            this.RoundDropdown.Size = new System.Drawing.Size(251, 21);
            this.RoundDropdown.TabIndex = 3;
            // 
            // UnplayedOnly
            // 
            this.UnplayedOnly.AutoSize = true;
            this.UnplayedOnly.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedOnly.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.UnplayedOnly.Location = new System.Drawing.Point(137, 114);
            this.UnplayedOnly.Name = "UnplayedOnly";
            this.UnplayedOnly.Size = new System.Drawing.Size(247, 49);
            this.UnplayedOnly.TabIndex = 4;
            this.UnplayedOnly.Text = "Unplayed Only";
            this.UnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // MatchupListbox
            // 
            this.MatchupListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListbox.FormattingEnabled = true;
            this.MatchupListbox.Location = new System.Drawing.Point(21, 174);
            this.MatchupListbox.Name = "MatchupListbox";
            this.MatchupListbox.Size = new System.Drawing.Size(367, 249);
            this.MatchupListbox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TeamOneName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeamOneName.Location = new System.Drawing.Point(436, 178);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(168, 37);
            this.TeamOneName.TabIndex = 6;
            this.TeamOneName.Text = "<Team 1>";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(436, 233);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(109, 37);
            this.TeamOneScoreLabel.TabIndex = 7;
            this.TeamOneScoreLabel.Text = "Score";
            // 
            // TeamOneScoreBox
            // 
            this.TeamOneScoreBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneScoreBox.Location = new System.Drawing.Point(551, 241);
            this.TeamOneScoreBox.Name = "TeamOneScoreBox";
            this.TeamOneScoreBox.Size = new System.Drawing.Size(100, 29);
            this.TeamOneScoreBox.TabIndex = 8;
            this.TeamOneScoreBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TeamTwoScoreBox
            // 
            this.TeamTwoScoreBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoScoreBox.Location = new System.Drawing.Point(551, 394);
            this.TeamTwoScoreBox.Name = "TeamTwoScoreBox";
            this.TeamTwoScoreBox.Size = new System.Drawing.Size(100, 29);
            this.TeamTwoScoreBox.TabIndex = 11;
            // 
            // ScoreLabel2
            // 
            this.ScoreLabel2.AutoSize = true;
            this.ScoreLabel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ScoreLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ScoreLabel2.Location = new System.Drawing.Point(436, 386);
            this.ScoreLabel2.Name = "ScoreLabel2";
            this.ScoreLabel2.Size = new System.Drawing.Size(109, 37);
            this.ScoreLabel2.TabIndex = 10;
            this.ScoreLabel2.Text = "Score";
            // 
            // TeamTwoName
            // 
            this.TeamTwoName.AutoSize = true;
            this.TeamTwoName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TeamTwoName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeamTwoName.Location = new System.Drawing.Point(436, 337);
            this.TeamTwoName.Name = "TeamTwoName";
            this.TeamTwoName.Size = new System.Drawing.Size(168, 37);
            this.TeamTwoName.TabIndex = 9;
            this.TeamTwoName.Text = "<Team 2>";
            // 
            // VSLabel
            // 
            this.VSLabel.AutoSize = true;
            this.VSLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.VSLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.VSLabel.Location = new System.Drawing.Point(522, 290);
            this.VSLabel.Name = "VSLabel";
            this.VSLabel.Size = new System.Drawing.Size(82, 37);
            this.VSLabel.TabIndex = 12;
            this.VSLabel.Text = "-VS-";
            // 
            // ScoreButton
            // 
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ScoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreButton.Location = new System.Drawing.Point(694, 288);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(94, 47);
            this.ScoreButton.TabIndex = 13;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VSLabel);
            this.Controls.Add(this.TeamTwoScoreBox);
            this.Controls.Add(this.ScoreLabel2);
            this.Controls.Add(this.TeamTwoName);
            this.Controls.Add(this.TeamOneScoreBox);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.MatchupListbox);
            this.Controls.Add(this.UnplayedOnly);
            this.Controls.Add(this.RoundDropdown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TournamentLabel;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundDropdown;
        private System.Windows.Forms.CheckBox UnplayedOnly;
        private System.Windows.Forms.ListBox MatchupListbox;
        private System.Windows.Forms.Label TeamOneName;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox TeamOneScoreBox;
        private System.Windows.Forms.TextBox TeamTwoScoreBox;
        private System.Windows.Forms.Label ScoreLabel2;
        private System.Windows.Forms.Label TeamTwoName;
        private System.Windows.Forms.Label VSLabel;
        private System.Windows.Forms.Button ScoreButton;
    }
}

