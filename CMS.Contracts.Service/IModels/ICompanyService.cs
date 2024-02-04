using CMS.Entities.Models;

namespace CMS.Contracts.Service.IModels
{
    public interface ICompanyService
    {
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
    }
}
