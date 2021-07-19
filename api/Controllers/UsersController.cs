using System.Collections.Generic;
using System.Linq;
using api.Data;
using api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        //Construtor
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers() {
            return _context.Users.ToList();
        }

        // api/users/3
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id) {
            return _context.Users.Find(id);
        }
    }
}