﻿using CMS.Contracts.IRepository;
using CMS.Contracts.Logger;
using CMS.Contracts.Service.IModels;
using CMS.Contracts.Service;
using CMS.Service.Models;
using CMS.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyService;
        private readonly Lazy<IEmployeeService> _employeeService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager
       logger)
        {
            _companyService = new Lazy<ICompanyService>(() => new
          CompanyService(repositoryManager, logger));
            _employeeService = new Lazy<IEmployeeService>(() => new
          EmployeeService(repositoryManager, logger));
        }

        public ICompanyService CompanyService => _companyService.Value;
        public IEmployeeService EmployeeService => _employeeService.Value;

    }
}
