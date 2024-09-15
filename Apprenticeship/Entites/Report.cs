namespace Apprenticeship.Entites
{
    public class Report
    {
        public int reportId { get; set; }

        public string reportName { get; set; }

        public string reportDescription { get; set; }

        public string  reportNote { get; set; }

        public Assignment assignment { get; set; }
        public int assignmentId { get; set; }

        public ReportStatus reportStatus { get; set; }

        public int reportStatusId { get; set; }


    }
}
