using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCursWork
{
    public partial class IssueReceiptForm : Form
    {
        private readonly List<ClientInfo> _clients;
        public IssueReceiptForm(List<ClientInfo> clients)
        {
            _clients = clients ?? throw new ArgumentNullException(nameof(clients));
            InitializeComponent();
            LoadClients();
        }

        private void LoadClients()
        {
            cbClients.DataSource = _clients;
            cbClients.DisplayMember = "RegistrationNumber"; // Отображение регистрационного номера
            cbClients.ValueMember = null; // Сохраняем объект клиента в SelectedItem
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            var selectedClient = cbClients.SelectedItem as ClientInfo;
            if (selectedClient == null)
            {
                MessageBox.Show("Не выбран клиент.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                $"ФИО: {selectedClient.FullName}\n" +
                $"Регистрационный номер: {selectedClient.RegistrationNumber}\n" +
                $"Взнос: {ClientInfo.Amount} руб.\n" +
                $"Время регистрации: {selectedClient.RegistrationTime}",
                "Квитанция",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
