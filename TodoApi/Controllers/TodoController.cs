using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;
        
        public TodoController(TodoContext context)
        {
            _context = context;

            if(_context.TodoItems.)
            {

            }
        }
    }
}
