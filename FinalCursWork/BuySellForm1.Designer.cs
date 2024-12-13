namespace FinalCursWork
{
    partial class BuySellForm1
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxClientRegNum;
        private ComboBox comboBoxRequestType;
        private Button buttonProceed;


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
            comboBoxClientRegNum = new ComboBox();
            comboBoxRequestType = new ComboBox();
            buttonProceed = new Button();
            lblRegNumber = new Label();
            lblRequestType = new Label();
            SuspendLayout();
            // 
            // comboBoxClientRegNum
            // 
            comboBoxClientRegNum.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClientRegNum.FormattingEnabled = true;
            comboBoxClientRegNum.Location = new Point(30, 69);
            comboBoxClientRegNum.Name = "comboBoxClientRegNum";
            comboBoxClientRegNum.Size = new Size(220, 28);
            comboBoxClientRegNum.TabIndex = 0;
            // 
            // comboBoxRequestType
            // 
            comboBoxRequestType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRequestType.FormattingEnabled = true;
            comboBoxRequestType.Location = new Point(30, 153);
            comboBoxRequestType.Name = "comboBoxRequestType";
            comboBoxRequestType.Size = new Size(220, 28);
            comboBoxRequestType.TabIndex = 1;
            // 
            // buttonProceed
            // 
            buttonProceed.Location = new Point(30, 226);
            buttonProceed.Name = "buttonProceed";
            buttonProceed.Size = new Size(220, 40);
            buttonProceed.TabIndex = 2;
            buttonProceed.Text = "Перейти к заявкам";
            buttonProceed.UseVisualStyleBackColor = true;
            buttonProceed.Click += buttonProceed_Click;
            // 
            // lblRegNumber
            // 
            lblRegNumber.AutoSize = true;
            lblRegNumber.Location = new Point(45, 29);
            lblRegNumber.Name = "lblRegNumber";
            lblRegNumber.Size = new Size(185, 20);
            lblRegNumber.TabIndex = 34;
            lblRegNumber.Text = "Регистрационный номер";
            // 
            // lblRequestType
            // 
            lblRequestType.AutoSize = true;
            lblRequestType.Location = new Point(91, 119);
            lblRequestType.Name = "lblRequestType";
            lblRequestType.Size = new Size(109, 20);
            lblRequestType.TabIndex = 35;
            lblRequestType.Text = "Тип операции";
            // 
            // BuySellForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 293);
            Controls.Add(lblRequestType);
            Controls.Add(lblRegNumber);
            Controls.Add(comboBoxClientRegNum);
            Controls.Add(comboBoxRequestType);
            Controls.Add(buttonProceed);
            Name = "BuySellForm1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Фильтр заявок";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label lblRegNumber;
        private Label lblRequestType;
    }
}