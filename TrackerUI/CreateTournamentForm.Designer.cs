namespace TrackerUI
{
    partial class CreateTournamentForm
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
            headerLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            deleteSelectedPlayerButton = new Button();
            deleteSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(171, 25);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Create tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(14, 68);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(195, 33);
            tournamentNameValue.TabIndex = 14;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Location = new Point(14, 40);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(165, 25);
            tournamentNameLabel.TabIndex = 13;
            tournamentNameLabel.Text = "Tournament name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(110, 116);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(100, 33);
            entryFeeValue.TabIndex = 18;
            entryFeeValue.Text = "0";
            entryFeeValue.TextChanged += teamOneScoreValue_TextChanged;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Location = new Point(14, 119);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(90, 25);
            entryFeeLabel.TabIndex = 17;
            entryFeeLabel.Text = "Entry fee:";
            entryFeeLabel.Click += teamOneScoreLabel_Click;
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(15, 191);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(194, 33);
            selectTeamDropDown.TabIndex = 20;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Location = new Point(15, 163);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(109, 25);
            selectTeamLabel.TabIndex = 19;
            selectTeamLabel.Text = "Select team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            createNewTeamLink.Location = new Point(144, 172);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(65, 13);
            createNewTeamLink.TabIndex = 21;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "Create new";
            // 
            // addTeamButton
            // 
            addTeamButton.Location = new Point(46, 243);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(133, 32);
            addTeamButton.TabIndex = 22;
            addTeamButton.Text = "Add team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += scoreButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.Location = new Point(46, 281);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(133, 32);
            createPrizeButton.TabIndex = 23;
            createPrizeButton.Text = "Create prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += button1_Click;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 25;
            tournamentPlayersListBox.Location = new Point(240, 68);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(206, 129);
            tournamentPlayersListBox.TabIndex = 24;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Location = new Point(240, 40);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(141, 25);
            tournamentPlayersLabel.TabIndex = 25;
            tournamentPlayersLabel.Text = "Teams / Players";
            tournamentPlayersLabel.Click += label1_Click;
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.Location = new Point(461, 68);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(122, 76);
            deleteSelectedPlayerButton.TabIndex = 26;
            deleteSelectedPlayerButton.Text = "Delete selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.Location = new Point(461, 243);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(122, 70);
            deleteSelectedPrizeButton.TabIndex = 29;
            deleteSelectedPrizeButton.Text = "Delete selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Location = new Point(240, 215);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(54, 25);
            prizesLabel.TabIndex = 28;
            prizesLabel.Text = "Prize";
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 25;
            prizesListBox.Location = new Point(240, 243);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(206, 129);
            prizesListBox.TabIndex = 27;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Location = new Point(197, 378);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(273, 32);
            createTournamentButton.TabIndex = 30;
            createTournamentButton.Text = "Create tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 421);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label tournamentPlayersLabel;
        private Button deleteSelectedPlayerButton;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}