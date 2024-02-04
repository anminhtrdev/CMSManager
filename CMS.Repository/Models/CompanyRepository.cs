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
        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
        FindAll(trackChanges)
        .OrderBy(c => c.Name)
        .ToList();
    }
}
