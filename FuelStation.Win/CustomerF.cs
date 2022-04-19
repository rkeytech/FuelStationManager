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
    public partial class CustomerF : Form
    {
        private uint _customerID = 0;
        private CustomerEditViewModel _customer;
        private readonly HttpClient _httpClient;


        public CustomerF(HttpClient httpClient)
        {
            InitializeComponent();
            _httpClient = httpClient;
        }

        public CustomerF(HttpClient httpClient, uint id) : this(httpClient)
        {
            _customerID = id;
        }

        private async void CustomerF_Load(object sender, EventArgs e)
        {
            _customer = await _httpClient.GetFromJsonAsync<CustomerEditViewModel>($"customer/{_customerID}");

            bsCustomer.DataSource = _customer;
            SetDataBindings();
        }

        private void SetDataBindings()
        {
            ctrlCustomerSurname.DataBindings.Add(new Binding("Text", bsCustomer, "Surname", true));
            ctrlCustomerName.DataBindings.Add(new Binding("Text", bsCustomer, "Name", true));
            ctrlCustomerCardNumber.DataBindings.Add(new Binding("Text", bsCustomer, "CardNumber", true));
        }

        private async void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ctrlCustomerName.Text) ||
                string.IsNullOrEmpty(ctrlCustomerSurname.Text) ||
                string.IsNullOrEmpty(ctrlCustomerCardNumber.Text))
            {
                MessageBox.Show("Make sure you have entered all the required values.", "Error", MessageBoxButtons.OK);
                return;
            }
            HttpResponseMessage response;
            if (_customerID == 0)
            {
                response = await _httpClient.PostAsJsonAsync("customer", _customer);
            }
            else
            {
                response = await _httpClient.PutAsJsonAsync("customer", _customer);
            }
            response.EnsureSuccessStatusCode();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelCustomer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
