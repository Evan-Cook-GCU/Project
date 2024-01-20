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
        private readonly List<UserModel> _users;
        //private readonly IRepository<UserDomainModel> _repo;

        public UsersController(
           // IRepository<UserDomainModel> repo
            )
        {
           // _repo = repo;
        }

        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<UserModel>> GetUsers()
        {
            using (var context = new ProjectContext())
            {
                var users = context.Users.ToList();
                return Ok(users);
            }
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult<UserModel> GetUser(int id)
        {
            using (var context = new ProjectContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == id);
                if (user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }   
            
        }
        // GET: api/Users/5
        [HttpGet("{username}/{password}")]
        public ActionResult<UserModel> GetUser(String username,
            string password)
        {
            using (var context = new ProjectContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Name == username
                               && u.Password == password);
                if (user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
        }
        // POST: api/Users
        [HttpPost]
        public void PostUser([FromBody] UserModel user)
        {
            using (var context = new ProjectContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void PutUser(int id, [FromBody] UserModel user)
        {
           using (var context = new ProjectContext())
            {
                var existingUser = context.Users.FirstOrDefault(u => u.Id == id);
                if (existingUser != null)
                {
                    existingUser.Name = user.Name;
                    existingUser.Password = user.Password;
                    existingUser.Email = user.Email;
                }
                context.SaveChanges();
            };
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            using (var context = new ProjectContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == id);
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }
    }
}
