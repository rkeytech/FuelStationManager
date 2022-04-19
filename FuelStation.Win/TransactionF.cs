using FuelStation.Blazor.Shared;
using FuelStation.Model;
using FuelStation.Model.Handlers;
using FuelStation.Win.HelperFunctions;
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
    public partial class TransactionF : Form
    {
        private uint _transactionID = 0;
        private TransactionEditViewModel _transaction;
        private CustomerEditViewModel _customer;
        private List<EmployeeListViewModel> _employees;
        private readonly HttpClient _httpClient;
        private ControlsHelper _controlsHelper;
        private TransactionHandler _transactionHandler;


        public TransactionF(HttpClient httpClient)
        {
            InitializeComponent();
            _httpClient = httpClient;
            _controlsHelper = new ControlsHelper();
            _transactionHandler = new TransactionHandler();
        }

        public TransactionF(HttpClient httpClient, uint id) : this(httpClient)
        {
            _transactionID = id;
        }

        private async void TransactionF_Load(object sender, EventArgs e)
        {
            _transaction = await _httpClient.GetFromJsonAsync<TransactionEditViewModel>($"transaction/{_transactionID}");
            _employees = await _httpClient.GetFromJsonAsync<List<EmployeeListViewModel>>("employee");
            bsTransaction.DataSource = _transaction;

            PopulateTransactionLines();
            PopulateControls();
            SetDataBindings();

        }

        private void PopulateControls()
        {

            if (_employees is not null)
                _controlsHelper.PopulateEmployees(ctrlTransactionEmployee, _employees);
            _controlsHelper.PopulatePaymentMethod(ctrlPaymentMethod);
        }

        private void PopulateTransactionLines()
        {
            bsTransactionLines.DataSource = _transaction.TransactionLines;

            grdTransactionLines.DataSource = null;
            grdTransactionLines.DataSource = bsTransactionLines;
            grdTransactionLines.Columns["ID"].Visible = false;
            grdTransactionLines.Columns["ItemID"].Visible = false;
            grdTransactionLines.Columns["DiscountPercent"].Visible = false;
        }

        private void SetDataBindings()
        {
            ctrlTransactionDate.DataBindings.Add(new Binding("Value", bsTransaction, "Date", true));
            ctrlTransactionEmployee.DataBindings.Add(new Binding("SelectedValue", bsTransaction, "EmployeeID", true));
            ctrlPaymentMethod.DataBindings.Add(new Binding("SelectedValue", bsTransaction, "PaymentMethod", true));
            ctrlTransactionTotalValue.DataBindings.Add(new Binding("Value", bsTransaction, "TotalValue", true));

        }

        private void btnAddTransactionLine_Click(object sender, EventArgs e)
        {
            var transaction = bsTransaction.Current as TransactionEditViewModel;
            Form form = new TransactionLineF(_httpClient, transaction);
            form.ShowDialog();
            if (_transaction.TransactionLines.Count > 0)
            {
                _transaction.TotalValue = _transactionHandler.CalculateTransactionTotalValue(_transaction.TransactionLines.Select(x => x.TotalValue).ToList());
                ctrlTransactionTotalValue.Value = (decimal)_transaction.TotalValue;
                if (!_transactionHandler.CheckCardPaymentAvail(_transaction.TotalValue))
                {
                    _transaction.PaymentMethod = PaymentMethodEnum.Cash;
                    ctrlPaymentMethod.SelectedIndex = (int)_transaction.PaymentMethod;
                    ctrlPaymentMethod.Enabled = false;
                }
            }
            PopulateTransactionLines();
        }

        private async void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ctrlTransactionCustomer.Text) ||
                string.IsNullOrEmpty(ctrlTransactionDate.Text) ||
                ctrlPaymentMethod.SelectedValue == null ||
                ctrlTransactionEmployee.SelectedValue == null)
            {
                MessageBox.Show("Make sure you have entered all the required values.", "Error", MessageBoxButtons.OK);
                return;
            }
            HttpResponseMessage response = new();
            if (_transactionID == 0)
            {
                response = await _httpClient.PostAsJsonAsync("transaction", _transaction);
            }
            response.EnsureSuccessStatusCode();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelTransaction_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void BtnSearchCustomer_Click(object sender, EventArgs e)
        {
            var cardNumber = ctrlTransactionCardNumber.Text;
            if (!string.IsNullOrEmpty(cardNumber))
            {
                _customer = await _httpClient.GetFromJsonAsync<CustomerEditViewModel>($"customer/card/{cardNumber}");
                if (_customer?.ID != 0)
                {
                    ctrlTransactionCardNumber.Text = _customer.CardNumber;
                    ctrlTransactionCustomer.Text = $"{_customer.Surname} {_customer.Name}";
                    _transaction.CustomerID = _customer.ID;
                }
                else
                {
                    MessageBox.Show("There is no customer with that Card number in database", "Error", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnDeleteTransactionLine_Click(object sender, EventArgs e)
        {
            var selectedTransactionLine = bsTransactionLines.Current as TransactionLineViewModel;
            if(selectedTransactionLine is not null)
                _transaction.TransactionLines.Remove(selectedTransactionLine);
            PopulateTransactionLines();
        }
    }
}
