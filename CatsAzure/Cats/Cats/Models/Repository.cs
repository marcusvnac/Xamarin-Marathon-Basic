using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cats.Models
{
    public class Repository
    {
        public async Task<List<Cat>> GetCats()
        {
            var service = new Services.AzureService<Cat>();
            var items = await service.GetTable();
            return items.ToList();
        }
    }
}
