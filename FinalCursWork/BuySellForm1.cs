using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalCursWork.Requests;

namespace FinalCursWork
{
    public partial class BuySellForm1 : Form
    {
        private readonly List<ClientInfo> _clients;
        private readonly List<PurchaseRequest> _purchaseRequests;
        private readonly List<SaleRequest> _saleRequests;

        public BuySellForm1(List<ClientInfo> clients, List<PurchaseRequest> purchaseRequests, List<SaleRequest> saleRequests)
        {
            InitializeComponent();
            _clients = clients;
            _purchaseRequests = purchaseRequests;
            _saleRequests = saleRequests;

            // Инициализация данных в ComboBox'ах
            comboBoxClientRegNum.Items.AddRange(_clients.Select(c => c.RegistrationNumber.ToString()).ToArray());
            comboBoxRequestType.Items.AddRange(new[] { "Купля", "Продажа" });
        }

        private void buttonProceed_Click(object sender, EventArgs e)
        {
            if (comboBoxClientRegNum.SelectedItem == null || comboBoxRequestType.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите клиента и тип заявки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Получение выбранного клиента
            var selectedRegNum = comboBoxClientRegNum.SelectedItem.ToString();
            var selectedClient = _clients.FirstOrDefault(c => c.RegistrationNumber.ToString() == selectedRegNum);

            if (selectedClient == null)
            {
                MessageBox.Show("Клиент не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Определение типа заявок
            var requestType = comboBoxRequestType.SelectedItem.ToString();
            bool isABuy = requestType == "Купля";

            List<RequestBase> filteredRequests; // Основной список заявок клиента
            List<PurchaseRequest> filteredPurchaseRequests; // Список заявок покупки, не связанных с клиентом
            List<SaleRequest> filteredSaleRequests; // Список заявок продажи, не связанных с клиентом

            if (isABuy)
            {
                // Фильтрация заявок покупки клиента
                filteredRequests = _purchaseRequests
                    .Where(pr => selectedClient.Requests.Contains(pr))
                    .Cast<RequestBase>()
                    .ToList();

                // Список заявок продажи, не принадлежащих клиенту
                filteredSaleRequests = _saleRequests
                    .Where(sr => !selectedClient.Requests.Contains(sr))
                    .Select(sr => new SaleRequest(sr.OwnType, sr.HouseType, sr.District, sr.Material, sr.Price, sr.Floor, sr.TotalArea, sr.LivingArea, sr.KitchenArea, sr.Floors,
                        sr.ConstructionDate, sr.LastRepairDate, sr.Address, sr.HasElevator, sr.HasGarbageChute, sr.HasPhoneCable, sr.AdditionalConditions, sr.IsSpecial))
                    .ToList();

                // Локальный список заявок покупки остаётся пустым
                filteredPurchaseRequests = new List<PurchaseRequest>();
            }
            else
            {
                // Фильтрация заявок продажи клиента
                filteredRequests = _saleRequests
                    .Where(sr => selectedClient.Requests.Contains(sr))
                    .Cast<RequestBase>()
                    .ToList();

                // Список заявок покупки, не принадлежащих клиенту
                filteredPurchaseRequests = _purchaseRequests
                    .Where(pr => !selectedClient.Requests.Contains(pr))
                    .Select(pr => new PurchaseRequest(pr.OwnType, pr.HouseType, pr.District, pr.Material, pr.PriceRange, pr.AdditionalConditions, pr.IsSpecial))
                    .ToList();

                // Локальный список заявок продажи остаётся пустым
                filteredSaleRequests = new List<SaleRequest>();
            }

            if (!filteredRequests.Any())
            {
                MessageBox.Show("Для данного клиента нет заявок выбранного типа.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Открытие формы для работы с заявками
            using (var requestsForm = new BuySellForm2(filteredRequests, filteredPurchaseRequests, filteredSaleRequests, isABuy))
            {
                requestsForm.ShowDialog();
            }
        }


    }
}
