using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoEmailDemoProject.Models
{
    [Table("Branch_Master", Schema = "dbo")]
    public class Branch_Master : CommDataModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string BranchName { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

        [MaxLength(10)]
        public string BranchShortName { get; set; }

        public bool IsAccounting { get; set; }

        public bool IsTextile { get; set; }

        public bool IsDenim { get; set; }
        public bool IsSPG { get; set; }
        public bool IsProcess { get; set; }
        public bool IsStore { get; set; }
        public bool IsGarment { get; set; }


        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string Add4 { get; set; }
        public int PinCode { get; set; }

        public string StateName { get; set; }
        public string StateType { get; set; }
        public string StateGSTCode { get; set; }
        public int? StateCode { get; set; }

        public string CityName { get; set; }
        public int? CityCode { get; set; }

        public string BankName { get; set; }
        public int? BankCode { get; set; }
        public string BankBranch { get; set; }
        public string BankIFSCCode { get; set; }
        public string BankAcNo { get; set; }

        public string MobileNo1 { get; set; }

        public string Email1 { get; set; }

    }
}