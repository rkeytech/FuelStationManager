namespace FuelStation.Blazor.Client.Pages;

using System.Net.Http.Json;
using FuelStation.Blazor.Shared;
using Microsoft.AspNetCore.Components;
using Model;

public partial class EmployeeEdit
{
    [Parameter] public int? Id { get; set; }
    private EmployeeEditViewModel? EmployeeItem { get; set; } = new();
    private int EmployeeType { get; set; } = -1;
    private bool _showingErrorMessages;

    protected override async Task OnInitializedAsync()
    {
        Id ??= 0;

        EmployeeItem = await ReqClient.GetFromJsonAsync<EmployeeEditViewModel>($"employee/{Id}");

        if (Id != 0 && EmployeeItem is not null)
        {
            EmployeeType = (int)EmployeeItem.EmployeeType;
        }
    }

    protected async Task OnSave()
    {
        if (EmployeeItem != null && (string.IsNullOrEmpty(EmployeeItem.Surname) ||
                                     string.IsNullOrEmpty(EmployeeItem.Name) ||
                                     EmployeeItem.HireDateStart == null ||
                                     EmployeeItem.SalaryPerMonth <= 0 ||
                                     EmployeeType == -1))
        {
            _showingErrorMessages = true;
            return;
        }

        HttpResponseMessage response;
        if (EmployeeItem is not null)
            EmployeeItem.EmployeeType = (EmployeeTypeEnum)EmployeeType;
        if (Id == 0)
        {
            response = await ReqClient.PostAsJsonAsync("employee", EmployeeItem);
        }
        else
        {
            response = await ReqClient.PutAsJsonAsync("employee", EmployeeItem);
        }
        response.EnsureSuccessStatusCode();
        NavManager.NavigateTo("employees");
    }

    protected void OnCancel()
    {
        NavManager.NavigateTo("employees");
    }
}
