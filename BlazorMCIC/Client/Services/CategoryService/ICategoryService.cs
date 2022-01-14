using BlazorMCIC.Shared;
using System.Collections.Generic;

namespace BlazorMCIC.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }
        void LoadCategories();

    }
}
