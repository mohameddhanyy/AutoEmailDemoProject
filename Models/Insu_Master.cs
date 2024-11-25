using AutoEmailDemoProject.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoEmailDemoProject;

[Table("Insu_Master", Schema = "dbo")]
public class Insu_Master : CommDataModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Insu_Code { get; set; }

    public string Insu_Name { get; set; }

    public string Policy_No { get; set; }
    public string Add1 { get; set; }
    public string Add2 { get; set; }
    public string Add3 { get; set; }
    public decimal? Rate { get; set; }
    public string RateOn { get; set; }
    public string PlantCodes { get; set; }
}