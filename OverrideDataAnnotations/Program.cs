using OverrideDataAnnotations;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

//var cultureInfo = new CultureInfo("en");
var cultureInfo = new CultureInfo("tr"); // <---- en or tr
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapDefaultControllerRoute();

ResourceManagerHack.OverrideComponentModelAnnotationsResourceManager();
app.Run();
