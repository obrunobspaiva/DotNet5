using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using UsingSwitch.Domain;
using UsingSwitch.Model;

namespace UsingSwitch.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculationIMCController: ControllerBase
    {
        private readonly ILogger<CalculationIMCController> _logger;

        public CalculationIMCController(ILogger<CalculationIMCController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<PersonalMeasuresModel> Get()
        {
            var people = new List<PersonalMeasuresModel>
            {
                new PersonalMeasuresModel() { Weight = 70, Height = 2.05 },
                new PersonalMeasuresModel() { Weight = 75, Height = 1.81 },
                new PersonalMeasuresModel() { Weight = 130, Height = 1.90 },
                new PersonalMeasuresModel() { Weight = 150, Height = 1.60 },
                new PersonalMeasuresModel() { Weight = 70, Height = 1.54 }
            };

            foreach (var p in people)
                p.State = CalculationIMCDomain.WeightAnalysis(p.IMC);

            return people;
        }
    }
}
