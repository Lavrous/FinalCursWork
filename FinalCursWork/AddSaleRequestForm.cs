using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalCursWork.Requests;

namespace FinalCursWork
{
    public partial class AddSaleRequestForm : Form
    {
        private readonly List<ClientInfo> _clients;

        public AddSaleRequestForm(List<ClientInfo> clients)
        {
            _clients = clients ?? throw new ArgumentNullException(nameof(clients));
            InitializeComponent();
            InitializeControls();
            LoadClients();
        }

        private static object[] GetEnumValuesWithDisplay<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(e => new { Text = GetEnumDisplayName(e), Value = e })
                .ToArray();
        }

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

        private void LoadClients()
        {
            cbClients.DataSource = _clients;
            cbClients.DisplayMember = "RegistrationNumber"; // Отображение регистрационного номера
            cbClients.ValueMember = null; // Сохраняем объект клиента в SelectedItem
        }
        private void InitializeControls()
        {
            this.Text = "Создание заявки на продажу";

            // Привязка перечислений к ComboBox
            cbRequestType.DataSource = GetEnumValuesWithDisplay<OwnType>();
            cbRequestType.DisplayMember = "Text";
            cbRequestType.ValueMember = "Value";

            cbHouseType.DataSource = GetEnumValuesWithDisplay<HouseType>();
            cbHouseType.DisplayMember = "Text";
            cbHouseType.ValueMember = "Value";

            cbMaterial.DataSource = GetEnumValuesWithDisplay<BuildingMaterial>();
            cbMaterial.DisplayMember = "Text";
            cbMaterial.ValueMember = "Value";

            cbDistrict.DataSource = GetEnumValuesWithDisplay<District>();
            cbDistrict.DisplayMember = "Text";
            cbDistrict.ValueMember = "Value";


            // Установка стандартных значений
            cbRequestType.SelectedIndex = 0;
            cbHouseType.SelectedIndex = 0;
            cbDistrict.SelectedIndex = 0;
            cbMaterial.SelectedIndex = 0;
        }

        private void BtnCreateRequest_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedClient = cbClients.SelectedItem as ClientInfo;
                if (selectedClient == null)
                {
                    MessageBox.Show("Не выбран клиент.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Считывание данных из формы
                var selectedRequestType = (OwnType)cbRequestType.SelectedValue;
                var selectedHouseType = (HouseType)cbHouseType.SelectedValue;
                var selectedDistrict = (District)cbDistrict.SelectedValue;
                var selectedMaterial = (BuildingMaterial)cbMaterial.SelectedValue;

                var price = nudPrice.Value;
                var floor = (int)nudFloor.Value;
                var totalArea = (double)nudTotalArea.Value;
                var livingArea = (double)nudLivingArea.Value;
                var kitchenArea = (double)nudKitchenArea.Value;
                var floors = (int)nudFloors.Value;

                var constructionDate = dtpConstructionDate.Value;
                var lastRepairDate = dtpLastRepairDate.Value;

                var address = tbAddress.Text;
                var hasElevator = cbHasElevator.Checked;
                var hasGarbageChute = cbHasGarbageChute.Checked;
                var hasPhoneCable = cbHasPhoneCable.Checked;

                bool isSpecial = cbIsSpecial.Checked;

                var saleRequest = new Requests.SaleRequest(
                    selectedRequestType,
                    selectedHouseType,
                    selectedDistrict,
                    selectedMaterial,
                    price,
                    floor,
                    totalArea,
                    livingArea,
                    kitchenArea,
                    floors,
                    constructionDate,
                    lastRepairDate,
                    address,
                    hasElevator,
                    hasGarbageChute,
                    hasPhoneCable,
                    tbAdditionalConditions.Text,
                    isSpecial
                );

                if (isSpecial)
                {
                    MainForm.SaleRequests.Insert(0, saleRequest); // В начало
                    selectedClient.Requests.Insert(0, saleRequest); // В начало списка клиента
                }
                else
                {
                    MainForm.SaleRequests.Add(saleRequest); // В конец
                    selectedClient.Requests.Add(saleRequest); // В конец списка клиента
                }
                MessageBox.Show($"Заявка успешно добавлена клиенту: {selectedClient.FullName}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
