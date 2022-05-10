namespace FuelStation.Blazor.Client.Pages;

using Microsoft.JSInterop;

public partial class Index
{
    private bool _isAuth;

    protected override async Task OnInitializedAsync()
    {
        _isAuth = Convert.ToBoolean(await JsRuntime.InvokeAsync<string>("localStorage.getItem", "isAuth"));
        if (!_isAuth)
            NavManager.NavigateTo("/login", true);
    }
}
