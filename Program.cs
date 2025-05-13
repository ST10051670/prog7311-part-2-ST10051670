using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MUHAMMED_ZIA_DESAI.ST10051670.POE.Data;
using Microsoft.AspNetCore.Session;
using MUHAMMED_ZIA_DESAI.ST10051670.POE.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// Register the application DB context
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Register default Identity services with EF Core Store
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Add session services
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);  // Set session timeout 
    options.Cookie.HttpOnly = true;  // Ensure cookies are HttpOnly for security
});

// Register custom services
builder.Services.AddScoped<ProductService>(); // Register ProductService

// Add MVC controllers with views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Enable session middleware
app.UseSession();

// Authentication and Authorization
app.UseAuthentication();  // Ensure authentication middleware is placed before authorization
app.UseAuthorization();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
