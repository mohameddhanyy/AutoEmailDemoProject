using Hangfire;
using Microsoft.AspNetCore.Mvc;
using AutoEmailDemoProject.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ReportController : Controller
{
    private readonly IBackgroundJobClient _backgroundJobClient;
    private readonly ReportService _reportService;
    private readonly EmailService _emailService; // Inject EmailService

    public ReportController(IBackgroundJobClient backgroundJobClient, ReportService reportService, EmailService emailService)
    {
        _backgroundJobClient = backgroundJobClient;
        _reportService = reportService;
        _emailService = emailService; // Initialize EmailService
    }

    // Index view to trigger scheduling page
    public IActionResult Index()
    {
        return View();
    }

    // Action to handle scheduling report
    [HttpPost]
    public IActionResult ScheduleReport(string reportType, string frequency, string time)
    {

        // Schedule report generation based on the new combined data functionality.
        // Modify this to dynamically choose which report template and data type should be used.

        string cronExpression = frequency switch
        {
            "daily" => $"0 {time.Split(':')[1]} {time.Split(':')[0]} * * *",
            "weekly" => $"0 {time.Split(':')[1]} {time.Split(':')[0]} * * 1",
            "monthly" => $"0 {time.Split(':')[1]} {time.Split(':')[0]} 1 * *",
            _ => throw new ArgumentException("Invalid frequency")
        };

        // Convert to local time (GMT+5:30) if needed
        DateTime localTime = DateTime.UtcNow.AddHours(5).AddMinutes(30);
        string localCronExpression = $"0 {localTime.Minute} {localTime.Hour} * * *";
        string reportFileName = reportType == "YarnInvoiceGstEinv" ? "YarnInvoiceGstEinv.repx" : "OtherReport.repx";
        string outputFileName = reportFileName.Replace(".repx", ".pdf");

        // Schedule the job with local time cron expression
        Hangfire.RecurringJob.AddOrUpdate(
            $"generate-{reportType}-report-job",
            () => GenerateReportAndSendEmail("1630183124", reportFileName, outputFileName, $"{reportType} Report", "::"),
            localCronExpression
        );

        // Log the scheduling success
        Console.WriteLine($"Job for {reportType} scheduled successfully.");

        TempData["Message"] = $"Recurring {reportType} report generation has been scheduled for {frequency} at {time}.";
        return RedirectToAction("ScheduleReport");
    }

    // Action to display the Schedule Report page
    public IActionResult ScheduleReport()
    {
        return View();
    }

    // New method to generate report and send email


    // Handle the generation and sending of reports based on multiple data sources.
    public async Task GenerateReportAndSendEmail(string filterValue, string reportFileName, string outputFileName, string title, string range)
    {
        // Generate the report
        try
        {
            // Generate the report
            _reportService.GenerateReport(filterValue, reportFileName, outputFileName, title, range, new Dictionary<string, string>());

            // Fetch invoices for the email sending process
            var invoices = await _reportService.GetInvoicesForEmailSendingAsync(filterValue); // Now this method is available

            // Send email with the generated report
            await _emailService.SendScheduledEmailsAsync(DateTime.UtcNow, invoices); // This will now work correctly
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in report generation or email sending: {ex.Message}");
            // Handle logging or further error handling
        }
    }
}