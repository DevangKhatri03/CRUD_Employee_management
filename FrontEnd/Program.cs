using FrontEnd.Services;  // Correct namespace for your services in the frontend project
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using FrontEnd;  // Ensure the Shared project models are accessible

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Register HttpClient to interact with the API, using the correct API base URL
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7044/api/") });

// Register the EmployeeService in the DI container
builder.Services.AddScoped<EmployeeService>();  // Service that makes API calls

await builder.Build().RunAsync();

