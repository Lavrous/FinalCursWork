namespace FinalCursWork
{
    partial class IssueReceiptForm
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
            cbClients = new ComboBox();
            lblReg = new Label();
            btnIssueReceipt = new Button();
            SuspendLayout();
            // 
            // cmbClients
            // 
            cbClients.Location = new Point(51, 107);
            cbClients.Name = "cmbClients";
            cbClients.Size = new Size(155, 28);
            cbClients.TabIndex = 1;
            // 
            // lblReg
            // 
            lblReg.AutoSize = true;
            lblReg.Location = new Point(39, 70);
            lblReg.Name = "lblReg";
            lblReg.Size = new Size(185, 20);
            lblReg.TabIndex = 2;
            lblReg.Text = "Регистрационный номер";
            // 
            // btnIssueReceipt
            // 
            btnIssueReceipt.Location = new Point(78, 172);
            btnIssueReceipt.Name = "btnIssueReceipt";
            btnIssueReceipt.Size = new Size(100, 30);
            btnIssueReceipt.TabIndex = 3;
            btnIssueReceipt.Text = "Сохранить";
            btnIssueReceipt.Click += btnIssue_Click;
            // 
            // IssueReceiptForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 263);
            Controls.Add(btnIssueReceipt);
            Controls.Add(lblReg);
            Controls.Add(cbClients);
            Name = "Выдать квитанцию";
            Text = "IssueReceiptForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbClients;
        private Label lblReg;
        private Button btnIssueReceipt;
    }
}