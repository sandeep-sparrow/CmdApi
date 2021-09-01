using System.Collections.Generic;
using CmdApi.DAL;
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
        public ActionResult<IEnumerable<string>> GetString(){
            return new string[] {"This", "Is", "New", "Mainframe"};
        }
    }
}