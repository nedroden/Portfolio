using RobertMonden.Website.Models;
using Microsoft.AspNetCore.Components;

namespace RobertMonden.Website.Components.Thesis
{
    public partial class ApplicationListItem : ComponentBase
    {
        [Parameter]
        public Application Application { get; set; }
    }
}
