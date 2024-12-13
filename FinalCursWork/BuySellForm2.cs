
using FinalCursWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static FinalCursWork.Requests;

namespace FinalCursWork
{
    public partial class BuySellForm2 : Form
    {
        private readonly List<RequestBase> _filteredRequests;
        private readonly List<PurchaseRequest> _purchaseRequests;
        private readonly List<SaleRequest> _saleRequests;
        private readonly bool _isABuy;

        private static string GetEnumDisplayName<T>(T value) where T : Enum
        {
            switch (value)
            {
                case OwnType.Ownership: return "Собственничество";
                case OwnType.Rent: return "Аренда";
                case HouseType.PrivateHouse: return "Частный дом";
                case HouseType.OneRoomApartment: return "1-комнатная квартира";
                case HouseType.TwoRoomApartment: return "2-комнатная квартира";
                case HouseType.ThreeRoomApartment: return "3-комнатная квартира";
                case HouseType.FourPlusApartment: return "4+-комнатная квартира";
                case BuildingMaterial.Panel: return "Панель";
                case BuildingMaterial.Wood: return "Дерево";
                case BuildingMaterial.Brick: return "Кирпич";
                case District.South: return "Южный";
                case District.Central: return "Центральный";
                case District.West: return "Западный";
                case District.East: return "Восточный";
                case District.North: return "Северный";
                case District.Suburbs: return "Пригород";
                default: return value.ToString();
            }
        }

        public BuySellForm2(List<RequestBase> filteredRequests, List<PurchaseRequest> purchaseRequests, List<SaleRequest> saleRequests, bool isABuy)
        {
            _filteredRequests = filteredRequests;
            _purchaseRequests = purchaseRequests;
            _saleRequests = saleRequests;
            _isABuy = isABuy;

            InitializeComponent();
            InitializeRequestsList();
        }

        private void InitializeRequestsList()
        {
            richTextBoxRequests.Clear(); // Очистим список перед добавлением новых элементов.

            foreach (var request in _filteredRequests.Select((req, index) => new { req, index }))
            {
                richTextBoxRequests.AppendText(
                    $"Заявка [{request.index + 1}]:\n" + // Индексация начинается с 1
                    $"{FormatRequest(request.req)}\n" +
                    "-----------------------------------\n"
                );
            }

            // Установить максимальное значение для NumericUpDown
            nudRequestIndex.Minimum = _filteredRequests.Any() ? 1 : 0; // Если список пуст, минимальное значение - 0.
            nudRequestIndex.Maximum = _filteredRequests.Count;
            nudRequestIndex.Value = nudRequestIndex.Minimum; // Сброс значения на минимальное.
        }


        private string FormatRequest(RequestBase request)
        {
            return request.ToString();
        }


        private void buttonSelectRequest_Click(object sender, EventArgs e)
        {
            if (_filteredRequests.Count == 0)
            {
                MessageBox.Show("Нет доступных заявок для выбора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedIndex = (int)nudRequestIndex.Value - 1; // Индексация в списке начинается с 0.
            var selectedRequest = _filteredRequests[selectedIndex];
            ProcessSelectedRequest(selectedRequest);
        }

        private void ProcessSelectedRequest(RequestBase selectedRequest)
        {
            List<RequestBase> matchingRequests;

            if (_isABuy && selectedRequest is PurchaseRequest purchaseRequest)
            {
                matchingRequests = FindMatchingSales(purchaseRequest).Cast<RequestBase>().ToList();
            }
            else if (!_isABuy && selectedRequest is SaleRequest saleRequest)
            {
                matchingRequests = FindMatchingPurchases(saleRequest).Cast<RequestBase>().ToList();
            }
            else
            {
                MessageBox.Show("Некорректная заявка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (matchingRequests.Any())
            {

                this.Hide();
                using (var form3 = new BuySellForm3(selectedRequest, matchingRequests, _isABuy))
                {
                    form3.ShowDialog();
                }

                if (selectedRequest is SaleRequest saleRequest)
                {
                    decimal profit = saleRequest.Price * 0.02m;
                    MainForm.Records.Add(new DealRecord
                    {
                        Date = DateTime.Today,
                        Profit = profit
                    });
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Нет подходящих заявок для завершения сделки.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private List<SaleRequest> FindMatchingSales(PurchaseRequest purchaseRequest)
        {
            return _saleRequests.Where(sale =>
                sale.District == purchaseRequest.District &&
                sale.HouseType == purchaseRequest.HouseType &&
                sale.Material == purchaseRequest.Material &&
                sale.OwnType == purchaseRequest.OwnType &&
                purchaseRequest.PriceRange.Contains(sale.Price)
            ).ToList();
        }

        private List<PurchaseRequest> FindMatchingPurchases(SaleRequest saleRequest)
        {
            return _purchaseRequests.Where(purchase =>
                purchase.District == saleRequest.District &&
                purchase.HouseType == saleRequest.HouseType &&
                purchase.Material == saleRequest.Material &&
                purchase.OwnType == saleRequest.OwnType &&
                purchase.PriceRange.Contains(saleRequest.Price)
            ).ToList();
        }
    }
}

