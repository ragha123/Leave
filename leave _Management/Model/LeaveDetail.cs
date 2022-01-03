namespace leave__Management.Model
{
    public partial class LeaveDetail
    {
        public int TotalMannedHours { get; set; }
        public int? LeaveHours { get; set; }
        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
