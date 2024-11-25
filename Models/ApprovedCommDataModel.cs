namespace AutoEmailDemoProject.Models
{
    public class ApprovedCommDataModel : CommDataModel
    {
        /// <summary>
        /// ApprovedCommDataModel
        /// </summary>
        public bool IsApproved { get; set; }

        /// <summary>
        /// ApprovedCommDataModel
        /// </summary>
        public string ApprovedBy { get; set; }

        /// <summary>
        /// ApprovedCommDataModel
        /// </summary>
        public DateTime? ApprovedDate { get; set; }
    }
}
