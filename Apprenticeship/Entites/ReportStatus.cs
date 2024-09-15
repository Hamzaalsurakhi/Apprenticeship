namespace Apprenticeship.Entites
{
    public class ReportStatus //lookup tables
    {
        public int reportStatusId { get; set; }

        public string statusName { get; set; }

        public List<Report> reports { get; set; }
    }
}

