using Microsoft.AspNetCore.Mvc;
using ShoeFeature.Services;

namespace ShoeFeature.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoeFeatureController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ShoeFeature>> GetAllShoeFeatures()
        {
            var shoeFeatures = ShoeFeaurteService.GetAll();
            return Ok(shoeFeatures);
        }

        [HttpGet("{id}")]
        public ActionResult<ShoeFeature> GetShoeFeatureById(int id)
        {
            var shoeFeature = ShoeFeaurteService.GetById(id);

            if (shoeFeature == null)
            {
                return NotFound();
            }

            return Ok(shoeFeature);
        }

        [HttpPost]
        public ActionResult<ShoeFeature> AddShoeFeature([FromBody] ShoeFeature shoeFeature)
        {
            if (shoeFeature == null)
            {
                return BadRequest("Invalid data.");
            }

            ShoeFeaurteService.Add(shoeFeature);
            return CreatedAtAction(nameof(GetShoeFeatureById), new { id = shoeFeature.Id }, shoeFeature);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateShoeFeature(int id, [FromBody] ShoeFeature updatedShoeFeature)
        {
            var shoeFeature = ShoeFeaurteService.GetById(id);

            if (shoeFeature == null)
            {
                return NotFound();
            }

            updatedShoeFeature.Id = id;
            ShoeFeaurteService.Update(updatedShoeFeature);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteShoeFeature(int id)
        {
            var shoeFeature = ShoeFeaurteService.GetById(id);

            if (shoeFeature == null)
            {
                return NotFound();
            }

            ShoeFeaurteService.Delete(id);
            return NoContent();
        }
    }
}
