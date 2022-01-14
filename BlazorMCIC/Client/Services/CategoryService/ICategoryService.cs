﻿using BlazorMCIC.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorMCIC.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }
        Task LoadCategories();
    }
}
