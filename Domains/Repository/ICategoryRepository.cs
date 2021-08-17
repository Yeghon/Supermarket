using SuperMarket.Domains.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperMarket.Domains.Repository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
