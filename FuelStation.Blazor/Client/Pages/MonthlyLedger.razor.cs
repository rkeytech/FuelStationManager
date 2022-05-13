namespace FuelStation.Blazor.Client.Pages;

using System.Net.Http.Json;
using Blazor.Shared;
using Microsoft.AspNetCore.Components;
using Shared;

public partial class MonthlyLedger
{
    [CascadingParameter]
    public MainLayout MyLayout { get; set; } = null!;
    private MonthlyLedgerViewModel? _ledger;
    private DateTime LedgerDate { get; set; } = DateTime.UtcNow;
    private bool _isLoading = true;

    protected override async Task OnInitializedAsync()
    {
        MyLayout.UpdateTitle("Monthly Ledger");
        _ledger = await ReqClient.GetFromJsonAsync<MonthlyLedgerViewModel>($"utility/ledger/{LedgerDate.Year}/{LedgerDate.Month}");
        _isLoading = false;
    }

    protected async Task GetLedger()
    {
        _ledger = await ReqClient.GetFromJsonAsync<MonthlyLedgerViewModel>($"utility/ledger/{LedgerDate.Year}/{LedgerDate.Month}");
    }
}
