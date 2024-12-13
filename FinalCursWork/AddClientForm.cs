using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalCursWork;
namespace FinalCursWork
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            this.Text = "Добавить клиента";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Width = 400;
            this.Height = 300;

            Label lblFullName = new Label { Text = "ФИО:", Top = 20, Left = 20, Width = 100 };
            TextBox txtFullName = new TextBox { Top = 20, Left = 130, Width = 200 };

            Label lblPhone = new Label { Text = "Телефон (+7XXXXXXXXXX):", Top = 60, Left = 20, Width = 200 };
            TextBox txtPhone = new TextBox { Top = 60, Left = 230, Width = 100 };

            Label lblRegNumber = new Label { Text = "Рег. номер (5 цифр):", Top = 100, Left = 20, Width = 200 };
            TextBox txtRegNumber = new TextBox { Top = 100, Left = 230, Width = 100 };

            Label lblAddress = new Label { Text = "Адрес:", Top = 140, Left = 20, Width = 100 };
            TextBox txtAddress = new TextBox { Top = 140, Left = 130, Width = 200 };

            Button BtnSave = new Button
            {
                Text = "Сохранить",
                Top = 200,
                Left = 130,
                Width = 100
            };


            this.Controls.Add(lblFullName);
            this.Controls.Add(txtFullName);
            this.Controls.Add(lblPhone);
            this.Controls.Add(txtPhone);
            this.Controls.Add(lblRegNumber);
            this.Controls.Add(txtRegNumber);
            this.Controls.Add(lblAddress);
            this.Controls.Add(txtAddress);
            this.Controls.Add(btnSave);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение данных из полей
                string fullName = txtFullName.Text;
                string phoneNumber = txtPhone.Text;
                string registrationNumber = txtRegNumber.Text;
                string address = txtAddress.Text;

                // Валидация данных
                if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phoneNumber) ||
                    string.IsNullOrWhiteSpace(registrationNumber) || string.IsNullOrWhiteSpace(address))
                {
                    MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isDuplicate_reg = MainForm.Clients.Any(client => client.RegistrationNumber == registrationNumber);
                if (isDuplicate_reg)
                {
                    MessageBox.Show("Клиент с таким регистрационным номером уже существует. Пожалуйста, введите другой номер.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool isDuplicate_phone = MainForm.Clients.Any(client => client.PhoneNumber == phoneNumber);
                if (isDuplicate_phone)
                {
                    MessageBox.Show("Клиент с таким телефонным номером уже существует. Пожалуйста, введите другой номер.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Создание нового клиента
                ClientInfo client = new ClientInfo
                {
                    FullName = fullName,
                    PhoneNumber = phoneNumber,
                    RegistrationNumber = registrationNumber,
                    Address = address,
                    RegistrationTime = DateTime.Now
                };

                // Сохранение клиента в общем списке
                MainForm.Clients.Add(client);

                // Уведомление об успешном сохранении
                MessageBox.Show("Клиент успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
