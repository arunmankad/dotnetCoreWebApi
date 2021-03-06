using System.Collections.Generic;
using commander.Models;
using commander.Data;
using Microsoft.AspNetCore.Mvc;

namespace commander.Controllers
{
    // api/commands to be routed to commands controller, but we are not using that wild card approach here 
    // [Route("api/[controller]")]
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        // GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands(){
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);
        }
        // GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}