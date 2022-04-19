using FuelStation.Blazor.Shared;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class FuelStation : Form
    {
        private readonly HttpClient _httpClient;
        private readonly UserAuthenticatedViewModel _user;

        public FuelStation(HttpClient httpClient, UserAuthenticatedViewModel user)
        {
            InitializeComponent();
            _httpClient = httpClient;
            _user = user;
        }

        private void FuelStation_Load(object sender, EventArgs e)
        {
            CheckUserforMenuItems();
        }

        private void CheckUserforMenuItems()
        {
            if (_user.EmployeeType == EmployeeTypeEnum.Cashier)
            {
                itemsToolStripMenuItem.Visible = false;
            }
            if (_user.EmployeeType == EmployeeTypeEnum.Staff)
            {
                customersToolStripMenuItem.Visible = false;
                transactionsToolStripMenuItem.Visible = false;
            }
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ItemsF(_httpClient));

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new CustomersF(_httpClient));
        }
        
        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new TransactionsF(_httpClient));
        }

        private void ShowForm(Form form)
        {
            form.ShowDialog();
        }

    }
}
