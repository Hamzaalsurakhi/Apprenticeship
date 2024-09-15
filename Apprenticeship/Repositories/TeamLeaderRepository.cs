using Apprenticeship.Data;
using Apprenticeship.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Apprenticeship.Repositories
{
    public class TeamLeaderRepository :ITeamLeaderRepository
    {
        private ApplicationDbContext _context;
        private readonly UserManager<Person> _userManager;
        public TeamLeaderRepository(ApplicationDbContext context, UserManager<Person> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public List<TeamLeader> GetAllTeamLeaders()
        {
            return _context.teamLeaders.Include(x =>x.company).
                ToList();
        }

        public async Task AddTeamLeader(TeamLeader teamLeader,string password)
        {
            var result = await _userManager.CreateAsync(teamLeader, password);

        }
    }
}
