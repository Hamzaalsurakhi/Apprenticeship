using Apprenticeship.Data;
using Apprenticeship.Entites;

namespace Apprenticeship.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private ApplicationDbContext _context;

        public CompanyRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<Company> GetAll()
        {
            return _context.companies.ToList();
        }
    }
}
