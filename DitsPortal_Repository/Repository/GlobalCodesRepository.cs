using Domain.Data;
using Domain.Models;
using DitsPortal_Repository.IRepository;
using DitsPortal.Common.Responses;
using DitsPortal.Common.Requests;
using Microsoft.EntityFrameworkCore;
namespace DitsPortal_Repository.Repository
{
     public class GlobalCodesRepository :  IGlobalCodesRepository
    {

        ApplicationDBContext ObjContext;
        public GlobalCodesRepository(ApplicationDBContext context)
        {
            ObjContext = context;
           
        }
         public  async Task <GlobalCodes> createGlobalCode(GlobalCodeRequest gcReq){
            GlobalCodes GC=new GlobalCodes();
            GC.GlobalCodeCategoryId=gcReq.GlobalCodeCategoryId;
            GC.CodeName=gcReq.CodeName;
            GC.Description=gcReq.Description;
            GC.CreatedBy=gcReq.ActionBy;
            ObjContext.GlobalCodes.AddAsync(GC);
            await ObjContext.SaveChangesAsync();
            return GC;
        }
        }
       
    }
