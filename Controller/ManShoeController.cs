using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ShoeFeature.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ManShoeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ManShoeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var shoes = await _context.Shoes
                .Where(s => s.Gender == "Men")
                .ToListAsync();
            return Ok(shoes);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var shoe = await _context.Shoes.FindAsync(id);
            if (shoe == null) return NotFound();
            return Ok(shoe);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ShoeFeature model)
        {
            _context.Shoes.Add(model);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ShoeFeature model)
        {
            var shoe = await _context.Shoes.FindAsync(id);
            if (shoe == null) return NotFound();

            shoe.Brand = model.Brand;
            shoe.Model = model.Model;
            shoe.Price = model.Price;
            shoe.Image1 = model.Image1;
            shoe.Image2 = model.Image2;
            shoe.Image3 = model.Image3;
            shoe.Image4 = model.Image4;
            shoe.ShopierLink = model.ShopierLink;

            await _context.SaveChangesAsync();
            return Ok(shoe);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var shoe = await _context.Shoes.FindAsync(id);
            if (shoe == null) return NotFound();

            _context.Shoes.Remove(shoe);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
