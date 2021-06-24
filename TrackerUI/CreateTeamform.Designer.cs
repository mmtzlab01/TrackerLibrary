
namespace TrackerUI
{
    partial class CreateTeamform
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
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.TeamNameEntry = new System.Windows.Forms.TextBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.AddMemberbutton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupbox = new System.Windows.Forms.GroupBox();
            this.CreateMemberButton = new System.Windows.Forms.Button();
            this.PhoneValue = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.TeamMembersListbox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AddNewMemberGroupbox.SuspendLayout();
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
            this.HeaderLabel.Size = new System.Drawing.Size(213, 50);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "Create Team";
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TeamNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TeamNameLabel.Location = new System.Drawing.Point(14, 78);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(172, 32);
            this.TeamNameLabel.TabIndex = 3;
            this.TeamNameLabel.Text = "Team Name";
            // 
            // TeamNameEntry
            // 
            this.TeamNameEntry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameEntry.Location = new System.Drawing.Point(12, 118);
            this.TeamNameEntry.Name = "TeamNameEntry";
            this.TeamNameEntry.Size = new System.Drawing.Size(369, 29);
            this.TeamNameEntry.TabIndex = 9;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SelectTeamLabel.Location = new System.Drawing.Point(12, 150);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(178, 32);
            this.SelectTeamLabel.TabIndex = 10;
            this.SelectTeamLabel.Text = "Select Team";
            // 
            // SelectTeamDropdown
            // 
            this.SelectTeamDropdown.FormattingEnabled = true;
            this.SelectTeamDropdown.Location = new System.Drawing.Point(12, 190);
            this.SelectTeamDropdown.Name = "SelectTeamDropdown";
            this.SelectTeamDropdown.Size = new System.Drawing.Size(369, 21);
            this.SelectTeamDropdown.TabIndex = 11;
            // 
            // AddMemberbutton
            // 
            this.AddMemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddMemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddMemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddMemberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberbutton.Location = new System.Drawing.Point(136, 217);
            this.AddMemberbutton.Name = "AddMemberbutton";
            this.AddMemberbutton.Size = new System.Drawing.Size(151, 61);
            this.AddMemberbutton.TabIndex = 14;
            this.AddMemberbutton.Text = "Add Member";
            this.AddMemberbutton.UseVisualStyleBackColor = true;
            // 
            // AddNewMemberGroupbox
            // 
            this.AddNewMemberGroupbox.Controls.Add(this.CreateMemberButton);
            this.AddNewMemberGroupbox.Controls.Add(this.PhoneValue);
            this.AddNewMemberGroupbox.Controls.Add(this.PhoneLabel);
            this.AddNewMemberGroupbox.Controls.Add(this.EmailValue);
            this.AddNewMemberGroupbox.Controls.Add(this.EmailLabel);
            this.AddNewMemberGroupbox.Controls.Add(this.LastNameValue);
            this.AddNewMemberGroupbox.Controls.Add(this.LastNameLabel);
            this.AddNewMemberGroupbox.Controls.Add(this.FirstNameValue);
            this.AddNewMemberGroupbox.Controls.Add(this.FirstNameLabel);
            this.AddNewMemberGroupbox.Location = new System.Drawing.Point(12, 284);
            this.AddNewMemberGroupbox.Name = "AddNewMemberGroupbox";
            this.AddNewMemberGroupbox.Size = new System.Drawing.Size(369, 289);
            this.AddNewMemberGroupbox.TabIndex = 15;
            this.AddNewMemberGroupbox.TabStop = false;
            this.AddNewMemberGroupbox.Text = "Add New Member";
            // 
            // CreateMemberButton
            // 
            this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMemberButton.Location = new System.Drawing.Point(90, 222);
            this.CreateMemberButton.Name = "CreateMemberButton";
            this.CreateMemberButton.Size = new System.Drawing.Size(178, 61);
            this.CreateMemberButton.TabIndex = 20;
            this.CreateMemberButton.Text = "Create Member";
            this.CreateMemberButton.UseVisualStyleBackColor = true;
            this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
            // 
            // PhoneValue
            // 
            this.PhoneValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneValue.Location = new System.Drawing.Point(218, 180);
            this.PhoneValue.Name = "PhoneValue";
            this.PhoneValue.Size = new System.Drawing.Size(145, 29);
            this.PhoneValue.TabIndex = 19;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PhoneLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PhoneLabel.Location = new System.Drawing.Point(6, 174);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(147, 32);
            this.PhoneLabel.TabIndex = 18;
            this.PhoneLabel.Text = "CellPhone";
            // 
            // EmailValue
            // 
            this.EmailValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailValue.Location = new System.Drawing.Point(218, 132);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(145, 29);
            this.EmailValue.TabIndex = 17;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EmailLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmailLabel.Location = new System.Drawing.Point(6, 126);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(87, 32);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "Email";
            // 
            // LastNameValue
            // 
            this.LastNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameValue.Location = new System.Drawing.Point(218, 85);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(145, 29);
            this.LastNameValue.TabIndex = 15;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LastNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LastNameLabel.Location = new System.Drawing.Point(6, 79);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(163, 32);
            this.LastNameLabel.TabIndex = 14;
            this.LastNameLabel.Text = "Last Name ";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameValue.Location = new System.Drawing.Point(218, 37);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(145, 29);
            this.FirstNameValue.TabIndex = 13;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.FirstNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 31);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(159, 32);
            this.FirstNameLabel.TabIndex = 12;
            this.FirstNameLabel.Text = "First Name";
            // 
            // TeamMembersListbox
            // 
            this.TeamMembersListbox.FormattingEnabled = true;
            this.TeamMembersListbox.Location = new System.Drawing.Point(432, 40);
            this.TeamMembersListbox.Name = "TeamMembersListbox";
            this.TeamMembersListbox.Size = new System.Drawing.Size(236, 355);
            this.TeamMembersListbox.TabIndex = 16;
            // 
            // DeleteSelectedMemberButton
            // 
            this.DeleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedMemberButton.Location = new System.Drawing.Point(484, 410);
            this.DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            this.DeleteSelectedMemberButton.Size = new System.Drawing.Size(133, 68);
            this.DeleteSelectedMemberButton.TabIndex = 26;
            this.DeleteSelectedMemberButton.Text = "Delete Selected";
            this.DeleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamButton.Location = new System.Drawing.Point(432, 506);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(214, 68);
            this.CreateTeamButton.TabIndex = 27;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 612);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedMemberButton);
            this.Controls.Add(this.TeamMembersListbox);
            this.Controls.Add(this.AddNewMemberGroupbox);
            this.Controls.Add(this.AddMemberbutton);
            this.Controls.Add(this.SelectTeamDropdown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.TeamNameEntry);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "CreateTeamform";
            this.Text = "Create Team";
            this.AddNewMemberGroupbox.ResumeLayout(false);
            this.AddNewMemberGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.TextBox TeamNameEntry;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.ComboBox SelectTeamDropdown;
        private System.Windows.Forms.Button AddMemberbutton;
        private System.Windows.Forms.GroupBox AddNewMemberGroupbox;
        private System.Windows.Forms.Button CreateMemberButton;
        private System.Windows.Forms.TextBox PhoneValue;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.ListBox TeamMembersListbox;
        private System.Windows.Forms.Button DeleteSelectedMemberButton;
        private System.Windows.Forms.Button CreateTeamButton;
    }
}