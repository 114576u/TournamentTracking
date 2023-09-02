namespace TrackerUI
{
    partial class TournamentViewerForm
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
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamTwoName = new Label();
            teamOneScoreLabel = new Label();
            teamTwoScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(117, 25);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Location = new Point(125, 9);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(81, 25);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Location = new Point(17, 44);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(66, 25);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(85, 36);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(142, 33);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.Location = new Point(85, 79);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(152, 29);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "Unplayed only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            unplayedOnlyCheckbox.CheckedChanged += unplayedOnlyCheckbox_CheckedChanged;
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 25;
            matchupListBox.Location = new Point(21, 111);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(206, 129);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Location = new Point(256, 111);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(117, 25);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Location = new Point(256, 176);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(116, 25);
            teamTwoName.TabIndex = 7;
            teamTwoName.Text = "<team two>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Location = new Point(256, 136);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(63, 25);
            teamOneScoreLabel.TabIndex = 8;
            teamOneScoreLabel.Text = "Score:";
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Location = new Point(256, 201);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(63, 25);
            teamTwoScoreLabel.TabIndex = 9;
            teamTwoScoreLabel.Text = "Score:";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(325, 133);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(100, 33);
            teamOneScoreValue.TabIndex = 10;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(325, 198);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(100, 33);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // scoreButton
            // 
            scoreButton.Location = new Point(445, 165);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(68, 36);
            scoreButton.TabIndex = 12;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            scoreButton.Click += button1_Click;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 265);
            Controls.Add(scoreButton);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamTwoName;
        private Label teamOneScoreLabel;
        private Label teamTwoScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Button scoreButton;
    }
}