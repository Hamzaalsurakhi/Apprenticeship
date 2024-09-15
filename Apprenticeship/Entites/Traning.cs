namespace Apprenticeship.Entites
{
    public class Traning  //relationShip
    {
        public int TraningId  { get; set; } //PK Unique Constranint

        public Student student { get; set; }
        public TeamLeader teamLeader { get; set; }
        public SchoolSupervisor schoolSupervisor { get; set; }


        public string studentId  { get; set; }

        public string teamLeaderId { get; set; }

        public string schoolSupervisorId { get; set; }

        public DateTime startDate { get; set; }

        public DateTime EndDate { get; set; }
        public List<Assignment> assignments  { get; set; }

        public List<TraningObjective> traningObjectives { get; set; }



    }
}
