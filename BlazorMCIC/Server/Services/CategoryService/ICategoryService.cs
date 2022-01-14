using BlazorMCIC.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMCIC.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
    }
}
