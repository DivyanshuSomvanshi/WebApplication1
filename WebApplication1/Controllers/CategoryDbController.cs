using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryDbController : ControllerBase
    {
        private ApplicationDbContext _context;
        public CategoryDbController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<CategoryDbController>
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _context.Categories;
        }

        // GET api/<CategoryDbController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<CategoryDbController>
        [HttpPost]
        public void Post([FromBody]Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();

        }

        // PUT api/<CategoryDbController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category category)
        {
            var categoryfromdb = _context.Categories.Find(id);
            _context.Categories.Update(categoryfromdb);
            _context.SaveChanges();
        }

        // DELETE api/<CategoryDbController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
