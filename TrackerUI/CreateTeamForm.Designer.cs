namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            addMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            removeSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.Location = new Point(14, 68);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(303, 33);
            teamNameValue.TabIndex = 17;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Location = new Point(14, 40);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(108, 25);
            teamNameLabel.TabIndex = 16;
            teamNameLabel.Text = "Team name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Location = new Point(12, 9);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(114, 25);
            createTeamLabel.TabIndex = 15;
            createTeamLabel.Text = "Create team";
            // 
            // addMemberButton
            // 
            addMemberButton.Location = new Point(81, 203);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(133, 32);
            addMemberButton.TabIndex = 26;
            addMemberButton.Text = "Add member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(14, 152);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(302, 33);
            selectTeamMemberDropDown.TabIndex = 24;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Location = new Point(14, 124);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(184, 25);
            selectTeamMemberLabel.TabIndex = 23;
            selectTeamMemberLabel.Text = "Select team member";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellphoneValue);
            addNewMemberGroupBox.Controls.Add(cellphoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Location = new Point(14, 258);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(302, 233);
            addNewMemberGroupBox.TabIndex = 27;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add new member";
            // 
            // createMemberButton
            // 
            createMemberButton.Location = new Point(67, 185);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(170, 32);
            createMemberButton.TabIndex = 28;
            createMemberButton.Text = "Create member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellphoneValue
            // 
            cellphoneValue.Location = new Point(125, 146);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(159, 33);
            cellphoneValue.TabIndex = 18;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Location = new Point(16, 154);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(102, 25);
            cellphoneLabel.TabIndex = 17;
            cellphoneLabel.Text = "Cellphone:";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(125, 107);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(159, 33);
            emailValue.TabIndex = 16;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(16, 115);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(62, 25);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email:";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(125, 68);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(159, 33);
            lastNameValue.TabIndex = 14;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(16, 76);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(101, 25);
            lastNameLabel.TabIndex = 13;
            lastNameLabel.Text = "Last name:";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(125, 29);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(159, 33);
            firstNameValue.TabIndex = 12;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(16, 37);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(103, 25);
            firstNameLabel.TabIndex = 11;
            firstNameLabel.Text = "First name:";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 25;
            teamMembersListBox.Location = new Point(376, 68);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(206, 154);
            teamMembersListBox.TabIndex = 28;
            // 
            // removeSelectedMemberButton
            // 
            removeSelectedMemberButton.Location = new Point(376, 228);
            removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            removeSelectedMemberButton.Size = new Size(206, 40);
            removeSelectedMemberButton.TabIndex = 29;
            removeSelectedMemberButton.Text = "Remove selected";
            removeSelectedMemberButton.UseVisualStyleBackColor = true;
            removeSelectedMemberButton.Click += removeSelectedMemberButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.Location = new Point(352, 459);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(273, 32);
            createTeamButton.TabIndex = 31;
            createTeamButton.Text = "Create team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 503);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberGroupBox;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Button createMemberButton;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private ListBox teamMembersListBox;
        private Button removeSelectedMemberButton;
        private Button createTeamButton;
    }
}