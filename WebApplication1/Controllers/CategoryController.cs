using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        List<Category> listofCategory = new List<Category>
        {new Category{Id=1,Title="Samsung",DisplayOrder=1},
            new Category{Id=2,Title="Apple",DisplayOrder=2}

        };
        //

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return listofCategory;
        }
        [HttpPost]
        public IEnumerable<Category> Post([FromBody] Category category)
        {
            listofCategory.Add(category);
            return listofCategory;
        }
        [HttpPut("{id}")]
        public IEnumerable<Category> Put(int id, [FromBody]Category category)
        {
            listofCategory[id] = category;
            return listofCategory;
        }
        [HttpDelete("{id}")]
        public IEnumerable<Category> Delete(int id)
        {
            listofCategory.RemoveAt(id);
            return listofCategory;
        }
    }
}
