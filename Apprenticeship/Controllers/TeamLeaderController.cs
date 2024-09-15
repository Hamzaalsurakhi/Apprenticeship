using Apprenticeship.DTO;
using Apprenticeship.Entites;
using Apprenticeship.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Apprenticeship.Controllers
{
    public class TeamLeaderController : Controller
    {
        private  ITeamLeaderRepository _teamLeaderRepository;
        private ICompanyRepository _companyRepository;
        public TeamLeaderController(ITeamLeaderRepository teamLeaderRepository,ICompanyRepository companyRepository)
        {
            _teamLeaderRepository=teamLeaderRepository;
            _companyRepository=companyRepository;
        }
        public IActionResult Index()
        {
            ViewBag.teamLeaders=_teamLeaderRepository.GetAllTeamLeaders();
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.Companies=_companyRepository.GetAll();
            return View();
        }

        [HttpPost]
        public async Task< IActionResult> Create(InsertTeamLeaderDTO teamLeaderDTO)
        {
            TeamLeader teamLeader = new TeamLeader();
            teamLeader.firstName=teamLeaderDTO.firstName;
            teamLeader.secondName=teamLeaderDTO.secondName;
            teamLeader.thirdName=teamLeaderDTO.thirdName;
            teamLeader.lastName=teamLeaderDTO.lastName;
            teamLeader.UserName=teamLeaderDTO.email;
            teamLeader.Email=teamLeaderDTO.email;
            teamLeader.NormalizedEmail=teamLeaderDTO.email.ToUpper();
            teamLeader.NormalizedUserName=teamLeaderDTO.email.ToUpper();
            teamLeader.EmailConfirmed=true;
            teamLeader.companyId=teamLeaderDTO.companyId;

            await _teamLeaderRepository.AddTeamLeader(teamLeader,teamLeaderDTO.password);
            return RedirectToAction("Index");
        }
    }
}
