namespace FinalCursWork
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button butnAddPurchase;
        private System.Windows.Forms.Button btnAddSaleRequest;


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
            btnAddClient = new Button();
            butnAddPurchase = new Button();
            btnAddSaleRequest = new Button();
            BtnShowClient = new Button();
            BtnShowRecepit = new Button();
            btnShowPopularRequest = new Button();
            BtnBuySell = new Button();
            BtnProfit = new Button();
            BtnClearAll = new Button();
            SuspendLayout();
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(12, 22);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(150, 40);
            btnAddClient.TabIndex = 0;
            btnAddClient.Text = "Добавить клиента";
            btnAddClient.Click += BtnAddClient_Click;
            // 
            // butnAddPurchase
            // 
            butnAddPurchase.Location = new Point(12, 88);
            butnAddPurchase.Name = "butnAddPurchase";
            butnAddPurchase.Size = new Size(150, 68);
            butnAddPurchase.TabIndex = 1;
            butnAddPurchase.Text = "Добавить заявку на покупку";
            butnAddPurchase.Click += BtnAddBuyRequest_Click;
            // 
            // btnAddSaleRequest
            // 
            btnAddSaleRequest.Location = new Point(12, 178);
            btnAddSaleRequest.Name = "btnAddSaleRequest";
            btnAddSaleRequest.Size = new Size(150, 86);
            btnAddSaleRequest.TabIndex = 2;
            btnAddSaleRequest.Text = "Добавить заявку на продажу";
            btnAddSaleRequest.Click += BtnAddSaleRequest_Click;
            // 
            // BtnShowClient
            // 
            BtnShowClient.Location = new Point(12, 291);
            BtnShowClient.Name = "BtnShowClient";
            BtnShowClient.Size = new Size(150, 86);
            BtnShowClient.TabIndex = 3;
            BtnShowClient.Text = "Вывести список клиентов";
            BtnShowClient.Click += BtnShowClients_Click;
            // 
            // BtnShowRecepit
            // 
            BtnShowRecepit.Location = new Point(595, 22);
            BtnShowRecepit.Name = "BtnShowRecepit";
            BtnShowRecepit.Size = new Size(163, 79);
            BtnShowRecepit.TabIndex = 4;
            BtnShowRecepit.Text = "Выдать квитанцию о регистрационном взносе";
            BtnShowRecepit.Click += BtnIssueReceipt_Click;
            // 
            // btnShowPopularRequest
            // 
            btnShowPopularRequest.Location = new Point(595, 126);
            btnShowPopularRequest.Name = "btnShowPopularRequest";
            btnShowPopularRequest.Size = new Size(163, 52);
            btnShowPopularRequest.TabIndex = 15;
            btnShowPopularRequest.Text = "Показать популярное";
            btnShowPopularRequest.Click += BtnShowPopular_Click;
            // 
            // BtnBuySell
            // 
            BtnBuySell.Location = new Point(310, 178);
            BtnBuySell.Name = "BtnBuySell";
            BtnBuySell.Size = new Size(178, 85);
            BtnBuySell.TabIndex = 16;
            BtnBuySell.Text = "Купить/Продать";
            BtnBuySell.Click += BtnBuySell_Click;
            // 
            // BtnProfit
            // 
            BtnProfit.Location = new Point(595, 211);
            BtnProfit.Name = "BtnProfit";
            BtnProfit.Size = new Size(163, 52);
            BtnProfit.TabIndex = 17;
            BtnProfit.Text = "Рассчитать прибыль";
            BtnProfit.Click += BtnProfit_Click;
            // 
            // BtnClearAll
            // 
            BtnClearAll.Location = new Point(595, 291);
            BtnClearAll.Name = "BtnClearAll";
            BtnClearAll.Size = new Size(163, 52);
            BtnClearAll.TabIndex = 18;
            BtnClearAll.Text = "Очистить всё";
            BtnClearAll.Click += BtnClearAll_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(BtnClearAll);
            Controls.Add(BtnProfit);
            Controls.Add(BtnBuySell);
            Controls.Add(btnShowPopularRequest);
            Controls.Add(BtnShowRecepit);
            Controls.Add(BtnShowClient);
            Controls.Add(butnAddPurchase);
            Controls.Add(btnAddClient);
            Controls.Add(btnAddSaleRequest);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Риэлтерская фирма «Рога и копыта»";
            ResumeLayout(false);
        }
        #endregion
        private Button BtnShowClient;
        private Button BtnShowRecepit;
        private Button btnShowPopularRequest;
        private Button BtnBuySell;
        private Button BtnProfit;
        private Button BtnClearAll;
    }
}
