namespace TrackerUI
{
    partial class CreatePrizeForm
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
            createPrizeLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizeAmountValue = new TextBox();
            priceAmountLabel = new Label();
            prizePercentageValue = new TextBox();
            pricePercentageLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Location = new Point(12, 9);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(114, 25);
            createPrizeLabel.TabIndex = 16;
            createPrizeLabel.Text = "Create prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(160, 54);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(159, 33);
            placeNumberValue.TabIndex = 18;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Location = new Point(11, 62);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(132, 25);
            placeNumberLabel.TabIndex = 17;
            placeNumberLabel.Text = "Place number:";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(160, 93);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(159, 33);
            placeNameValue.TabIndex = 20;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Location = new Point(11, 101);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(113, 25);
            placeNameLabel.TabIndex = 19;
            placeNameLabel.Text = "Place name:";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(160, 132);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(159, 33);
            prizeAmountValue.TabIndex = 22;
            prizeAmountValue.Text = "0";
            // 
            // priceAmountLabel
            // 
            priceAmountLabel.AutoSize = true;
            priceAmountLabel.Location = new Point(11, 140);
            priceAmountLabel.Name = "priceAmountLabel";
            priceAmountLabel.Size = new Size(128, 25);
            priceAmountLabel.TabIndex = 21;
            priceAmountLabel.Text = "Price amount:";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(160, 210);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(159, 33);
            prizePercentageValue.TabIndex = 24;
            prizePercentageValue.Text = "0";
            // 
            // pricePercentageLabel
            // 
            pricePercentageLabel.AutoSize = true;
            pricePercentageLabel.Location = new Point(11, 218);
            pricePercentageLabel.Name = "pricePercentageLabel";
            pricePercentageLabel.Size = new Size(158, 25);
            pricePercentageLabel.TabIndex = 23;
            pricePercentageLabel.Text = "Prize percentage:";
            // 
            // createPrizeButton
            // 
            createPrizeButton.Location = new Point(116, 270);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(133, 32);
            createPrizeButton.TabIndex = 27;
            createPrizeButton.Text = "Create prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 319);
            Controls.Add(createPrizeButton);
            Controls.Add(prizePercentageValue);
            Controls.Add(pricePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(priceAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizeAmountValue;
        private Label priceAmountLabel;
        private TextBox prizePercentageValue;
        private Label pricePercentageLabel;
        private Button createPrizeButton;
    }
}