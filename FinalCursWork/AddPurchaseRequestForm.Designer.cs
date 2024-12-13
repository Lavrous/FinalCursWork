using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalCursWork
{
    partial class AddPurchaseRequestForm
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
        private System.Windows.Forms.ComboBox cbClients;
        private System.Windows.Forms.ComboBox cbRequestType;
        private System.Windows.Forms.Label lblHouseType;
        private System.Windows.Forms.ComboBox cbHouseType;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.Label lblMinPrice;
        private System.Windows.Forms.NumericUpDown nudMinPrice;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.NumericUpDown nudMaxPrice;
        private System.Windows.Forms.Label lblAdditionalConditions;
        private System.Windows.Forms.TextBox tbAdditionalConditions;
        private System.Windows.Forms.Button btnCreateRequest;
        private System.Windows.Forms.Label lblResult;

        private void InitializeComponent()
        {
            lblRequestType = new Label();
            cbRequestType = new ComboBox();
            lblHouseType = new Label();
            cbHouseType = new ComboBox();
            lblDistrict = new Label();
            cbDistrict = new ComboBox();
            lblMaterial = new Label();
            cbMaterial = new ComboBox();
            lblMinPrice = new Label();
            nudMinPrice = new NumericUpDown();
            lblMaxPrice = new Label();
            nudMaxPrice = new NumericUpDown();
            lblAdditionalConditions = new Label();
            tbAdditionalConditions = new TextBox();
            btnCreateRequest = new Button();
            lblResult = new Label();
            cbClients = new ComboBox();
            label1 = new Label();
            cbIsSpecial = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudMinPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxPrice).BeginInit();
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
            cbRequestType.Size = new Size(256, 28);
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
            // lblMinPrice
            // 
            lblMinPrice.AutoSize = true;
            lblMinPrice.Location = new Point(20, 300);
            lblMinPrice.Name = "lblMinPrice";
            lblMinPrice.Size = new Size(147, 20);
            lblMinPrice.TabIndex = 8;
            lblMinPrice.Text = "Минимальная цена";
            // 
            // nudMinPrice
            // 
            nudMinPrice.Location = new Point(20, 330);
            nudMinPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMinPrice.Name = "nudMinPrice";
            nudMinPrice.Size = new Size(150, 27);
            nudMinPrice.TabIndex = 9;
            // 
            // lblMaxPrice
            // 
            lblMaxPrice.AutoSize = true;
            lblMaxPrice.Location = new Point(200, 300);
            lblMaxPrice.Name = "lblMaxPrice";
            lblMaxPrice.Size = new Size(151, 20);
            lblMaxPrice.TabIndex = 10;
            lblMaxPrice.Text = "Максимальная цена";
            // 
            // nudMaxPrice
            // 
            nudMaxPrice.Location = new Point(200, 330);
            nudMaxPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMaxPrice.Name = "nudMaxPrice";
            nudMaxPrice.Size = new Size(150, 27);
            nudMaxPrice.TabIndex = 11;
            // 
            // lblAdditionalConditions
            // 
            lblAdditionalConditions.AutoSize = true;
            lblAdditionalConditions.Location = new Point(20, 370);
            lblAdditionalConditions.Name = "lblAdditionalConditions";
            lblAdditionalConditions.Size = new Size(190, 20);
            lblAdditionalConditions.TabIndex = 12;
            lblAdditionalConditions.Text = "Дополнительные условия";
            // 
            // tbAdditionalConditions
            // 
            tbAdditionalConditions.Location = new Point(20, 400);
            tbAdditionalConditions.Multiline = true;
            tbAdditionalConditions.Name = "tbAdditionalConditions";
            tbAdditionalConditions.Size = new Size(226, 100);
            tbAdditionalConditions.TabIndex = 13;
            // 
            // btnCreateRequest
            // 
            btnCreateRequest.Location = new Point(20, 520);
            btnCreateRequest.Name = "btnCreateRequest";
            btnCreateRequest.Size = new Size(150, 30);
            btnCreateRequest.TabIndex = 14;
            btnCreateRequest.Text = "Создать заявку";
            btnCreateRequest.Click += BtnCreateRequest_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(450, 20);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 15;
            // 
            // cbClients
            // 
            cbClients.Location = new Point(326, 50);
            cbClients.Name = "cbClients";
            cbClients.Size = new Size(155, 28);
            cbClients.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 20);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 16;
            label1.Text = "Регистрационный номер";
            // 
            // cbIsSpecial
            // 
            cbIsSpecial.Location = new Point(215, 524);
            cbIsSpecial.Name = "cbIsSpecial";
            cbIsSpecial.Size = new Size(235, 24);
            cbIsSpecial.TabIndex = 31;
            cbIsSpecial.Text = "Специальное предложение!";
            // 
            // AddPurchaseRequestForm
            // 
            ClientSize = new Size(600, 596);
            Controls.Add(cbIsSpecial);
            Controls.Add(label1);
            Controls.Add(cbClients);
            Controls.Add(lblRequestType);
            Controls.Add(cbRequestType);
            Controls.Add(lblHouseType);
            Controls.Add(cbHouseType);
            Controls.Add(lblDistrict);
            Controls.Add(cbDistrict);
            Controls.Add(lblMaterial);
            Controls.Add(cbMaterial);
            Controls.Add(lblMinPrice);
            Controls.Add(nudMinPrice);
            Controls.Add(lblMaxPrice);
            Controls.Add(nudMaxPrice);
            Controls.Add(lblAdditionalConditions);
            Controls.Add(tbAdditionalConditions);
            Controls.Add(btnCreateRequest);
            Controls.Add(lblResult);
            Name = "AddPurchaseRequestForm";
            Text = "Создание заявки на покупку";
            ((System.ComponentModel.ISupportInitialize)nudMinPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Label label1;
        private CheckBox cbIsSpecial;
    }
}