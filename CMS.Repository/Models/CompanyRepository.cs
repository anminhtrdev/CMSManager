using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CMS.Contracts.IModels;
using CMS.Entities.Models;
using CMS.Repository.Repository;

namespace CMS.Repository.Models
{
    internal sealed class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public void CreateCompany(Company company) => Create(company);

        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
        FindAll(trackChanges)
        .OrderBy(c => c.Name)
        .ToList();

        public Company GetCompany(Guid companyId, bool trackChanges) =>
        FindByCondition(c => c.Id.Equals(companyId), trackChanges)
        .SingleOrDefault();

        public IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
        FindByCondition(x => ids.Contains(x.Id), trackChanges)
        .ToList();

        public void DeleteCompany(Company company) => Delete(company);
    }
}
