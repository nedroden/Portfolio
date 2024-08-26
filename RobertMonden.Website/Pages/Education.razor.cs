using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using RobertMonden.Website.Models;

namespace RobertMonden.Website.Pages
{
    public partial class Education : ComponentBase
    {
        private List<Degree> _degrees = new List<Degree>();

        protected override async Task OnInitializedAsync()
        {
            List<Degree> degrees = await HttpClient.GetFromJsonAsync<List<Degree>>("data/degrees.json");

            _degrees = degrees;
        }
    }
}
