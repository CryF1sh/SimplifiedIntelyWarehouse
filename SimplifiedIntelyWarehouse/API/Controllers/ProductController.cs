using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimplifiedIntelyWarehouse.Core.Entities;
using SimplifiedIntelyWarehouse.Infrastructure.Data;

namespace SimplifiedIntelyWarehouse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly SIWDbContext _context;

        public ProductController(SIWDbContext context)
        {
            _context = context;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }


        // GET: api/Product/{id}
        [HttpGet("byId/{id}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null) return NotFound();

            return product;
        }

        // GET: api/Product/{name}
        [HttpGet("byName/{name}")]
        public async Task<ActionResult<Product>> GetProductByName(string name)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Name == name);

            if (product == null) return NotFound();

            return product;
        }

        // GET: api/Product/{sku}
        [HttpGet("bySKU/{sku}")]
        public async Task<ActionResult<Product>> GetProductBySKU(string sku)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.SKU == sku);

            if (product == null) return NotFound();

            return product;
        }

        // POST: api/Product/create
        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct([FromBody] Product product)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }


    }
}
