using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Infrastructure.Services
{
    internal sealed class CategoryService : ICategoryService
    {
        public IGenericRepository<Category> _categoryRepository;

        public CategoryService(IGenericRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task AddCategory(AddCategoryDTO categoryDTO)
        {
            var category = new Category()
            {
                Name = categoryDTO.Name,

            };
          await  _categoryRepository.AddAsync(category);
        }


        public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync() 
        {
            var categories = await _categoryRepository.GetAllAsync();


            return categories
            .Select(c => new CategoryDTO()
            {
                Id = c.Id,
                Name = c.Name,
                // Czy to nie jest za bardzo rozbudowany kod, czy pobieranie tych Jobów powinno być w innym miejscu?
                Jobs = c.Jobs?.ToList().Select(j => new JobDTO()
                {
                    Id = j.Id,
                    Position = j.Position,
                    MaxSalary = j.MaxSalary,
                    MinSalary = j.MinSalary,

                })


            });
        }



    }
}
