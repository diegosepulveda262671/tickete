using Blazored.Modal;
using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Ticket.WEB.Repositories;
using Ticket.WEB2;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7182/") });
builder.Services.AddSweetAlert2();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddBlazoredModal();

await builder.Build().RunAsync();

