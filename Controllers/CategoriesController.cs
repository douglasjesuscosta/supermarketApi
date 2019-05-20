using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SupermarketAPI.Domain.Models;
using SupermarketAPI.Domain.Services;
using SupermarketAPI.Resources;
using AutoMapper;
using SupermarketAPI.Extensions;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SupermarketAPI.Controllers {

    [Route("/api/[Controller]")]
    public class CategoriesController : Controller {

        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper) {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryResource>> getAllAsync() {

            var categories = await _categoryService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(categories);

            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCategoryResource resource) {

            if (!ModelState.IsValid) {
                return BadRequest(ModelState.GetErrorMessages());
            }

            var category = _mapper.Map<SaveCategoryResource, Category>(resource);

            var result = await _categoryService.SaveAsync(category);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = _mapper.Map<Category, CategoryResource>(result.Category);

            return Ok(categoryResource);

        }




    }
}
