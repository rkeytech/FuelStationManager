namespace FuelStation.Blazor.Client.Pages;

using System.Net.Http.Json;
using Blazor.Shared;

public partial class EmployeeList
{
    private List<EmployeeListViewModel>? _employees = new();
    private bool _isLoading = true;

    protected override async Task OnInitializedAsync()
    {
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
