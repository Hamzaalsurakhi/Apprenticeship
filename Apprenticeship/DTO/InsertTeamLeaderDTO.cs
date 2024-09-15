namespace Apprenticeship.DTO
{
    public class InsertTeamLeaderDTO
    {
        public string firstName { get; set; }

        public string secondName { get; set; }

        public string thirdName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }

        public string password { get; set; }
        public string confirmPassword { get; set; }

        public int companyId { get; set; }
    }
}
