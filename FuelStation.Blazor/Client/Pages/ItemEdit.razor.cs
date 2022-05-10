namespace FuelStation.Blazor.Client.Pages;

using System.Net.Http.Json;
using Blazor.Shared;
using Microsoft.AspNetCore.Components;
using Model;

public partial class ItemEdit
{
    [Parameter] public int? Id { get; set; }
    private ItemEditViewModel? ItemItem { get; set; } = new();
    private int ItemType { get; set; } = -1;
    private bool _showingErrorMessages;

    protected override async Task OnInitializedAsync()
    {
        Id ??= 0;

        ItemItem = await ReqClient.GetFromJsonAsync<ItemEditViewModel>($"item/{Id}");

        if (Id != 0 && ItemItem is not null)
        {
            ItemType = (int)ItemItem.ItemType;
        }
    }

    protected async Task OnSave()
    {
        if (ItemItem != null && (string.IsNullOrEmpty(ItemItem.Code) ||
                                 string.IsNullOrEmpty(ItemItem.Description) ||
                                 ItemType == -1 ||
                                 ItemItem.Cost <= 0 ||
                                 ItemItem.Price <= 0))
        {
            _showingErrorMessages = true;
            return;
        }

        HttpResponseMessage response;
        if(ItemItem is not null)
            ItemItem.ItemType = (ItemTypeEnum)ItemType;
        if (Id == 0)
        {
            response = await ReqClient.PostAsJsonAsync("item", ItemItem);
        }
        else
        {
            response = await ReqClient.PutAsJsonAsync("item", ItemItem);
        }
        response.EnsureSuccessStatusCode();
        NavManager.NavigateTo("items");
    }

    protected void OnCancel()
    {
        NavManager.NavigateTo("items");
    }
}
