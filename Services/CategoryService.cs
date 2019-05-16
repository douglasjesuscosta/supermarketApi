using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SupermarketAPI.Domain.Models;
using SupermarketAPI.Domain.Services;
using SupermarketAPI.Domain.Repositories;

namespace SupermarketAPI.Services {
    public class CategoryService : ICategoryService {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository) {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync() {
            return await _categoryRepository.ListAsync();
        }

    }
}
