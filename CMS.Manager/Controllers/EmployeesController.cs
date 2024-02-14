﻿using CMS.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace CMS.Manager.Controllers
{
    [Route("api/companies/{companyId}/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IServiceManager _service;
        public EmployeesController(IServiceManager service) => _service = service;
    }
}
