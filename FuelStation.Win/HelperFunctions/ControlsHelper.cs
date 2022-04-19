using FuelStation.Blazor.Shared;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Win.HelperFunctions
{
    internal class ControlsHelper
    {
        public ControlsHelper()
        {

        }

        public void PopulateItemType(ComboBox select)
        {
            select.DataSource = Enum.GetValues(typeof(ItemTypeEnum));
        }

        public void PopulatePaymentMethod(ComboBox select)
        {
            select.DataSource = Enum.GetValues(typeof(PaymentMethodEnum));
        }

        public void PopulateEmployees(ComboBox select, List<EmployeeListViewModel> employees)
        {
            select.DataSource = employees;

            select.DisplayMember = "Surname";
            select.ValueMember = "ID";
        }

        public void PopulateItems(ComboBox select, List<ItemListViewModel> items)
        {
            select.DataSource = items;

            select.DisplayMember = "Description";
            select.ValueMember = "ID";
        }
    }
}
