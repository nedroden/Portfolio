using Microsoft.AspNetCore.Components;

namespace RobertMonden.Website.Components.Math
{
    public partial class Equation : ComponentBase
    {
        [Parameter]
        public RenderFragment<string> Body { get; set; }
    }
}
