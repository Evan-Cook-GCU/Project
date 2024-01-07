using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models.DomainModels;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GridController : ControllerBase
    {
        private readonly List<Grid> _grids;

        public GridController()
        {
            _grids = new List<Grid>();
        }

        // GET: api/Grid
        [HttpGet]
        public ActionResult<IEnumerable<Grid>> GetGrids()
        {
            return _grids;
        }

        // GET: api/Grid/5
        [HttpGet("{id}")]
        public ActionResult<Grid> GetGrid(int id)
        {
            var grid = _grids.FirstOrDefault(g => g.Id == id);

            if (grid == null)
            {
                return NotFound();
            }

            return grid;
        }

        // POST: api/Grid
        [HttpPost]
        public void PostGrid([FromBody] Grid grid)
        {
            _grids.Add(grid);
        }

        // PUT: api/Grid/5
        [HttpPut("{id}")]
        public void PutGrid(int id, [FromBody] Grid grid)
        {
            var existingGrid = _grids.FirstOrDefault(g => g.Id == id);
            if (existingGrid != null)
            {
                existingGrid.Name = grid.Name;
                existingGrid.GridElements = grid.GridElements;
                existingGrid.groupId = grid.groupId;
            }
        }

        // DELETE: api/Grid/5
        [HttpDelete("{id}")]
        public void DeleteGrid(int id)
        {
            var grid = _grids.FirstOrDefault(g => g.Id == id);
            _grids.Remove(grid);
        }
    }
}
