namespace FuelStation.Blazor.Client.Pages;

using System.Net.Http.Json;
using Blazor.Shared;

public partial class ItemList
{
    private List<ItemListViewModel>? _items = new();
    private bool _isLoading = true;

    protected override async Task OnInitializedAsync()
    {
        await LoadItemsFromServer();
        _isLoading = false;
    }

    private async Task LoadItemsFromServer()
    {
        _items = await ReqClient.GetFromJsonAsync<List<ItemListViewModel>>("item");
    }

    protected void AddItem()
    {
        NavManager.NavigateTo("/items/edit");
    }

    protected async Task DeleteItem(ItemListViewModel item)
    {
        var response = await ReqClient.DeleteAsync($"item/{item.ID}");
        response.EnsureSuccessStatusCode();
        await LoadItemsFromServer();
    }

    protected void EditItem(ItemListViewModel item)
    {
        NavManager.NavigateTo($"/items/edit/{item.ID}");
    }
}
