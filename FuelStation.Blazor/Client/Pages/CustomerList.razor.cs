﻿namespace FuelStation.Blazor.Client.Pages;

using System.Net.Http.Json;
using FuelStation.Blazor.Shared;

public partial class CustomerList
{
    private List<CustomerListViewModel>? _customers = new();
    private bool _isLoading = true;

    protected override async Task OnInitializedAsync()
    {
        await LoadItemsFromServer();
        _isLoading = false;
    }

    private async Task LoadItemsFromServer()
    {
        _customers = await ReqClient.GetFromJsonAsync<List<CustomerListViewModel>>("customer");
    }

    protected void AddItem()
    {
        NavManager.NavigateTo("/customers/edit");
    }

    protected async Task DeleteItem(CustomerListViewModel customer)
    {
        var response = await ReqClient.DeleteAsync($"customer/{customer.ID}");
        response.EnsureSuccessStatusCode();
        await LoadItemsFromServer();
    }

    protected void EditItem(CustomerListViewModel customer)
    {
        NavManager.NavigateTo($"/customers/edit/{customer.ID}");
    }
}
