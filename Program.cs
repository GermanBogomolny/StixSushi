using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Stix.Services;
using Stix.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FoodContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("FoodContext") ?? throw new InvalidOperationException("Connection string 'FoodContext' not found.")));
builder.Services.AddDbContext<FoodContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("FoodContext") ?? throw new InvalidOperationException("Connection string 'FoodContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IRestaurantService, RestaurantService>();
builder.Services.AddScoped<IFoodService, FoodService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

