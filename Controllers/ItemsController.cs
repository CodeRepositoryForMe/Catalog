using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Model;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly InMemoryRepository repository;

        public ItemsController()
        {
            repository = new InMemoryRepository();
        }

        [HttpGet]
        public IEnumerable<Item> GetItems(){
            var items = repository.GetItems();
            return items;
        }

        [HttpGet("{id}")]
        public ActionResult GetItem(Guid Id)
        {
            var item = repository.GetItem(Id);
            if(item is null)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}