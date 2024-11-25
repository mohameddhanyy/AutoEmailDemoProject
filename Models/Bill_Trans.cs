using AutoEmailDemoProject.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Bill_Trans", Schema = "dbo")]
public class Bill_Trans : CommDataModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BillTransLineId { get; set; }

    public int BillMasterId { get; set; }

    public string FVNo { get; set; }
    public int? VNo { get; set; }
    public int? VSNo { get; set; }
    public int? Book_Code { get; set; }

    public string Book_Short { get; set; }
    public DateTime? Date { get; set; }

    public int? Party_Code { get; set; }
    public string Account_Name { get; set; }

    public int? Acof_Code { get; set; }

    public int? Agent_Code { get; set; }
    public int? Sr_No { get; set; }
    public string Caseno { get; set; }
    public string Des_No { get; set; }
    public int? Shade_Code { get; set; }
    public string Shade { get; set; }
    public string Shades { get; set; }
    public string Item { get; set; }
    public int? Des_Code { get; set; }

    public int? Item_Code { get; set; }
    public int? YarnShadeCode { get; set; }
    public int? FabricShadeCode { get; set; }
    public string Unit { get; set; }

    public int? Trans_Code { get; set; }
    public DateTime? Order_Date { get; set; }
    public int? No_Pcs { get; set; }
    public int? Cases { get; set; }
    public string Cut { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Amount { get; set; }
    public string Clear { get; set; }
    public string Desc { get; set; }
    public decimal? Weight { get; set; }
    public int? Rec_Pcs { get; set; }
    public int? Isu_pcs { get; set; }
    public decimal? Rec_Qty { get; set; }
    public decimal? Isu_Qty { get; set; }
    public decimal? Rec_Amount { get; set; }
    public decimal? Isu_Amount { get; set; }
    public int? Bal_Pcs { get; set; }
    public int? Cones { get; set; }
    public decimal? Bal_Qty { get; set; }
    public string Packing_Name { get; set; }
    public int? Packing_Code { get; set; }

    public string FdPd_Name { get; set; }
    public int? FdPd_Code { get; set; }

    public string Bill_No { get; set; }

    public DateTime? Bill_Date { get; set; }
    public string Ord_No { get; set; }
    public DateTime? AcDate { get; set; }
    public int? Factory_Code { get; set; }
    public int? MillCode { get; set; }
    public string Factory_Name { get; set; }

    public string Chl_No { get; set; }
    public string ChlFVNo { get; set; }

    public string Lot_No { get; set; }
    public string Shade_No { get; set; }
    public int? Bags { get; set; }
    public string RetBillNo { get; set; }
    public DateTime? RetBillDate { get; set; }
    public int? RetSNo { get; set; }
    public decimal? Width { get; set; }
    public decimal? Pick { get; set; }
    public decimal? Pick_rate { get; set; }
    public string Beam_No { get; set; }
    public int? Book_Ac_Code { get; set; }
    public decimal? Isu_Wt { get; set; }
    public decimal? Rec_Wt { get; set; }
    public decimal? Shaft { get; set; }
    public decimal? Shaft_Rate { get; set; }
    public string GVNo { get; set; }
    public decimal? Namt { get; set; }
    public decimal? RdPerMtr { get; set; }
    public decimal? RdPerCase { get; set; }
    public decimal? CdOn { get; set; }
    public decimal? CdPer { get; set; }
    public decimal? QWT { get; set; }
    public decimal? ExRate { get; set; }
    public decimal? ExAmount { get; set; }
    public int? Process_Code { get; set; }
    public int? Selvg_Code { get; set; }

    public string OrdFVNo { get; set; }
    public decimal? OrdQty { get; set; }
    public decimal? OrdNoPcs { get; set; }
    public string OrdLineId { get; set; }

    public string Selvg_Name { get; set; }
    public decimal? TrptPer { get; set; }
    public decimal? TrptAmt { get; set; }
    public decimal? PackingWt { get; set; }
    public string GPNO { get; set; }
    public int? SUBSRNO { get; set; }
    public decimal? GrossWT { get; set; }
    public decimal? TareWt { get; set; }
    public decimal? NetWt { get; set; }
    public bool PrntYN { get; set; }
    public string PrintItem { get; set; }
    public int? PrintItemCode { get; set; }
    public decimal? PrintRate { get; set; }

    public int? Grade_Code { get; set; }
    public string Grade { get; set; }
    public string TrSign { get; set; }
    public string RateFVNo { get; set; }
    public string ProgNo { get; set; }
    public string RDON { get; set; }
    public string RdType { get; set; }
    public string MainNo { get; set; }
    public string PiNo { get; set; }
    public string GSTNo { get; set; }
    public string GSTInOut { get; set; }
    public string TaxName { get; set; }
    public decimal? TAXPer { get; set; }
    public int? TAXCode { get; set; }
    public string GSTListName { get; set; }
    public decimal? DISCper { get; set; }
    public string DiscType { get; set; }
    public decimal? Discount { get; set; }
    public decimal? GSTOnAmt { get; set; }
    public decimal? TotalGSTAmount { get; set; }
    public decimal? CgstPer { get; set; }
    public decimal? SgstPer { get; set; }
    public decimal? IgstPer { get; set; }
    public decimal? CessPer { get; set; }
    public decimal? CgstAMT { get; set; }
    public decimal? SgstAMT { get; set; }
    public decimal? IgstAMT { get; set; }
    public decimal? CessAMT { get; set; }

    public int? CgstAcCode { get; set; }
    public int? SgstAcCode { get; set; }
    public int? IgstAcCode { get; set; }
    public int? CessAcCode { get; set; }

    public string HSNCode { get; set; }
    public decimal? NetAmount { get; set; }
    public decimal? NetPer { get; set; }
    public decimal? AvgWithGSTRate { get; set; }
    public decimal? AvgWoGSTRate { get; set; }
    public decimal? WoTcsNetAmt { get; set; }
    public decimal? TotalAdd { get; set; }
    public decimal? TotalLess { get; set; }

    /// <summary>
    /// used for store Invoice
    /// </summary>
    public decimal? AddOther { get; set; }

    public int? BrokerCode { get; set; }
    public string BrokerName { get; set; }

    public string GarmentSizeName { get; set; }
    public int? GarmentSizeCode { get; set; }

    public string GarmentBrandName { get; set; }
    public int? GarmentBrandCode { get; set; }

    public string GarmentColorName { get; set; }
    public int? GarmentColorCode { get; set; }

    public string GarmentGradeName { get; set; }
    public int? GarmentGradeCode { get; set; }

    public string GarmentStyleName { get; set; }
    public int? GarmentStyleCode { get; set; }

    /// <summary>
    /// Used for Tag Wise Group, Plaza RMG
    /// </summary>
    public string TagNo { get; set; }

    /// <summary>
    /// Used for Tag Wise Group, Plaza RMG
    /// </summary>
    public string MainTagNo { get; set; }

    public string PackRowRollNo { get; set; }
}