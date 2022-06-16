using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Commander.Controllers
{
    //api/commands
    [ApiController]
    [Route("api/commands")]
    public class CommmandsController  : ControllerBase
    {
        private readonly MockCommanderRepo _Repository = new MockCommanderRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _Repository.GetAllCommands();

            return Ok(commandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandbyId(int id) 
        {
            var commandItem = _Repository.GetCommandbyId(id);

            return Ok(commandItem);
        }
    }
}