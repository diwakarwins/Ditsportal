using DitsPortal.Common.Responses;
using DitsPortal.Common.Requests;
using Domain.Models;

namespace DitsPortal_Repository.IRepository
{
    public interface IGlobalCodesRepository 
    {
         Task <GlobalCodes> createGlobalCode(GlobalCodeRequest gcReq);
    }
}