namespace FuelStation.Blazor.Client.Pages;

using System.Net.Http.Json;
using Blazor.Shared;
using Microsoft.AspNetCore.Components;
using Shared;

public partial class EmployeeList
{
    [CascadingParameter]
    public MainLayout MyLayout { get; set; } = null!;
    private List<EmployeeListViewModel>? _employees = new();
    private bool _isLoading = true;

    private readonly List<Tuple<string, string>> _tableHeaders = new()
    {
        new Tuple<string, string>("Surname", "Surname"),
        new Tuple<string, string>("Name", "Name"),
        new Tuple<string, string>("Employee Type", "EmployeeType"),
        new Tuple<string, string>("Salary Per Month", "SalaryPerMonth"),
        new Tuple<string, string>("Date Started", "HireDateStart"),
        new Tuple<string, string>("Date Ended", "HireDateEnd"),
    };

    protected override async Task OnInitializedAsync()
    {
        MyLayout.UpdateTitle("Employees");
        await LoadItemsFromServer();
        _isLoading = false;
    }

    private async Task LoadItemsFromServer()
    {
        _employees = await ReqClient.GetFromJsonAsync<List<EmployeeListViewModel>>("employee");
    }

    protected void AddItem()
    {
        NavManager.NavigateTo("/employees/edit");
    }

    protected async Task DeleteItem(EmployeeListViewModel employee)
    {
        var response = await ReqClient.DeleteAsync($"employee/{employee.ID}");
        response.EnsureSuccessStatusCode();
        await LoadItemsFromServer();
    }

    protected void EditItem(EmployeeListViewModel employee)
    {
        NavManager.NavigateTo($"/employees/edit/{employee.ID}");
    }
}
