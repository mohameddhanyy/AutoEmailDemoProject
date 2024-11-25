using AutoEmailDemoProject.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoEmailDemoProject;

[Table("Item_Master", Schema = "dbo")]
public class Item_Master : ApprovedCommDataModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Item_Code { get; set; }

    public string Item_Name { get; set; }
    public string ShortName { get; set; }
    public string Group_Item_Name { get; set; }
    public int Group_Item_Code { get; set; }

    public decimal? Purchase_Rate { get; set; }
    public decimal? Lump_Rate { get; set; }
    public decimal? Than_Rate { get; set; }
    public decimal? Pcs_Rate { get; set; }
    public decimal? Job_Rate { get; set; }
    public string Unit { get; set; }
    public string Description { get; set; }
    public decimal? Width { get; set; }
    public decimal? FinishWidth { get; set; }
    public string Design_From { get; set; }
    public string Design_To { get; set; }
    public int? Count { get; set; }
    public int? Blend { get; set; }
    public string Shade { get; set; }
    public string NewShade { get; set; }
    public decimal? Wastage { get; set; }
    public decimal? FinishGSM { get; set; }
    public int? Cat_Code { get; set; }
    public string Cat_Name { get; set; }

    public int? MainCat_Code { get; set; }
    public string MainCat_Name { get; set; }

    public string FdPd { get; set; }
    public decimal? CostRate { get; set; }
    public decimal? Weight { get; set; }
    public string Group1 { get; set; }
    public string Weev { get; set; }
    public string Grade { get; set; }
    public int? Grade_Code { get; set; }
    public int? GroupCode { get; set; }
    public string LocCode { get; set; }
    public string ItemCodeLikeYn { get; set; }
    public int? ItemCodeLike { get; set; }
    public string ItemNameLike { get; set; }
    public decimal? Variance { get; set; }
    public decimal? SCuts { get; set; }

    public decimal? FinishWt { get; set; }
    public decimal? PackWt { get; set; }
    public string IsPrimary { get; set; }
    public string SelvgYn { get; set; }
    public string SelvgName { get; set; }
    public int? SelvgCode { get; set; }
    public string CType { get; set; }
    public decimal? Count1 { get; set; }
    public decimal? Count2 { get; set; }
    public decimal? Denier { get; set; }
    public string LikeYn { get; set; }
    public string PartyYesNo { get; set; }
    public int? PartyCode { get; set; }
    public int? FLD1GroupCode { get; set; }
    public int? FLD2GroupCode { get; set; }
    public int? FLD3GroupCode { get; set; }
    public int? FLD4GroupCode { get; set; }
    public int? FLD5GroupCode { get; set; }
    public int? FLD6GroupCode { get; set; }
    public int? FLD7GroupCode { get; set; }
    public int? FLD8GroupCode { get; set; }
    public int? FLD9GroupCode { get; set; }
    public int? FLD10GroupCode { get; set; }
    public string MFLD1Group { get; set; }
    public string MFLD2Group { get; set; }
    public string MFLD3Group { get; set; }
    public string MFLD4Group { get; set; }
    public string MFLD5Group { get; set; }
    public string MFLD6Group { get; set; }
    public string MFLD7Group { get; set; }
    public string MFLD8Group { get; set; }
    public string MFLD9Group { get; set; }
    public string MFLD10Group { get; set; }
    public int? BItemCode { get; set; }
    public string BItemYn { get; set; }
    public int TaxCode { get; set; }
    public string TaxName { get; set; }
    public decimal? CgstPer { get; set; }
    public decimal? SgstPer { get; set; }
    public decimal? IgstPer { get; set; }
    public decimal? CessPer { get; set; }
    public decimal? CgstCessPer { get; set; }
    public decimal? SgstCessPer { get; set; }
    public decimal? IgstCessPer { get; set; }
    public int? GSTListCode { get; set; }
    public string GSTListName { get; set; }
    public string HSNCode { get; set; }
    public decimal? GreyRate { get; set; }

    public string Weave { get; set; }
    public decimal? Reed { get; set; }
    public decimal? Pick { get; set; }
    public decimal? RSpace { get; set; }
    public decimal? Dent { get; set; }

    public int? YarnCountCode { get; set; }
    public int? YarnBlendCode { get; set; }
    public string YarnCountName { get; set; }
    public string YarnBlendName { get; set; }

    public string PlantCodes { get; set; }
}
