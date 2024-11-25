using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoEmailDemoProject.Models
{
    [Table("Account_Master", Schema = "dbo")]
    public class Account_Master : ApprovedCommDataModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ac_Code { get; set; }

        public string Ac_Name { get; set; }

        public string Name { get; set; }
        public string Alias { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }

        public int Group_Code { get; set; }
        public string Group_Name { get; set; }

        public string Group_Type { get; set; }
        public string BillToBill { get; set; }
        public decimal? Op_Bal { get; set; }
        public string Op_Type { get; set; }
        public decimal? Clo_Bal { get; set; }
        public string Clo_Type { get; set; }
        public string Agent { get; set; }
        public int? Agent_Code { get; set; }
        public string AgYesNo { get; set; }
        public string Dispatch { get; set; }

        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Pan { get; set; }
        public string LSTNo { get; set; }
        public string CstNo { get; set; }
        public decimal? IntPer { get; set; }
        public decimal? CdPer { get; set; }
        public decimal? Limit { get; set; }
        public decimal? ComPer { get; set; }
        public decimal? RdPer { get; set; }
        public int Side_Days { get; set; }
        public decimal? Balance { get; set; }
        public decimal? StockBal { get; set; }
        public decimal? CreditLimit { get; set; }
        public int? CreditDays { get; set; }
        public int? Parent_Code { get; set; }

        public string Sub_Led { get; set; }
        public int Typ_cd { get; set; }
        public string Typ_cdName { get; set; }

        public int? Trans_Code { get; set; }
        public bool Insu_Yn { get; set; }
        public string Mobile { get; set; }
        public string EMail { get; set; }
        public string Eccno { get; set; }
        public string Range { get; set; }
        public int? StateCode { get; set; }

        public int? CityCode { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }

        public int? LessPer { get; set; }
        public int? AddPer { get; set; }
        public int? OnMtrs { get; set; }
        public int? OnMtrsRate { get; set; }
        public bool ItemYesno { get; set; }
        public bool Qty { get; set; }
        public decimal? ThanRate { get; set; }
        public decimal? LumpRate { get; set; }
        public decimal? PCSRate { get; set; }
        public string Rate_Name { get; set; }
        public int? Rate_Code { get; set; }
        public string Rate_Type { get; set; }
        public string Post_Desp { get; set; }

        public string ContactPerson { get; set; }

        public decimal? TransportPer { get; set; }
        public string Fax { get; set; }
        public int? Samp_code { get; set; }
        public DateTime? Cust_Dt { get; set; }
        public int? CustTypeCode { get; set; }
        public int? AreaCode { get; set; }
        public int? PaymentTermsCode { get; set; }
        public int? NOLR { get; set; }
        public string GSTStateCode { get; set; }
        public string Country { get; set; }
        public string StateType { get; set; }
        public string GSTInOut { get; set; }
        public string GSTyn { get; set; }
        public string GSTInBill { get; set; }
        public decimal? TDSPer { get; set; }
        public int? GSTListCode { get; set; }
        public string GSTListName { get; set; }
        public int? TaxCode { get; set; }
        public string TaxName { get; set; }
        public decimal? CgstPer { get; set; }
        public decimal? SgstPer { get; set; }
        public decimal? IgstPer { get; set; }
        public decimal? CessPer { get; set; }
        public string AdharNumber { get; set; }
        public string UANNumber { get; set; }
        public string ExRange { get; set; }
        public string ExcRate { get; set; }
        public string ExDivision { get; set; }
        public string ExecCno { get; set; }
        public string GSTNo { get; set; }
        public string CinNumber { get; set; }
        public decimal? TaxPer { get; set; }
        public string PartyType { get; set; }
        public string TanNo { get; set; }
        public string TanDetail { get; set; }
        public string BankName { get; set; }
        public int? BankCode { get; set; }
        public string BankBranch { get; set; }
        public string BankIFSCCode { get; set; }
        public string BankAccountNo { get; set; }
        public DateTime? GSTApplyDate { get; set; }
        public string PortCode { get; set; }
        public string ECommGSTNo { get; set; }
        public string CdnUrType { get; set; }
        public string CDON { get; set; }
        public string TDON { get; set; }
        public string RDON { get; set; }
        public decimal? TDPer { get; set; }
        public string COMON { get; set; }
        public string PinCode { get; set; }
        public int? SalesmanCode1 { get; set; }
        public int? SalesmanCode2 { get; set; }

        public string TDSYN { get; set; }
        public string TCSYN { get; set; }

        public int? PartyGroupCode { get; set; }
        public string PartyGroupName { get; set; }

        public string MsmeType { get; set; }
        public string MsmeNumber { get; set; }

        public string PlantCodes { get; set; }
    }
}
