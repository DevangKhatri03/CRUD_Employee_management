using CRUD_Employee_management.Service;
using Empolyee_Management_Frontend;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7044/api/") });

builder.Services.AddScoped<EmployeeService>();

builder.RootComponents.Add<HeadOutlet>("head::after");

await builder.Build().RunAsync();
