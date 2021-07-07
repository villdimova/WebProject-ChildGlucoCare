namespace ChildGlucoCare.Web.ViewModels.Statistics
{
    public class BloodGlucoseReportViewModel
    {
        public string PeriodStart { get; set; }

        public string LowPercentage { get; set; }

        public string HighPercentage { get; set; }

        public string NormalPercentage { get; set; }

        public int BloodGlucoseRecords { get; set; }

        public string AvgBloodGlucose { get; set; }
    }
}
