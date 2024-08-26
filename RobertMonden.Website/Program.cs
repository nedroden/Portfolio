using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RobertMonden.Website;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http;
using System;
using Modulight.Modules.Hosting;
using StardustDL.RazorComponents.Markdown;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddModules(builder =>
{
    builder.UseRazorComponentClientModules().AddMarkdownModule();
});

await builder.Build().RunAsyncWithModules();
