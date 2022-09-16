using DitsPortal.Common.Requests;
using DitsPortal.Common.Responses;
using Domain.Models;
namespace DitsPortal_Service.IService
{
    public interface IGlobalCodesService
    {
        Task<GlobalCodes> create_GlobalCode(GlobalCodeRequest req);
      
    }
}