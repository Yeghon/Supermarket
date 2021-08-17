using System.Collections.Generic;
using System.Threading.Tasks;
using SuperMarket.Domains.Model;
using SuperMarket.Domains.Repository;
using SuperMarket.Domains.Service;

namespace SuperMarket.Service
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await categoryRepository.ListAsync();

        }
    }
}