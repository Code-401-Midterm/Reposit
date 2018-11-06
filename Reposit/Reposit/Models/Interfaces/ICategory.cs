﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reposit.Models.Interfaces
{
    public interface ICategory
    {
        Task AddCategory(Category newCat);

        Task UpdateCategory(Category updateCat);

        Task DeleteCategory(int id);

        Task<Category> GetCategory(int? id);

        Task<List<Category>> GetCategories();

        Task<List<FullSnippet>> GetAllSnippetsFromCategory(int? id);
    }
}
