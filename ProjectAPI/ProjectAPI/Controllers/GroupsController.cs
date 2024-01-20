using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models.DomainModels;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        

        public GroupsController()
        {
            
        }

        // GET: api/Groups
        [HttpGet]
        public ActionResult<IEnumerable<GroupModel>> GetGroups()
        {
            using (var context = new ProjectContext())
            {
                var groups = context.Groups.ToList();
                return Ok(groups);
            }
        }

        // GET: api/Groups/5
        [HttpGet("{id}")]
        public ActionResult<GroupModel> GetGroup(int id)
        {
            using (var context = new ProjectContext())
            {
                var group = context.Groups.FirstOrDefault(g => g.Id == id);
                if (group == null)
                {
                    return NotFound();
                }
                return Ok(group);
            }
        }

        // POST: api/Groups
        [HttpPost]
        public void PostGroup([FromBody] GroupModel group)
        {
            using (var context = new ProjectContext())
            {
                context.Groups.Add(group);
                context.SaveChanges();
            }
        }

        // PUT: api/Groups/5
        [HttpPut("{id}")]
        public void PutGroup(int id, [FromBody] GroupModel group)
        {
            using (var context = new ProjectContext())
            {
                var existingGroup = context.Groups.FirstOrDefault(g => g.Id == id);
                if (existingGroup != null)
                {
                    existingGroup.Name = group.Name;
                    existingGroup.Description = group.Description;
                    existingGroup.DisplayName = group.DisplayName;
                    existingGroup.Users = group.Users;
                    existingGroup.Rating = group.Rating;
                    context.SaveChanges();
                }
            }
            
        }

        // DELETE: api/Groups/5
        [HttpDelete("{id}")]
        public void DeleteGroup(int id)
        {
            using (var context = new ProjectContext())
            {
                var group = context.Groups.FirstOrDefault(g => g.Id == id);
                context.Groups.Remove(group);
                context.SaveChanges();
            }
        }
    }
}
