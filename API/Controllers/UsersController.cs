using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        //Vid 15
        private readonly DataContext _context;
        //Injecting the dependecies
        //1 - DataContext dependency

        public UsersController(DataContext context)
        {
            _context = context;
        }
        
        //endpoint 1: Get all users, the main end point
        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetAllUsers()
        {
            return _context.Users.ToList();
        }
        //Endpoint 2: Get user by Id
        [HttpGet]
        [Route("{id}")]
        public ActionResult<AppUser> GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id==id);
        }
    }
}