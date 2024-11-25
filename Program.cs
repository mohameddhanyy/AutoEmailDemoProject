using Hangfire;
using Hangfire.SqlServer;
using Microsoft.EntityFrameworkCore;
using AutoEmailDemoProject.Services;
using AutoEmailDemoProject;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register the custom time zone resolver
builder.Services.AddSingleton<ITimeZoneResolver, CustomTimeZoneResolver>();

// Configure Hangfire with SQL Server storage
builder.Services.AddHangfire(configuration =>
    configuration.SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                 .UseSqlServerStorage("Data Source=localhost;Initial Catalog=AutoEmailDemoProject;Integrated Security=True;Persist Security Info=True;TrustServerCertificate=True", new SqlServerStorageOptions
                 {
                     CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                     SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                     QueuePollInterval = TimeSpan.Zero,
                     UseRecommendedIsolationLevel = true,
                     DisableGlobalLocks = true
                 }));


// Add Hangfire background job server
builder.Services.AddHangfireServer();

// Configure DbContext
builder.Services.AddDbContext<MainDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add ReportService as scoped since it depends on MainDataContext (scoped)
builder.Services.AddScoped<ReportService>();

// Add EmailService as scoped to be able to use it in Hangfire jobs
builder.Services.AddScoped<EmailService>();


///
///
///Add the service for combining tables and generating reports (this might be a new service or modify existing ones).
///builder.Services.AddScoped<IReportService, ReportService>(); // Example of adding a new service for combining tables
///


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Hangfire dashboard configuration
app.UseHangfireDashboard("/hangfire");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Report}/{action=Index}/{id?}");

app.Run();