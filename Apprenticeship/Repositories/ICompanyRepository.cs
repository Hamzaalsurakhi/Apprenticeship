using Apprenticeship.Entites;

namespace Apprenticeship.Repositories
{
    public interface ICompanyRepository
    {
        public List<Company> GetAll();
    }
}
