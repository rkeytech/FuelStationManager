namespace FuelStation.Blazor.Client.Components;

using System.Reflection;
using Microsoft.AspNetCore.Components;

public partial class EntityList<TEntity>
{
    [Parameter]
    public RenderFragment? TableHeader { get; set; }
    [Parameter]
    public IReadOnlyList<Tuple<string, string>>? Headers { get; set; }
    [Parameter]
    public RenderFragment<TEntity>? RowTemplate { get; set; }
    [Parameter]
    public IReadOnlyList<TEntity>? Items { get; set; }
    [Parameter]
    public EventCallback<TEntity> OnClickDelete { get; set; }
    [Parameter]
    public EventCallback<TEntity> OnClickEdit { get; set; }
    

    protected Task DeleteClick(TEntity entity)
    {
        return OnClickDelete.InvokeAsync(entity);
    }

    protected Task EditClick(TEntity entity)
    {
        return OnClickEdit.InvokeAsync(entity);
    }

    private List<string> GetItemProperties()
    {
        return typeof(TEntity).GetProperties().Select(pr => pr.Name).ToList();
    }
}
