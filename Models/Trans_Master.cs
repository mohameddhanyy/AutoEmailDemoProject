using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoEmailDemoProject.Models
{
    [Table("Trans_Master", Schema = "dbo")]
    public class Trans_Master : ApprovedCommDataModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Trans_Code { get; set; }

        public string Trans_Name { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Phone { get; set; }
        public string Insu_yn { get; set; }
        public string Mobile { get; set; }
        public string IsTravels { get; set; }
        public decimal? Freight { get; set; }
        public string StateName { get; set; }
        public string AdharNumber { get; set; }
        public string UANNumber { get; set; }
        public string Pan { get; set; }
        public string EMail { get; set; }
        public string TransType { get; set; }
        public string GSTNo { get; set; }
        public string CinNumber { get; set; }
        public string StateType { get; set; }
        public string StateGSTCode { get; set; }
        public int? CityCode { get; set; }
        public string LstNo { get; set; }
    }
}
