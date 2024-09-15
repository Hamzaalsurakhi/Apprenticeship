namespace Apprenticeship.Entites
{
    public class Assignment
    {
        public int assignmentId { get; set; }

        public string assignmentTitle { get; set; }

        public string assignmentDescription { get; set; }

        public string assignmentNote { get; set; }

        public Traning traning { get; set; }
        public int traningId { get; set; }

        public List<Report> reports { get; set; }

        public List<AssignmentObjective> assignmentObjectives { get; set; }


    }
}
