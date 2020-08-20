using Domain.Entities;
using Domain.Interfaces.AppServices;
using LibraryAPI.Helper;
using System.Collections.Generic;
using System.Web.Http;

namespace LibraryAPI.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly ICategoryAppService categoryAppService = SystemHelper.Container.GetInstance<ICategoryAppService>();

        // GET api/<controller>
        public IEnumerable<CategoryEntity> Get()
        {
            var categories = categoryAppService.GetList(c => c.Id > 0);

            return categories;
        }

        // GET api/<controller>/5
        public CategoryEntity Get(int id)
        {
            var category = categoryAppService.GetById(id);
            return category;
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}