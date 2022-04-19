using FuelStation.Blazor.Shared;
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
    public partial class ItemF : Form
    {
        private uint _itemID = 0;
        private ItemEditViewModel _item;
        private readonly HttpClient _httpClient;
        private ControlsHelper _controlsHelper;


        public ItemF(HttpClient httpClient)
        {
            InitializeComponent();
            _httpClient = httpClient;
            _controlsHelper = new ControlsHelper();
        }

        public ItemF(HttpClient httpClient, uint id) : this(httpClient)
        {
            _itemID = id;
        }

        private async void ItemF_Load(object sender, EventArgs e)
        {
            _item = await _httpClient.GetFromJsonAsync<ItemEditViewModel>($"item/{_itemID}");

            bsItem.DataSource = _item;
            PopulateControl();
            SetDataBindings();
        }

        private void PopulateControl()
        {
            _controlsHelper.PopulateItemType(ctrlItemType);
        }

        private void SetDataBindings()
        {
            ctrlItemCode.DataBindings.Add(new Binding("Text", bsItem, "Code", true));
            ctrlItemDescription.DataBindings.Add(new Binding("Text", bsItem, "Description", true));
            ctrlItemCost.DataBindings.Add(new Binding("Value", bsItem, "Cost", true));
            ctrlItemPrice.DataBindings.Add(new Binding("Value", bsItem, "Price", true));
            ctrlItemType.DataBindings.Add(new Binding("SelectedItem", bsItem, "ItemType", true));
        }

        private async void btnSaveItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ctrlItemCode.Text) ||
                string.IsNullOrEmpty(ctrlItemDescription.Text) ||
                string.IsNullOrEmpty(ctrlItemCost.Text) ||
                string.IsNullOrEmpty(ctrlItemPrice.Text) ||
                ctrlItemType.SelectedValue == null)
            {
                MessageBox.Show("Make sure you have entered all the required values.", "Error", MessageBoxButtons.OKCancel);
                return;
            }
            HttpResponseMessage response;
            if (_itemID == 0)
            {
                response = await _httpClient.PostAsJsonAsync("item", _item);
            }
            else
            {
                response = await _httpClient.PutAsJsonAsync("item", _item);
            }
            response.EnsureSuccessStatusCode();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        
    }
}
