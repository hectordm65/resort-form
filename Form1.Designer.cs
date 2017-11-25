namespace Dominguez_Resort_Form
{
    partial class DominguezResort
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BedChoices = new System.Windows.Forms.GroupBox();
            this.KingButton = new System.Windows.Forms.RadioButton();
            this.QueenButton = new System.Windows.Forms.RadioButton();
            this.ViewBox = new System.Windows.Forms.GroupBox();
            this.AtriumViewButton = new System.Windows.Forms.RadioButton();
            this.StandViewButton = new System.Windows.Forms.RadioButton();
            this.RoomNumBar = new System.Windows.Forms.TrackBar();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RoomNumLabel = new System.Windows.Forms.Label();
            this.NumNightUpDown = new System.Windows.Forms.NumericUpDown();
            this.NumNightsLabel = new System.Windows.Forms.Label();
            this.ParkingCheckBox = new System.Windows.Forms.CheckBox();
            this.CardPayBox = new System.Windows.Forms.MaskedTextBox();
            this.SumBox = new System.Windows.Forms.GroupBox();
            this.GrandTotal = new System.Windows.Forms.Label();
            this.RoomCharge = new System.Windows.Forms.Label();
            this.ResortFeeTotal = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.ParkingTotal = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TaxTotal = new System.Windows.Forms.Label();
            this.DayFeesLabel = new System.Windows.Forms.Label();
            this.ParkingInfoLabel = new System.Windows.Forms.Label();
            this.RoomChargesLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AdultsNumLabel = new System.Windows.Forms.Label();
            this.NumChildrenLabel = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.AdultsUpDown = new System.Windows.Forms.NumericUpDown();
            this.ChildrenUpDown = new System.Windows.Forms.NumericUpDown();
            this.CardPicker = new System.Windows.Forms.ComboBox();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.PricingTip = new System.Windows.Forms.ToolTip(this.components);
            this.RoomTip = new System.Windows.Forms.ToolTip(this.components);
            this.NightTip = new System.Windows.Forms.ToolTip(this.components);
            this.AdultTip = new System.Windows.Forms.ToolTip(this.components);
            this.ParkingTip = new System.Windows.Forms.ToolTip(this.components);
            this.RoomTotTip = new System.Windows.Forms.ToolTip(this.components);
            this.TaxTip = new System.Windows.Forms.ToolTip(this.components);
            this.ParkingTotTip = new System.Windows.Forms.ToolTip(this.components);
            this.ResortFeeTip = new System.Windows.Forms.ToolTip(this.components);
            this.GrandTotTip = new System.Windows.Forms.ToolTip(this.components);
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CardLabel = new System.Windows.Forms.Label();
            this.SubmitTip = new System.Windows.Forms.ToolTip(this.components);
            this.CancelTip = new System.Windows.Forms.ToolTip(this.components);
            this.ExitTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BedChoices.SuspendLayout();
            this.ViewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomNumBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNightUpDown)).BeginInit();
            this.SumBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdultsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrenUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Location = new System.Drawing.Point(101, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(216, 23);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Dominguez Canal Resort Reservation Form";
            // 
            // BedChoices
            // 
            this.BedChoices.Controls.Add(this.KingButton);
            this.BedChoices.Controls.Add(this.QueenButton);
            this.BedChoices.Location = new System.Drawing.Point(25, 96);
            this.BedChoices.Name = "BedChoices";
            this.BedChoices.Size = new System.Drawing.Size(142, 81);
            this.BedChoices.TabIndex = 3;
            this.BedChoices.TabStop = false;
            this.BedChoices.Text = "Type of Bed";
            // 
            // KingButton
            // 
            this.KingButton.AutoSize = true;
            this.KingButton.Location = new System.Drawing.Point(26, 43);
            this.KingButton.Name = "KingButton";
            this.KingButton.Size = new System.Drawing.Size(77, 17);
            this.KingButton.TabIndex = 1;
            this.KingButton.Text = "1 King Bed";
            this.PricingTip.SetToolTip(this.KingButton, "A Standard King is 290 per night\r\nAn Atrium King is 350 per night");
            this.KingButton.UseVisualStyleBackColor = true;
            // 
            // QueenButton
            // 
            this.QueenButton.AutoSize = true;
            this.QueenButton.Checked = true;
            this.QueenButton.Location = new System.Drawing.Point(26, 20);
            this.QueenButton.Name = "QueenButton";
            this.QueenButton.Size = new System.Drawing.Size(93, 17);
            this.QueenButton.TabIndex = 0;
            this.QueenButton.TabStop = true;
            this.QueenButton.Text = "2 Queen Beds";
            this.PricingTip.SetToolTip(this.QueenButton, "A Standard Queen is 284 per night\r\nAn Atrium Queen is 325 per night");
            this.QueenButton.UseVisualStyleBackColor = true;
            // 
            // ViewBox
            // 
            this.ViewBox.Controls.Add(this.AtriumViewButton);
            this.ViewBox.Controls.Add(this.StandViewButton);
            this.ViewBox.Location = new System.Drawing.Point(237, 96);
            this.ViewBox.Name = "ViewBox";
            this.ViewBox.Size = new System.Drawing.Size(142, 81);
            this.ViewBox.TabIndex = 4;
            this.ViewBox.TabStop = false;
            this.ViewBox.Text = "Type of View";
            // 
            // AtriumViewButton
            // 
            this.AtriumViewButton.AutoSize = true;
            this.AtriumViewButton.Location = new System.Drawing.Point(26, 43);
            this.AtriumViewButton.Name = "AtriumViewButton";
            this.AtriumViewButton.Size = new System.Drawing.Size(54, 17);
            this.AtriumViewButton.TabIndex = 1;
            this.AtriumViewButton.Text = "Atrium";
            this.PricingTip.SetToolTip(this.AtriumViewButton, "An Atrium Queen is 325 per night\r\nAn Atrium King is 350 per night");
            this.AtriumViewButton.UseVisualStyleBackColor = true;
            // 
            // StandViewButton
            // 
            this.StandViewButton.AutoSize = true;
            this.StandViewButton.Checked = true;
            this.StandViewButton.Location = new System.Drawing.Point(26, 19);
            this.StandViewButton.Name = "StandViewButton";
            this.StandViewButton.Size = new System.Drawing.Size(68, 17);
            this.StandViewButton.TabIndex = 0;
            this.StandViewButton.TabStop = true;
            this.StandViewButton.Text = "Standard";
            this.PricingTip.SetToolTip(this.StandViewButton, "A Standard Queen is 284 per night\r\nA Standard King is 290 per night");
            this.StandViewButton.UseVisualStyleBackColor = true;
            // 
            // RoomNumBar
            // 
            this.RoomNumBar.LargeChange = 3;
            this.RoomNumBar.Location = new System.Drawing.Point(24, 222);
            this.RoomNumBar.Minimum = 1;
            this.RoomNumBar.Name = "RoomNumBar";
            this.RoomNumBar.Size = new System.Drawing.Size(143, 45);
            this.RoomNumBar.TabIndex = 6;
            this.RoomNumBar.Value = 1;
            this.RoomNumBar.Scroll += new System.EventHandler(this.RoomNumBar_Scroll);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(312, 624);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 22;
            this.ExitButton.Text = "E&xit";
            this.ExitTip.SetToolTip(this.ExitButton, "This button closes the application");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RoomNumLabel
            // 
            this.RoomNumLabel.Location = new System.Drawing.Point(35, 199);
            this.RoomNumLabel.Name = "RoomNumLabel";
            this.RoomNumLabel.Size = new System.Drawing.Size(115, 23);
            this.RoomNumLabel.TabIndex = 5;
            this.RoomNumLabel.Text = "Number of Rooms: 1";
            this.RoomTip.SetToolTip(this.RoomNumLabel, "You can reserve 1 to 10 rooms\r\nEach room can contain up to 6 people");
            // 
            // NumNightUpDown
            // 
            this.NumNightUpDown.Location = new System.Drawing.Point(266, 225);
            this.NumNightUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumNightUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumNightUpDown.Name = "NumNightUpDown";
            this.NumNightUpDown.Size = new System.Drawing.Size(51, 20);
            this.NumNightUpDown.TabIndex = 8;
            this.NumNightUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumNightsLabel
            // 
            this.NumNightsLabel.Location = new System.Drawing.Point(243, 199);
            this.NumNightsLabel.Name = "NumNightsLabel";
            this.NumNightsLabel.Size = new System.Drawing.Size(116, 23);
            this.NumNightsLabel.TabIndex = 7;
            this.NumNightsLabel.Text = "Number of Nights: ";
            this.RoomTip.SetToolTip(this.NumNightsLabel, "You are able to reserve from 1 to 7 nights");
            // 
            // ParkingCheckBox
            // 
            this.ParkingCheckBox.AutoSize = true;
            this.ParkingCheckBox.Location = new System.Drawing.Point(246, 265);
            this.ParkingCheckBox.Name = "ParkingCheckBox";
            this.ParkingCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ParkingCheckBox.Size = new System.Drawing.Size(104, 17);
            this.ParkingCheckBox.TabIndex = 11;
            this.ParkingCheckBox.Text = "Optional Parking";
            this.ParkingTip.SetToolTip(this.ParkingCheckBox, "Parking is 12.75 per day\r\nThere is no tax for parking");
            this.ParkingCheckBox.UseVisualStyleBackColor = true;
            // 
            // CardPayBox
            // 
            this.CardPayBox.Location = new System.Drawing.Point(230, 352);
            this.CardPayBox.Mask = "0000-0000-0000-0000";
            this.CardPayBox.Name = "CardPayBox";
            this.CardPayBox.Size = new System.Drawing.Size(113, 20);
            this.CardPayBox.TabIndex = 16;
            // 
            // SumBox
            // 
            this.SumBox.Controls.Add(this.GrandTotal);
            this.SumBox.Controls.Add(this.RoomCharge);
            this.SumBox.Controls.Add(this.ResortFeeTotal);
            this.SumBox.Controls.Add(this.TotalCostLabel);
            this.SumBox.Controls.Add(this.ParkingTotal);
            this.SumBox.Controls.Add(this.TaxLabel);
            this.SumBox.Controls.Add(this.TaxTotal);
            this.SumBox.Controls.Add(this.DayFeesLabel);
            this.SumBox.Controls.Add(this.ParkingInfoLabel);
            this.SumBox.Controls.Add(this.RoomChargesLabel);
            this.SumBox.Location = new System.Drawing.Point(51, 417);
            this.SumBox.Name = "SumBox";
            this.SumBox.Size = new System.Drawing.Size(282, 193);
            this.SumBox.TabIndex = 19;
            this.SumBox.TabStop = false;
            this.SumBox.Text = "Summary";
            // 
            // GrandTotal
            // 
            this.GrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrandTotal.Location = new System.Drawing.Point(153, 136);
            this.GrandTotal.Name = "GrandTotal";
            this.GrandTotal.Size = new System.Drawing.Size(100, 15);
            this.GrandTotal.TabIndex = 9;
            this.GrandTotal.Text = "$0.00";
            this.GrandTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // RoomCharge
            // 
            this.RoomCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RoomCharge.Location = new System.Drawing.Point(153, 22);
            this.RoomCharge.Name = "RoomCharge";
            this.RoomCharge.Size = new System.Drawing.Size(100, 15);
            this.RoomCharge.TabIndex = 1;
            this.RoomCharge.Text = "$0.00";
            this.RoomCharge.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ResortFeeTotal
            // 
            this.ResortFeeTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResortFeeTotal.Location = new System.Drawing.Point(153, 107);
            this.ResortFeeTotal.Name = "ResortFeeTotal";
            this.ResortFeeTotal.Size = new System.Drawing.Size(100, 15);
            this.ResortFeeTotal.TabIndex = 7;
            this.ResortFeeTotal.Text = "$0.00";
            this.ResortFeeTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Location = new System.Drawing.Point(37, 138);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(69, 13);
            this.TotalCostLabel.TabIndex = 8;
            this.TotalCostLabel.Text = "Grand Total: ";
            this.GrandTotTip.SetToolTip(this.TotalCostLabel, "The grand total due is room charges + tax + parking fees + resort fees");
            // 
            // ParkingTotal
            // 
            this.ParkingTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ParkingTotal.Location = new System.Drawing.Point(153, 77);
            this.ParkingTotal.Name = "ParkingTotal";
            this.ParkingTotal.Size = new System.Drawing.Size(100, 15);
            this.ParkingTotal.TabIndex = 5;
            this.ParkingTotal.Text = "$0.00";
            this.ParkingTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(37, 49);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(58, 13);
            this.TaxLabel.TabIndex = 2;
            this.TaxLabel.Text = "Tax Total: ";
            this.TaxTip.SetToolTip(this.TaxLabel, "Tax is 15% of your total room charge");
            // 
            // TaxTotal
            // 
            this.TaxTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TaxTotal.Location = new System.Drawing.Point(153, 49);
            this.TaxTotal.Name = "TaxTotal";
            this.TaxTotal.Size = new System.Drawing.Size(100, 15);
            this.TaxTotal.TabIndex = 3;
            this.TaxTotal.Text = "$0.00";
            this.TaxTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DayFeesLabel
            // 
            this.DayFeesLabel.AutoSize = true;
            this.DayFeesLabel.Location = new System.Drawing.Point(37, 107);
            this.DayFeesLabel.Name = "DayFeesLabel";
            this.DayFeesLabel.Size = new System.Drawing.Size(92, 13);
            this.DayFeesLabel.TabIndex = 6;
            this.DayFeesLabel.Text = "Resort Fee Total: ";
            this.ResortFeeTip.SetToolTip(this.DayFeesLabel, "The resort fee is 15 dollars per day per room");
            // 
            // ParkingInfoLabel
            // 
            this.ParkingInfoLabel.AutoSize = true;
            this.ParkingInfoLabel.Location = new System.Drawing.Point(37, 77);
            this.ParkingInfoLabel.Name = "ParkingInfoLabel";
            this.ParkingInfoLabel.Size = new System.Drawing.Size(113, 13);
            this.ParkingInfoLabel.TabIndex = 4;
            this.ParkingInfoLabel.Text = "Parking Charge Total: ";
            this.ParkingTotTip.SetToolTip(this.ParkingInfoLabel, "The parking total charge is 12.75 per night");
            // 
            // RoomChargesLabel
            // 
            this.RoomChargesLabel.AutoSize = true;
            this.RoomChargesLabel.Location = new System.Drawing.Point(37, 22);
            this.RoomChargesLabel.Name = "RoomChargesLabel";
            this.RoomChargesLabel.Size = new System.Drawing.Size(110, 13);
            this.RoomChargesLabel.TabIndex = 0;
            this.RoomChargesLabel.Text = "Room Charges Total: ";
            this.RoomTotTip.SetToolTip(this.RoomChargesLabel, "The total room cost is the type of room price times the amount of rooms you reser" +
        "ved");
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(174, 624);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "&Cancel";
            this.CancelTip.SetToolTip(this.CancelButton, "This button cancels the order and starts you from scratch");
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AdultsNumLabel
            // 
            this.AdultsNumLabel.Location = new System.Drawing.Point(35, 266);
            this.AdultsNumLabel.Name = "AdultsNumLabel";
            this.AdultsNumLabel.Size = new System.Drawing.Size(115, 23);
            this.AdultsNumLabel.TabIndex = 9;
            this.AdultsNumLabel.Text = "Number of Adults:";
            this.AdultTip.SetToolTip(this.AdultsNumLabel, "Each room is required to have at least 1 adult");
            // 
            // NumChildrenLabel
            // 
            this.NumChildrenLabel.Location = new System.Drawing.Point(35, 325);
            this.NumChildrenLabel.Name = "NumChildrenLabel";
            this.NumChildrenLabel.Size = new System.Drawing.Size(115, 23);
            this.NumChildrenLabel.TabIndex = 12;
            this.NumChildrenLabel.Text = "Number of Children:";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(19, 624);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 20;
            this.AcceptButton.Text = "&Submit";
            this.SubmitTip.SetToolTip(this.AcceptButton, "This button enters all of your information and informs you of your total cost");
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // AdultsUpDown
            // 
            this.AdultsUpDown.Location = new System.Drawing.Point(63, 292);
            this.AdultsUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.AdultsUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AdultsUpDown.Name = "AdultsUpDown";
            this.AdultsUpDown.Size = new System.Drawing.Size(51, 20);
            this.AdultsUpDown.TabIndex = 10;
            this.AdultsUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AdultsUpDown.ValueChanged += new System.EventHandler(this.AdultsUpDown_ValueChanged);
            // 
            // ChildrenUpDown
            // 
            this.ChildrenUpDown.Location = new System.Drawing.Point(63, 351);
            this.ChildrenUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ChildrenUpDown.Name = "ChildrenUpDown";
            this.ChildrenUpDown.Size = new System.Drawing.Size(51, 20);
            this.ChildrenUpDown.TabIndex = 13;
            this.ChildrenUpDown.ValueChanged += new System.EventHandler(this.ChildrenUpDown_ValueChanged);
            // 
            // CardPicker
            // 
            this.CardPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CardPicker.FormattingEnabled = true;
            this.CardPicker.Items.AddRange(new object[] {
            "American Express",
            "Visa",
            "Mastercard",
            "Discover"});
            this.CardPicker.Location = new System.Drawing.Point(230, 321);
            this.CardPicker.Name = "CardPicker";
            this.CardPicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CardPicker.Size = new System.Drawing.Size(113, 21);
            this.CardPicker.TabIndex = 15;
            this.CardPicker.SelectedIndexChanged += new System.EventHandler(this.CardPicker_SelectedIndexChanged);
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.MonthComboBox.Location = new System.Drawing.Point(230, 378);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(35, 21);
            this.MonthComboBox.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.comboBox2.Location = new System.Drawing.Point(283, 378);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(60, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(168, 44);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(190, 20);
            this.NameBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(61, 47);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(101, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Reservation Name: ";
            // 
            // CardLabel
            // 
            this.CardLabel.AutoSize = true;
            this.CardLabel.Location = new System.Drawing.Point(241, 299);
            this.CardLabel.Name = "CardLabel";
            this.CardLabel.Size = new System.Drawing.Size(89, 13);
            this.CardLabel.TabIndex = 14;
            this.CardLabel.Text = "Card information: ";
            // 
            // DominguezResort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 660);
            this.Controls.Add(this.CardLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.CardPicker);
            this.Controls.Add(this.ChildrenUpDown);
            this.Controls.Add(this.AdultsUpDown);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.NumChildrenLabel);
            this.Controls.Add(this.AdultsNumLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SumBox);
            this.Controls.Add(this.CardPayBox);
            this.Controls.Add(this.ParkingCheckBox);
            this.Controls.Add(this.NumNightsLabel);
            this.Controls.Add(this.NumNightUpDown);
            this.Controls.Add(this.RoomNumLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RoomNumBar);
            this.Controls.Add(this.ViewBox);
            this.Controls.Add(this.BedChoices);
            this.Controls.Add(this.TitleLabel);
            this.Name = "DominguezResort";
            this.Text = "Dominguez Resort";
            this.BedChoices.ResumeLayout(false);
            this.BedChoices.PerformLayout();
            this.ViewBox.ResumeLayout(false);
            this.ViewBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoomNumBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumNightUpDown)).EndInit();
            this.SumBox.ResumeLayout(false);
            this.SumBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdultsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChildrenUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox BedChoices;
        private System.Windows.Forms.RadioButton KingButton;
        private System.Windows.Forms.RadioButton QueenButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox ViewBox;
        private System.Windows.Forms.RadioButton AtriumViewButton;
        private System.Windows.Forms.RadioButton StandViewButton;
        private System.Windows.Forms.TrackBar RoomNumBar;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label RoomNumLabel;
        private System.Windows.Forms.NumericUpDown NumNightUpDown;
        private System.Windows.Forms.Label NumNightsLabel;
        private System.Windows.Forms.CheckBox ParkingCheckBox;
        private System.Windows.Forms.MaskedTextBox CardPayBox;
        private System.Windows.Forms.GroupBox SumBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label RoomChargesLabel;
        private System.Windows.Forms.Label DayFeesLabel;
        private System.Windows.Forms.Label ParkingInfoLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label AdultsNumLabel;
        private System.Windows.Forms.Label NumChildrenLabel;
        private System.Windows.Forms.Label RoomCharge;
        private System.Windows.Forms.Label GrandTotal;
        private System.Windows.Forms.Label ResortFeeTotal;
        private System.Windows.Forms.Label ParkingTotal;
        private System.Windows.Forms.Label TaxTotal;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.NumericUpDown AdultsUpDown;
        private System.Windows.Forms.NumericUpDown ChildrenUpDown;
        private System.Windows.Forms.ComboBox CardPicker;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolTip PricingTip;
        private System.Windows.Forms.ToolTip RoomTip;
        private System.Windows.Forms.ToolTip ParkingTip;
        private System.Windows.Forms.ToolTip AdultTip;
        private System.Windows.Forms.ToolTip NightTip;
        private System.Windows.Forms.ToolTip TaxTip;
        private System.Windows.Forms.ToolTip ResortFeeTip;
        private System.Windows.Forms.ToolTip ParkingTotTip;
        private System.Windows.Forms.ToolTip RoomTotTip;
        private System.Windows.Forms.ToolTip GrandTotTip;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ToolTip ExitTip;
        private System.Windows.Forms.ToolTip CancelTip;
        private System.Windows.Forms.ToolTip SubmitTip;
        private System.Windows.Forms.Label CardLabel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

