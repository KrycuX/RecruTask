using MudBlazor;
using static MudBlazor.Icons.Material;

namespace RecruTask.Data;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }=string.Empty;
    public string Icon { get; set; } = Filled.StarBorder;
}
