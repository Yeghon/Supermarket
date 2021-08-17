using Microsoft.EntityFrameworkCore;
using SuperMarket.Domains.Model;
using SuperMarket.Domains.Repository;
using SuperMarket.Persistence.Contexts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperMarket.Persistence.Repositories
{
    public class CategoryRepository: BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context): base(context) { }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
