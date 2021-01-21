using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStackDemoTherese.Core.ApplicationService;
using FullStackDemoTherese.Core.DomainModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackDemoTherese.UserInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeagueTableController : ControllerBase
    {
        private readonly LeagueTableService _leagueTableService;

        public LeagueTableController(LeagueTableService leagueTableService)
        {
            _leagueTableService = leagueTableService;
        }

        [HttpGet]
        public ActionResult<LeagueTable> Get()
        {
            return _leagueTableService.GetLeagueTable();
        }
    }
}
