using Microsoft.EntityFrameworkCore;
using ShopUI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var cnnString = builder.Configuration.GetConnectionString("StoreCnn");
builder.Services.AddDbContext<StoreDbContext>(options => options.UseSqlServer(cnnString));
builder.Services.AddScoped<IProductRepository, EfProductRepository>();

var app = builder.Build();

app.UseDeveloperExceptionPage(); // detail of exception show to me
app.UseStatusCodePages();
app.UseStaticFiles();   
app.UseRouting(); // routing

app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}/Page{pageNumber}");
            endpoints.MapDefaultControllerRoute();
        }
    );

app.Run();
