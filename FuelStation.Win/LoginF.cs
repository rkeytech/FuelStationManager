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
    public partial class LoginF : Form
    {
        public static HttpClient _httpClient;
        public static UserAuthenticatedViewModel _user;

        public LoginF()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7254");
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = ctrlUsername.Text;
            var password = ctrlPassword.Text;
            _user = await _httpClient.GetFromJsonAsync<UserAuthenticatedViewModel>($"utility/auth/{username}/{password}");
            if (_user.IsAuthed)
            {
                Thread t = new Thread(new ThreadStart(OpenApp));
                t.Start();
                Close();
            }
        }

        public static void OpenApp()
        {
            Application.Run(new FuelStation(_httpClient, _user));
        }
    }
}
