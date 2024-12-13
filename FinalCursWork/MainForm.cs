using System.Net;

using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using FinalCursWork;
using static FinalCursWork.Requests;
using System.Net.Sockets;

namespace FinalCursWork
{
    public partial class MainForm : Form
    {

        private const string FilePath = "DealRecords.txt";
        private const string ClientsFilePath = "Clients.txt";

        public MainForm()
        {
            InitializeComponent();
            LoadDealRecords();
            LoadClients();
            this.FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDealRecords(); // ���������� ������ ��� ��������
            SaveClients();
        }

        private void SaveDealRecords()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (var record in Records)
                    {
                        // ��������� ������ ������ � ������� "����|�������"
                        writer.WriteLine($"{record.Date:yyyy-MM-dd}|{record.Profit}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ���������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDealRecords()
        {
            try
            {
                if (!File.Exists(FilePath))
                    return; // ���� ����� ���, ������ �� ���������

                using (StreamReader reader = new StreamReader(FilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // ������ ������ � ��������� �� ����������� "|"
                        var parts = line.Split('|');
                        if (parts.Length == 2 &&
                            DateTime.TryParse(parts[0], out DateTime date) &&
                            decimal.TryParse(parts[1], out decimal profit))
                        {
                            Records.Add(new DealRecord { Date = date, Profit = profit });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ �������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveClients()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(ClientsFilePath))
                {
                    foreach (var client in Clients)
                    {
                        // ��������� ���� ������� ����� ����������� "|"
                        writer.WriteLine($"{client.FullName}|{client.PhoneNumber}|{client.Address}|{client.RegistrationNumber}|{client.RegistrationTime:yyyy-MM-dd HH:mm:ss}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ���������� ������ ��������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadClients()
        {
            try
            {
                if (!File.Exists(ClientsFilePath))
                    return; // ���� ���� �� ����������, ������ �� ���������

                using (StreamReader reader = new StreamReader(ClientsFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // ������ ������ � ��������� �� �����
                        var parts = line.Split('|');
                        if (parts.Length == 5 &&
                            DateTime.TryParse(parts[4], out DateTime registrationTime))
                        {
                            var client = new ClientInfo
                            {
                                FullName = parts[0],
                                PhoneNumber = parts[1],
                                Address = parts[2],
                                RegistrationNumber = parts[3],
                                RegistrationTime = registrationTime
                            };
                            Clients.Add(client);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ �������� ������ ��������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "����������� �����";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public static List<ClientInfo> Clients { get; set; } = new List<ClientInfo>();
        public static List<PurchaseRequest> PurchaseRequests { get; set; } = new List<PurchaseRequest>();
        public static List<SaleRequest> SaleRequests { get; set; } = new List<SaleRequest>();
        public static List<DealRecord> Records { get; set; } = new List<DealRecord>();



        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            using (AddClient addClientForm = new AddClient())
            {
                addClientForm.ShowDialog();
            }
        }


        private void BtnAddSaleRequest_Click(object sender, EventArgs e)
        {
            if (!Clients.Any())
            {
                MessageBox.Show("��� �������� ��� �������� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var buyRequestForm = new AddSaleRequestForm(Clients))
            {
                buyRequestForm.ShowDialog();
            }
        }

        private void BtnAddBuyRequest_Click(object sender, EventArgs e)
        {
            if (!Clients.Any())
            {
                MessageBox.Show("��� �������� ��� �������� ������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var buyRequestForm = new AddPurchaseRequestForm(Clients))
            {
                buyRequestForm.ShowDialog();
            }
        }

        private void BtnShowClients_Click(object sender, EventArgs e)
        {
            if (!Clients.Any())
            {
                MessageBox.Show("������ �������� ����.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var clientInfo = string.Join("\n\n", Clients.Select(client =>
                $"���: {client.FullName}\n" +
                $"�������: {string.Join(", ", client.PhoneNumber)}\n" +
                $"�����: {string.Join(", ", client.Address)}\n" +
                $"��������������� �����: {client.RegistrationNumber}\n" +
                $"������:\n{string.Join("\n", client.Requests.Select(r => r.ToString()))}"));

            var clientForm = new Form
            {
                Text = "������ ��������",
                Width = 600,
                Height = 400,
                StartPosition = FormStartPosition.CenterScreen
            };

            var richTextBox = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                Text = clientInfo,
                Font = new Font("Times New Roman", 10),
                ScrollBars = RichTextBoxScrollBars.Vertical
            };

            clientForm.Controls.Add(richTextBox);
            clientForm.ShowDialog();
        }


        private void BtnIssueReceipt_Click(object sender, EventArgs e)
        {
            if (!Clients.Any())
            {
                MessageBox.Show("������ �������� ����.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            IssueReceiptForm receiptForm = new IssueReceiptForm(Clients);
            receiptForm.ShowDialog(); // ������� ����� ��� ������ ���������
        }

        private void BtnShowPopular_Click(object sender, EventArgs e)
        {
            try
            {
                // ������ ������ �� �������
                string purchaseStatistics = RequestAnalyzer.GetCategoryStatistics(PurchaseRequests);
                purchaseStatistics = "����� ���������� ����������� ��� ������:\n" + purchaseStatistics;

                // ������ ������ �� ������� (��������)
                var ownershipRequests = SaleRequests.Where(r => r.OwnType == Requests.OwnType.Ownership);
                string ownershipStatistics = RequestAnalyzer.GetCategoryStatistics(ownershipRequests, includeOwnType: false);
                ownershipStatistics = "����� ���������� ����������� ��� ������� (�������������):\n" + ownershipStatistics;

                // ������ ������ �� ������
                var rentRequests = SaleRequests.Where(r => r.OwnType == Requests.OwnType.Rent);
                string rentStatistics = RequestAnalyzer.GetCategoryStatistics(rentRequests, includeOwnType: false);
                rentStatistics = "����� ���������� ����������� ��� ������:\n" + rentStatistics;

                // ��������� ����� ����� ��� �����������
                string result = $"{purchaseStatistics}\n\n{ownershipStatistics}\n\n{rentStatistics}";

                // ���������� ��������� � MessageBox
                MessageBox.Show(result, "���������� ������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnBuySell_Click(object sender, EventArgs e)
        {
            if (!Clients.Any())
            {
                MessageBox.Show("��� �������� ��� ���������� ��������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var buySellForm = new BuySellForm1(Clients, PurchaseRequests, SaleRequests))
            {
                buySellForm.ShowDialog();
            }
        }

        private void BtnProfit_Click(object sender, EventArgs e)
        {
            var profitComparisonForm = new ProfitComparisonForm();
            profitComparisonForm.ShowDialog();
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            // ������� ���� �������
            Clients.Clear();
            PurchaseRequests.Clear();
            SaleRequests.Clear();
            Records.Clear();

            // ���������� ������������ �� �������� �������
            MessageBox.Show("��� ������ ������� �������!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
