using BlazorWebApp;
using BlazorWebApp.Services;

var builder = WebApplication.CreateBuilder(args);
 
builder.Services.AddRazorComponents()
    .AddServerComponents();

builder.Services.AddScoped<DataService, DataService>();
builder.Services.AddScoped<CounterService, CounterService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.MapRazorComponents<App>();

app.Run();
