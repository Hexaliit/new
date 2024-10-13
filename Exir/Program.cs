using Exir.Client.Pages;
using Exir.Client.Services;
using Exir.Components;
using Exir.Data;
using Exir.Interfaces;
using Exir.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();



builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));

builder.Services.AddRazorPages();
builder.Services.AddControllers();


builder.Services.AddScoped<IPersonRepository, PersonRepository>();
builder.Services.AddScoped<IProfileRepository, ProfileRepository>();

builder.Services.AddScoped(typeof(IHttpRepository<>), typeof(HttpRepository<>));

builder.Services.AddHttpClient("MyClient", client => {
    client.BaseAddress = new Uri(builder.Configuration.GetValue<string>("BaseURL")!);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}
app.UseRouting();

app.UseStaticFiles();
app.UseAntiforgery();


app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Exir.Client._Imports).Assembly);


app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapControllers();
}
);

app.Run();
