namespace Apprenticeship.Entites
{
    public class TeamLeader :Person
    {
        public List<Traning> apprenticeships { get; set; }
        public Company company { get; set; }
        public int companyId { get; set; }


    }
}
