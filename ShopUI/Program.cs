var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseDeveloperExceptionPage(); // detail of exception show to me
app.UseStatusCodePages();
app.UseStaticFiles();   
app.UseRouting(); // routing

app.UseEndpoints(endpoints =>
    endpoints.MapDefaultControllerRoute()
    );

app.Run();
