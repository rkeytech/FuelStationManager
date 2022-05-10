namespace FuelStation.Blazor.Client.Pages;

using System.Net.Http.Json;
using FuelStation.Blazor.Shared;
using Microsoft.AspNetCore.Components;

public partial class CustomerEdit
{
    [Parameter] public int? Id { get; set; }
    private CustomerEditViewModel? CustomerItem { get; set; } = new();
    private bool _showingErrorMessages;

    protected override async Task OnInitializedAsync()
    {
        Id ??= 0;
        CustomerItem = await ReqClient.GetFromJsonAsync<CustomerEditViewModel>($"customer/{Id}");
    }

    protected async Task OnSave()
    {
        if (CustomerItem != null && (string.IsNullOrEmpty(CustomerItem.CardNumber) ||
                                     string.IsNullOrEmpty(CustomerItem.Surname) ||
                                     string.IsNullOrEmpty(CustomerItem.Name) ||
                                     !CustomerItem.CardNumber.StartsWith("A", StringComparison.CurrentCulture)))
        {
            _showingErrorMessages = true;
            return;
        }

        HttpResponseMessage response;
        if (Id == 0)
        {
            response = await ReqClient.PostAsJsonAsync("customer", CustomerItem);
        }
        else
        {
            response = await ReqClient.PutAsJsonAsync("customer", CustomerItem);
        }
        response.EnsureSuccessStatusCode();
        NavManager.NavigateTo("customers");
    }

    protected void OnCancel()
    {
        NavManager.NavigateTo("customers");
    }
}
