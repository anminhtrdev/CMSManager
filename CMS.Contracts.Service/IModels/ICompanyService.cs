using CMS.Entities.Models;
using CMS.Shared.DataTransferObjects;

namespace CMS.Contracts.Service.IModels
{
    public interface ICompanyService
    {
        IEnumerable<CompanyDto> GetAllCompanies(bool trackChanges);
        CompanyDto GetCompany(Guid companyId, bool trackChanges);
    }
}
