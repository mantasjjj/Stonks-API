using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StonksAPI.Services;

namespace StonksAPI.Controllers
{
    [Route("api/progress")]
    [ApiController]
    public class ProgressAdviceController : ControllerBase
    {
        private readonly IProgressAdviceServices _services;

        public ProgressAdviceController(IProgressAdviceServices services)
        {
            _services = services;
        }

        [HttpGet]
        [Route("GetAdvice")]
        public ActionResult<Dictionary<string, double>> GetAdvice(double income)
        {
            var advice = _services.GetAdvice(income);

            return advice;
        }


        [HttpGet]
        [Route("GetPotencialScore")]
        public ActionResult<double> GetPotencialScore(double income)
        {
            var score = _services.GetPotencialScore(income);

            return score;
        }

        [HttpGet]
        [Route("RecommendedValues")]
        public ActionResult<Dictionary<string, double>> RecommendedValues(double usedForExpenses) 
        {
            var values = _services.RecommendedValues(usedForExpenses);

            return values;
        }
    }
}
