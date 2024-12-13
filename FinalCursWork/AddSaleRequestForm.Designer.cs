namespace FinalCursWork
{
    partial class AddSaleRequestForm
    {

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
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblRequestType;
        private System.Windows.Forms.ComboBox cbRequestType;
        private System.Windows.Forms.Label lblHouseType;
        private System.Windows.Forms.ComboBox cbHouseType;
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblAdditionalConditions;
        private System.Windows.Forms.TextBox tbAdditionalConditions;
        private System.Windows.Forms.Button btnCreateRequest;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.NumericUpDown nudFloor;
        private System.Windows.Forms.Label lblTotalArea;
        private System.Windows.Forms.NumericUpDown nudTotalArea;
        private System.Windows.Forms.Label lblLivingArea;
        private System.Windows.Forms.NumericUpDown nudLivingArea;
        private System.Windows.Forms.Label lblKitchenArea;
        private System.Windows.Forms.NumericUpDown nudKitchenArea;
        private System.Windows.Forms.Label lblFloors;
        private System.Windows.Forms.NumericUpDown nudFloors;
        private System.Windows.Forms.Label lblConstructionDate;
        private System.Windows.Forms.DateTimePicker dtpConstructionDate;
        private System.Windows.Forms.Label lblLastRepairDate;
        private System.Windows.Forms.DateTimePicker dtpLastRepairDate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.CheckBox cbHasElevator;
        private System.Windows.Forms.CheckBox cbHasGarbageChute;
        private System.Windows.Forms.CheckBox cbHasPhoneCable;

        private void InitializeComponent()
        {
            lblRequestType = new Label();
            cbRequestType = new ComboBox();
            lblHouseType = new Label();
            cbHouseType = new ComboBox();
            lblDistrict = new Label();
            cbDistrict = new ComboBox();
            cbClients = new ComboBox();
            lblMaterial = new Label();
            cbMaterial = new ComboBox();
            lblPrice = new Label();
            nudPrice = new NumericUpDown();
            lblAdditionalConditions = new Label();
            tbAdditionalConditions = new TextBox();
            btnCreateRequest = new Button();
            lblResult = new Label();
            lblFloor = new Label();
            nudFloor = new NumericUpDown();
            lblTotalArea = new Label();
            nudTotalArea = new NumericUpDown();
            lblLivingArea = new Label();
            nudLivingArea = new NumericUpDown();
            lblKitchenArea = new Label();
            nudKitchenArea = new NumericUpDown();
            lblFloors = new Label();
            nudFloors = new NumericUpDown();
            lblConstructionDate = new Label();
            dtpConstructionDate = new DateTimePicker();
            lblLastRepairDate = new Label();
            dtpLastRepairDate = new DateTimePicker();
            lblAddress = new Label();
            tbAddress = new TextBox();
            cbHasElevator = new CheckBox();
            cbHasGarbageChute = new CheckBox();
            cbHasPhoneCable = new CheckBox();
            lblRegNumber = new Label();
            cbIsSpecial = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTotalArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudLivingArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKitchenArea).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFloors).BeginInit();
            SuspendLayout();
            // 
            // lblRequestType
            // 
            lblRequestType.AutoSize = true;
            lblRequestType.Location = new Point(20, 20);
            lblRequestType.Name = "lblRequestType";
            lblRequestType.Size = new Size(86, 20);
            lblRequestType.TabIndex = 0;
            lblRequestType.Text = "Тип владения";
            // 
            // cbRequestType
            // 
            cbRequestType.Location = new Point(20, 50);
            cbRequestType.Name = "cbRequestType";
            cbRequestType.Size = new Size(232, 28);
            cbRequestType.TabIndex = 1;
            // 
            // lblHouseType
            // 
            lblHouseType.AutoSize = true;
            lblHouseType.Location = new Point(20, 90);
            lblHouseType.Name = "lblHouseType";
            lblHouseType.Size = new Size(75, 20);
            lblHouseType.TabIndex = 2;
            lblHouseType.Text = "Тип дома";
            // 
            // cbHouseType
            // 
            cbHouseType.Location = new Point(20, 120);
            cbHouseType.Name = "cbHouseType";
            cbHouseType.Size = new Size(200, 28);
            cbHouseType.TabIndex = 3;
            // 
            // lblDistrict
            // 
            lblDistrict.AutoSize = true;
            lblDistrict.Location = new Point(20, 160);
            lblDistrict.Name = "lblDistrict";
            lblDistrict.Size = new Size(52, 20);
            lblDistrict.TabIndex = 4;
            lblDistrict.Text = "Район";
            // 
            // cbDistrict
            // 
            cbDistrict.Location = new Point(20, 190);
            cbDistrict.Name = "cbDistrict";
            cbDistrict.Size = new Size(200, 28);
            cbDistrict.TabIndex = 5;
            // 
            // cbClients
            // 
            cbClients.Location = new Point(786, 50);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(155, 28);
            cbClients.TabIndex = 34;
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Location = new Point(20, 230);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(78, 20);
            lblMaterial.TabIndex = 6;
            lblMaterial.Text = "Материал";
            // 
            // cbMaterial
            // 
            cbMaterial.Location = new Point(20, 260);
            cbMaterial.Name = "cbMaterial";
            cbMaterial.Size = new Size(200, 28);
            cbMaterial.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 307);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(45, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Цена";
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(20, 330);
            nudPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(150, 27);
            nudPrice.TabIndex = 9;
            // 
            // lblAdditionalConditions
            // 
            lblAdditionalConditions.AutoSize = true;
            lblAdditionalConditions.Location = new Point(308, 20);
            lblAdditionalConditions.Name = "lblAdditionalConditions";
            lblAdditionalConditions.Size = new Size(190, 20);
            lblAdditionalConditions.TabIndex = 10;
            lblAdditionalConditions.Text = "Дополнительные условия";
            // 
            // tbAdditionalConditions
            // 
            tbAdditionalConditions.Location = new Point(300, 50);
            tbAdditionalConditions.Multiline = true;
            tbAdditionalConditions.Name = "tbAdditionalConditions";
            tbAdditionalConditions.Size = new Size(400, 100);
            tbAdditionalConditions.TabIndex = 11;
            // 
            // btnCreateRequest
            // 
            btnCreateRequest.Location = new Point(20, 535);
            btnCreateRequest.Name = "btnCreateRequest";
            btnCreateRequest.Size = new Size(150, 30);
            btnCreateRequest.TabIndex = 12;
            btnCreateRequest.Text = "Создать заявку";
            btnCreateRequest.Click += BtnCreateRequest_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(750, 20);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 13;
            // 
            // lblFloor
            // 
            lblFloor.Location = new Point(470, 181);
            lblFloor.Name = "lblFloor";
            lblFloor.Size = new Size(100, 23);
            lblFloor.TabIndex = 14;
            lblFloor.Text = "Этаж";
            // 
            // nudFloor
            // 
            nudFloor.Location = new Point(450, 207);
            nudFloor.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudFloor.Name = "nudFloor";
            nudFloor.Size = new Size(120, 27);
            nudFloor.TabIndex = 15;
            nudFloor.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTotalArea
            // 
            lblTotalArea.Location = new Point(300, 181);
            lblTotalArea.Name = "lblTotalArea";
            lblTotalArea.Size = new Size(139, 23);
            lblTotalArea.TabIndex = 16;
            lblTotalArea.Text = "Общая площадь";
            // 
            // nudTotalArea
            // 
            nudTotalArea.DecimalPlaces = 2;
            nudTotalArea.Location = new Point(300, 207);
            nudTotalArea.Maximum = new decimal(new int[] { 6000, 0, 0, 0 });
            nudTotalArea.Name = "nudTotalArea";
            nudTotalArea.Size = new Size(120, 27);
            nudTotalArea.TabIndex = 17;
            // 
            // lblLivingArea
            // 
            lblLivingArea.Location = new Point(300, 249);
            lblLivingArea.Name = "lblLivingArea";
            lblLivingArea.Size = new Size(139, 23);
            lblLivingArea.TabIndex = 18;
            lblLivingArea.Text = "Жилая площадь";
            // 
            // nudLivingArea
            // 
            nudLivingArea.DecimalPlaces = 2;
            nudLivingArea.Location = new Point(300, 275);
            nudLivingArea.Maximum = new decimal(new int[] { 6000, 0, 0, 0 });
            nudLivingArea.Name = "nudLivingArea";
            nudLivingArea.Size = new Size(120, 27);
            nudLivingArea.TabIndex = 19;
            // 
            // lblKitchenArea
            // 
            lblKitchenArea.Location = new Point(300, 330);
            lblKitchenArea.Name = "lblKitchenArea";
            lblKitchenArea.Size = new Size(120, 23);
            lblKitchenArea.TabIndex = 20;
            lblKitchenArea.Text = "Площадь кухни";
            // 
            // nudKitchenArea
            // 
            nudKitchenArea.DecimalPlaces = 2;
            nudKitchenArea.Location = new Point(300, 356);
            nudKitchenArea.Maximum = new decimal(new int[] { 6000, 0, 0, 0 });
            nudKitchenArea.Name = "nudKitchenArea";
            nudKitchenArea.Size = new Size(120, 27);
            nudKitchenArea.TabIndex = 21;
            // 
            // lblFloors
            // 
            lblFloors.Location = new Point(450, 249);
            lblFloors.Name = "lblFloors";
            lblFloors.Size = new Size(120, 23);
            lblFloors.TabIndex = 22;
            lblFloors.Text = "Этажей в доме";
            // 
            // nudFloors
            // 
            nudFloors.Location = new Point(450, 275);
            nudFloors.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudFloors.Name = "nudFloors";
            nudFloors.Size = new Size(120, 27);
            nudFloors.TabIndex = 23;
            nudFloors.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblConstructionDate
            // 
            lblConstructionDate.Location = new Point(300, 406);
            lblConstructionDate.Name = "lblConstructionDate";
            lblConstructionDate.Size = new Size(160, 23);
            lblConstructionDate.TabIndex = 24;
            lblConstructionDate.Text = "Дата постройки";
            // 
            // dtpConstructionDate
            // 
            dtpConstructionDate.Format = DateTimePickerFormat.Short;
            dtpConstructionDate.Location = new Point(298, 444);
            dtpConstructionDate.Name = "dtpConstructionDate";
            dtpConstructionDate.Size = new Size(200, 27);
            dtpConstructionDate.TabIndex = 25;
            // 
            // lblLastRepairDate
            // 
            lblLastRepairDate.Location = new Point(524, 406);
            lblLastRepairDate.Name = "lblLastRepairDate";
            lblLastRepairDate.Size = new Size(212, 23);
            lblLastRepairDate.TabIndex = 26;
            lblLastRepairDate.Text = "Дата последнего ремонта";
            // 
            // dtpLastRepairDate
            // 
            dtpLastRepairDate.Format = DateTimePickerFormat.Short;
            dtpLastRepairDate.Location = new Point(524, 444);
            dtpLastRepairDate.Name = "dtpLastRepairDate";
            dtpLastRepairDate.Size = new Size(200, 27);
            dtpLastRepairDate.TabIndex = 27;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(450, 330);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 23);
            lblAddress.TabIndex = 28;
            lblAddress.Text = "Адрес";
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(450, 356);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(200, 27);
            tbAddress.TabIndex = 29;
            // 
            // cbHasElevator
            // 
            cbHasElevator.Location = new Point(20, 385);
            cbHasElevator.Name = "cbHasElevator";
            cbHasElevator.Size = new Size(104, 24);
            cbHasElevator.TabIndex = 30;
            cbHasElevator.Text = "Есть лифт";
            // 
            // cbHasGarbageChute
            // 
            cbHasGarbageChute.Location = new Point(20, 415);
            cbHasGarbageChute.Name = "cbHasGarbageChute";
            cbHasGarbageChute.Size = new Size(190, 54);
            cbHasGarbageChute.TabIndex = 31;
            cbHasGarbageChute.Text = "Есть мусоропровод";
            // 
            // cbHasPhoneCable
            // 
            cbHasPhoneCable.Location = new Point(20, 475);
            cbHasPhoneCable.Name = "cbHasPhoneCable";
            cbHasPhoneCable.Size = new Size(200, 38);
            cbHasPhoneCable.TabIndex = 32;
            cbHasPhoneCable.Text = "Есть телефонная линия";
            // 
            // lblRegNumber
            // 
            lblRegNumber.AutoSize = true;
            lblRegNumber.Location = new Point(786, 20);
            lblRegNumber.Name = "lblRegNumber";
            lblRegNumber.Size = new Size(185, 20);
            lblRegNumber.TabIndex = 33;
            lblRegNumber.Text = "Регистрационный номер";
            // 
            // cbIsSpecial
            // 
            cbIsSpecial.Location = new Point(204, 539);
            cbIsSpecial.Name = "cbIsSpecial";
            cbIsSpecial.Size = new Size(235, 24);
            cbIsSpecial.TabIndex = 35;
            cbIsSpecial.Text = "Специальное предложение!";
            // 
            // AddSaleRequestForm
            // 
            ClientSize = new Size(1182, 596);
            Controls.Add(cbIsSpecial);
            Controls.Add(lblRegNumber);
            Controls.Add(lblRequestType);
            Controls.Add(cbRequestType);
            Controls.Add(lblHouseType);
            Controls.Add(cbHouseType);
            Controls.Add(lblDistrict);
            Controls.Add(cbDistrict);
            Controls.Add(lblMaterial);
            Controls.Add(cbMaterial);
            Controls.Add(lblPrice);
            Controls.Add(cbClients);
            Controls.Add(nudPrice);
            Controls.Add(lblAdditionalConditions);
            Controls.Add(tbAdditionalConditions);
            Controls.Add(btnCreateRequest);
            Controls.Add(lblResult);
            Controls.Add(lblFloor);
            Controls.Add(nudFloor);
            Controls.Add(lblTotalArea);
            Controls.Add(nudTotalArea);
            Controls.Add(lblLivingArea);
            Controls.Add(nudLivingArea);
            Controls.Add(lblKitchenArea);
            Controls.Add(nudKitchenArea);
            Controls.Add(lblFloors);
            Controls.Add(nudFloors);
            Controls.Add(lblConstructionDate);
            Controls.Add(dtpConstructionDate);
            Controls.Add(lblLastRepairDate);
            Controls.Add(dtpLastRepairDate);
            Controls.Add(lblAddress);
            Controls.Add(tbAddress);
            Controls.Add(cbHasElevator);
            Controls.Add(cbHasGarbageChute);
            Controls.Add(cbHasPhoneCable);
            Name = "AddSaleRequestForm";
            Text = "Создание заявки на продажу";
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTotalArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudLivingArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKitchenArea).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFloors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label lblRegNumber;
        private CheckBox cbIsSpecial;
    }

}