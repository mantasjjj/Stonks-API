using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StonksAPI.Services;
using System.Web.Http.Cors;

namespace StonksAPI.Controllers
{
    [Route("api/financialGoal")]
    [ApiController]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class FinancialGoalController : ControllerBase
    {
        private readonly IFinancialGoalServices _services;

        public FinancialGoalController(IFinancialGoalServices services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("AddFinancialGoal")]
        public ActionResult<FinancialGoal> AddFinancialGoal(FinancialGoal goals)
        {
            var financialGoals = _services.AddFinancialGoal(goals);

            if (financialGoals == null) 
            {
                return BadRequest();
            }

            return financialGoals;
        }

        [HttpGet]
        [Route("GetFinancialGoals")]
        public ActionResult<Dictionary<string, FinancialGoal>> GetFinancialGoals() {

            var financialGoals = _services.GetFinancialGoals();

            if (financialGoals.Count == 0) 
            {
                return NotFound();
            }

            return financialGoals;
        }

        [HttpDelete]
        [Route("DeleteFinancialGoal")]
        public ActionResult<string> DeleteFinancialGoal(string goalName)
        {
            var financialGoals = _services.RemoveFinancialGoal(goalName);

            if (financialGoals == null)
            {
                return BadRequest();
            }

            return financialGoals;
        }
    }
}
