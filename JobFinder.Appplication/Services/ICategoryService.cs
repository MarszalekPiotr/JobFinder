using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinder.Application.Services
{
    public interface ICategoryService
    {
        public  Task AddCategory(AddCategoryDTO categoryDTO);
        public Task<IEnumerable<CategoryDTO>> GetCategoriesAsync();

    }
}
