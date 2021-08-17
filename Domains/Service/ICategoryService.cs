using System.Collections.Generic;
using System.Threading.Tasks;
using SuperMarket.Domains.Model;

namespace SuperMarket.Domains.Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
    
}

