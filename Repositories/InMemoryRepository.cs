using System.Collections.Generic;
using Catalog.Model;
using System;
using System.Linq;

namespace Catalog.Repositories
{
    public class InMemoryRepository
    {
        private readonly List<Item> items = new(){
            new Item{ Id = Guid.NewGuid(), Name = "Test1", Price = 12 },
            new Item{ Id=Guid.NewGuid(), Name = "Test2", Price = 14},
            new Item{ Id=Guid.NewGuid(), Name = "Test3", Price = 17}
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid Id)
        {
            return items.Where(item => item.Id == Id).FirstOrDefault();
        }

    }
}