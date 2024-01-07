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
        private readonly List<Group> _groups;

        public GroupsController()
        {
            _groups = new List<Group>();
        }

        // GET: api/Groups
        [HttpGet]
        public ActionResult<IEnumerable<Group>> GetGroups()
        {
            return _groups;
        }

        // GET: api/Groups/5
        [HttpGet("{id}")]
        public ActionResult<Group> GetGroup(int id)
        {
            var group = _groups.FirstOrDefault(g => g.Id == id);

            if (group == null)
            {
                return NotFound();
            }

            return group;
        }

        // POST: api/Groups
        [HttpPost]
        public void PostGroup([FromBody] Group group)
        {
            _groups.Add(group);
        }

        // PUT: api/Groups/5
        [HttpPut("{id}")]
        public void PutGroup(int id, [FromBody] Group group)
        {
            var existingGroup = _groups.FirstOrDefault(g => g.Id == id);
            if (existingGroup != null)
            {
                existingGroup.Name = group.Name;
                existingGroup.Description = group.Description;
                existingGroup.DisplayName = group.DisplayName;
                existingGroup.Users = group.Users;
                existingGroup.Rating = group.Rating;
            }
        }

        // DELETE: api/Groups/5
        [HttpDelete("{id}")]
        public void DeleteGroup(int id)
        {
            var group = _groups.FirstOrDefault(g => g.Id == id);
            _groups.Remove(group);
        }
    }
}
