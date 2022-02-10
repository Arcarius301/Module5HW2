using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Module5HW2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogItemController : Controller
    {
        private readonly ILogger<CatalogItemController> _logger;

        public CatalogItemController(ILogger<CatalogItemController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetItem")]
        public IEnumerable<Item> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Item
            {
                Id = index,
                Name = index.ToString(),
                Description = "TestDesc",
                Price = Random.Shared.Next(30, 2001)
            })
            .ToArray();
        }
    }
}
