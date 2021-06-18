
namespace TrackerUI
{
    partial class tournamentDashboardForm
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
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.LoadExistingDropdown = new System.Windows.Forms.ComboBox();
            this.LoadExistingLabel = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentButton.Location = new System.Drawing.Point(140, 238);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(214, 68);
            this.CreateTournamentButton.TabIndex = 32;
            this.CreateTournamentButton.Text = "Create Tournament ";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LoadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadTournamentButton.Location = new System.Drawing.Point(189, 181);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(116, 42);
            this.LoadTournamentButton.TabIndex = 31;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // LoadExistingDropdown
            // 
            this.LoadExistingDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExistingDropdown.FormattingEnabled = true;
            this.LoadExistingDropdown.Location = new System.Drawing.Point(92, 138);
            this.LoadExistingDropdown.Name = "LoadExistingDropdown";
            this.LoadExistingDropdown.Size = new System.Drawing.Size(311, 28);
            this.LoadExistingDropdown.TabIndex = 30;
            // 
            // LoadExistingLabel
            // 
            this.LoadExistingLabel.AutoSize = true;
            this.LoadExistingLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoadExistingLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExistingLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadExistingLabel.Location = new System.Drawing.Point(92, 95);
            this.LoadExistingLabel.Name = "LoadExistingLabel";
            this.LoadExistingLabel.Size = new System.Drawing.Size(311, 28);
            this.LoadExistingLabel.TabIndex = 29;
            this.LoadExistingLabel.Text = "Load existing Tournament";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.HeaderLabel.Location = new System.Drawing.Point(55, 30);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(385, 50);
            this.HeaderLabel.TabIndex = 33;
            this.HeaderLabel.Text = "Tournament Dashboard";
            // 
            // tournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 339);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.LoadExistingDropdown);
            this.Controls.Add(this.LoadExistingLabel);
            this.Name = "tournamentDashboardForm";
            this.Text = "Tournament Dashboard Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateTournamentButton;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.ComboBox LoadExistingDropdown;
        private System.Windows.Forms.Label LoadExistingLabel;
        private System.Windows.Forms.Label HeaderLabel;
    }
}