using Microsoft.AspNetCore.Components;

namespace RobertMonden.Website.Components.Layout
{
    public partial class PageHeader : ComponentBase
    {
        [Parameter]
        public string Title { get; set; }
    }
}