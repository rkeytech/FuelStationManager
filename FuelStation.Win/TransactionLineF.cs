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
    public partial class TransactionLineF : Form
    {
        private uint _transactionLineID = 0;
        private TransactionLineViewModel _transactionLine;
        private TransactionEditViewModel _transaction;
        private List<ItemListViewModel> _items;
        private ItemEditViewModel _selectedItem;
        private readonly HttpClient _httpClient;
        private ControlsHelper _controlsHelper;
        private TransactionHandler _transactionHandler;


        public TransactionLineF(HttpClient httpClient, TransactionEditViewModel transaction)
        {
            InitializeComponent();
            _httpClient = httpClient;
            _controlsHelper = new ControlsHelper();
            _transaction = transaction;
            _transactionLine = new TransactionLineViewModel();
            _transactionHandler = new TransactionHandler();
        }

        public TransactionLineF(HttpClient httpClient, TransactionEditViewModel transaction, uint id) : this(httpClient, transaction)
        {
            _transactionLineID = id;
        }

        private async void TransactionLineF_Load(object sender, EventArgs e)
        {
            _items = await _httpClient.GetFromJsonAsync<List<ItemListViewModel>>($"item");
            if (_transaction.TransactionLines.Any(x => x.ItemType == Model.ItemTypeEnum.Fuel))
            {
                _items = _items.Where(x => x.ItemType != Enum.GetName(typeof(ItemTypeEnum), ItemTypeEnum.Fuel)).ToList();
            }
            bsTransactionLine.DataSource = _transactionLine;
            SetDataBindings();
        }


        private void SetDataBindings()
        {
            ctrlItem.DataSource = _items;
            ctrlItem.SelectedIndex = -1;
            ctrlItem.ValueMember = "ID";
            ctrlItem.DisplayMember = "Description";

            ctrlItem.DataBindings.Add(new Binding("SelectedValue", bsTransactionLine, "ItemID", true));
            ctrlQuantity.DataBindings.Add(new Binding("Value", bsTransactionLine, "Quantity", true));
            ctrlItemPrice.DataBindings.Add(new Binding("Value", bsTransactionLine, "ItemPrice", true));
            ctrlTotalValue.DataBindings.Add(new Binding("Value", bsTransactionLine, "TotalValue", true));
        }

        private void btnSaveTransactionLine_Click(object sender, EventArgs e)
        {
            if (ctrlQuantity.Value <= 0 ||
                ctrlItem.SelectedValue == null)
            {
                MessageBox.Show("Make sure you have entered all the required values.", "Error", MessageBoxButtons.OKCancel);
                return;
            }
            _transaction.TransactionLines.Add(_transactionLine);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelTransactionLine_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void ctrlItem_DropDownClosed(object sender, EventArgs e)
        {
            if (ctrlItem.SelectedValue is null)
                return;
            var selectedItemID = ctrlItem.SelectedValue;
            _selectedItem = await _httpClient.GetFromJsonAsync<ItemEditViewModel>($"item/{selectedItemID}");
            UpdateTransactionLine();
            ctrlItemPrice.Value = (decimal)_transactionLine.ItemPrice;
            ctrlTotalValue.Value = (decimal)_transactionLine.TotalValue;
        }

        private void UpdateTransactionLine()
        {
            _transactionLine.ItemPrice = _selectedItem.Price;
            _transactionLine.ItemType = _selectedItem.ItemType;
            _transactionLine.ItemName = _selectedItem.Description;
            _transactionLine.NetValue = _transactionHandler.CalculateNetValue((double)ctrlQuantity.Value, _selectedItem.Price);
            _transactionLine.DiscountValue = _transactionHandler.ApplyTenPercentDiscount(_transactionLine.NetValue, 0.10, _selectedItem.ItemType);
            _transactionLine.TotalValue = _transactionHandler.CalculateLineTotalValue(_transactionLine.DiscountValue, _transactionLine.NetValue);
        }

        private void ctrlQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (ctrlItem.SelectedValue is null)
                return;
            UpdateTransactionLine();
            ctrlItemPrice.Value = (decimal)_transactionLine.ItemPrice;
            ctrlTotalValue.Value = (decimal)_transactionLine.TotalValue;
        }
    }
}
