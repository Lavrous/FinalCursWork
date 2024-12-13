using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalCursWork
{
    partial class AddClient

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

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.TextBox txtRegNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblRegNumber = new Label();
            txtRegNumber = new TextBox();
            lblAddress = new Label();
            txtAddress = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(20, 20);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(100, 20);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "ФИО:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(230, 20);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(261, 27);
            txtFullName.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(20, 60);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(200, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Телефон (+7XXXXXXXXXX):";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(230, 60);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(261, 27);
            txtPhone.TabIndex = 3;
            // 
            // lblRegNumber
            // 
            lblRegNumber.Location = new Point(20, 100);
            lblRegNumber.Name = "lblRegNumber";
            lblRegNumber.Size = new Size(200, 20);
            lblRegNumber.TabIndex = 4;
            lblRegNumber.Text = "Рег. номер (5 цифр):";
            // 
            // txtRegNumber
            // 
            txtRegNumber.Location = new Point(230, 100);
            txtRegNumber.Name = "txtRegNumber";
            txtRegNumber.Size = new Size(261, 27);
            txtRegNumber.TabIndex = 5;
            // 
            // lblAddress
            // 
            lblAddress.Location = new Point(20, 140);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(100, 20);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Адрес:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(230, 137);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(261, 27);
            txtAddress.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(262, 212);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Сохранить";
            btnSave.Click += btnSave_Click;
            // 
            // AddClient
            // 
            ClientSize = new Size(595, 285);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblRegNumber);
            Controls.Add(txtRegNumber);
            Controls.Add(lblAddress);
            Controls.Add(txtAddress);
            Controls.Add(btnSave);
            Name = "AddClient";
            Text = "Добавление клиента";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}