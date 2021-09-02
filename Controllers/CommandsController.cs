using System.Collections.Generic;
using CmdApi.DAL;
using CmdApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CmdApi.Controllers{

    [ApiController]
    [Route("api/[Controller]")]
    public class CommandsController : Controller{

        private readonly CommandDbContext _context;

        public CommandsController(CommandDbContext context)
        {
            _context = context;
        }

        //GET:      api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetCommands(){

            return _context.CommandItems;
        }

        //GET:      api/commands/id
        [HttpGet("{Id}")]
        public ActionResult<Command> GetCommandItem(int id){

            var commandItem = _context.CommandItems.Find(id);
            if(commandItem == null){
                return NotFound();
            }

            return commandItem;

        }

        //POST:     api/commands
        [HttpPost]
        public ActionResult<Command> PostCommandItem(Command command){

            _context.CommandItems.Add(command);
            _context.SaveChanges();

            return CreatedAtAction("GetCommandItem", new Command{Id = command.Id}, command);
  
        }

        //PUT:      api/command
        [HttpPut("{Id}")]
        public ActionResult PutCommandItem(int id, Command command){

            if(id != command.Id){
                return BadRequest();
            }

            _context.Entry(command).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        //DELETE:       api/commands/id
        [HttpDelete("{Id}")]
        public ActionResult<Command> DeleteCommandItem(int id){

            var commandItem = _context.CommandItems.Find(id);

            if(commandItem == null){
                return NotFound();
            }

            _context.CommandItems.Remove(commandItem);
            _context.SaveChanges();

            return NoContent();
        }
    }
}