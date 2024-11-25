using AutoEmailDemoProject.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Bill_Master", Schema = "dbo")]
public class Bill_Master : CommDataModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int BillMasterId { get; set; }

    public string FVNo { get; set; }
    public string Caseno { get; set; }
    public int? Book_Code { get; set; }

    public int? VNo { get; set; }
    public int? VSNo { get; set; }
    public string Ord_No { get; set; }
    public string PartyRefNo { get; set; }
    public string OrdFVNo { get; set; }
    public DateTime? Order_Date { get; set; }
    public string Book_Short { get; set; }
    public string GpNo { get; set; }
    public DateTime? GpDate { get; set; }
    public DateTime? AcDate { get; set; }
    public string Bill_No { get; set; }
    public DateTime? Bill_date { get; set; }
    public string BillType { get; set; }
    public string Ref_No { get; set; }
    public DateTime? Ref_Dt { get; set; }

    public int? Party_Code { get; set; }
    public int? DespPartyCode { get; set; }

    public int? BrokerCode { get; set; }
    public string BrokerName { get; set; }

    public int? Book_Ac_Code { get; set; }

    public int? Agent_Code { get; set; }
    public int? Acof_Code { get; set; }
    public string Account_Name { get; set; }
    public int? Trans_Code { get; set; }
    public int? Process_Code { get; set; }
    public int? No_Pcs { get; set; }
    public string Cases { get; set; }
    public int? No_Of_Cases { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Amount { get; set; }
    public string Despatch { get; set; }
    public string Insu_Yesno { get; set; }
    public int? Insu_Code { get; set; }
    public string InsuPolNo { get; set; }
    public int? InsuDeclNo { get; set; }
    public decimal? InsuNewPolAmt { get; set; }
    public string LrNo { get; set; }
    public DateTime? LrDate { get; set; }
    public decimal? LrFreight { get; set; }
    public decimal? LrWeight { get; set; }
    public decimal? Weight { get; set; }
    public decimal? NetAmount { get; set; }
    public string NetAmountWord { get; set; }
    public decimal? ROff_Amt { get; set; }
    public string Doc_Thr { get; set; }

    public int? Due_Days { get; set; }
    public string LstNo { get; set; }
    public decimal? NetQty { get; set; }
    public string Retailer { get; set; }
    public int? Retailer_Code { get; set; }
    public string Crossing { get; set; }
    public string LrName { get; set; }
    public int? LrCode { get; set; }
    public string LrStation { get; set; }
    public string LrType { get; set; }
    public decimal? LrSNO { get; set; }
    public DateTime? UnloadPaidDate { get; set; }
    public DateTime? CartPaidDate { get; set; }
    public decimal? UnloadPaidAmt { get; set; }
    public decimal? CartPaidAmt { get; set; }
    public string MainOrderNo { get; set; }
    public string GSTNo { get; set; }
    public string GSTInOut { get; set; }
    public int? TaxCode { get; set; }
    public decimal? TaxPer { get; set; }

    public string TaxName { get; set; }
    public string GSTListName { get; set; }

    public int? CgstACCODE { get; set; }
    public int? SgstACODE { get; set; }
    public int? IgstACODE { get; set; }
    public int? CessACODE { get; set; }
    public decimal? CgstPer { get; set; }
    public decimal? SgstPer { get; set; }
    public decimal? IgstPer { get; set; }
    public decimal? CessPer { get; set; }
    public decimal? GSTOnAmt { get; set; }
    public decimal? TotalGSTAmount { get; set; }
    public decimal? CgstAMT { get; set; }
    public decimal? SgstAMT { get; set; }
    public decimal? IgstAMT { get; set; }
    public decimal? CessAMT { get; set; }
    public decimal? GSTInBill { get; set; }
    public decimal? RoundOff { get; set; }

    public string PartyStateCode { get; set; }
    public string StType { get; set; }
    public string GSTStateName { get; set; }
    public string TruckNo { get; set; }
    public string TransMode { get; set; }
    public string HSNCode { get; set; }
    public int? ItemCode { get; set; }

    public int? GSTRound { get; set; }
    public string IsRCM { get; set; }
    public string ITC { get; set; }

    public string EWAYBillNo { get; set; }
    public DateTime? EWAYBillDate { get; set; }
    public string ACKNO { get; set; }
    public DateTime? ACKDATE { get; set; }
    public string IRNNO { get; set; }
    public string IrnStatus { get; set; }
    public byte[] QRIMG { get; set; }
    public int? EInvoiceCond { get; set; }

    public string EWAYBillYn { get; set; }
    public string ShipBillNo { get; set; }
    public DateTime? ShipBillDT { get; set; }
    public string EWAYBillVehNo { get; set; }

    public string USDSymbol { get; set; }
    public decimal? USDRate { get; set; }
    public decimal? USDAmt { get; set; }
    public string Port { get; set; }

    public int? CountryCode { get; set; }
    public int? CityCode { get; set; }
    public decimal? REFUNDCLAIM { get; set; }

    public string TcsYN { get; set; }
    public int? TcsCode { get; set; }
    public decimal? TCSAmount { get; set; }
    public decimal? TCSPer { get; set; }

    public int? TdsCode { get; set; }
    public decimal? TdsPer { get; set; }
    public decimal? TdsAmount { get; set; }

    public decimal? ExportDuty { get; set; }
    public bool AcofReqd { get; set; }

    public bool RoundOff0 { get; set; }

    public int? FldSno01 { get; set; }
    public int? FldSno02 { get; set; }
    public int? FldSno03 { get; set; }
    public int? FldSno04 { get; set; }
    public int? FldSno05 { get; set; }
    public int? FldSno06 { get; set; }
    public int? FldSno07 { get; set; }
    public int? FldSno08 { get; set; }
    public int? FldSno09 { get; set; }
    public int? FldSno10 { get; set; }

    public string FldName01 { get; set; }
    public string FldCalcOn01 { get; set; }
    public string FldLessPlus01 { get; set; }
    public string FldCalcFromTop01 { get; set; }
    public decimal? FldRate01 { get; set; }
    public decimal? FldAmount01 { get; set; }

    public string FldName02 { get; set; }
    public string FldCalcOn02 { get; set; }
    public string FldLessPlus02 { get; set; }
    public string FldCalcFromTop02 { get; set; }
    public decimal? FldRate02 { get; set; }
    public decimal? FldAmount02 { get; set; }

    public string FldName03 { get; set; }
    public string FldCalcOn03 { get; set; }
    public string FldLessPlus03 { get; set; }
    public string FldCalcFromTop03 { get; set; }
    public decimal? FldRate03 { get; set; }
    public decimal? FldAmount03 { get; set; }

    public string FldName04 { get; set; }
    public string FldCalcOn04 { get; set; }
    public string FldLessPlus04 { get; set; }
    public string FldCalcFromTop04 { get; set; }
    public decimal? FldRate04 { get; set; }
    public decimal? FldAmount04 { get; set; }

    public string FldName05 { get; set; }
    public string FldCalcOn05 { get; set; }
    public string FldLessPlus05 { get; set; }
    public string FldCalcFromTop05 { get; set; }
    public decimal? FldRate05 { get; set; }
    public decimal? FldAmount05 { get; set; }

    public string FldName06 { get; set; }
    public string FldCalcOn06 { get; set; }
    public string FldLessPlus06 { get; set; }
    public string FldCalcFromTop06 { get; set; }
    public decimal? FldRate06 { get; set; }
    public decimal? FldAmount06 { get; set; }

    public string FldName07 { get; set; }
    public string FldCalcOn07 { get; set; }
    public string FldLessPlus07 { get; set; }
    public string FldCalcFromTop07 { get; set; }
    public decimal? FldRate07 { get; set; }
    public decimal? FldAmount07 { get; set; }

    public string FldName08 { get; set; }
    public string FldCalcOn08 { get; set; }
    public string FldLessPlus08 { get; set; }
    public string FldCalcFromTop08 { get; set; }
    public decimal? FldRate08 { get; set; }
    public decimal? FldAmount08 { get; set; }

    public string FldName09 { get; set; }
    public string FldCalcOn09 { get; set; }
    public string FldLessPlus09 { get; set; }
    public string FldCalcFromTop09 { get; set; }
    public decimal? FldRate09 { get; set; }
    public decimal? FldAmount09 { get; set; }

    public string FldName10 { get; set; }
    public string FldCalcOn10 { get; set; }
    public string FldLessPlus10 { get; set; }
    public string FldCalcFromTop10 { get; set; }
    public decimal? FldRate10 { get; set; }
    public decimal? FldAmount10 { get; set; }

    public decimal? TotalAddChg { get; set; }
    public decimal? TotalLessChg { get; set; }
    public decimal? WoTcsNetAmt { get; set; }

    public string WeightSLPNo { get; set; }
    public decimal? GrossWt { get; set; }
    public decimal? TareWt { get; set; }
    public decimal? NettWt { get; set; }
    public decimal? TDSOnAmount { get; set; }

    public int? GatePassNo { get; set; }
    public DateTime? GatePassDate { get; set; }
    public string GatePassRefNo { get; set; }
    public string GatePassFVNo { get; set; }
    public string GatePassCreatedBy { get; set; }
    public DateTime? GatePassCreatedDate { get; set; }

    //public bool IsManualGSTAmt { get; set; }
}
