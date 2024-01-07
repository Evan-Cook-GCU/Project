using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Models.DomainModels;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GridElementController : ControllerBase
    {
        private readonly List<GridElement> _gridElements;

        public GridElementController()
        {
            _gridElements = new List<GridElement>();
        }

        // GET: api/GridElement
        [HttpGet]
        public ActionResult<IEnumerable<GridElement>> GetGridElements()
        {
            return _gridElements;
        }

        // GET: api/GridElement/5
        [HttpGet("{id}")]
        public ActionResult<GridElement> GetGridElement(int id)
        {
            var gridElement = _gridElements.FirstOrDefault(g => g.Id == id);

            if (gridElement == null)
            {
                return NotFound();
            }

            return gridElement;
        }

        // POST: api/GridElement
        [HttpPost]
        public void PostGridElement([FromBody] GridElement gridElement)
        {
            _gridElements.Add(gridElement);
        }

        // PUT: api/GridElement/5
        [HttpPut("{id}")]
        public void PutGridElement(int id, [FromBody] GridElement gridElement)
        {
            var existingGridElement = _gridElements.FirstOrDefault(g => g.Id == id);
            if (existingGridElement != null)
            {
                existingGridElement.Name = gridElement.Name;
                existingGridElement.X = gridElement.X;
                existingGridElement.Y = gridElement.Y;
                existingGridElement.Width = gridElement.Width;
                existingGridElement.Height = gridElement.Height;
                existingGridElement.GridId = gridElement.GridId;
                existingGridElement.Value = gridElement.Value;
                existingGridElement.Type = gridElement.Type;
            }
        }

        // DELETE: api/GridElement/5
        [HttpDelete("{id}")]
        public void DeleteGridElement(int id)
        {
            var gridElement = _gridElements.FirstOrDefault(g => g.Id == id);
            _gridElements.Remove(gridElement);
        }
    }
}
