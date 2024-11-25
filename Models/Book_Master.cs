using System.ComponentModel.DataAnnotations.Schema;

namespace AutoEmailDemoProject.Models
{
    [Table("Book_Master", Schema = "dbo")]
    public class Book_Master : CommDataModel
    {
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Book_Code { get; set; }

        public string Book_Name { get; set; }
        public bool LedgerPost { get; set; }
        public string Form { get; set; }
        public bool Return { get; set; }
        public bool OrderMaintain { get; set; }
        public bool BillFromChallan { get; set; }
        public bool YarnStockYesNo { get; set; }
        public bool Autono { get; set; }
        public int? Sub_Code { get; set; }
        public string Old_Code { get; set; }
        public string TagSeries { get; set; }
        public string Book_Short { get; set; }
        public string Book_Type { get; set; }
        public string DrCr { get; set; }
        public bool DueProcess { get; set; }
        public bool IsPerformaBook { get; set; }
        public bool GreyChallanFromFolding { get; set; }
        public bool BillYesNo { get; set; }
        public bool ShadeGroupInBill { get; set; }
        public bool DesGroupInBill { get; set; }
        public bool TagGroupInBill { get; set; }
        public bool IsExport { get; set; }
        public int? SUBCODE { get; set; }
        public int? GSTYesNo { get; set; }
        public string ACTUALBOOK { get; set; }
        public string ChallanBooks { get; set; }
        public string BillBooks { get; set; }
        public string BillFormat { get; set; }
        public int? ShirtingBook { get; set; }
        public string BooksOrigin { get; set; }

        public string UnitCodes { get; set; }
        public string GwnCodes { get; set; }
    }
}
