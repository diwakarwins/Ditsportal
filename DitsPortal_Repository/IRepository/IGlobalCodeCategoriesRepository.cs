
using DitsPortal.Common.Responses;
using DitsPortal.Common.Requests;
using Domain.Models;
namespace DitsPortal_Repository.IRepository
{
    public interface IGlobalCodeCategoriesRepository
    
    {
        Task<GlobalCodeCategories> CreateCategory(GCCategoryRequest gccReq);
      Task<List<GlobalCodeCategories>>GetCategorydata();
      Task<GlobalCodeCategories>GetcategorydataById(int id);
    }
}