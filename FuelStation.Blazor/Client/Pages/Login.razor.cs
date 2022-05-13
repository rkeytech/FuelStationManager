namespace FuelStation.Blazor.Client.Pages;

using System.Net.Http.Json;
using Blazor.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Shared;

public partial class Login
{
    [CascadingParameter]
    public MainLayout MyLayout { get; set; } = null!;
    private UserAuthenticatedViewModel? User { get; set; }
    private string? Username { get; set; }
    private string? Password { get; set; }

    protected override void OnInitialized()
    {
        MyLayout.UpdateTitle("Login");
    }

    protected async Task OnLogin()
    {
        User = await ReqClient.GetFromJsonAsync<UserAuthenticatedViewModel>($"utility/auth/{Username}/{Password}");
        if (User is not null && User.IsAuthed)
        {
            await JsRuntime.InvokeAsync<string>("localStorage.setItem", "username", User.Username);
            await JsRuntime.InvokeAsync<string>("localStorage.setItem", "role", User.EmployeeType);
            await JsRuntime.InvokeAsync<string>("localStorage.setItem", "isAuth", true);
            NavManager.NavigateTo("/", true);
        }
    }
}
