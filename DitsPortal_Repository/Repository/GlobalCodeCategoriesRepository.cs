using Domain.Data;
using DitsPortal_Repository.IRepository;
using DitsPortal.Common.Responses;
using DitsPortal.Common.Requests;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
namespace DitsPortal_Repository.Repository
{
    public class GlobalCodeCategoriesRepository : IGlobalCodeCategoriesRepository
    {
        private readonly ApplicationDBContext ObjContext;
        public GlobalCodeCategoriesRepository(ApplicationDBContext context)
        {
            ObjContext = context;
        }

        public async Task<GlobalCodeCategories> CreateCategory(GCCategoryRequest gccReq)
        {
            // List<GlobalCodeCategoriesResponse> _status;
            var IsExist = ObjContext.GlobalCodeCategories.Where(x => x.CategoryName == gccReq.CategoryName && x.IsDeleted == false).FirstOrDefault();

            try{
                 
                GlobalCodeCategories Gcc = new GlobalCodeCategories();
                Gcc.CategoryName = gccReq.CategoryName;
                Gcc.Description=gccReq.Description;
                Gcc.CreatedOn=DateTime.Now;
                Gcc.CreatedBy=gccReq.ActionBy;
               // Gcc.IsActive = gccReq.IsActive;
                ObjContext.GlobalCodeCategories.AddAsync(Gcc);
                await ObjContext.SaveChangesAsync();
                 return Gcc;

            }
            catch(Exception e){
                throw new Exception(e.Message);
            }

        }
            public async Task<List<GlobalCodeCategories>>GetCategorydata(){
                var data=await ObjContext.GlobalCodeCategories.ToListAsync();
                return data;
       }
        public async Task<GlobalCodeCategories>GetcategorydataById(int id){
            var data = await ObjContext.GlobalCodeCategories.Where(x=>x.GlobalCodeCategoryId==id).FirstOrDefaultAsync();
            // ObjContext.SaveChangesAsync();
            return data;
        }
    }

}
