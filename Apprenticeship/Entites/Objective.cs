namespace Apprenticeship.Entites
{
    public class Objective
    {
        public int objectiveId { get; set; }

        public string objectiveName { get; set; }

        public List<ObjectiveSkills> objectiveSkills { get; set; }

        public List<TraningObjective> traningObjectives { get; set; }
        public List<AssignmentObjective> assignmentObjectives { get; set; }



    }
}
