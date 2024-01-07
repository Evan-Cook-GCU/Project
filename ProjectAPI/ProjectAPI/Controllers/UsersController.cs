using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models.DomainModels;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly List<User> _users;

        public UsersController()
        {
            _users = new List<User>();
        }

        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return _users;
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // POST: api/Users
        [HttpPost]
        public void PostUser([FromBody] User user)
        {
            _users.Add(user);
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void PutUser(int id, [FromBody] User user)
        {
            var existingUser = _users.FirstOrDefault(u => u.Id == id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
                existingUser.Groups = user.Groups;
            }
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            _users.Remove(user);
        }
    }
}
