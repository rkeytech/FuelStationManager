using FuelStation.Blazor.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class TransactionsF : Form
    {
        private readonly HttpClient _httpClient;
        private List<TransactionListViewModel> _transactions;

        public TransactionsF(HttpClient httpClient)
        {
            InitializeComponent();
            _httpClient = httpClient;
        }

        private async void PopulateTransactions()
        {
            _transactions = await _httpClient.GetFromJsonAsync<List<TransactionListViewModel>>("transaction");


            bsTransactions.DataSource = _transactions;
            grdTransactions.DataSource = bsTransactions;

            grdTransactions.Columns["ID"].Visible = false;
        }

        private void TransactionsF_Load(object sender, EventArgs e)
        {
            PopulateTransactions();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            Form form = new TransactionF(_httpClient);
            _ = form.ShowDialog();
            PopulateTransactions();
        }

        private void btnEditTransaction_Click(object sender, EventArgs e)
        {
            var selectedTransaction = bsTransactions.Current as TransactionListViewModel;
            if (selectedTransaction is null)
                return;
            Form form = new TransactionF(_httpClient, selectedTransaction.ID);
            form.ShowDialog();
            PopulateTransactions();
        }

        private async void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            var selectedTransaction = bsTransactions.Current as TransactionListViewModel;
            if (selectedTransaction is null)
                return;
            HttpResponseMessage response;
            response = await _httpClient.DeleteAsync($"transaction/{selectedTransaction.ID}");
            response.EnsureSuccessStatusCode();
            PopulateTransactions();
        }
    }
}
