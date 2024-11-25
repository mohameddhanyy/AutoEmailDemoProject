using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoEmailDemoProject.Models;

[Table("Selvage_Master", Schema = "dbo")]
public class Selvage_Master : ApprovedCommDataModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Selvg_Code { get; set; }

    public string Selvg_Name { get; set; }

    public bool PartyYes { get; set; }
    public int? Ac_Code { get; set; }
    public string Party_Name { get; set; }

    public bool ItemYes { get; set; }
    public int? Item_code { get; set; }
    public string Item_Name { get; set; }

    public string Alias { get; set; }

    public DateTime? DISDATE { get; set; }
}
