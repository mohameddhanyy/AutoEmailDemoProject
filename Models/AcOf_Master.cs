using AutoEmailDemoProject.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Acof_Master", Schema = "dbo")]
public class AcOf_Master : ApprovedCommDataModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Acof_Code { get; set; }

    public string Acof_Name { get; set; }
    public string Add1 { get; set; }
    public string Add2 { get; set; }
    public string Add3 { get; set; }
    public string Phone { get; set; }
    public string Dispatch { get; set; }
    public string LstNo { get; set; }
    public int? LessPer { get; set; }
    public int? AddPer { get; set; }
    public int? OnMtrs { get; set; }
    public int? OnMtrsRate { get; set; }
    public bool ItemYesno { get; set; }
    public bool Qty { get; set; }

    public bool Cust { get; set; }
    public int? Cust_Code { get; set; }

    public int? Trans_Code { get; set; }
    public int? Insu_Yesno { get; set; }
    public decimal? Limit { get; set; }
    public bool DealerTrs { get; set; }
    public string AdharNumber { get; set; }
    public string UANNumber { get; set; }
    public string PAN { get; set; }
    public string ExRange { get; set; }
    public string ExcRate { get; set; }
    public string ExDivision { get; set; }
    public string ExeccNo { get; set; }
    public string GSTNo { get; set; }
    public string CinNumber { get; set; }
    public string CityName { get; set; }
    public string StateName { get; set; }
    public string StateType { get; set; }
    public string StateGSTCode { get; set; }
    public int? StateCode { get; set; }
    public int? CityCode { get; set; }
    public string PinCode { get; set; }

    public decimal? IntPer { get; set; }
    public decimal? CdPer { get; set; }
    public decimal? ComPer { get; set; }
    public decimal? RdPer { get; set; }
    public int? Side_Days { get; set; }
    public decimal? CreditLimit { get; set; }
    public int? Samp_code { get; set; }
    public int? AreaCode { get; set; }
    public string CDON { get; set; }
    public string TDON { get; set; }
    public string RDON { get; set; }
    public decimal? TDPer { get; set; }
    public string COMON { get; set; }
    public string TcsYn { get; set; }
    public int? CreditDays { get; set; }

    public string PlantCodes { get; set; }
}
