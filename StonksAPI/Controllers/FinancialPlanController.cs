using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StonksAPI.Services;

namespace StonksAPI.Controllers
{
    [Route("api/financialPlan")]
    [ApiController]
    public class FinancialPlanController : ControllerBase
    {
        private readonly IFinancialPlanServices _services;

        public FinancialPlanController(IFinancialPlanServices services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("AddFinancialPlan")]
        public ActionResult<FinancialPlan> AddFinancialPlan(FinancialPlan plan)
        {
            var financialPlans = _services.AddFinancialPlan(plan);

            if (financialPlans == null)
            {
                return BadRequest();
            }

            return financialPlans;
        }

        [HttpGet]
        [Route("GetFinancialPlan")]
        public ActionResult<List<FinancialPlan>> GetFinancialPlan()
        {

            var financialPlans = _services.GetFinancialPlan();

            if (financialPlans.Count == 0)
            {
                return NotFound();
            }

            return financialPlans;
        }
    }
}
