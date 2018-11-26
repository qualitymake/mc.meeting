using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mc.meeting.Models;
using mc.meeting.DAL;

namespace mc.meeting.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyAccountController : ControllerBase
    {
        [HttpPut]
        public bool Update(CompanyAccountBE companyAccount)
        {
            try
            {
                CompanyAccount objCompanyAccount = new CompanyAccount();
                objCompanyAccount.UpdateCompanyAccount(companyAccount);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}