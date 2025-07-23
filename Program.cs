using FinanceApp.Data;
using Microsoft.EntityFrameworkCore;
using FinanceApp.Data.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<FinanceAppContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnectionString")));

builder.Services.AddScoped<IExpensesService, ExpensesService>();
var app = builder.Build();

// Ensure database is created and migrated
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<FinanceAppContext>();
    
    // Ensure the data directory exists (important for Render persistent disk)
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString");
    if (!string.IsNullOrEmpty(connectionString) && connectionString.Contains("Data Source="))
    {
        var dbPath = connectionString.Split("Data Source=")[1].Split(';')[0];
        var dbDirectory = Path.GetDirectoryName(dbPath);
        if (!string.IsNullOrEmpty(dbDirectory) && !Directory.Exists(dbDirectory))
        {
            Directory.CreateDirectory(dbDirectory);
        }
    }
    
    try
    {
        context.Database.Migrate();
    }
    catch
    {
        // Fallback to EnsureCreated if migrations fail
        context.Database.EnsureCreated();
    }
    
    // Add sample data if database is empty (helps verify persistence)
    if (!context.Expenses.Any())
    {
        context.Expenses.AddRange(
            new FinanceApp.Models.Expense
            {
                Amount = 25.99,
                Category = "Food",
                Description = "Sample lunch expense",
                Date = DateTime.Now.AddDays(-1)
            },
            new FinanceApp.Models.Expense
            {
                Amount = 45.00,
                Category = "Transportation",
                Description = "Sample gas expense",
                Date = DateTime.Now.AddDays(-2)
            }
        );
        context.SaveChanges();
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Expenses}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
