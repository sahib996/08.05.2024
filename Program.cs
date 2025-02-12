using Pronia.DataAccesLayer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProniaContext>();
var app = builder.Build();
app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
app.Run();
