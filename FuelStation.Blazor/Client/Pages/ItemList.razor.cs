namespace FuelStation.Blazor.Client.Pages;

using System.Net.Http.Json;
using Blazor.Shared;

public partial class ItemList
{
    private List<ItemListViewModel>? _items = new();
    private bool _isLoading = true;
    private readonly List<Tuple<string, string>> _tableHeaders = new()
    {
        new Tuple<string, string>("Code", "Code"),
        new Tuple<string, string>("Description", "Description"),
        new Tuple<string, string>("Cost", "Cost"),
        new Tuple<string, string>("Price", "Price"),
        new Tuple<string, string>("ItemType", "ItemType"),
    };

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
