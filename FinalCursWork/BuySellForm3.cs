using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static FinalCursWork.Requests;

namespace FinalCursWork
{


    public partial class BuySellForm3 : Form
    {


        private readonly RequestBase _selectedRequest;
        private readonly List<RequestBase> _matchingRequests;
        private bool _isABuy;

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

        public BuySellForm3(RequestBase selectedRequest, List<RequestBase> matchingRequests, bool isABuy)
        {
            _selectedRequest = selectedRequest;
            _matchingRequests = matchingRequests;
            _isABuy = isABuy;

            InitializeComponent();
            InitializeMatchingRequestsList();
        }

        private void InitializeMatchingRequestsList()
        {
            richTextBoxMatchingRequests.Clear();

            foreach (var request in _matchingRequests.Select((req, index) => new { req, index }))
            {
                richTextBoxMatchingRequests.AppendText(
                    $"Заявка [{request.index + 1}]:\n" +
                    $"{FormatRequest(request.req)}\n" +
                    "-----------------------------------\n"
                );
            }

            nudMatchingRequestIndex.Minimum = _matchingRequests.Any() ? 1 : 0;
            nudMatchingRequestIndex.Maximum = _matchingRequests.Count;
            nudMatchingRequestIndex.Value = nudMatchingRequestIndex.Minimum;
        }

        private bool AreRequestsMatching(RequestBase request1, RequestBase request2, bool isABuy)
        {
            if (isABuy)
            {
                // Сравнение как SaleRequest
                if (request1 is SaleRequest sale1 && request2 is SaleRequest sale2)
                {
                    return sale1.Price == sale2.Price;
                }
            }
            else
            {
                // Сравнение как PurchaseRequest
                if (request1 is PurchaseRequest purchase1 && request2 is PurchaseRequest purchase2)
                {
                    return purchase1.PriceRange.Min == purchase2.PriceRange.Min &&
                           purchase1.PriceRange.Max == purchase2.PriceRange.Max;
                }
            }
            return false;
        }

        private string FormatRequest(RequestBase request)
        {
            return request.ToString();
        }

        private void ButtonConfirmSelection_Click(object sender, EventArgs e)
        {
            if (_matchingRequests.Count == 0 || nudMatchingRequestIndex.Value == 0)
            {
                MessageBox.Show("Выберите заявку для завершения сделки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedIndex = (int)nudMatchingRequestIndex.Value - 1;
            var selectedMatchingRequest = _matchingRequests[selectedIndex];

            // Удаление заявок из списков MainForm
            MainForm.PurchaseRequests.Remove(_selectedRequest as PurchaseRequest);
            MainForm.SaleRequests.Remove(_selectedRequest as SaleRequest);
            MainForm.PurchaseRequests.RemoveAll(req => AreRequestsMatching(req, selectedMatchingRequest, _isABuy));
            MainForm.SaleRequests.RemoveAll(req => AreRequestsMatching(req, selectedMatchingRequest, _isABuy));

            // Удаление заявок у клиентов
            var client = MainForm.Clients.FirstOrDefault(c => c.Requests.Contains(_selectedRequest));
            client?.Requests.Remove(_selectedRequest);

            var matchingClient = MainForm.Clients.FirstOrDefault(c => c.Requests.Any(req => AreRequestsMatching(req, selectedMatchingRequest, _isABuy)));
            matchingClient?.Requests.RemoveAll(req => AreRequestsMatching(req, selectedMatchingRequest, _isABuy));

            // Добавление записи о сделке
            if (selectedMatchingRequest is SaleRequest saleRequest)
            {
                decimal profit = saleRequest.Price * 0.02m;
                MainForm.Records.Add(new DealRecord
                {
                    Date = DateTime.Today,
                    Profit = profit
                });
            }

            MessageBox.Show("Сделка успешно завершена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


    }
}

