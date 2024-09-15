namespace Apprenticeship.Entites
{
    public class SchoolSupervisor:Person
    {
        public List<Traning> apprenticeships { get; set; }
        public School school { get; set; }

        public int schoolId { get; set; }

    }
}
