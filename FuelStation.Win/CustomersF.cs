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
    public partial class CustomersF : Form
    {
        private readonly HttpClient _httpClient;
        private List<CustomerListViewModel> _customers;

        public CustomersF(HttpClient httpClient)
        {
            InitializeComponent();
            _httpClient = httpClient;
        }
        
        private async void CustomersF_Load(object sender, EventArgs e)
        {
            await PopulateCustomers();
        }

        private async Task PopulateCustomers()
        {
            _customers = await _httpClient.GetFromJsonAsync<List<CustomerListViewModel>>("customer");


            bsCustomers.DataSource = _customers;
            grdCustomers.DataSource = bsCustomers;

            grdCustomers.Columns["ID"].Visible = false;
        }

        private async void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Form form = new CustomerF(_httpClient);
            form.ShowDialog();
            await PopulateCustomers();
        }

        private async void btnEditCustomer_Click(object sender, EventArgs e)
        {
            var selectedCustomer = bsCustomers.Current as CustomerListViewModel;
            if (selectedCustomer is null)
                return;
            Form form = new CustomerF(_httpClient, selectedCustomer.ID);
            form.ShowDialog();
            await PopulateCustomers();
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var selectedCustomer = bsCustomers.Current as CustomerListViewModel;
            if (selectedCustomer is null)
                return;
            HttpResponseMessage response;
            response = await _httpClient.DeleteAsync($"customer/{selectedCustomer.ID}");
            response.EnsureSuccessStatusCode();
            await PopulateCustomers();
        }
    }
}
