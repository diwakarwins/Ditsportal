using DitsPortal_Repository.IRepository;
using Microsoft.Extensions.Logging;
using DitsPortal.Common.Responses;
using DitsPortal.Common.Requests;
using DitsPortal.Common;
using Domain.Models;
using DitsPortal_Service.IService;
using AutoMapper;
namespace DitsPortal_Service.Service
{
    public class GlobalCodesService : IGlobalCodesService
    {
         private readonly IGlobalCodesRepository _globalCodesIRepository;
       
         
          private ILogger<GlobalCodesService> _logger;
          
        public GlobalCodesService(IGlobalCodesRepository globalCodesIRepository, ILogger<GlobalCodesService> logger)
        {
            _globalCodesIRepository = globalCodesIRepository;
       
            
        }
        public async Task<GlobalCodes> create_GlobalCode(GlobalCodeRequest req){

        var res= await _globalCodesIRepository.createGlobalCode(req);
        return res;
        }

    }
}