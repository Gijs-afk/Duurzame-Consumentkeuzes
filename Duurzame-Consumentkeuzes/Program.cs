using dotenv.net;
using Duurzame_Consumentkeuzes.Data;
using Duurzame_Consumentkeuzes.Middleware;
using Duurzame_Consumentkeuzes.Data;
using Duurzame_Consumentkeuzes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Numerics;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

DotEnv.Load();
var EnvVars = DotEnv.Read();


var connectionString = EnvVars["CONNECTIONSTRINGS__DEFAULTCONNECTION"];
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<Customer>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
    options.User.RequireUniqueEmail = true;
})
    .AddRoles<IdentityRole>() // enable role management
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(new ConfigurationBuilder()
            .AddEnvironmentVariables()
            .Build()
        )
    .CreateLogger();
Log.Information("Created logger");

var dotEnv = new ConfigurationBuilder()
        .AddEnvironmentVariables()
        .Build();

builder.Services.AddSingleton<IConfiguration>(dotEnv);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseMiddleware<GlobalErrorHandeling>();
Log.Information("Configured errorhandeling");

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

Log.Information("Set standard path");
Log.Information("Starting application!");

app.Run();