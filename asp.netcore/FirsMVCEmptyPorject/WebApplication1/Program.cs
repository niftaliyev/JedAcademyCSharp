var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Development
if (app.Environment.IsDevelopment()) 
{
    app.UseDeveloperExceptionPage();
}
//Production
else
{
    app.UseExceptionHandler("/Home/Error/500");
}
app.UseStatusCodePagesWithRedirects("/Home/Error/{0}");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapDefaultControllerRoute();


app.Run();
