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
    public partial class ItemsF : Form
    {
        private readonly HttpClient _httpClient;
        private List<ItemListViewModel> _items;

        public ItemsF(HttpClient httpClient)
        {
            InitializeComponent();
            _httpClient = httpClient;
        }

        private async void ItemsF_Load(object sender, EventArgs e)
        {
            await PopulateItems();
        }

        private async Task PopulateItems()
        {
            _items = await _httpClient.GetFromJsonAsync<List<ItemListViewModel>>("item");

            bsItems.DataSource = _items;
            grdItems.DataSource = bsItems;

            grdItems.Columns["ID"].Visible = false;
        }

        private async void btnAddItem_Click(object sender, EventArgs e)
        {
            Form form = new ItemF(_httpClient);
            form.ShowDialog();
            await PopulateItems();
        }

        private async void btnEditItem_Click(object sender, EventArgs e)
        {
            var selectedItem = bsItems.Current as ItemListViewModel;
            if (selectedItem is null)
                return;
            Form form = new ItemF(_httpClient, selectedItem.ID);
            form.ShowDialog();
            await PopulateItems();
        }

        private async void btnDeleteItem_Click(object sender, EventArgs e)
        {
            var selectedItem = bsItems.Current as ItemListViewModel;
            if (selectedItem is null)
                return;
            HttpResponseMessage response;
            response = await _httpClient.DeleteAsync($"item/{selectedItem.ID}");
            response.EnsureSuccessStatusCode();
            await PopulateItems();
        }

    }
}
