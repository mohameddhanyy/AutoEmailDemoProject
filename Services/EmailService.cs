using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using AutoEmailDemoProject.Models;
using AutoEmailDemoProject; // Adjust namespace for DbContext
using Microsoft.EntityFrameworkCore;
using Hangfire;
using System.Runtime.Intrinsics.X86;

public class EmailService
{
    private readonly MainDataContext _dbContext;
    private readonly ReportService _reportService;

    public EmailService(MainDataContext dbContext, ReportService reportService)
    {
        _dbContext = dbContext;
        _reportService = reportService;
    }

    public async Task SendScheduledEmailsAsync(DateTime scheduledDate, List<Bill_Trans> invoices)
    {
        // Group invoices by customer
        var groupedInvoices = invoices.GroupBy(i => i.Party_Code);

        // Instead of grouping only by Party_Code (Bill_Trans), we need to handle more complex grouping
        // depending on the combined data.




        foreach (var group in groupedInvoices)
        {
            int customerId = group.Key ?? 0; // Assuming Party_Code is the customer identifier
            var customerInvoices = group.ToList();
            var CustomerEmail = await GetCustomerEmailAsync(customerId);

            if (!string.IsNullOrEmpty(CustomerEmail))
            {
                // Generate report for the customer invoices
                string reportFileName = "InvoiceReportTemplate.repx"; // Replace with your report template
                string outputFileName = $"InvoiceReport_{customerId}_{scheduledDate:yyyyMMdd}.pdf";
                string title = "Invoice Report";
                string range = $"Invoices for {scheduledDate.ToShortDateString()}";

                var defText = new Dictionary<string, string>(); // Populate if needed
                var filterValue = string.Join(", ", customerInvoices.Select(i => "'" + i.FVNo + "'")); // Assuming FVNo is the filter

                _reportService.GenerateReport(filterValue, reportFileName, outputFileName, title, range, defText);

                // Send the email with the generated report
                //using (var smtpClient = CreateSmtpClient(customerId))
                string SMTPServer = "";
                int SMTPPort = 0;
                string SenderEmail = "";
                string MailPassword = "";
                bool SMTPSSL = false;
                SmtpClient smtpClient;

                var CompObj = _dbContext.Company_Master.FirstOrDefault();

                SMTPServer = CompObj.SMTPServer;
                SMTPPort = int.Parse(CompObj.SMTPPort);
                SenderEmail = CompObj.SenderEmail;
                MailPassword = CompObj.MailPassword;
                SMTPSSL = CompObj.SMTPSSL;

                smtpClient = new(CompObj.SMTPServer, int.Parse(CompObj.SMTPPort))
                {
                    Credentials = new NetworkCredential(CompObj.SenderEmail, CompObj.MailPassword),
                    EnableSsl = CompObj.SMTPSSL
                };

                // Dynamically customize the email body and attachments based on the type of report.


                using MailMessage mail = new(SenderEmail, CustomerEmail)
                {
                    Subject = "Invoice Report",
                    IsBodyHtml = true,
                    Body = @$"<br> <br> <br>

<b>Sent {DateTime.Now:dd-MMM-yyyy HH-mm-ss}"
                };
                {
                    // Attach the generated report
                    string dir = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
                    var attachment = new Attachment(Path.Combine(dir, outputFileName));
                    mail.Attachments.Add(attachment);

                    // Send the email
                    try
                    {
                        await smtpClient.SendMailAsync(mail);
                    }
                    catch (Exception ex)
                    {
                        LogError(ex, CustomerEmail, customerInvoices);
                    }
                }
            }
        }
    }

    private async Task<string> GetCustomerEmailAsync(int customerId)
    {
        var customer = await _dbContext.Account_Master.FindAsync(customerId);
        return customer?.EMail;
    }

    private void LogError(Exception ex, string email, List<Bill_Trans> failedInvoices)
    {
        // Log the error details to a database or a log file
        Console.WriteLine($"Error sending email to {email}: {ex.Message}");

        // Log details of failed invoices
        foreach (var invoice in failedInvoices)
        {
            Console.WriteLine($"Failed Invoice: FVNo = {invoice.FVNo}, Amount = {invoice.Amount}");
        }

        // Schedule a retry for the next day at 10 AM
        var jobId = BackgroundJob.Schedule(() => ResendFailedEmails(email, failedInvoices), TimeSpan.FromDays(1));
    }

    public void ResendFailedEmails(string email, List<Bill_Trans> failedInvoices)
    {
        // Logic to resend the failed emails
        // Here, you might want to log the attempt or actually attempt to resend the emails again
        Console.WriteLine($"Resending failed emails to {email} for {failedInvoices.Count} invoices.");

        // For demonstration, you could log the retry attempt
        foreach (var invoice in failedInvoices)
        {
            Console.WriteLine($"Retrying Invoice: FVNo = {invoice.FVNo}, Amount = {invoice.Amount}");
        }

        // If you want to retry sending the emails, you can call SendScheduledEmailsAsync again
        // Note: This is a synchronous call, so you might want to manage the async context properly
        // You may want to consider using BackgroundJob for this or handle it differently based on your app's architecture
    }
}