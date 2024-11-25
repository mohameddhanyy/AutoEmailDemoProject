// ReportService.cs
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.Sql;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using AutoEmailDemoProject;
using AutoEmailDemoProject.Services;
using DevExpress.DataAccess.Wizard.Services;
using System.ComponentModel.Design;
using Microsoft.EntityFrameworkCore;
using DevExpress.XtraReports;

public class ReportService
{
    private readonly IServiceScopeFactory _scopeFactory;
    private readonly MainDataContext _dbContext;

    public ReportService(IServiceScopeFactory scopeFactory, MainDataContext dbContext)
    {
        _scopeFactory = scopeFactory;
        _dbContext = dbContext;
    }



    // New method to combine data from different tables based on the filter value
    // This method will return a list of combined data (of type T).


    // When combining data from multiple tables, create an anonymous object to hold the combined data.
    // Example of combining data from two different tables (Bill_Trans and another table) into a single object.
    //var combinedData = from bill in billTrans
    //                 join other in otherTable on bill.Id equals other.Id
    //                 select new { bill.FVNo, other.Property, ... };



    public void GenerateReport(string filterValue, string reportFileName, string outputFileName, string Title, string Range, Dictionary<string, string> DefText)
    {
        try
        {
            string dir = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            string reportFilePath = Path.Combine(dir, reportFileName);
            string exportPath = Path.Combine(dir, outputFileName);

            Console.WriteLine($"Report file path: {reportFilePath}");
            Console.WriteLine($"Export path: {exportPath}");

            if (!File.Exists(reportFilePath))
            {
                Console.WriteLine($"Report template not found at {reportFilePath}");
                return;
            }

            // Load the report from the template file
            XtraReport xrReport = XtraReport.FromFile(reportFilePath);
            xrReport.FilterString = "";

            // Apply filters to the report
            Dictionary<string, string> selectionFormula = new()
            {
                { nameof(Bill_Trans), $"[{nameof(Bill_Trans.FVNo)}] In ({filterValue})" }
            };

            xrReport = ApplyFilterToReport(xrReport, selectionFormula);

            // Set default titles and ranges (custom logic)
            xrReport = SetDefaultValues(xrReport, Title, Range, DefText);

            // Export the report to PDF
            xrReport.ExportToPdf(exportPath);

            Console.WriteLine($"Report generated and saved at: {exportPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error generating report: {ex.Message}");
        }
    }

    public async Task GenerateReportAndSendEmail(string filterValue, string reportFileName, string outputFileName, string title, string range, Dictionary<string, string> defText, List<Bill_Trans> invoices, string customerEmail)
    {
        try
        {
            // Generate the report
            GenerateReport(filterValue, reportFileName, outputFileName, title, range, defText);

            // Now send the email with the generated report
            var emailService = new EmailService(_dbContext, this); // Ensure you have access to the DbContext
            await emailService.SendScheduledEmailsAsync(DateTime.UtcNow, invoices); // Pass the current date to send emails
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in report generation or email sending: {ex.Message}");
            // Handle logging or further error handling
        }
    }

    private XtraReport SetDefaultValues(XtraReport report, string Title, string Range, Dictionary<string, string> DefText)
    {
        report.ShowPreviewMarginLines = false;
        try
        {
            foreach (Band band in report.Bands)
            {
                SetTextFromCode(band, DefText, Title, Range);
            }
        }
        catch { }

        (report as IServiceContainer).RemoveService(typeof(IConnectionProviderService));
        (report as IServiceContainer).AddService(typeof(IConnectionProviderService), new CustomConnectionProviderService());

        return report;
    }

    private void SetTextFromCode(Band band, Dictionary<string, string> DefText, string Title, string Range)
    {
        foreach (XRControl item in band.Controls)
        {
            if (item is Band subBand)
            {
                SetTextFromCode(subBand, DefText, Title, Range);
            }
            else
            {
                SetTextFromCodeForItem(item, DefText, Title, Range);
            }
        }
    }

    private void SetTextFromCodeForItem(XRControl item, Dictionary<string, string> DefText, string Title, string Range)
    {
        if (item is XRSubreport subrpt)
        {
            // Ensure correct connection provider is used
            if (!string.IsNullOrEmpty(subrpt.ReportSourceUrl))
            {
                try
                {
                    (subrpt as IServiceContainer).RemoveService(typeof(IConnectionProviderService));
                    (subrpt as IServiceContainer).AddService(typeof(IConnectionProviderService), new CustomConnectionProviderService());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error setting connection provider: " + ex.Message);
                }
            }
        }

        // Proceed with setting text from code
        if (DefText != null)
        {
            foreach (var defItem in DefText)
            {
                if (defItem.Key.ToUpper() == item.Text.ToUpper())
                {
                    item.Text = defItem.Value;
                }
            }
        }

        if (item.Name.ToUpper().EndsWith("TITLE") || item.Text.ToUpper().EndsWith("TITLE"))
        {
            item.Text = Title;
        }

        if (item.Name.ToUpper().EndsWith("RANGE") || item.Text.ToUpper().EndsWith("RANGE"))
        {
            item.Text = Range;
        }
    }

    private XtraReport ApplyFilterToReport(XtraReport report, Dictionary<string, string> selectionFormula)
    {
        if (report == null) return null;

        if (report.DataSource is SqlDataSource sqlDataSource)
        {
            foreach (var formula in selectionFormula)
            {
                var query = sqlDataSource.Queries.FirstOrDefault(x => x.Name.Equals(formula.Key, StringComparison.OrdinalIgnoreCase));
                if (query is SelectQuery selectQuery)
                {
                    // Apply filters in the query before it is sent to the report
                    selectQuery.FilterString = formula.Value;  // Make sure the filter is optimized
                }
            }
        }

        return report;
    }

    public async Task<List<Bill_Trans>> GetInvoicesForEmailSendingAsync(string filterValue)
    {
        // Assuming filterValue corresponds to FVNo or some other identifier
        // Adjust the logic as necessary based on your actual requirements
        return await _dbContext.Bill_Trans
            .Where(i => i.FVNo == filterValue) // Adjust this condition based on your filtering logic
            .ToListAsync();
    }



}