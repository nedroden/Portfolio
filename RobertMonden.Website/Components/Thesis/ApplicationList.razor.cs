using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using RobertMonden.Website.Models;
using Microsoft.AspNetCore.Components;

namespace RobertMonden.Website.Components.Thesis
{
    public partial class ApplicationList : ComponentBase
    {
        public List<Application> Applications { get; set; } = new List<Application>();

        protected async override Task OnInitializedAsync()
        {
            List<Application> response = await HttpClient.GetFromJsonAsync<List<Application>>("data/applications.json");

            Applications = response;
        }
    }
}
