using Microsoft.AspNetCore.Mvc;
using Commander.Models;
using Commander.data;
using Commander.Data;

namespace Commander.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;    
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands() 
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id) 
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}