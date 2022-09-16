using DitsPortal.Common.Responses;
using DitsPortal.Common.Requests;
using Domain.Models;
namespace DitsPortal_Service.IService
{
    public interface IGlobalCodeCategoriesService
    {
        Task<GlobalCodeCategories> CreateGlobalCategory(GCCategoryRequest gcCategoryRequest);
      Task<List<GlobalCodeCategories>>GetallCategorydata();
      Task<GlobalCodeCategories>GetallcategorydataById(int id);
    }
}