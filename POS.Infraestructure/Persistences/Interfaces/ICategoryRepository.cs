using POS.Domain.Entities;
using POS.Infraestructure.Commons.Bases.Reponse;
using POS.Infraestructure.Commons.Bases.Request;

namespace POS.Infraestructure
{
    public interface ICategoryRepository
    {
        Task<BaseEntityResponse<Category>> ListCategories(BaseFilterRequest filters);
        Task<IEnumerable<Category>> ListSelectCategories();
        Task<Category> CategoryById(int categoryId);
        Task<bool> RegisterCategory(Category category);
        Task<bool> EditCategory(Category category);
        Task<bool> RemoveCategory(int categoryId);
    }
}

