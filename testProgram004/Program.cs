var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<testProgram004.Data.DatabaseContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(cfg => cfg.MapControllerRoute(
    "Default",
    "/{controller}/{action}/{id?}",
    new { controller = "Customer", action = "Index" } 
));
app.Run();