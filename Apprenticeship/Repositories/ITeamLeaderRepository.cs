using Apprenticeship.Entites;

namespace Apprenticeship.Repositories
{
    public interface ITeamLeaderRepository
    {
        public List<TeamLeader> GetAllTeamLeaders();
        public  Task AddTeamLeader(TeamLeader teamLeader, string password);
    }
}
